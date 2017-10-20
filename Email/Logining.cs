using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Email
{
    class Logining
    {

        public static void WriteLog(string logmassage)
        {

            //FileStream file = new FileStream("Log.txt", FileMode.Append, FileAccess.ReadWrite, FileShare.ReadWrite);
            ////file.
            
            File.AppendAllText("Log.txt", DateTime.Now.ToString() + "  " + logmassage + "\r\n-------------------------------------------------------------------------------------------------\r\n");

        }
    }
}
