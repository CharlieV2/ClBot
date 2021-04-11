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
                              $"%group={Settings.group}" +
                              $"%faculty={Settings.faculty}" +
                              $"%course={Settings.course}" +
                              $"%groupID={Settings.vkgroupID}" +
                              $"%accessToken={Settings.token}" +
                              $"%patternOutput={Settings.patternOutput}" +
                              $"%themeColor={Settings.themeColor}");
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
                            Settings.group = item.Split('=')[1];
                            break;
                        case "faculty":
                            Settings.faculty = item.Split('=')[1];
                            break;
                        case "course":
                            Settings.course = item.Split('=')[1];
                            break;
                        case "groupID":
                            Settings.vkgroupID = item.Split('=')[1];
                            break;
                        case "accessToken":
                            Settings.token = item.Split('=')[1];
                            break;
                        case "patternOutput":
                            Settings.patternOutput = item.Split('=')[1];
                            break;
                        case "themeColor":
                            Settings.themeColor = item.Split('=')[1];
                            Settings.color = Color.FromName(item.Split('=')[1]);
                            break;
                        default:
                            break;
                    }
                }
            }
        }
    }
}
