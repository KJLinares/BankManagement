using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    [Serializable]
    public class CreditAccount:Account
    {
        int limitAmount;
        public int LimitAmount
        {
            get { return limitAmount; }
            set { limitAmount = value; }
        }
        
        decimal interestRate;
        public decimal InterestRate
        {
            get { return interestRate; }
            set { interestRate = value; }
        }

        public CreditAccount():base()
        {
            this.limitAmount = 00;
            this.interestRate = 00;
        }
        public CreditAccount(int accountNum, int customerId, Date openDate, decimal balance, decimal extrafees,EnumAccountType typeAccount, int limitAmount, decimal interestRate)
            : base(accountNum, customerId, openDate, balance, extrafees, typeAccount)

        {
            this.limitAmount = limitAmount;
            this.interestRate = interestRate;
        }

        public override String ToString()
        {
            return base.ToString() + "\n\tLimit Amount: " + this.limitAmount  + "\n\tInterest Rate" + this.interestRate;
        }

        public bool WithdrawExeedsLimit(decimal amnt)
        {
            bool result = new bool();

            if (this.limitAmount >= amnt )
            {
                result = false;
            }
            else if (this.limitAmount < amnt)
            {
                result = true;
                this.UpdateBalance(EnumTransactionType.withdraw, this.ExtraFees);
            }
            return result;
        }
    }
}
