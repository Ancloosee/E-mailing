using Email.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Email
{
    public partial class MainForm : Form
    {
        public List<Label> labelSender { set; get; } = new List<Label>();
        public List<Label> labelStatus { set; get; } = new List<Label>();
        public int CountTasks { set; get; } = 1;
        public MainForm()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            new AddTaskForm(this).Show();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void labelFrom7_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        
        private void MainForm_Load(object sender, EventArgs e)
        {
            for (int index = 0; index < User.GetInstance().tasks.Count; index++)
            {
                AddNewGropBox(index);
            }
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
                this.Hide();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            WindowState = FormWindowState.Normal;
        }

        private void contextMenuStrip1_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void MainForm_MouseClick(object sender, MouseEventArgs e)
        {
            //if call condext menu
            if (e.Button == MouseButtons.Right)
            {
                //if call from form
                if(WindowState == FormWindowState.Normal)
                {
                    contextMenuStrip1.Show(new Point(e.X,e.Y-10));
                }
                contextMenuStrip1.Show();
            }
        }



        /*Context menu handler */
        private void toolStripMenuAddNewTask_Click(object sender, EventArgs e)
        {
            new AddTaskForm(this).Show();
        }
        private  void toolStripMenuItemRunAllTasks_Click(object sender, EventArgs e)
        { 
            for (int i = 0; i < User.GetInstance().tasks.Count; i++)
            {
                  Send(i);  
            }
        }


        /*Starts task buttons*/
      
        /*Helps methods*/
        private async void Send(int index)
        {
            System.Threading.Tasks.Task task = User.GetInstance().tasks[index].SendMailAsync();
            //change text in label
            this.Controls.Find("userTaskGroupBox" + Convert.ToString(index), false)[0].Controls.Find("userTaskStatucLabel" + Convert.ToString(index), false)[0].Text = "Отправка";            
            try
            {
                await task;
                this.Controls.Find("userTaskGroupBox" + Convert.ToString(index), false)[0].Controls.Find("userTaskStatucLabel" + Convert.ToString(index), false)[0].Text = "Завершенно";
                MessageBox.Show("Задание: \"" + User.GetInstance().tasks[index].Name + "\" выполненно");
                Logining.WriteLog("Задание: \"" + User.GetInstance().tasks[index].Name + "\" выполненно");
            }
            catch (System.Net.Mail.SmtpException ex)
            {
                this.Controls.Find("userTaskGroupBox" + Convert.ToString(index), false)[0].Controls.Find("userTaskStatucLabel" + Convert.ToString(index), false)[0].Text = "Ошибка";
                MessageBox.Show(ex.Message);
                Logining.WriteLog(ex.Message);
            }
        }
        private void настройкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Setting().Show();
        }
        //Button "Remove All Task"
        private void buttonRemoveAllTask_Click(object sender, EventArgs e)
        {
           //delete from form
           foreach(var gr in this.Controls)
                if(gr is GroupBox)
                    this.Controls.Remove((GroupBox)gr);
           
            User.GetInstance().tasks = null;
            User.GetInstance().tasks = new List<Task>();
        }
        //Button "Run All Task"
        private void buttonRunAllTask_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < User.GetInstance().tasks.Count; i++)
            {
                Send(i);
            }
        }
        //Context menu-"EXIT"
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
   
        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutProgramForm().Show();
        }
        

        public  void AddNewGropBox(int index)
        {

            GroupBox gr = new GroupBox();
            gr.Name = "userTaskGroupBox" + Convert.ToString(index);
            gr.Text = User.GetInstance().tasks[index].Name;
            gr.Size = new Size(ClientRectangle.Width, 70);
            gr.Top = CountTasks * 85;
            gr.Margin = new Padding(70);
            gr.Padding = new Padding(10);
            this.Controls.Add(gr);

            //Start button
            Button startTaskButton = new Button();
            startTaskButton.Name= "userTaskStartButton" + Convert.ToString(index);
            startTaskButton.Text = "Запустить";
            startTaskButton.Margin = new Padding(10);
            startTaskButton.Size = new Size(80, 25);
            startTaskButton.Top = 25;

            int ind = index;
            
            startTaskButton.Click+=(s,e)=>{ Send(index); };
            gr.Controls.Add(startTaskButton);

            //settingButton
            Button settingbnt = new Button();
            settingbnt.Name= "userTaskSettingButton" + Convert.ToString(index);
            settingbnt.Text = "Настроить";
            settingbnt.Margin = new Padding(10);
            settingbnt.Left = 100;
            settingbnt.Size = new Size(80, 25);
            settingbnt.Top = 25;
            gr.Controls.Add(settingbnt);
            settingbnt.Click += (s, e) => { new TaskSetting(index).Show(); };
            //labels

            //static labels
            //adreesee mails
            Label atatdreeseemail = new Label();
            atatdreeseemail.Name="userTaskStaticSenderMailLabel" + Convert.ToString(index);
            atatdreeseemail.Text = "Отправитель";
            atatdreeseemail.Margin = new Padding(10);
            atatdreeseemail.Left = 200;
            atatdreeseemail.Top = 7;
            gr.Controls.Add(atatdreeseemail);


            Label statStatus = new Label();
            statStatus.Name= "userTaskStatStatucLabel" + Convert.ToString(index);
            statStatus.Text = "Статус: ";
            statStatus.AutoSize = true;
            statStatus.Top = 30;
            statStatus.Left = ClientRectangle.Right - 150;

            gr.Controls.Add(statStatus);

            Label statuc = new Label();
            statuc.Name= "userTaskStatucLabel" + Convert.ToString(index);
            statuc.AutoSize = true;
            statuc.Text = "...";
            statuc.Top = 30;
            statuc.Left = statStatus.Right;
            gr.Controls.Add(statuc);
            
            //no static
            Label adreeseeMail = new Label();
            atatdreeseemail.Name= "userTaskSenderMailLabel" + Convert.ToString(index);
            adreeseeMail.Text = User.GetInstance().tasks[index].SenderMail;
            adreeseeMail.Margin = new Padding(10);
            adreeseeMail.Left = 200;
            adreeseeMail.AutoSize = true;
            adreeseeMail.Top = 30;
            gr.Controls.Add(adreeseeMail);


            CountTasks++;
        }
    }
}
