﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class StaffDetails
    {
        public int Staffid { get; set; }
        public string? Name { get; set; }
        public string? Department { get; set; }

        public void DisplayStaffDetails()
        {
            Console.WriteLine("Id:{0} \n Name :{1} \n" + "Department: {2}"
                , Staffid, Name,Department);
        }
    }
}
