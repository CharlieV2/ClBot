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
    public class Settings
    {
        // mstu
        [DataMember] public string group = "";
        [DataMember] public string faculty = "";
        [DataMember] public string course = "";

        // vk
        [DataMember] public string vkgroupID = "";
        [DataMember] public string token = "";

        [DataMember] public Dictionary<string, List<string>> members = new Dictionary<string, List<string>>();

        // program
        [DataMember] public string patternOutput = "{0}\n ->{2}<-\n{1} << {5} >>\n{3} {4}\n\n";
        [DataMember] public string themeColor = "RoyalBlue";

        public string date = DateTime.Now.AddDays(1).ToString("yyyy-MM-dd");

        public Color color
        {
            get
            {
                return Color.FromName(themeColor);
            }
        }
    }
}
