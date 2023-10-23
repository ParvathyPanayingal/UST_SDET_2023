using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Employee : Person, IDisplayable
    {

        private int e_id;

        public Employee(string? firstname, string? lastname, int age, int e_id) : base(firstname, lastname, age)
        {
            E_id = e_id;
        }

        public int E_id { get => e_id; set => e_id = value; }

        public void DisplayInfo(int age)
        {

            if (age >= 18 && age <= 100)

                Console.WriteLine("Employee id:" + E_id);
                Console.WriteLine("Full name:" + Firstname + Lastname);
                Console.WriteLine("Age:" + Age);

          
        }
    }
}
