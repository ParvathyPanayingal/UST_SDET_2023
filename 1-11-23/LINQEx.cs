using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class LINQEx
    {
        public void eg1()
        {
            List<string> courses = new List<string>();
            courses.Add("C Tutorial");
            courses.Add("C++ Tutorial");
            courses.Add("Java Tutorial");
            courses.Add("Web Tech");
            courses.Add("DBMS");
            courses.Add("UI Exp");
            courses.Add("Cloud Tech");


            //query syntax
            /* var result = from c in courses
                          where c.Equals("DBMS")
                          select c;
            */

            //method syntax
            //var result = courses.Where(c=>c.Equals("DBMS"));
            var result = courses.Where(c => c.Contains("Tutorial"));

            foreach (var r in result)
            {
                Console.WriteLine(r); 
            }
        }

        public void eg2()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student(1,"AA","CSE"));
            students.Add(new Student(2, "BB", "ECE"));
            students.Add(new Student(3, "CC", "IT"));
            students.Add(new Student(4, "DD", "CSE"));
            students.Add(new Student(5, "EE", "ECE"));
            students.Add(new Student(6, "FF", "CSE"));

            var stud = students.Where(s=>s.Id==3);
            foreach (var s in stud)
            {
                Console.WriteLine("Student:" +s.Id +" " + s.Name + " " + s.Dept);
            }

            var stud2 = (Student)students.FirstOrDefault(s => s.Id == 5);
            
           
                Console.WriteLine("Student:" + stud2.Id + " " + stud2.Name + " " + stud2.Dept);

            //exception
            var stud4 = (Student)students.FirstOrDefault(s => s.Id == 9);

            if (stud4 != null)
            {
                Console.WriteLine("Student:" + stud4.Id + " " + stud4.Name + " " + stud4.Dept);

            }
            else
            {
                Console.WriteLine("Not Found");
            }

            


            var stud1 = students.Where(s => s.Name == "FF");
            foreach (var s in stud)
            {
                Console.WriteLine("Student:" + s.Id + " " + s.Name + " " + s.Dept);
            }

            
            List<Student> stud3=(List<Student>)students.FindAll(s=>s.Name=="BB" || s.Name =="DD");

            foreach(var s in stud3)
            {
                Console.WriteLine("Student:" + s.Id + " " + s.Name+ " " + s.Dept);
            }

        }

        public void filteringOfType()
        {
            ArrayList elements = new ArrayList();
            elements.Add(1);
            elements.Add("Two");
            elements.Add(3);
            elements.Add(4);
            elements.Add("Five");

            var numbers =elements.OfType<int>();
            var strings=elements.OfType<string>();

            foreach(string str in strings)
                Console.WriteLine( "String :" + str);

            foreach (int num in numbers)
                Console.WriteLine("String :" + num);
        }
        
        
    }
}
