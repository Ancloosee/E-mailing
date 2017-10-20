using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Email
{
    public partial class AddTaskForm : Form
    {

        /*---------------Temps method---*/
        private void AutoLoadTestData()
        {
           
            textBoxTaskName.Text = "Новое задание 1";
            
            textBoxSubkect.Text = "Тест номер какойто";
            textBoxBody.Text = "Ну выведу хоть дату пусть будет " + DateTime.Now.ToShortTimeString();
        }

        /*-----------------------------*/
        //костиль
        private void AddItemsToParentForm()
        {
            parentForm.AddNewGropBox(index);
        }

        //count of page
        private int page = 0;
        private int index = 0;
        //flag for chek created new task or no
        private bool IsCreate = false;
        private MainForm parentForm;



        /*!!!!!!!!!!!!!!!!МОЖНО ЛИ ТАК ДЕЛАТЬ???????????????????????????????????????*/
        public AddTaskForm(MainForm form)
        {
            this.parentForm = form;
            InitializeComponent();
        }
        private void AddTaskForm_Load(object sender, EventArgs e)
        {
            AutoLoadTestData();
            //set tooltip to button add mail
            toolTipAddNewEmail.SetToolTip(buttonAddNewEmail,"Добавить новый email");
            //set tooltip to button read mail from file
            toolTipReadEmailFromFile.SetToolTip(buttonReadEmailFromFile, "Считать email с файла");

        }
        private void labelBody_Click(object sender, EventArgs e)
        {

        }
        //for show add email to List email when we add email
        private void AddToListsEmail()
        {
            textBoxShowAllAdresseeMails.Text = "";
            try
            {
                foreach (string str in User.GetInstance().tasks[index].AdresseMails)
                {
                    textBoxShowAllAdresseeMails.Text += str + "\r\n";
                }
            }
            catch (NullReferenceException ex)
            {

            }
        }
        /*--------------------------BUTTONS----------------------------*/
        private void buttonNext_Click(object sender, EventArgs e)
        {
            //if show first page
            if (page == 0)
            {
                if (textBoxSenderMail.Text != "" && textBoxTaskName.Text != ""&&textBoxMailPassword.Text!="")
                {
                    //add name and sender email
                    try
                    {
                        //if need create new tast
                        if (!IsCreate)
                        {
                            //create and get index of task in list
                            index = User.GetInstance().AddNewTask(new Task(textBoxTaskName.Text, textBoxSenderMail.Text,textBoxMailPassword.Text)) - 1;
                            //change flag
                            IsCreate = true;
                            Logining.WriteLog(textBoxTaskName.Text + " Создан при нажатии на кнопку далее");
                        }
                        //if task was created when ButtonAddNewEmail was pressed
                        else
                        {
                            //change infirmation 
                            User.GetInstance().tasks[index].SenderMail = textBoxSenderMail.Text;
                            User.GetInstance().tasks[index].SenderMail = textBoxSenderMail.Text;
                        }
                        
                    }
                    //if invalid email
                    catch(CustomExeption.EmailNotValidExeption ex)
                    {
                        //show message
                        //write log
                        MessageBox.Show(ex.Message);
                        Logining.WriteLog(ex.Message);
                        return;
                    }


                    /*-----------------------UI-----------------------------------*/

                    //off visible elements in this page
                    this.labelAdresseeMail.Visible = false;
                    this.labelSenderMail.Visible = false;
                    this.labelTaskName.Visible = false;
                    this.textBoxAdresseeMail.Visible = false;
                    this.textBoxSenderMail.Visible = false;
                    this.textBoxShowAllAdresseeMails.Visible = false;
                    this.buttonAddNewEmail.Visible = false;
                    this.buttonReadEmailFromFile.Visible = false;
                    this.labelMailPassword.Visible = false;
                    this.textBoxMailPassword.Visible = false;
                    this.textBoxTaskName.Visible = false;
                    //on new elements
                    this.textBoxSubkect.Visible = true;
                    this.textBoxBody.Visible = true;
                    this.labelBody.Visible = true;
                    this.labelSubject.Visible = true;
                    this.buttonAttachment.Visible = true;

                    this.buttonNext.Text = "Сохранить";

                    page++;
                }
                //if textbox is empty
                else
                {
                    MessageBox.Show("Данные не введенны!");
                    Logining.WriteLog("Попытка создать задание.Не введенны данные");
                }
            }
            //if show second page
            else if (page == 1)
            {
                //if task without some adressee email
                if (User.GetInstance().tasks[index].AdresseMails.Count == 0)
                {
                    MessageBox.Show("Введите хотя бы один email");
                    Logining.WriteLog("Попытка сохрниния задания.Не введен ни один email");
                    return;
                }
                //if task have adressee email
                else
                {
                    //if textBox have some text
                    if (textBoxSubkect.Text != "" && textBoxBody.Text != "")
                    {
                        //save body and subject text
                        User.GetInstance().tasks[index].Body = textBoxBody.Text;
                        User.GetInstance().tasks[index].Subject = textBoxSubkect.Text;
                        //write log and close this form
                        Logining.WriteLog("Текст и Тема добавленна");

                        AddItemsToParentForm();
                        
                        this.Close();
                    }
                    //if textBox without tetx
                    else
                    {
                        MessageBox.Show("Введите тему и сообщение!");
                        Logining.WriteLog("Не введенна тема или собщение!");
                        return;
                    }
                }
            }
        }
        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            //if start  page
            if(page==0)
            {

            }
            if(page==1)
            {

                //on visible elements in this page
                this.labelAdresseeMail.Visible = true;
                this.labelSenderMail.Visible = true;
                this.labelTaskName.Visible = true;
                this.textBoxAdresseeMail.Visible = true;
                this.textBoxSenderMail.Visible = true;
                this.textBoxShowAllAdresseeMails.Visible = true;
                this.buttonAddNewEmail.Visible = true;
                this.buttonReadEmailFromFile.Visible = true;
                this.labelMailPassword.Visible = true;
                this.textBoxMailPassword.Visible = true;
                this.textBoxTaskName.Visible = true;
                //off new elements
                this.textBoxSubkect.Visible = false;
                this.textBoxBody.Visible = false;
                this.labelBody.Visible = false;
                this.labelSubject.Visible = false;
                this.buttonAttachment.Visible = false;

                this.buttonNext.Text = "Далее";

                page--;
            }
        }
        private void buttonAddNewEmail_Click(object sender, EventArgs e)
        {
            //if text box have some text
            if (textBoxSenderMail.Text != "" && textBoxTaskName.Text != "")
            {
                //add name and sender email
                try
                {
                    //if need create new task
                    if (!IsCreate)
                    {
                        ////create and get index of task in list
                        index = User.GetInstance().AddNewTask(new Task(textBoxTaskName.Text, textBoxSenderMail.Text,textBoxMailPassword.Text)) - 1;
                     
                        IsCreate = true;
                        Logining.WriteLog(textBoxTaskName.Text + " Создан при нажатии добавить емейл");
                    }
                    //if task was created when ButtonNext was presse
                    else
                    {
                        //change infrmation
                        User.GetInstance().tasks[index].SenderMail = textBoxSenderMail.Text;
                        User.GetInstance().tasks[index].SenderMail = textBoxSenderMail.Text;
                    }

                }
                //if invalid email
                catch (CustomExeption.EmailNotValidExeption ex)
                {
                    MessageBox.Show(ex.Message);
                    Logining.WriteLog(ex.Message);
                    return;
                }
            }

                
            if (textBoxAdresseeMail.Text!="")
             {

                try
                {
                    //add email ito list adressee mail
                    User.GetInstance().tasks[index].AddAdresseeMail(textBoxAdresseeMail.Text);
                    //update textBox this listemail
                    AddToListsEmail();
                }
                //if invalid email
                catch(CustomExeption.EmailNotValidExeption ex)
                {
                    MessageBox.Show(ex.Message);
                    Logining.WriteLog(ex.Message);
                    return;    
                }
            }
        }
        private void buttonReadEmailFromFile_Click(object sender, EventArgs e)
        {

            if (textBoxSenderMail.Text != "" && textBoxTaskName.Text != "")
            {
                //add name and sender email
                try
                {
                    //if need create new task
                    if (!IsCreate)
                    {
                        ////create and get index of task in list
                        index = User.GetInstance().AddNewTask(new Task(textBoxTaskName.Text, textBoxSenderMail.Text, textBoxMailPassword.Text)) - 1;
                        IsCreate = true;
                        Logining.WriteLog(textBoxTaskName.Text + " Создан при нажатии считать емейл с файла");
                    }
                    //if task was created when ButtonNext was presse
                    else
                    {
                        //change infrmation
                        User.GetInstance().tasks[index].SenderMail = textBoxSenderMail.Text;
                        User.GetInstance().tasks[index].SenderMail = textBoxSenderMail.Text;
                    }

                }
                //if invalid email
                catch (CustomExeption.EmailNotValidExeption ex)
                {
                    MessageBox.Show(ex.Message);
                    Logining.WriteLog(ex.Message);
                    return;
                }
            }




            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text Documents|*.txt";
            if (ofd.ShowDialog() == DialogResult.Cancel)
                return;
           
            User.GetInstance().tasks[index].LoadEmailAdreeseFromFile(ofd.FileName);
            AddToListsEmail();
        }
        private void textBoxBody_TextChanged(object sender, EventArgs e)
        {

        }
        //add attachment
        private void buttonAttachment_Click(object sender, EventArgs e)
        {
            //FolderBrowserDialog file = new FolderBrowserDialog();
            OpenFileDialog file=new OpenFileDialog();
            file.Multiselect = true;
            if (file.ShowDialog() == DialogResult.Cancel)
                return;
            foreach (var str in file.FileNames)
                User.GetInstance().tasks[index].PathAttachments.Add(str);
        }
    }
}
