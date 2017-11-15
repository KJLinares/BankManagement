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
    public partial class FormLogIn : Form
    {
        private Bank fortisBank = new Bank(SavingAccountDB.ReadFromFile(), CheckingAccountDB.ReadFromFile(), CreditAccountDB.ReadFromFile(), CustomerDB.ReadFromFile());
        
        public FormLogIn( )
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string res;
            res = Convert.ToString(MessageBox.Show("Do you want to exit?", "Exit?", MessageBoxButtons.OKCancel,MessageBoxIcon.Question));
            if (res == "OK")
            {
                this.Close();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FormLogIn_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            try
            {
            int inputID = Convert.ToInt16(textBoxUserID.Text);
            int inputPin = Convert.ToInt16(textBoxPassword.Text);

            Customer cust = new Customer();

           
                foreach (Customer current in fortisBank.CustomerList.Values)
                {
                    if (current.CustomerId == inputID)
                    {
                        cust = current;
                    }
                }
                if (cust.ValidPin(inputPin) == true )
            {
                FormTransaction depoWithd = new FormTransaction(cust);
                depoWithd.Show();
            }
            else
            {
                MessageBox.Show("Incorrect User or Pin");
            }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Username and Password don't match."+"\n"+ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            
        }
    }
}
