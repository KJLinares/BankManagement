using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{

    [Serializable]
    public abstract class Account : IAccount
    {
        int accountNum;

        public int AccountNum
        {
            get { return accountNum; }
            set { accountNum = value; }
        }


        int customerId;
        public int CustomerId
        {
            get { return customerId; }
            set { customerId = value; }
        }

        Date openDate;
        public Date OpenDate
        {
            get { return openDate; }
            set { openDate = value; }
        }

        decimal extraFees;
        public decimal ExtraFees
        {
            get { return extraFees; }
            set { extraFees = value; }
        }

        decimal balance;
        public decimal Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        EnumAccountType typeAccount;
        public EnumAccountType TypeAccount
        {
            get { return typeAccount; }
            set { typeAccount = value; }
        }

        public Account()
        {
            this.accountNum = 000;
            this.customerId = 00;
            this.openDate = new Date();
            this.balance = 00;
            this.extraFees = 00;
            this.typeAccount = new EnumAccountType();

        }

        public Account(int accountNum, int customerId, Date openDate, decimal balance, decimal extrafees, EnumAccountType typeAccount)
        {
            this.accountNum = accountNum;
            this.customerId = customerId;
            this.openDate = openDate;
            this.balance = balance;
            this.extraFees = extrafees;
            this.typeAccount = typeAccount;
        }

        public override String ToString()
        {
            return "\n\tAccount Number: " + this.accountNum + "\n\tCustomer ID: " + this.customerId + "\n\tOpen Date: " + this.openDate + "\n\tBalance: " + this.balance + "\n\tExtraFees" + this.extraFees;
        }

        public void UpdateBalance(EnumTransactionType trans, decimal amnt)
        {
            if (EnumTransactionType.deposite == trans)
            {
                this.balance = +amnt;
            }
            else if (EnumTransactionType.withdraw == trans)
            {
                this.balance = -amnt;
            }
        }

    }
}
