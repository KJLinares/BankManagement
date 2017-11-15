using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    [Serializable]
    public class CheckingAccount:Account
    {
        int limitNum;
        public int LimitNum
        {
            get { return limitNum; }
            set { limitNum = value; }
        }
        
        int countTrans;
        public int CountTrans
        {
            get { return countTrans; }
            set { countTrans = value; }
        }

        public CheckingAccount():base()
        {
            this.limitNum = 00;
            this.countTrans = 00;
        }
        public CheckingAccount(int accountNum, int customerId, Date openDate, decimal balance, decimal extrafees, EnumAccountType typeAccount, int limitNum, int countTrans): base(accountNum, customerId, openDate,  balance,  extrafees, typeAccount)

        {
            this.limitNum = limitNum;
            this.countTrans = countTrans;
        }
        
        public override String ToString()
        {
            return base.ToString()+"\n\tLimit Number: "+this.limitNum+"\n\tCount Transaction:"+this.countTrans;
        }

        public bool ReachedLimitTransactions()
        {
            bool result = new bool();

            if (this.countTrans < this.limitNum)
            {
                result = false;
            }
            else if (this.countTrans >= this.limitNum)
            {
                result = true;
                this.UpdateBalance(EnumTransactionType.withdraw, base.ExtraFees);
            }

            return result;
        }

        public void UpdateCountTransactions()
        {
            this.countTrans++;
        }

       }
}
