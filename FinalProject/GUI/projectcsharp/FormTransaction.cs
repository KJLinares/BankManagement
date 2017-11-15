using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using ClassLibraryDataSide;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace projectcsharp
{
    public partial class FormTransaction : Form
    {
        Customer cust = new Customer();

        public FormTransaction(Customer argCust)
        {
            InitializeComponent();
            this.cust = argCust;
        }

        private void Transaction_Load(object sender, EventArgs e)
        {

        }

        private void buttonDeposit_Click(object sender, EventArgs e)
        {

            Customer custDeposit = new Customer();
            long amount = Convert.ToInt64(textBoxAmont.Text);
            Transaction newTransaction = new Transaction();
            newTransaction.TypeTransaction = EnumTransactionType.deposite;

            if (checkBoxSaving.Checked)
            {
                newTransaction.Amount = amount;
                newTransaction.TransactionId = newTransaction.GenerateTransactionNumber();
                newTransaction.Description = EnumAccountType.saving;
                newTransaction.DateOfTrans = DateTime.Today;
                newTransaction.Status = EnumStatus.successful;

                custDeposit.AccSaving.UpdateBalance(newTransaction.TypeTransaction, amount);

                MessageBox.Show("Successfull deposit to your Savings account");

            }
            else if (checkBoxChecking.Checked)
            {
                newTransaction.Amount = amount;
                newTransaction.TransactionId = newTransaction.GenerateTransactionNumber();
                newTransaction.Description = EnumAccountType.checking;
                newTransaction.DateOfTrans = DateTime.Today;
                newTransaction.Status = EnumStatus.successful;


                custDeposit.AccChecking.UpdateBalance(newTransaction.TypeTransaction, amount);

                MessageBox.Show("Successfull deposit to your Checking account");
            }
            else if (checkBoxCredit.Checked)
            {
                newTransaction.Amount = amount;
                newTransaction.TransactionId = newTransaction.GenerateTransactionNumber();
                newTransaction.Description = EnumAccountType.credit;
                newTransaction.DateOfTrans = DateTime.Today;
                newTransaction.Status = EnumStatus.successful;


                custDeposit.AccCredit.UpdateBalance(newTransaction.TypeTransaction, amount);

                MessageBox.Show("Successfull deposit to your Credit account");
            }
            else
            {
                newTransaction.Status = EnumStatus.unsuccessful;
                MessageBox.Show("UnSuccessfull deposit");
            }
            custDeposit.Transactionlist.Add(newTransaction.TransactionId, newTransaction);

            Reset();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            string res;
            res = Convert.ToString(MessageBox.Show("Do you want to exit?", "Exit?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question));
            if (res == "OK")
            {
                this.Close();
            }
        }

        private void buttonWithdraw_Click(object sender, EventArgs e)
        {
           
            Customer custWithdraw = new Customer();
            decimal amount = Convert.ToDecimal(textBoxAmont.Text);
            Transaction newTransaction = new Transaction();
            newTransaction.TypeTransaction = EnumTransactionType.withdraw;

            if (checkBoxSaving.Checked)
            {
                newTransaction.Amount = amount;
                newTransaction.TransactionId = newTransaction.GenerateTransactionNumber();
                newTransaction.Description = EnumAccountType.saving;
                newTransaction.DateOfTrans = DateTime.Today;
                newTransaction.Status = EnumStatus.successful;


                custWithdraw.AccSaving.UpdateBalance(newTransaction.TypeTransaction, amount);

                MessageBox.Show("Successfull Withdraw from your Savings account");

            }
            else if (checkBoxChecking.Checked)
            {
                newTransaction.Amount = amount;
                newTransaction.TransactionId = newTransaction.GenerateTransactionNumber();
                newTransaction.Description = EnumAccountType.checking;
                newTransaction.DateOfTrans = DateTime.Today;

                if (custWithdraw.AccChecking.ReachedLimitTransactions() == false)
                {
                    newTransaction.Status = EnumStatus.successful;
                    custWithdraw.AccChecking.UpdateBalance(newTransaction.TypeTransaction, amount);
                    custWithdraw.AccChecking.UpdateCountTransactions();
                    MessageBox.Show("Successfull Withdraw from your Checking account");
                }
                else
                {
                    string ifcontinue;
                    ifcontinue = Convert.ToString(MessageBox.Show("You have reached the limitation of transactions. You will be charged extra fees if you continue to withdraw.", "Extra Fees Warn", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning));

                    if (ifcontinue == "OK")
                    {
                        newTransaction.Status = EnumStatus.successful;
                        custWithdraw.AccChecking.UpdateBalance(newTransaction.TypeTransaction, amount + custWithdraw.AccSaving.ExtraFees);
                        custWithdraw.AccChecking.UpdateCountTransactions();
                        MessageBox.Show("Successfull Withdraw from your Checking account");
                    }
                    else
                    {
                        newTransaction.Status = EnumStatus.unsuccessful;
                        //cust.AccChecking.UpdateBalance(newTransaction.TypeTransaction, cust.AccChecking.ExtraFees);
                        MessageBox.Show("UnSuccessfull Withdraw from your Checking account");
                    }

                    //newTransaction.Status = EnumStatus.unsuccessful;
                    //cust.AccChecking.UpdateBalance(newTransaction.TypeTransaction, cust.AccChecking.ExtraFees);
                    //MessageBox.Show("UnSuccessfull Withdrawal from your Checking account, You have reach the limit of allowed transactions.");
                }
            }
            else if (checkBoxCredit.Checked)
            {
                newTransaction.Amount = amount;
                newTransaction.TransactionId = newTransaction.GenerateTransactionNumber();
                newTransaction.Description = EnumAccountType.credit;
                newTransaction.DateOfTrans = DateTime.Today;

                if (custWithdraw.AccCredit.WithdrawExeedsLimit(amount) == false)
                {

                    newTransaction.Status = EnumStatus.successful;

                    custWithdraw.AccCredit.UpdateBalance(newTransaction.TypeTransaction, ((amount * custWithdraw.AccCredit.InterestRate) + amount));
                    MessageBox.Show("Successfull deposit to your Credit account");
                }
                else
                {
                    newTransaction.Status = EnumStatus.unsuccessful;

                    custWithdraw.AccCredit.UpdateBalance(newTransaction.TypeTransaction, custWithdraw.AccCredit.ExtraFees);

                    MessageBox.Show("UnSuccessfull Withdrawal from your Checking account, You have reach the limit of allowed transactions.");
                }
            }
            else
            {
                newTransaction.Status = EnumStatus.unsuccessful;
                MessageBox.Show("UnSuccessfull deposit");
            }

            custWithdraw.Transactionlist.Add(newTransaction.TransactionId, newTransaction);
            Reset();

        }
        public void Reset()
        {

            checkBoxSaving.Checked = false;
            checkBoxChecking.Checked = false;
            checkBoxCredit.Checked = false;
            textBoxAmont.Text = "";
        }

        private void labelSelectAccount_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxSaving_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxChecking_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxChecking.Checked)
            {
                checkBoxSaving.Checked = false;
                checkBoxCredit.Checked = false;

            }

        }

        private void checkBoxSaving_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBoxSaving.Checked)
            {
                checkBoxChecking.Checked = false;
                checkBoxCredit.Checked = false;

            }


        }

        private void checkBoxCredit_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCredit.Checked)
            {
                checkBoxChecking.Checked = false;
                checkBoxSaving.Checked = false;

            }

        }
    }
}
