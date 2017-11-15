using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

namespace BusinessLayer
{
    //customer has accounts,transactions
    [Serializable]
    public class Customer
    {

        int customerId;
        public int CustomerId
        {
            get { return customerId; }
            set { customerId = value; }
        }

        String c_first;
        public String C_first
        {
            get { return c_first; }
            set { c_first = value; }
        }

        String c_last;
        public String C_last
        {
            get { return c_last; }
            set { c_last = value; }
        }

        int pin;
        public int Pin
        {
            get { return pin; }
            set { pin = value; }
        }

        String email;
        public String Email
        {
            get { return email; }
            set { email = value; }
        }

        String phoneNumber;
        public String PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        String address;
        public String Address
        {
            get { return address; }
            set { address = value; }
        }

        SavingAccount accSaving;
        public SavingAccount AccSaving
        {
            get { return accSaving; }
            set { accSaving = value; }
        }

        CheckingAccount accChecking;
        public CheckingAccount AccChecking
        {
            get { return accChecking; }
            set { accChecking = value; }
        }

        CreditAccount accCredit;
        public CreditAccount AccCredit
        {
            get { return accCredit; }
            set { accCredit = value; }
        }

        Dictionary<long, Transaction> transactionlist;
        public Dictionary<long, Transaction> Transactionlist
        {
            get { return transactionlist; }
            set { transactionlist = value; }
        }

        public Customer()
        {
            this.customerId = 0000;
            this.c_first = " ";
            this.c_last = "";
            this.pin = 0000;
            this.email = "";
            this.phoneNumber = "Unknonwn";
            this.address = "";
            this.accSaving = new SavingAccount();
            this.accCredit = new CreditAccount();
            this.accChecking = new CheckingAccount();
            this.transactionlist = new Dictionary<long, Transaction>();

        }
        public Customer(int customerId, String c_first, String c_last, int pin, String email, String phoneNumber, String address)
        {
            this.customerId = customerId;
            this.c_first = c_first;
            this.c_last = c_last;
            this.pin = pin;
            this.email = email;
            this.phoneNumber = phoneNumber;
            this.address = address;

        }

        public Customer(int customerId, String c_first, String c_last, int pin, String email, String phoneNumber, String address, SavingAccount accSaving, CreditAccount accCredit, CheckingAccount accChecking, Dictionary<long, Transaction> transactionlist)
        {
            this.customerId = customerId;
            this.c_first = c_first;
            this.c_last = c_last;
            this.pin = pin;
            this.email = email;
            this.phoneNumber = phoneNumber;
            this.address = address;
            this.accSaving = accSaving;
            this.accCredit = accCredit;
            this.accChecking = accChecking;
            this.transactionlist = transactionlist;
        }
        public override String ToString()
        {
            return "\n\tCustomer ID: " + this.customerId + "\n\tFirst Name: " + this.c_first + "\n\tLast Name: " + this.c_last + "\n\tPIN: " + this.pin + "\n\tEmail: " + this.email + "\n\tPhone Number: " + this.phoneNumber + "\n\tAddress: " + this.address;
        }

        public bool ValidPin(int pin)
        {
            if (this.pin == pin)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool ValidId(int Cid)
        {
            if (this.customerId == Cid)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
