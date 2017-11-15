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
    public partial class FormAccount : Form
    {
        public FormAccount()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string res;
            res = Convert.ToString(MessageBox.Show("Do you want to exit?", "Exit?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question));
            if (res == "OK")
            {
                this.Close();
            }
        }
    }
}
