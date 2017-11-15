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
            FormLogIn loginMan = new FormLogIn();
            loginMan.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
