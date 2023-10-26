using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class CallRecord
    {
        public int CallId { get; set; }

        public long PhoneNumber { get; set; }
        public long CallTime { get; set; }

        public static List<CallRecord> Call = new List<CallRecord>()
        {
            new CallRecord() { CallId = 111,PhoneNumber=9990009990,CallTime=5},
            new CallRecord() {CallId=122,PhoneNumber=8880008880,CallTime=2},
            new CallRecord(){CallId=133,PhoneNumber=7770007770,CallTime=7}

        };
        public static void CallHistory(long phonenumber)
        {
            var data = Call.FindAll(x => x.PhoneNumber == phonenumber);
            if (data.Count() > 0)
                foreach (var x in data)
                {
                    Console.WriteLine("CallId:" + x.CallId);
                    Console.WriteLine("CallTime:" + x.CallTime);
                }
            else
            {
                Console.WriteLine("No Record Found");
            }

        }
    }
}