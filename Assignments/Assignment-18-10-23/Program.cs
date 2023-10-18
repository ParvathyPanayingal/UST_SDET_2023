
using Assignments;
/*static void Main(string[] args)
{
    int[] studentGrades = { 90, 85, 78, 92 };
    Student student = new Student("abc", studentGrades);
    double average = student.CalculateAverage();
    Console.WriteLine(student.studentname);
    Console.WriteLine(average);
}*/


Student student = new("abc",30,70,80); //-- no need to give constructor name 
Console.WriteLine(student.studentname);
Console.WriteLine(student.CalculateAverage());
