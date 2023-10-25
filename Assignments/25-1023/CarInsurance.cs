using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class CarInsurance : InsurancePolicyNew
    {
        public CarInsurance(int policyId, string? policyName,  double premiumAmount,string carType) : base(policyName, policyId, premiumAmount)
        {
        }
        public string? CarType { get; set; }
        public override double CalculatePremium()
        {
            if(CarType == "Electrical")
            {
                return PremiumAmount * 0.1+ PremiumAmount;
            }
            if (CarType == "Petrol")
            {
                return PremiumAmount * 0.2 + PremiumAmount;

            }
            if (CarType == "Diesel")
            {
                return PremiumAmount * 0.3 + PremiumAmount;

            }
            else
            {
                return PremiumAmount;
            }

        }
    }
}
