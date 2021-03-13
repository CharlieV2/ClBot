using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;

namespace ClBot.Functions
{
    #region Help Classes
    public class GetIDs
    {
        public response response { get; set; }
    }
    public class GetName
    {
        public List<Dictionary<string, string>> response { get; set; }
    }
    public class response
    {
        public string[] items { get; set; }
    }
    #endregion


    public static class NetWorker
    {
        private static WebClient webClient = new WebClient();


        public static void SendMessage(string targets, string message)
        {
            Random random = new Random();

            webClient.DownloadString($"https://api.vk.com/method/messages.send?user_ids={targets}&message={message}&random_id={random.Next(10000000)}&access_token={Variables.token}&v=5.102");
        }


        public static void GetMembers()
        {
            webClient.Encoding = Encoding.UTF8;

            Variables.members.Clear();

            // получение ID участников
            string ids;
            string getIDs = (webClient.DownloadString($"https://api.vk.com/method/groups.getMembers?group_id={Variables.vkgroupID}&access_token={Variables.token}&v=5.102"));
            ids = String.Join(",", JsonConvert.DeserializeObject<GetIDs>(getIDs).response.items);

            // получение имени и фамилии каждого участника
            string usersRow = (webClient.DownloadString($"https://api.vk.com/method/users.get?user_ids={ids}&access_token={Variables.token}&v=5.102"));
            GetName users = JsonConvert.DeserializeObject<GetName>(usersRow);

            // заполнение списка участников
            foreach (var item in users.response)
            {
                Variables.members.Add(item["id"], new List<string>{ item["first_name"] + " " + item["last_name"], "ON" });
            }
        }

        public static string GetTable()
        {
            StringBuilder FinalMessage = new StringBuilder();
            webClient.Encoding = Encoding.GetEncoding("windows-1251");

            string HtmlPage = webClient.DownloadString(String.Format(@"http://www.mstu.edu.ru/study/timetable/schedule.php?key={0}&perstart={1}&perend={1}&perkind=%F7", FindKey(), Variables.date));

            string pattern = String.Format(@"<td>({0})</td>{0}<td>({0})<b>({0})</b>{0}<small>({0})</small>{0}</td>{0}<td>({0})</td>{0}<td>({0})</td>", "[^<]*?");
            foreach (Match match in Regex.Matches(HtmlPage, pattern))
                /*
                 * 0 - Номер пары
                 * 1 - Группа
                 * 2 - Предмет
                 * 3 - Тип занятия
                 * 4 - Преподаватель
                 * 5 - Кабинет
                 */

                FinalMessage.Append(String.Format(Variables.patternOutput,
                                                  match.Groups[1].Value,
                                                  match.Groups[2].Value.ToLower(),
                                                  match.Groups[3].Value.ToUpper(),
                                                  match.Groups[4].Value,
                                                  match.Groups[5].Value,
                                                  match.Groups[6].Value));

            // Обозначение отсутствия пар
            if (FinalMessage.ToString().Trim() == "")
            {
                FinalMessage.Append(@"¯\_(ツ)_/¯");
            }

            return FinalMessage.ToString();
        }
        private static string FindKey()
        {
            string pattern = string.Format(@"<{0}key=({0})&perstart={0}>{1}</a>", "[^<]*?", Variables.group.ToLower());
            string key = Regex.Match(SceduleTable(), pattern).Groups[1].Value;
            return key;
        }
        private static string SceduleTable()
        {
            string url = "http://www.mstu.edu.ru/study/timetable/";
            string tableResponse = "";
            string numInstitute = "";

            WebRequest request = WebRequest.Create(url);
            request.Method = "POST";

            switch (Variables.faculty.ToLower())
            {
                case "иат":
                    numInstitute = "4";
                    break;
                case "ети":
                    numInstitute = "1";
                    break;
                case "има":
                    numInstitute = "2";
                    break;
                case "аф":
                    numInstitute = "3";
                    break;
                default:
                    break;
            }

            string data = $"mode=1&facs={numInstitute}&courses={Variables.course}";
            byte[] byteArray = Encoding.GetEncoding("windows-1251").GetBytes(data);

            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = byteArray.Length;

            using (Stream dataStream = request.GetRequestStream())
            {
                dataStream.Write(byteArray, 0, byteArray.Length);
            }

            WebResponse response = request.GetResponse();
            using (Stream stream = response.GetResponseStream())
            {
                using (StreamReader reader = new StreamReader(stream, Encoding.GetEncoding("windows-1251")))
                {
                    tableResponse = reader.ReadToEnd().ToLower();
                }
            }
            response.Close();

            return tableResponse;
        }
    }
}
