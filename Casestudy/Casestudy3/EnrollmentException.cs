﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy.Customexception
{
    internal class EnrollmentException
    {
        public static Dictionary<string, string> exceptionMessages = new Dictionary<string, string>()
        {
            {"One","The Course Enrolled Is Full sorry For The Inconvenience" },
            {"Two","Duplicate Entry Not Allowed" }

        };
        internal class FullException : Exception
        {
            public FullException(string message) : base(message)
            {

            }
        }
        internal class DuplicateException : Exception
        {
            public DuplicateException(string message) : base(message)
            {

            }
        }

    }
}