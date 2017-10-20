using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Email
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            
            InitializeComponent();
            AutoLoadTestData();
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            //if user doesn't enter the data
            if (textBoxLogin.Text==""||textBoxPassword.Text=="")
            {
                MessageBox.Show("Данные не введены.Введите и повторите сново!");
                Logining.WriteLog("Данные не введены.Введите и повторите сново!");
                return;
            }
            Settings.GetInstance().DirectoryPath = @"D:\Study\ШАГ\С#\New\Email\Email\bin\Debug\" + textBoxLogin.Text;
            //if user enter first time
            if (checkBoxNewUser.Checked==true)
            {
                Logining.WriteLog("Создаем новый акаунт!");
                //Create new folder for this user
                Directory.CreateDirectory(Settings.GetInstance().DirectoryPath);
                //create file for save login and password
                //write user data to file
                File.AppendAllText(Settings.GetInstance().DirectoryPath + Settings.GetInstance().AutorisationFileName, textBoxLogin.Text + "    " + textBoxPassword.Text);
                //set hidden and REadOnly atribytes
                File.SetAttributes(Settings.GetInstance().DirectoryPath + Settings.GetInstance().AutorisationFileName, FileAttributes.Hidden|FileAttributes.ReadOnly);
              
                Logining.WriteLog(textBoxLogin.Text + " успешно вошел.Все пользовательские данные сохраненны");
            }
            //if user have account
            else
            {
                Logining.WriteLog("Входим с существующий акаунт");
                //if found user directory    
                if(Directory.Exists(Settings.GetInstance().DirectoryPath)&& File.Exists(Settings.GetInstance().DirectoryPath + Settings.GetInstance().AutorisationFileName))
                {
                    //save password and login from file for chek
                    string tmpData=new StreamReader(Settings.GetInstance().DirectoryPath + Settings.GetInstance().AutorisationFileName).ReadLine();
                    //if success
                    if(tmpData.Contains(textBoxLogin.Text)&& tmpData.Contains(textBoxPassword.Text))
                    {
                       // Settings.GetInstance().recipientLogEmail = File.ReadAllLines(Settings.GetInstance().DirectoryPath + Settings.GetInstance().AutorisationFileName)[1];
                        Logining.WriteLog(textBoxLogin.Text + " Успешно вошел");
                        
                    }
                    //if somw trouble
                    else
                    {
                        //show mwssage and write log
                        MessageBox.Show("Логин или пароль не верный!Перепроверьте и попробуйте сново");
                        Logining.WriteLog("Не правильный логин или пароль");
                        return;
                    }
                }
                //directory not found
                else
                {
                    MessageBox.Show("Упс...У нас нету Ваших данных.Войдите как новый пользователь");
                    Logining.WriteLog("Данные пользователя не найдены");
                    return;
                }
            }

            new MainForm().Show();
            this.Visible = false;
        }

        private void AutoLoadTestData()
        {
            textBoxLogin.Text = "Admin";
            textBoxPassword.Text = "1111";
        }

        ~LoginForm()
        {
            
        }
    }
}
