using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class CustomerData
    {
        int customerid;
        string? customername;
        int phonenumber;
        double balance;


        public int Customerid { get => customerid; set => customerid = value; }
        public string? Customername { get => customername; set => customername = value; }
        public int Phonenumber { get => phonenumber; set => phonenumber = value; }
        public double Balance { get => balance; set => balance = value; }



        public static List<CustomerData> customer = new List<CustomerData>()
             {
                 new CustomerData() { Customerid = 111, Customername = "Parvathy", Phonenumber = 90090090, Balance = 57899 },
                 new CustomerData() { Customerid = 122, Customername = "Aiswarya", Phonenumber = 90094444, Balance = 35499 },
                 new CustomerData() { Customerid = 133, Customername = "Aryamol", Phonenumber = 95678744, Balance = 67889 }


             };

        public void DispCustomerData(long phonenumber)
        {
            var found=customer.Find(x=>x.Phonenumber== phonenumber);    
            if(found != null)
            {
                Console.WriteLine(found.Customername);
                Console.WriteLine(found.Balance);
            }
            else
            {
                Console.WriteLine("no customer found");
            }
        }

        public void DispAllDetails()
        {

            foreach(var customer in customer)
            {
                Console.WriteLine($"Customer ID: {customer.Customerid} \n Customer name: {customer.Customername} \n Phone number:{phonenumber} \n Balance:{customer.Balance}" );
            }
        }


}

}
