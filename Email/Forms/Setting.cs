using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Email.Forms
{
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();
        }

        private void Setting_Load(object sender, EventArgs e)
        {
            checkBoxSendLog.Checked = Settings.GetInstance().SendLog;
            numericUpDownInterval.Value = Settings.GetInstance().IntervalSendLog;
            textBoxEmailLog.Text = Settings.GetInstance().recipientLogEmail;
        }

        private void checkBoxSendLog_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSendLog.Checked == true)
            {
                numericUpDownInterval.Enabled = true;
                Settings.GetInstance().SendLog = true;
            }
            else
            {
                numericUpDownInterval.Enabled = false;
                Settings.GetInstance().SendLog = false;
            }
        }

        private void numericUpDownInterval_ValueChanged(object sender, EventArgs e)
        {
            Settings.GetInstance().IntervalSendLog = numericUpDownInterval.Value;
        }

        private void buttonEmailLog_Click(object sender, EventArgs e)
        {
            if (textBoxEmailLog.Text != "" && Task.IsValidMail(textBoxEmailLog.Text))
            {
                Settings.GetInstance().recipientLogEmail = textBoxEmailLog.Text;

            }
        }
    }
}
