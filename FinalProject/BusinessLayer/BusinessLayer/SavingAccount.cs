using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    [Serializable]
    public class SavingAccount : Account
    {
        decimal interestRate;

        public decimal InterestRate
        {
            get { return interestRate; }
            set { interestRate = value; }
        }
        decimal annualGain;

        public decimal AnnualGain
        {
            get { return annualGain; }
            set { annualGain = value; }
        }


        public SavingAccount()
            : base()
        {
            this.annualGain = 00;
            this.interestRate = 00;
        }
        public SavingAccount(int accountNum, int customerId, Date openDate, decimal balance, decimal extrafees,EnumAccountType typeAccount, decimal interestRate, decimal annualGain)
            : base( accountNum,  customerId,  openDate,  balance, extrafees, typeAccount)
        {            
            this.interestRate = interestRate;
            CalculateAnnualGain();
        }
        public override String ToString()
        {
            return base.ToString() + "\n\tAnnual Gain: " + this.annualGain + "\n\tInterest Rate:" + this.interestRate ;
        }


        public void CalculateAnnualGain()
        {
            this.annualGain = this.interestRate * this.Balance;

        }

    }
}