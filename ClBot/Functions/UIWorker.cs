using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClBot.Functions
{
    public static class UIWorker
    {
        public static Button NewButton(string key)
        {
            Button button = new Button();

            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.FlatAppearance.BorderColor = Color.White;
            button.BackColor = Color.White;
            button.Font = new Font("Segoe UI", 10, FontStyle.Regular);

            button.Tag = key;
            button.Text = Variables.members[key][0];

            button.Width = 183;
            button.Height = 30;

            button.Click += DisableMe;
            
            void DisableMe(object sender, EventArgs e)
            {
                if (Variables.members[key][1] == "ON")
                {
                    Variables.members[key][1] = "OFF";
                    button.BackColor = Color.FromArgb(226, 226, 226);
                }
                else
                {
                    Variables.members[key][1] = "ON";
                    button.BackColor = Color.White;
                }
            }


            return button;
        }
    }
}
