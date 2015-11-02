using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seranet.SpecM2.Model
{
    public static class SpecSettings
    {
       
        public static String Config()
        {
            return System.Environment.GetEnvironmentVariable("SERANET.SPECM2.DBCONTEXT");
        }

        public static String UserMail()
        {
            return System.Environment.GetEnvironmentVariable("SERANET.SPECM2.USEREMAILADDRESS");
        }
        
        public static String UserMailPassword()
        {
            return System.Environment.GetEnvironmentVariable("SERANET.SPECM2.USERPASSWORD");
        }



    }
}
