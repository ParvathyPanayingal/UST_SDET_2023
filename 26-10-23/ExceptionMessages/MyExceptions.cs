using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs.ExceptionMessages
{
    internal class MyExceptions
    {
        /* public static List<string> expmesslist = new List<string>()
         {
             "Dont't give 0 for denominator.",
             "Index is out of range.",
             "Unknown exception occured."
         };*/

        public static Dictionary<int, string> expmesslist = new Dictionary<int, string>()
        {
            { 1, "Dont't give 0 for denominator." },
            { 2,"Index is out of range." },
            { 3,"Unknown exception occured." },
            {4,"Age is less" }
        };

        internal class Num1Exception : Exception
        {
            public Num1Exception(string message) : base(message)
            {
            }
        }

        internal class Num2Exception : Exception
        {
            public Num2Exception(string message) : base(message)
            {
            }
        }


    }

}
