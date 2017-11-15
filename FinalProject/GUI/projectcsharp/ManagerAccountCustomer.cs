using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectcsharp
{
    public partial class ManagerAccountCustomer : Form
    {
        public ManagerAccountCustomer()
        {
            InitializeComponent();
        }

        private void ManagerAccountCustomer_Load(object sender, EventArgs e)
        {

        }

        private void btn_CustomerInfo_Click(object sender, EventArgs e)
        {
            CustomerInfo custInfo = new CustomerInfo();
            custInfo.Show();
        }

        private void btn_AccountInfo_Click(object sender, EventArgs e)
        {
            FormAccount accountInfo = new FormAccount();
            accountInfo.Show();
        }
    }
}
