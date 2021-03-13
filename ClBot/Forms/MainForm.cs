using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClBot.Forms;
using ClBot.Functions;
using System.Windows.Forms;


namespace ClBot
{
    public partial class MainForm : Form
    {
        SettingsForm settingsForm = new SettingsForm();
        bool enableButtons = false;

        public MainForm()
        {
            InitializeComponent();
            OSWorker.Settings_Load();
            CreateUserControls();
            UpdateSettings(null, null);
        }

        private void CreateUserControls()
        {
            // окно настроек
            settingsForm.Location = new Point(0, 0);
            this.Controls.Add(settingsForm);
            settingsForm.BringToFront();
            settingsForm.Visible = false;
            settingsForm.VisibleChanged += UpdateSettings;
        }
        private void UpdateSettings(object sender, EventArgs e)
        {
            if (settingsForm.Visible == false)
            {
                // проверка корректности настроек
                
                enableButtons = !(Variables.group == "" || Variables.faculty == "" || Variables.course == "" || Variables.vkgroupID == "" || Variables.token == "");

                parse_Button.Enabled = enableButtons;
                send_Button.Enabled = enableButtons;

                this.Text = $"ClBot - {((parse_Button.Enabled && send_Button.Enabled) ? Variables.group : "требуется настройка")}";

                ColorUpdate();
            }
        }


        private string GetTargets()
        {
            StringBuilder targets = new StringBuilder();
            
            foreach (var item in Variables.members)
            {
                if (item.Value[1] == "ON")
                {
                    targets.Append("," + item.Key); 
                }
            }
            targets.Remove(0, 1);

            return targets.ToString();
        }


        private void ParseMessage()
        {
            message_RichText.Text = NetWorker.GetTable();
        }
        private void ParseMembers()
        {
            NetWorker.GetMembers();

            members_Panel.Controls.Clear();
            panel2.Width = 191;
            members_Panel.Width = 189;

            if (Variables.members.Count > 7)
            {
                panel2.Width = 208;
                members_Panel.Width = 206;
            }

            foreach (var item in Variables.members)
            {
                members_Panel.Controls.Add(UIWorker.NewButton(item.Key));
            }
        }

        #region Buttons
        private void send_Button_Click(object sender, EventArgs e)
        {
            NetWorker.SendMessage(GetTargets(), message_RichText.Text);
        }
        private void parse_Button_Click(object sender, EventArgs e)
        {
            ParseMembers();
            ParseMessage();
        }

        private void settings_Button_Click(object sender, EventArgs e)
        {
            settingsForm.Visible = true;
        }
        private void settings_Button_Enter(object sender, EventArgs e)
        {
            settings_Button.Image = Properties.Resources.Settings_Active;
        }
        private void settings_Button_Leave(object sender, EventArgs e)
        {
            settings_Button.Image = Properties.Resources.Settings_Default;
        }

        #endregion

        private void ColorUpdate()
        {
            parse_Button.BackColor = Variables.color;
            send_Button.BackColor = Variables.color;

            panel1.BackColor = Variables.color;
            panel2.BackColor = Variables.color;
        }
    }
}
