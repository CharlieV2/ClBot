using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClBot.Forms.tabs
{
    public partial class FormatSettings_Control : UserControl
    {
        public FormatSettings_Control()
        {
            InitializeComponent();
        }

        private void help_Button_Click(object sender, EventArgs e)
        {
            help_Button.Visible = false;
            help1_Label.Visible = true;
            help2_Label.Visible = true;
        }
    }
}
