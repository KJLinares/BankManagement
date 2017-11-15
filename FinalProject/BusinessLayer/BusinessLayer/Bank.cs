using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    [Serializable]
    public class Bank
    {
        Dictionary<int, Customer> customerList;
        public Dictionary<int, Customer> CustomerList
        {
            get { return customerList; }
            set { customerList = value; }
        }

        Dictionary<int, SavingAccount> savingAccountList;
        public Dictionary<int, SavingAccount> SavingAccountList
        {
            get { return savingAccountList; }
            set { savingAccountList = value; }
        }

        Dictionary<int, CheckingAccount> checkingAccountList;
        public Dictionary<int, CheckingAccount> CheckingAccountList
        {
            get { return checkingAccountList; }
            set { checkingAccountList = value; }
        }

        Dictionary<int, CreditAccount> creditAccountList;
        public Dictionary<int, CreditAccount> CreditAccountList
        {
            get { return creditAccountList; }
            set { creditAccountList = value; }
        }


        public Bank()
        {
            this.savingAccountList = new Dictionary<int, SavingAccount>();
            this.checkingAccountList = new Dictionary<int, CheckingAccount>();
            this.creditAccountList = new Dictionary<int, CreditAccount>();
            this.customerList = new Dictionary<int,Customer>();
        }

        public Bank(Dictionary<int, SavingAccount> savingAccountList, Dictionary<int, CheckingAccount> checkingAccountList, Dictionary<int, CreditAccount> creditAccountList, Dictionary<int, Customer> customerList)
        {
            this.savingAccountList = savingAccountList;
            this.checkingAccountList = checkingAccountList;
            this.creditAccountList =creditAccountList;
            this.customerList = customerList;
        }

    }
}
