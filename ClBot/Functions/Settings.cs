using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ClBot.Functions
{
    [DataContract]
    public static class Settings
    {
        // mstu
        [DataMember] public static string group = "";
        [DataMember] public static string faculty = "";
        [DataMember] public static string course = "";

        // vk
        [DataMember] public static string vkgroupID = "";
        [DataMember] public static string token = "";

        [DataMember] public static Dictionary<string, List<string>> members = new Dictionary<string, List<string>>();

        // program
        [DataMember] public static string patternOutput = "{0}\n ->{2}<-\n{1} << {5} >>\n{3} {4}\n\n";
        [DataMember] public static string date = DateTime.Now.AddDays(1).ToString("yyyy-MM-dd");

        [DataMember] public static string themeColor = "RoyalBlue";
        [DataMember] public static Color color = Color.FromName(themeColor);
    }
}
