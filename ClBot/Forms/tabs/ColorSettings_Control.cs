using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClBot.Functions;

namespace ClBot.Forms.tabs
{
    public partial class ColorSettings_Control : UserControl
    {
        public ColorSettings_Control()
        {
            InitializeComponent();

            foreach (KnownColor knownColor in Enum.GetValues(typeof(KnownColor)))
            {
                Color color = Color.FromKnownColor(knownColor);
                if (!color.IsSystemColor)
                {
                    knownColor_ComboBox.Items.Add(color);
                }
            }

            knownColor_ComboBox.Text = Variables.themeColor;
        }

        Color selectedColor;
        private void knownColor_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedColor = Color.FromName(knownColor_ComboBox.Text);

            sample0_Button.BackColor = selectedColor;
            sample1_Button.FlatAppearance.BorderColor = selectedColor;
            panel1.BackColor = selectedColor;
        }
    }
}
