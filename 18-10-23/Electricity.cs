using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    class Electricity
    {
       public int consumernumber, previousreading, currentreading;
        public string? consumername;

        public Electricity(int consumernumber, int previousreading, int currentreading, string? consumername) //--select the variables and ctrl . the constructirs will be created.
        {
            this.consumernumber = consumernumber;
            this.previousreading = previousreading;
            this.currentreading = currentreading;
            this.consumername = consumername;
        }

        //writing constructor
        /*public Electricity()
        {
          consumernumber = 12345;
          previousreading = 9000;
          currentreading = 9300;
            consumername = "YY"; //--empty string is not null it is " "

        }*/


        //wriring method
        public double CalculateBill()
        {
            double billamount; //--no need to assign value because billamunt is never used in the right side of the code.
            int reading = currentreading - previousreading;
            if (reading <= 100) 
            {
                billamount = reading * 2.00;
            }
            else if(reading <= 200 && reading >= 101)
            {
                billamount =(100*2) + ((reading -100)* 2.5); 
            }
            else if (reading <= 401 && reading >= 201)
            {
                billamount = (100*2) + (100*2.5) + ((reading - 200)* 3.5);
            }
            else
            {
                billamount = (100*2) + (100*2.5) + (100*3.5) + ((reading-400)  *3.5);
            }
            return billamount;
        }
    }
}
