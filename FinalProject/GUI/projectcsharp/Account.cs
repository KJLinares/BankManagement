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
    public partial class FormAccount : Form
    {

        String savingfilePath = SavingAccountDB.filePath;
        String checkingfilePath = CheckingAccountDB.filePath;
        String creditfilePath = CreditAccountDB.filePath;
        //Customer cust = new Customer();
        //private Bank fortisBank = new Bank(SavingAccountDB.ReadFromFile(), CheckingAccountDB.ReadFromFile(), CreditAccountDB.ReadFromFile(), CustomerDB.ReadFromFile());
        private Bank fortisBank = new Bank();
        public FormAccount()
        {
            InitializeComponent();
        }
        public void listAllSavingAccount(Dictionary<int, SavingAccount> dictSaving)
        {
            listViewSaving.Items.Clear();
            if (fortisBank.SavingAccountList != null)
            {
                foreach (SavingAccount current in fortisBank.SavingAccountList.Values)
                {
                    ListViewItem item = new ListViewItem(current.CustomerId.ToString());
                    item.SubItems.Add(current.Balance.ToString());
                    item.SubItems.Add(current.OpenDate.ToString());
                    item.SubItems.Add(current.AccountNum.ToString());
                    item.SubItems.Add(current.InterestRate.ToString());
                    item.SubItems.Add(current.ExtraFees.ToString());
                    listViewSaving.Items.Add(item);
                }
            }
            else { MessageBox.Show("NO DATA"); }
        }

        public void listAllCheckingAccount(Dictionary<int, CheckingAccount> dictChecking)
        {
            listViewChecking.Items.Clear();
            if (fortisBank.CheckingAccountList != null)
            {
                foreach (CheckingAccount current in fortisBank.CheckingAccountList.Values)
                {
                    ListViewItem item = new ListViewItem(current.CustomerId.ToString());
                    item.SubItems.Add(current.Balance.ToString());
                    item.SubItems.Add(current.OpenDate.ToString());
                    item.SubItems.Add(current.AccountNum.ToString());
                    item.SubItems.Add(current.LimitNum.ToString());
                    item.SubItems.Add(current.CountTrans.ToString());
                    item.SubItems.Add(current.ExtraFees.ToString());
                    listViewChecking.Items.Add(item);
                }
            }
            else { MessageBox.Show("NO DATA"); }
        }

        public void listAllCreditAccount(Dictionary<int, CreditAccount> dictCredit)
        {
            listViewCredit.Items.Clear();
            if (fortisBank.CreditAccountList != null)
            {
                foreach (CreditAccount current in fortisBank.CreditAccountList.Values)
                {
                    ListViewItem item = new ListViewItem(current.CustomerId.ToString());
                    item.SubItems.Add(current.Balance.ToString());
                    item.SubItems.Add(current.OpenDate.ToString());
                    item.SubItems.Add(current.AccountNum.ToString());
                    item.SubItems.Add(current.InterestRate.ToString());
                    item.SubItems.Add(current.LimitAmount.ToString());
                    item.SubItems.Add(current.ExtraFees.ToString());
                    listViewCredit.Items.Add(item);
                }

            }
            else { MessageBox.Show("NO DATA"); }

        }

        private void FormAccount_Load(object sender, EventArgs e)
        {

        }

        private void listViewSaving_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listViewChecking_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_deleteAccount_Click(object sender, EventArgs e)
        {

        }

        private void btn_addAccount_Click(object sender, EventArgs e)
        {

        }

        private void btn_listAccounts_Click(object sender, EventArgs e)
        {

        }

        private void txb_CreditLimitedAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void txb_CreditExtraFees_TextChanged(object sender, EventArgs e)
        {

        }

        private void lb_CreditExtraFees_Click(object sender, EventArgs e)
        {

        }

        private void lb_CreditLimitedAmount_Click(object sender, EventArgs e)
        {

        }

        private void txb_CreditInterestRate_TextChanged(object sender, EventArgs e)
        {

        }

        private void lb_CreditInterestRate_Click(object sender, EventArgs e)
        {

        }

        private void txb_SavingExtraFees_TextChanged(object sender, EventArgs e)
        {

        }

        private void lb_SavingExtraFees_Click(object sender, EventArgs e)
        {

        }

        private void txb_CheckingExtraFees_TextChanged(object sender, EventArgs e)
        {

        }

        private void lb_CheckingExtraFees_Click(object sender, EventArgs e)
        {

        }

        private void lb_checkingCounterTrans_Click(object sender, EventArgs e)
        {

        }

        private void txb_checkingCounterTrans_TextChanged(object sender, EventArgs e)
        {

        }

        private void txb_checkingLimitedTrans_TextChanged(object sender, EventArgs e)
        {

        }

        private void lb_checkingLimitedTrans_Click(object sender, EventArgs e)
        {

        }

        private void txb_SavingInterestRate_TextChanged(object sender, EventArgs e)
        {

        }

        private void lb_SavingInterestRate_Click(object sender, EventArgs e)
        {

        }

        private void txb_CreditAccountNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void lb_CreditAccountNum_Click(object sender, EventArgs e)
        {

        }

        private void txb_SavingAccountNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void lb_SavingAccountNum_Click(object sender, EventArgs e)
        {

        }

        private void txb_checkingAccountNUm_TextChanged(object sender, EventArgs e)
        {

        }

        private void lb_CheckingAccountNum_Click(object sender, EventArgs e)
        {

        }

        private void chb_credit_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chb_saving_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chb_checking_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txb_balanceid_TextChanged(object sender, EventArgs e)
        {

        }

        private void lb_balance_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txb_year_TextChanged(object sender, EventArgs e)
        {

        }

        private void txb_day_TextChanged(object sender, EventArgs e)
        {

        }

        private void txb_month_TextChanged(object sender, EventArgs e)
        {

        }

        private void lb_openDate_Click(object sender, EventArgs e)
        {

        }

        private void txb_cid_TextChanged(object sender, EventArgs e)
        {

        }

        private void lb_cid_Click(object sender, EventArgs e)
        {

        }

        private void listViewCredit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormAccount_Load_1(object sender, EventArgs e)
        {

        }


        private void btn_addAccount_Click_1(object sender, EventArgs e)
        {
            bool gotCustomer=false;
            Customer cust = new Customer();
            int inputCid=Convert.ToInt32(txb_cid.Text);
            foreach (Customer current in CustomerDB.ReadFromFile().Values)
            {
                if (current.ValidId(inputCid) == true)
                {
                    
                    gotCustomer = true;
                    if (chb_saving.Checked)
                    {
                        cust.AccSaving.CustomerId = Convert.ToInt32(txb_cid.Text);
                        cust.AccSaving.Balance = Convert.ToInt32(txb_balanceid.Text);
                        cust.AccSaving.OpenDate.Month = Convert.ToInt32(txb_month.Text);
                        cust.AccSaving.OpenDate.Day = Convert.ToInt32(txb_day.Text);
                        cust.AccSaving.OpenDate.Year = Convert.ToInt32(txb_year.Text);
                        cust.AccSaving.TypeAccount = EnumAccountType.saving;
                        cust.AccSaving.AccountNum = Convert.ToInt32(txb_SavingAccountNum.Text);
                        cust.AccSaving.InterestRate = Convert.ToDecimal(txb_SavingInterestRate.Text);
                        cust.AccSaving.ExtraFees = Convert.ToDecimal(txb_SavingExtraFees.Text);
                        MessageBox.Show("Successfull add a Saving account to Customer");
                        fortisBank.SavingAccountList.Add(cust.AccSaving.AccountNum, cust.AccSaving);

                        SavingAccountDB.SaveToFile(fortisBank.SavingAccountList);

                    }
                    else if (chb_checking.Checked)
                    {
                        cust.AccChecking.CustomerId = Convert.ToInt32(txb_cid.Text);
                        cust.AccChecking.Balance = Convert.ToInt32(txb_balanceid.Text);
                        cust.AccChecking.OpenDate.Month = Convert.ToInt32(txb_month.Text);
                        cust.AccChecking.OpenDate.Day = Convert.ToInt32(txb_day.Text);
                        cust.AccChecking.OpenDate.Year = Convert.ToInt32(txb_year.Text);
                        cust.AccChecking.TypeAccount = EnumAccountType.checking;
                        cust.AccChecking.AccountNum = Convert.ToInt32(txb_checkingAccountNUm.Text);
                        cust.AccChecking.LimitNum = Convert.ToInt32(txb_checkingLimitedTrans.Text);
                        cust.AccChecking.CountTrans = Convert.ToInt32(txb_checkingCounterTrans.Text);
                        cust.AccChecking.ExtraFees = Convert.ToDecimal(txb_CheckingExtraFees.Text);
                        MessageBox.Show("Successfull add a Checkig account to Customer");
                        fortisBank.CheckingAccountList.Add(cust.AccChecking.AccountNum, cust.AccChecking);

                        CheckingAccountDB.SaveToFile(fortisBank.CheckingAccountList);
                    }
                    else if (chb_credit.Checked)
                    {
                        cust.AccCredit.CustomerId = Convert.ToInt32(txb_cid.Text);
                        cust.AccCredit.Balance = Convert.ToInt32(txb_balanceid.Text);
                        cust.AccCredit.OpenDate.Month = Convert.ToInt32(txb_month.Text);
                        cust.AccCredit.OpenDate.Day = Convert.ToInt32(txb_day.Text);
                        cust.AccCredit.OpenDate.Year = Convert.ToInt32(txb_year.Text);
                        cust.AccCredit.TypeAccount = EnumAccountType.credit;
                        cust.AccCredit.AccountNum = Convert.ToInt32(txb_CreditAccountNum.Text);
                        cust.AccCredit.InterestRate = Convert.ToDecimal(txb_CreditInterestRate.Text);
                        cust.AccCredit.LimitAmount = Convert.ToInt32(txb_CreditLimitedAmount.Text);
                        cust.AccCredit.ExtraFees = Convert.ToDecimal(txb_CreditExtraFees.Text);
                        MessageBox.Show("Successfull add a Credit account to Customer");
                        fortisBank.CreditAccountList.Add(cust.AccCredit.AccountNum, cust.AccCredit);

                        CreditAccountDB.SaveToFile(fortisBank.CreditAccountList);

                    }
                    else
                    {
                        MessageBox.Show("Account was not added successfully");
                    }
                }
            }

            if (gotCustomer == false)
            {
                MessageBox.Show("This customer doesn't exist! ");
            }



        }
        private void Reset()
        {
            foreach (Control guiControl in Controls)
            {
                if (guiControl is TextBox)
                {
                    ((TextBox)guiControl).Clear();
                }

                if (guiControl is ListView)
                {
                    ((ListView)guiControl).Items.Clear();
                }
            }
            txb_cid.Focus();
        }
        public bool ifDelete()
        {
            string res;
            res = Convert.ToString(MessageBox.Show("Do you want to delete this account?", "Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
            if (res == "Yes")
            {
                return true;
            }
            return false;
        }

        private void btn_deleteAccount_Click_1(object sender, EventArgs e)
        {
            Customer cust = new Customer();
            if (listViewSaving.SelectedItems.Count > 0)
            {
                if (ifDelete())
                {
                    cust.AccSaving.AccountNum = Convert.ToInt32(listViewSaving.SelectedItems[0].SubItems[3].Text);
                    fortisBank.SavingAccountList.Remove(cust.AccSaving.AccountNum);
                    SavingAccountDB.SaveToFile(fortisBank.SavingAccountList);
                    MessageBox.Show("Account has been removed");
                    fortisBank.SavingAccountList = SavingAccountDB.ReadFromFile();
                    Reset();
                    listAllCheckingAccount(fortisBank.CheckingAccountList);
                    listAllSavingAccount(fortisBank.SavingAccountList);
                    listAllCreditAccount(fortisBank.CreditAccountList);
                }
            }

            else if (listViewChecking.SelectedItems.Count > 0)
            {
                if (ifDelete())
                {
                    cust.AccChecking.AccountNum = Convert.ToInt32(listViewChecking.SelectedItems[0].SubItems[3].Text);
                    fortisBank.CheckingAccountList.Remove(cust.AccChecking.AccountNum);
                    CheckingAccountDB.SaveToFile(fortisBank.CheckingAccountList);
                    MessageBox.Show("Account has been removed");
                    fortisBank.CheckingAccountList = CheckingAccountDB.ReadFromFile();
                    Reset();
                    listAllCheckingAccount(fortisBank.CheckingAccountList);
                    listAllSavingAccount(fortisBank.SavingAccountList);
                    listAllCreditAccount(fortisBank.CreditAccountList);

                }

            }
            else if (listViewCredit.SelectedItems.Count > 0)
            {
                if (ifDelete())
                {
                cust.AccCredit.AccountNum = Convert.ToInt32(listViewCredit.SelectedItems[0].SubItems[3].Text);

                fortisBank.CreditAccountList.Remove(cust.AccCredit.AccountNum);
                CreditAccountDB.SaveToFile(fortisBank.CreditAccountList);
                MessageBox.Show("Account has been removed");
                fortisBank.CreditAccountList = CreditAccountDB.ReadFromFile();
                Reset();
                listAllCheckingAccount(fortisBank.CheckingAccountList);
                listAllSavingAccount(fortisBank.SavingAccountList);
                listAllCreditAccount(fortisBank.CreditAccountList);
                }


            }
        }

        private void btn_listAccounts_Click_1(object sender, EventArgs e)
        {
            if (chb_checking.Checked)
            {
                
                listViewChecking.Visible = true;
                if (File.Exists(checkingfilePath))
                {
                    MessageBox.Show("CheckingAccount path exists");
                    fortisBank.CheckingAccountList = CheckingAccountDB.ReadFromFile();
                    listAllCheckingAccount(fortisBank.CheckingAccountList);
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("File CheckingAccount was not found", "INFO");
                }
            }
            else if (chb_saving.Checked)
            {
               
                listViewSaving.Visible = true;
                if (File.Exists(savingfilePath))
                {
                    MessageBox.Show("SavingAccount path exists");
                    fortisBank.SavingAccountList = SavingAccountDB.ReadFromFile();
                    listAllSavingAccount(fortisBank.SavingAccountList);

                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("File SavingAccount was not found", "INFO");
                }

            }
            else if (chb_credit.Checked)
            {
                
                listViewCredit.Visible = true;
                if (File.Exists(creditfilePath))
                {
                    MessageBox.Show("CreditAccount path exists");
                    fortisBank.CreditAccountList = CreditAccountDB.ReadFromFile();
                    listAllCreditAccount(fortisBank.CreditAccountList);

                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("File SavingAccount was not found", "INFO");
                }
            }


        }

        private void chb_checking_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chb_checking.Checked)
            {
                chb_saving.Checked =false;
                chb_credit.Checked = false;

            }

        }

        private void chb_saving_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chb_saving.Checked)
            {
                chb_checking.Checked = false;
                chb_credit.Checked = false;

            }

        }

        private void chb_credit_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chb_credit.Checked)
            {
                chb_checking.Checked = false;
                chb_saving.Checked = false;

            }

        }

        private void listViewSaving_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void listViewChecking_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
