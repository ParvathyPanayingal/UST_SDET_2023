﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class NonTeachingStaff:StaffDetails
    {
        public string? Responsibilities { get; set; }
        public int Experience { get; set; }

        public void DisplayNonTSDetails()
        {
            Console.WriteLine("Responsibilities:{0} \n Experience :{1} \n"
                , Responsibilities, Experience);
        }
    }

}
