using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using ClBot.Forms.tabs;
using ClBot.Functions;

namespace ClBot.Forms
{
    public partial class SettingsForm : UserControl
    {
        public SettingsForm()
        {
            InitializeComponent();
            InitializeTabs();
            ColorUpdate();
        }
        private void SaveSettings()
        {
            Settings.group = mstuSettings_Control.group_TextBox.Text.Trim();
            Settings.faculty = mstuSettings_Control.faculty_TextBox.Text.Trim();
            Settings.course = mstuSettings_Control.course_TextBox.Text.Trim();

            Settings.vkgroupID = vkSettings_Control.groupID_TextBox.Text.Trim();
            Settings.token = vkSettings_Control.token_TextBox.Text.Trim();

            Settings.patternOutput = formatSettings_Control.patternOutput_TextBox.Text;
            Settings.date = formatSettings_Control.date_TextBox.Text.Trim();

            Settings.themeColor = colorSettings_Control.knownColor_ComboBox.Text;

            OSWorker.Settings_Save();
        }

        private void Update(object sender, EventArgs e)
        {
            if (Visible == true)
            {
                ColorUpdate();
                ShowCurrentSettings();
            }
        }
        private void ShowCurrentSettings()
        {
            mstuSettings_Control.group_TextBox.Text = Settings.group;
            mstuSettings_Control.faculty_TextBox.Text = Settings.faculty;
            mstuSettings_Control.course_TextBox.Text = Settings.course;

            vkSettings_Control.groupID_TextBox.Text = Settings.vkgroupID;
            vkSettings_Control.token_TextBox.Text = Settings.token;

            formatSettings_Control.date_TextBox.Text = Settings.date;
            formatSettings_Control.patternOutput_TextBox.Text = Settings.patternOutput;
        }



        #region Buttons
        private void saveSettings_Button_Click(object sender, EventArgs e)
        {
            SaveSettings();
            ColorUpdate();
        }
        private void Link_Click(object sender, EventArgs e)
        {
            if ((sender as Label).Text == "www.mstu.edu.ru")
                Process.Start((sender as Label).Text);
            else
                Process.Start("https://vk.com/id325140195");
        }
        private void back_Button_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
        private void back_Button_Enter(object sender, EventArgs e)
        {
            back_Button.Image = Properties.Resources.Back_Active;
        }
        private void back_Button_Leave(object sender, EventArgs e)
        {
            back_Button.Image = Properties.Resources.Back_Default;
        }

        #endregion

        #region TabControl
        MSTUSettings_Control mstuSettings_Control = new MSTUSettings_Control();
        VKSettings_Control vkSettings_Control = new VKSettings_Control();
        FormatSettings_Control formatSettings_Control = new FormatSettings_Control();
        ColorSettings_Control colorSettings_Control = new ColorSettings_Control();

        Button CurrentTab;

        private void InitializeTabs()
        {
            mstuSettings_Control.Location = new Point(0, 0);
            vkSettings_Control.Location = new Point(0, 0);
            formatSettings_Control.Location = new Point(0, 0);
            colorSettings_Control.Location = new Point(0, 0);

            tabControl_Panel.Controls.Add(mstuSettings_Control);
            tabControl_Panel.Controls.Add(vkSettings_Control);
            tabControl_Panel.Controls.Add(formatSettings_Control);
            tabControl_Panel.Controls.Add(colorSettings_Control);

            CurrentTab = mstu_Button;
            Transform(CurrentTab, null);
        }

        private void Transform(object sender, EventArgs e)
        {
            ShowSettings((sender as Button).Tag.ToString());

            Button_Disable();

            CurrentTab = (sender as Button);
            Button_Enable();
        }

        private void Button_Enable()
        {
            CurrentTab.BackColor = Settings.color;
            CurrentTab.ForeColor = Color.White;
            CurrentTab.BringToFront();

            CurrentTab.Height = CurrentTab.Height + 2;
            CurrentTab.Width = CurrentTab.Width + 4;
            CurrentTab.Location = new Point(CurrentTab.Location.X - 2, CurrentTab.Location.Y - 2);
        }
        private void Button_Disable()
        {
            // reset color
            CurrentTab.BackColor = Color.White;
            CurrentTab.ForeColor = Color.Black;

            // reset transform
            CurrentTab.Height = CurrentTab.Height - 2;
            CurrentTab.Width = CurrentTab.Width - 4;
            CurrentTab.Location = new Point(CurrentTab.Location.X + 2, CurrentTab.Location.Y + 2);
        }
        private void ShowSettings(string tag)
        {
            switch (tag)
            {
                case "0":
                    mstuSettings_Control.BringToFront();
                    break;
                case "1":
                    vkSettings_Control.BringToFront();
                    break;
                case "2":
                    formatSettings_Control.BringToFront();
                    break;
                case "3":
                    colorSettings_Control.BringToFront();
                    break;
            }
        }
        #endregion

        private void ColorUpdate()
        {
            colorSettings_Control.knownColor_ComboBox.Text = Settings.themeColor;

            Settings.color = Color.FromName(Settings.themeColor);

            CurrentTab.BackColor = Settings.color;
            saveSettings_Button.BackColor = Settings.color;

            mstu_Button.FlatAppearance.BorderColor = Settings.color;
            vk_Button.FlatAppearance.BorderColor = Settings.color;
            format_Button.FlatAppearance.BorderColor = Settings.color;
            theme_Button.FlatAppearance.BorderColor = Settings.color;

            MstuLink.ForeColor = Settings.color;
            HelpLink.ForeColor = Settings.color;

            panel2.BackColor = Settings.color;
            formatSettings_Control.panel7.BackColor = Settings.color;
        }
    }
}
