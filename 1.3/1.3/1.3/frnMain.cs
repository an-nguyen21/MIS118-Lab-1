using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1._3
{
    public partial class frnMain : Form
    {
        public frnMain()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string strname = txtName.Text;

            //Concatenates strname and a string to display a message
            lblMessage.Text = "Hello World my name is: " + txtName.Text;
        }
    }
}
