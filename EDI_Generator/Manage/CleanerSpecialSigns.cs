using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDI_Generator.Manage
{
    class CleanerSpecialSigns
    {
       // private 


        public static string Cleaner(string str)
        {
            StringBuilder sb = new StringBuilder();

            foreach (char c in str)
            {
                if (!c.Equals('?') && !c.Equals(':') && !c.Equals('\'') && !c.Equals(',') && !c.Equals('+'))
                {
                    sb.Append(c);
                }
               
            }
            return sb.ToString();


        }


    }
}
