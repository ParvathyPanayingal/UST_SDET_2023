using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class InsurancePolicy
    {
        private string? policyName;
        private int policyId;
        private double premiumAmount;

        public string? PolicyName { get => policyName; set => policyName = value; }
        public int PolicyId { get => policyId; set => policyId = value; }
        public double PremiumAmount { get => premiumAmount; set => premiumAmount = value; }

        public InsurancePolicy(string? policyName, int policyId, double premiumAmount)
        {
            PolicyName = policyName;
            PolicyId = policyId;
            PremiumAmount = premiumAmount;
        }

        public void RenewPolicy(double newPremium)
        {
            premiumAmount = newPremium;
            Console.WriteLine("New premium amount : " + newPremium);
        }

        public void RenewPolicy()
        {
            premiumAmount = premiumAmount+0.1*premiumAmount;
            Console.WriteLine(" Premium amount : " + premiumAmount);
        }
    }
}
