using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Email
{
    class User
    {
        static User instance;
        //List of your Task
        Serialize serialise = new Serialize();
        public List<Task> tasks { set; get; }
        //tehnilac email and passwor
        
        private User()
        {
            //try deserialisation
            //if error create new 
            tasks = new List<Task>();

            /*ВРЕМЕННО*/

            try
            {
                // Serialize.XmlDeserialization(tasks);
                tasks = serialise.BinaryDeserialization();

                Logining.WriteLog("XML десериализация прошла успешно");
            }
            catch (FileNotFoundException ex)
            {
                tasks = new List<Task>();
            }


        }
        public static User GetInstance()
        {
            if (instance == null)
                instance = new User();
            return instance;
        }
        
        //add new task
        public int AddNewTask(Task task)
        {
            tasks.Add(task);
            return tasks.Count();
        }
        private async System.Threading.Tasks.Task SendLog()
        {

           if (File.Exists("Log.txt") )
           {
            MailMessage message = new MailMessage();
            message.From = new MailAddress(Settings.GetInstance().tehEmail);

            message.To.Add(Settings.GetInstance().recipientLogEmail);
            message.Body = "You Log";
            message.IsBodyHtml = false;
            message.Subject = "Log";

            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            // логин и пароль
            smtp.Credentials = new NetworkCredential(Settings.GetInstance().tehEmail, Settings.GetInstance().tehPassword);
            smtp.EnableSsl = true;
                
                message.Attachments.Add(new Attachment("Log.txt"));
                await smtp.SendMailAsync(message);
            }
        }
        public async void SendLogs()
        {
            if(Settings.GetInstance().SendLog)
            {
                
                while (true)
                {
                    
                    if (Settings.GetInstance().SendLog)
                    {
                        System.Threading.Tasks.Task task = SendLog();
                        await task;
                        await  System.Threading.Tasks.Task.Delay((60000 * (int)Settings.GetInstance().IntervalSendLog));
                    }
                }
            }
        }
        ~User()
        {
            //serialisation 
            serialise.BinarySerialisation(tasks);
            serialise.XmlSerialisation(tasks);
            Logining.WriteLog("Успешно сериализированно");
        }
    }
}
