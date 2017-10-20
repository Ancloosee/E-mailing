using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Email
{
    //Singletone class for save all user data
    [Serializable]
    class Settings
    {
        static Settings instanse;
        public string AutorisationFileName { get; } 
        public string DirectoryPath { set; get; }
        public int TaskTimeout { set; get; }
        public bool isDeserialize { set; get; }
        //flag send log
        //true- need send
        //false don't send
        public bool SendLog { set; get; } = true;
        //interval send Log
        public decimal IntervalSendLog { set; get; } = 1;
        // recipient log mail
        public string recipientLogEmail { set; get; } = "jenya.schulga@gmail.com";
        //email
        public string tehEmail { get; } = "teh.emaildispatch@gmail.com";
        //password
        public string tehPassword { get; } = "12er78ui45fg09kl";




        private Settings()
        {
            this.AutorisationFileName = @"\Authorization Data.txt";
            this.TaskTimeout = 5000000;
        }
       

        public static Settings GetInstance()
        {
            if (instanse == null)
                instanse = new Settings();
            return instanse;
        }
        //save recipientEmail to the file with avtorisation data
        
        ~Settings()
        {
            
        }


    }
}
