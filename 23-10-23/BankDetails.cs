using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//polymorphism with overloading
namespace Basic_Programs
{

    //constructor- overloading can be done in case of constructors also.
    internal class BankDetails
    {

        //default constructor
        /*
        public BankDetails()
        {
            Custid = 0;
            Accno = 0;
            Name= string.Empty;
            Status = "Inactive";
        }

        public BankDetails(int custid, long accno, string? name)
        {
            Custid = custid;
            Accno = accno;
            Name = name;
            Status = "Inactive";
        }
        */

        //parameterized constructor
        public BankDetails(int custid, long accno, string? name, string? status)
        {
            Custid = custid;
            Accno = accno;
            Name = name;
            Status = status;
        }

        public int Custid { get; set; }
        public long Accno { get; set; }
        public string? Name { get; set; }
        public string? Status { get; set; }

        public  virtual void WelcomeMessage()
        {
            Console.WriteLine("WELCOME");
        }

        public  void ExitMessage()
        {
            Console.WriteLine("Done");
        }

        //method

        public void GetAccountDetails(int custid)
        {
            if (Custid == custid)
                Console.WriteLine("Accno:{0} \t Name :{1} \t Status:{2}", Accno, Name, Status);
            else Console.WriteLine("Custid does not exist");
        }
        public void GetAccountDetails(long accno)
        {
            if (Accno == accno)
                Console.WriteLine("Custid:{0} \t Name :{1} \t Status:{2}", Custid, Name, Status);
            else Console.WriteLine("Accno does not exist");
        }
        public void GetAccountDetails(string name)
        {
            if (Name == name)
                Console.WriteLine("Custid:{0} \t Name :{1} \t Status:{2}", Custid, Accno, Status);
            else Console.WriteLine("Name does not exist");
        }
    }
}
