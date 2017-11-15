using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BusinessLayer
{
    [Serializable]
    public class Transaction
    {
        long transactionId;
        public long TransactionId
        {
            get { return transactionId; }
            set { transactionId = value; }
        }

        EnumAccountType description;
        public EnumAccountType Description
        {
            get { return description; }
            set { description = value; }
        }

        //system time
        DateTime dateOfTrans = DateTime.Now;

        public DateTime DateOfTrans
        {
            get { return dateOfTrans; }
            set { dateOfTrans = value; }
        }


        decimal amount;
        public decimal Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        EnumTransactionType typeTransaction;
        public EnumTransactionType TypeTransaction
        {
            get { return typeTransaction; }
            set { typeTransaction = value; }
        }

        EnumStatus status;
        public EnumStatus Status
        {
            get { return status; }
            set { status = value; }
        }

        public Transaction()
        {
            this.transactionId = GenerateTransactionNumber();
            this.description = new EnumAccountType();
            this.dateOfTrans = DateTime.Now;
            this.amount = 00;
            this.typeTransaction = new EnumTransactionType();
            this.status = new EnumStatus();
        }
        public Transaction(long transactionId, EnumAccountType description, DateTime dateOfTrans, decimal amount, EnumTransactionType typeTransaction, EnumStatus status)
        {
            this.transactionId = transactionId;
            this.description = description;
            this.dateOfTrans = dateOfTrans;
            this.amount = amount;
            this.typeTransaction = typeTransaction;
            this.status = status;
        }
        public override string ToString()
        {
            return base.ToString()+"\n\tTransaction Id: "+this.transactionId+"\n\tDescrition: "+this.description+"Date of Transaction: "+this.dateOfTrans+"Amount: "+this.amount+"Type of Transaction: "+this.typeTransaction;
        }
        public long GenerateTransactionNumber()
        {
            String type = ((int)this.typeTransaction).ToString();
            String generator = dateOfTrans.ToString("yyyyMMddHHmmss") + type;
            return long.Parse(generator);
        }

    }
}
