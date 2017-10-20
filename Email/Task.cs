using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
//using Ionic.Zip;
using System.IO;
using Ionic.Zip;

namespace Email
{
    [Serializable]
    public class Task
    {
        //mail adress "from"
        public string SenderMail { set; get; }
        //password from senderMail
        public string PasswordSenderMail { set; get; }
        //list of email adress "to"
        public List<string> AdresseMails { set; get; }
        //sybject of your mail
        public string Subject { set; get; }
        //body of your mail
        public string Body { set; get; }
        //name of our Task
        public string Name { set; get; }
        //count emails in the one task
        const int MAILSCOUNT = 100;
        //save smtp server and smtp port all provoderes
        Dictionary<string, KeyValuePair<string, int>> smpSERVPORT;
        //curreat smpt server and port
        KeyValuePair<string, int> currentSMTP;
        public List<string> PathAttachments { set; get; }


        public Task()
        {

        }
        public Task(string Name,string senderMail,string password)
        {
            //if valid email
            if(IsValidSenderEmail(senderMail))
            {
                this.Name = Name;
                this.SenderMail = senderMail;
                this.PasswordSenderMail = password;
                AdresseMails = new List<string>();
                PathAttachments = new List<string>();
                smpSERVPORT = new Dictionary<string, KeyValuePair<string, int>>();
                //gmail
                smpSERVPORT.Add("gmail.com", new KeyValuePair<string, int>("smtp.gmail.com", 587));
                smpSERVPORT.Add("yandex.ru", new KeyValuePair<string, int>("smtp.yandex.ru", 25));
                smpSERVPORT.Add("mail.ru", new KeyValuePair<string, int>("smtp.mail.ru ", 25));
               
                foreach(var tmp in smpSERVPORT)
                {
                    if(senderMail.Contains(tmp.Key))
                    {
                        currentSMTP = new KeyValuePair<string, int>(tmp.Value.Key, tmp.Value.Value);
                    }
                }
            }
            //if not valid email
            else
            {
                throw new CustomExeption.EmailNotValidExeption();
            }
        }
        //add email to list adrese emails
        public void AddAdresseeMail(string email)
        {
            //if string сorresponds to email format
            if (IsValidEmail(email))
                AdresseMails.Add(email);
            else    
                throw new CustomExeption.EmailNotValidExeption();
        }
        //chek valid email 
        bool IsValidSenderEmail(string email)
        {

            //        string pattern = @"^[-a-zA-Z0-9][+-.a-zA-Z0-9]*@[-.a-zA-Z0-9]+(\.[-.a-zA-Z0-9]+)*\.
            //(com|edu|info|gov|int|mil|net|org|biz|name|museum|coop|aero|pro|tv|[a-zA-Z]{2})$";
            string pattern = @"^[-a-zA-Z0-9][+-.a-zA-Z0-9]*@
    (gmail.com|yandex.ru|mail.ru)";
            //Regular expression object
            Regex check = new Regex(pattern, RegexOptions.IgnorePatternWhitespace);
            //boolean variable to return to calling method
            bool valid = false;

            //make sure an email address was provided
            if (string.IsNullOrEmpty(email))
            {
                valid = false;
            }
            else
            {
                //use IsMatch to validate the address
                valid = check.IsMatch(email);
            }
            //return the value to the calling method
            return valid;
        }
        bool IsValidEmail(string email)
        {

            string pattern = @"^[-a-zA-Z0-9][+-.a-zA-Z0-9]*@[-.a-zA-Z0-9]+(\.[-.a-zA-Z0-9]+)*\.
            (com|edu|info|gov|int|mil|net|org|biz|name|museum|coop|aero|pro|tv|[a-zA-Z]{2})$";

            //Regular expression object
            Regex check = new Regex(pattern, RegexOptions.IgnorePatternWhitespace);
            //boolean variable to return to calling method
            bool valid = false;

            //make sure an email address was provided
            if (string.IsNullOrEmpty(email))
            {
                valid = false;
            }
            else
            {
                //use IsMatch to validate the address
                valid = check.IsMatch(email);
            }
            //return the value to the calling method
            return valid;
        }
        
        //asysc version send mail
        public async System.Threading.Tasks.Task SendMailAsync()
        {
            MailMessage message = new MailMessage();
            message.From = new MailAddress(this.SenderMail);

            foreach (string str in this.AdresseMails)
            {
              ////  if (message.Bcc.Count < Task.MAILSCOUNT)
              //  {
                    message.Bcc.Add(str);
                    //Remove from the list those already in the list
               //     AdresseMails.Remove(str);
              //  }
              //  else
                    //break;
            }
            message.Body = this.Body;
            message.IsBodyHtml = false;
            message.Subject = this.Subject;

            SmtpClient smtp = new SmtpClient(currentSMTP.Key, currentSMTP.Value);
            // логин и пароль
            smtp.Credentials = new NetworkCredential(this.SenderMail, PasswordSenderMail);
            smtp.EnableSsl = true;

            //if need add atachents
            if (this.PathAttachments.Count>0)
            {
                //logging it
                Logining.WriteLog("Имеются вложения.Они будут заархивированны");
              //  add all atachments to zip archive
                ZipFile zipFile = new ZipFile();
                ;
                string path = "tmpArhive" + new Random().Next() + ".zip";
                zipFile.AddFiles(this.PathAttachments, "");
                zipFile.Save(path);
                //add archive to atachments 
                message.Attachments.Add(new Attachment(path));
            }

            await smtp.SendMailAsync(message);
         
        }
        public void SendMail()
        {
            MailMessage message = new MailMessage();
            message.From = new MailAddress(this.SenderMail);

            foreach (string str in this.AdresseMails)
                message.Bcc.Add(str);

            message.Body = this.Body;
            message.IsBodyHtml = false;
            message.Subject = this.Subject;

            SmtpClient smtp = new SmtpClient(currentSMTP.Key, currentSMTP.Value);
            // логин и пароль
            smtp.Credentials = new NetworkCredential(this.SenderMail, PasswordSenderMail);
            smtp.EnableSsl = true;

            //if need add atachents
            if (this.PathAttachments != null)
            {
                //logging it
                Logining.WriteLog("Имеются вложения.Они будут заархивированны");
                //add all atachments to zip archive 
                ZipFile zipFile = new ZipFile();
                zipFile.AddFiles(PathAttachments);
                zipFile.Save("tmpArhive.zip");
                //add archive to atachments 
                message.Attachments.Add(new Attachment("tmpArhive.zip"));


            }
            smtp.Send(message);

        }
        //read all emails from file
        public void LoadEmailAdreeseFromFile(string path)
        {
            StreamReader reader = new StreamReader(path);

            while(!reader.EndOfStream)
            {
                string tmpmal = reader.ReadLine();
                if (IsValidEmail(tmpmal))
                    AdresseMails.Add(tmpmal);
            }
            reader.Close();

        }
        //static methods
        public static bool IsValidMail(string email)
        {

            string pattern = @"^[-a-zA-Z0-9][+-.a-zA-Z0-9]*@[-.a-zA-Z0-9]+(\.[-.a-zA-Z0-9]+)*\.
            (com|edu|info|gov|int|mil|net|org|biz|name|museum|coop|aero|pro|tv|[a-zA-Z]{2})$";

            //Regular expression object
            Regex check = new Regex(pattern, RegexOptions.IgnorePatternWhitespace);
            //boolean variable to return to calling method
            bool valid = false;

            //make sure an email address was provided
            if (string.IsNullOrEmpty(email))
            {
                valid = false;
            }
            else
            {
                //use IsMatch to validate the address
                valid = check.IsMatch(email);
            }
            //return the value to the calling method
            return valid;
        }
        ~Task()
        {
           
            string[] _files = Directory.GetFiles(@"D:\Study\ШАГ\С#\New\Email\Email\bin\Debug",@"*.zip");
            foreach (string fl in _files)
            {
                File.Delete(fl);
               
            }
        }
       }
    }
