using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ClBot.Functions
{
    public static class OSWorker
    {
        private static string MainPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "ClBot");

        public static void Settings_Save()
        {
            File.WriteAllText(MainPath + @"/Settings.txt",
                              $"%group={Variables.group}" +
                              $"%faculty={Variables.faculty}" +
                              $"%course={Variables.course}" +
                              $"%groupID={Variables.vkgroupID}" +
                              $"%accessToken={Variables.token}" +
                              $"%patternOutput={Variables.patternOutput}" +
                              $"%themeColor={Variables.themeColor}");
        }
        public static void Settings_Load()
        {
            if (!(File.Exists(MainPath + @"/Settings.txt")))
            {
                Directory.CreateDirectory(MainPath);
                Settings_Save();
            }
            else
            {
                string[] InputVariables = File.ReadAllText(MainPath + @"/Settings.txt").Split('%');

                foreach (string item in InputVariables)
                {
                    switch (item.Split('=')[0])
                    {
                        case "group":
                            Variables.group = item.Split('=')[1];
                            break;
                        case "faculty":
                            Variables.faculty = item.Split('=')[1];
                            break;
                        case "course":
                            Variables.course = item.Split('=')[1];
                            break;
                        case "groupID":
                            Variables.vkgroupID = item.Split('=')[1];
                            break;
                        case "accessToken":
                            Variables.token = item.Split('=')[1];
                            break;
                        case "patternOutput":
                            Variables.patternOutput = item.Split('=')[1];
                            break;
                        case "themeColor":
                            Variables.themeColor = item.Split('=')[1];
                            Variables.color = Color.FromName(item.Split('=')[1]);
                            break;
                        default:
                            break;
                    }
                }
            }
        }
    }
}
