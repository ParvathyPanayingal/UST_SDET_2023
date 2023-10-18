using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class Student
    {
        public string? studentname ;
        public int grade1;
        public int grade2;
        public int grade3;


        public Student(string? studentname,int grade1,int grade2,int grade3 ) 
        {
            this.studentname = studentname;
            this.grade1 = grade1;
            this.grade2 = grade2;
            this.grade3 = grade3;
        }
        
        
        public double CalculateAverage()
        {
            double average;
            average = (grade1 + grade2 + grade3)/3;
            return average;
        }
            
    }
}
