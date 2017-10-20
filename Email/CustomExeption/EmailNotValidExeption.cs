using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Email.CustomExeption
{
    class EmailNotValidExeption:Exception
    {

        public EmailNotValidExeption():base("Емейл имеет не верный формат")
        {

        }
        
    }
}
