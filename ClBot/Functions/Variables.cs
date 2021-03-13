using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClBot.Functions
{
    public static class Variables
    {
        // mstu
        public static string group = "";
        public static string faculty = "";
        public static string course = "";

        // vk
        public static string vkgroupID = "";
        public static string token = "";

        public static Dictionary<string, List<string>> members = new Dictionary<string, List<string>>();

        // program
        public static string patternOutput = "{0}\n ->{2}<-\n{1} << {5} >>\n{3} {4}\n\n";
        public static string date = DateTime.Now.AddDays(1).ToString("yyyy-MM-dd");

        public static string themeColor = "RoyalBlue";
        public static Color color = Color.FromName(themeColor);
    }
}
