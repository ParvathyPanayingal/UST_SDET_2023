using Basic_Programs;

/*Employee employee =new (1223,"abc","IT",10000);
Console.WriteLine("Employee id :{0} \n"+
    "Name : {1} \n" +
    "Dept : {2} \n" +
    "Basic Pay : {3} ",
    employee.Eid,
    employee.Empname, 
    employee.Dept, 
    employee.Basicpay);
Console.WriteLine("Net Pay : {0} ",employee.CalcultaeSalary());*/

/*ArraySample arraySample = new ();
ArraySample jarray = new();
//arraySample.Onedim();
//arraySample.Twodim();
arraySample.Jarray();*/

/*StudentsMarks marks = new();
marks.RollNo = 32;
marks.StudentName = "Parvathy";
marks.City = "Kozhikode";
marks.Mark1 = 90;
marks.Mark2 = 85;
marks.Mark3 = 97;
marks.DisplayStudentDetails();
Console.WriteLine("Total:"+marks.CalculateTotal());
Console.WriteLine("Average:"+marks.CalculateAverage());*/

/*StudentGrade grade = new();
grade.RollNo = 32;
grade.StudentName = "Parvathy";
grade.City = "Kozhikode";
grade.Mark1 = 90;
grade.Mark2 = 85;
grade.Mark3 = 97;
grade.DisplayStudentDetails();
Console.WriteLine("Total:" + grade.CalculateTotal());
Console.WriteLine("Average:" + grade.CalculateAverage());
Console.WriteLine("Grade:" + grade.CalculateGrade());*/

/*Console.WriteLine("1.TS 2.NTS");

switch (Convert.ToInt32(Console.ReadLine()))
{
    case 1:
        TeachingStaff tstaff = new TeachingStaff();
        tstaff.Staffid = 111;
        tstaff.Name = "TS1";
        tstaff.Department = "CS";
        tstaff.Specializations = "O,DBMS";
        tstaff.Semester = 4;
        tstaff.DisplayStaffDetails();
        tstaff.DisplayTSDetails();
        break; 

case 2 :
    NonTeachingStaff ntstaff = new NonTeachingStaff();
        ntstaff.Staffid = 999;
        ntstaff.Name = "TS1";
        ntstaff.Department = "Admin";
        ntstaff.Responsibilities = "Attendence";
        ntstaff.Experience = 4;
        ntstaff.DisplayNonTSDetails();
        ntstaff.DisplayNonTSDetails();
    break;

}*/
//TeachingStaff ts = new TeachingStaff();
//NonTeachingStaff nts = new NonTeachingStaff();

/*
 EV ev = new();
ev.Vehnum = 4343;
ev.Brand = "MARUTI";
ev.Model = "aa";
ev.Disp();
Console.WriteLine( ev.setTypeForVehicle());

PV pv = new();
pv.Vehnum =2119;
pv.Brand = "KIA";
pv.Model = "bb";
pv.Disp();
Console.WriteLine(pv.setTypeForVehicle());
*/

/*Doctor doc=new Doctor();
doc.AddNewDoctor(1234,"abc");
doc.DisplayDoctorDetails();
doc.ModifyDoctor(5678,"def");
doc.DisplayDoctorDetails();
doc.BookApp(9876,"AAA");
doc.DelApp("AAA");*/

//BankDetails bank=new BankDetails(1234,123456789L,"AA","Inactive");
//BankDetails bank1 = new();
/*BankDetails bank2=new (1234,123456789L,"Parvathy","Inactive");


bank2.WelcomeMessage();
//bank2.WelcomeMessage("Parvathy");
Console.WriteLine("1.Custid 2.Accno 3.Name");
int choice=Convert.ToInt32(Console.ReadLine());

switch(choice)
{
    case 1:
        Console.WriteLine("Custid : ");
        bank2.GetAccountDetails(Convert.ToInt32(Console.ReadLine()));
        break;

    case 2:
        Console.WriteLine("Accno : ");
        bank2.GetAccountDetails(Convert.ToInt64(Console.ReadLine()));
        break;

    case 3:
        Console.WriteLine("Name : ");
        bank2.GetAccountDetails(Convert.ToInt64(Console.ReadLine()));
        break;

    default:Console.WriteLine("Enter between 1-3");
        break;
}
bank2.ExitMessage();*/

NGC nGC =new NGC();
//nGC.ArrayListHandling();
//nGC.Stackhandling();
//nGC.Queuehandling();
//nGC.HThandling();
//nGC.SLHandling();
Basic_Programs.GC gc = new();
//gc.ListHandling();
//gc.Stackhandling();
gc.Dicthandling();










