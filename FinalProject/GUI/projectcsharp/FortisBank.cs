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
    public partial class FromFortisInternationalBank : Form
    {

        

        public FromFortisInternationalBank()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {


        }

        private void buttonCustomer_Click(object sender, EventArgs e)
        {
            FormLogIn loginCus = new FormLogIn();
            loginCus.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonManager_Click(object sender, EventArgs e)
        {
            ManagerAccountCustomer managerPage = new ManagerAccountCustomer();
            managerPage.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FromFortisInternationalBank_Load(object sender, EventArgs e)
        {

        }
    }
}
