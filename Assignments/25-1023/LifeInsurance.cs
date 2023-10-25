using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class LifeInsurance:InsurancePolicyNew
    {
       
        public LifeInsurance(int policyId, string? policyName,  double premiumAmount,int age
            ) : base(policyName, policyId, premiumAmount)
        {
        }

        
        public int Age { get; set; }
        public override double CalculatePremium()
        {
             if ( Age <=10 )
            {
                return PremiumAmount * 0.1 + PremiumAmount;
            }
            if (Age <= 18)
            {
                return PremiumAmount * 0.2 + PremiumAmount;
            }
            if (Age <= 60)
            {
                return PremiumAmount * 0.3 + PremiumAmount;
            }
            else
            {
                return PremiumAmount *0.4 + PremiumAmount;
            }
        }
    }
}
