using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal abstract class InsurancePolicyNew
    {
        private string? policyName;
        private int policyId;
        private double premiumAmount;

        public InsurancePolicyNew(string? policyName, int policyId, double premiumAmount)
        {
            PolicyName = policyName;
            PolicyId = policyId;
            PremiumAmount = premiumAmount;
        }

        public string? PolicyName { get => policyName; set => policyName = value; }
        public int PolicyId { get => policyId; set => policyId = value; }
        public double PremiumAmount { get => premiumAmount; set => premiumAmount = value; }


        public abstract double CalculatePremium();

    }
}
