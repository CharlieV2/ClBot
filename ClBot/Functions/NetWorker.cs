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


        public static void SendMessage(string targets, string message, string token)
        {
            Random random = new Random();

            webClient.DownloadString($"https://api.vk.com/method/messages.send?user_ids={targets}&message={message}&random_id={random.Next(10000000)}&access_token={token}&v=5.102");
        }


        public static Dictionary<string, List<string>> GetMembers(string vkgroupID, string token)
        {
            webClient.Encoding = Encoding.UTF8;

            Dictionary<string, List<string>> members = new Dictionary<string, List<string>>();

            // получение ID участников
            string ids;
            string getIDs = (webClient.DownloadString($"https://api.vk.com/method/groups.getMembers?group_id={vkgroupID}&access_token={token}&v=5.102"));
            ids = String.Join(",", JsonConvert.DeserializeObject<GetIDs>(getIDs).response.items);

            // получение имени и фамилии каждого участника
            string usersRow = (webClient.DownloadString($"https://api.vk.com/method/users.get?user_ids={ids}&access_token={token}&v=5.102"));
            GetName users = JsonConvert.DeserializeObject<GetName>(usersRow);

            // заполнение списка участников
            foreach (var item in users.response)
            {
                members.Add(item["id"], new List<string>{ item["first_name"] + " " + item["last_name"], "ON" });
            }

            return members;
        }

        public static string GetTable(string patternOutput, string group, string date, string faculty, string course)
        {
            StringBuilder FinalMessage = new StringBuilder();
            webClient.Encoding = Encoding.GetEncoding("windows-1251");

            string HtmlPage = webClient.DownloadString(String.Format(@"http://www.mstu.edu.ru/study/timetable/schedule.php?key={0}&perstart={1}&perend={1}&perkind=%F7", FindKey(group, faculty, course), date));

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

                FinalMessage.Append(String.Format(patternOutput,
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
        private static string FindKey(string group, string faculty, string course)
        {
            string pattern = string.Format(@"<{0}key=({0})&perstart={0}>{1}</a>", "[^<]*?", group.ToLower());
            string key = Regex.Match(SceduleTable(faculty, course), pattern).Groups[1].Value;
            return key;
        }
        private static string SceduleTable(string faculty, string course)
        {
            string url = "http://www.mstu.edu.ru/study/timetable/";
            string tableResponse = "";
            string numInstitute = "";

            Dictionary<string, string> institutes = new Dictionary<string, string> { { "ети", "1"}, { "има", "2" }, { "аф", "3" }, { "иат", "4" } };

            WebRequest request = WebRequest.Create(url);
            request.Method = "POST";


            institutes.TryGetValue(faculty.ToLower(), out numInstitute);

            string data = $"mode=1&facs={numInstitute}&courses={course}";
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
