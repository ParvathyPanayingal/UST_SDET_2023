using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignments
{
    internal class Person
    {
        private string? firstname;
        private string? lastname;
        private int age;

        public Person(string? firstname, string? lastname, int age)
        {
            Firstname = firstname;
            Lastname = lastname;
            Age = age;
        }

        public string? Firstname { get => firstname; set => firstname = value; }
        public string? Lastname { get => lastname; set => lastname = value; }

        

        public int Age
        {
            get { return age; }
            set { if (value >= 18 && value<= 100)
                {
                    age = value;
                }
                else
                {
                    Console.WriteLine("Enter age between 18 and 100");
                }
            }
        }


        





    }


}
