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
    public partial class CustomerInfo : Form
    {

        String filePath = CustomerDB.filePath;

        Dictionary<int, Customer> dictCustomer = new Dictionary<int, Customer>();

        public CustomerInfo()
        {
            InitializeComponent();
        }

        private void btn_AddCustomer_Click(object sender, EventArgs e)
        {

            Customer aCustomer;


            aCustomer = new Customer(Convert.ToInt32(txb_cid.Text), txb_fn.Text, txb_ln.Text, Convert.ToInt32(txb_pin.Text), txb_email.Text, txb_phonenum.Text, txb_address.Text);

            dictCustomer.Add(aCustomer.CustomerId, aCustomer);
            CustomerDB.SaveToFile(dictCustomer);
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

        private void btn_AddAccount_Click(object sender, EventArgs e)
        {

        }

        private void btn_removeCustomer_Click(object sender, EventArgs e)
        {
            int currId = Convert.ToInt32(txb_cid.Text);
            String fName = txb_fn.Text;
            String lName = txb_ln.Text;
            int pin = Convert.ToInt32(txb_pin.Text);
            String email = txb_email.Text;
            String phoneNumber = txb_phonenum.Text;
            String address = txb_address.Text;
            Customer newCustomer = new Customer(currId, fName, lName, pin, email, phoneNumber, address);


            dictCustomer.Remove(currId);
            CustomerDB.SaveToFile(dictCustomer);
            MessageBox.Show("Customer has been removed");
            Reset();
        }

        public void listAllCustomer(Dictionary<int, Customer> dictCust)
        {
            ListViewCustomer.Items.Clear();


            if (dictCust != null)
            {
                foreach (Customer current in dictCust.Values)
                {
                    ListViewItem item = new ListViewItem(current.CustomerId.ToString());
                    item.SubItems.Add(current.C_first);
                    item.SubItems.Add(current.C_last);
                    item.SubItems.Add(current.Pin.ToString());
                    item.SubItems.Add(current.Email);
                    item.SubItems.Add(current.PhoneNumber);
                    item.SubItems.Add(current.Address);

                    ListViewCustomer.Items.Add(item);
                }
            }
            else { MessageBox.Show("NO DATA"); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListViewCustomer.Visible = true;

            if (File.Exists(filePath))
            {
                MessageBox.Show("Customer path exists");

                dictCustomer = CustomerDB.ReadFromFile();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("File Customer was not found", "INFO");
            }

            listAllCustomer(dictCustomer);
        }

        private void ListViewCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListViewCustomer.SelectedIndices.Count > 0)
            {
                this.txb_cid.Text = ListViewCustomer.SelectedItems[0].SubItems[0].Text;
                this.txb_fn.Text = ListViewCustomer.SelectedItems[0].SubItems[1].Text;
                this.txb_ln.Text = ListViewCustomer.SelectedItems[0].SubItems[2].Text;
                this.txb_pin.Text = ListViewCustomer.SelectedItems[0].SubItems[3].Text;
                this.txb_email.Text = ListViewCustomer.SelectedItems[0].SubItems[4].Text;
                this.txb_phonenum.Text = ListViewCustomer.SelectedItems[0].SubItems[5].Text;
                this.txb_address.Text = ListViewCustomer.SelectedItems[0].SubItems[6].Text;


            }
        }

        private void ManagerMainPage_Load(object sender, EventArgs e)
        {

        }

        private void txb_ln_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
