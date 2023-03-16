using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMSWinFormsApp1
{
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private  void CustomForm_Load(object sender,EventArgs e)
        {
            errorCustForm.SetError(textBox1, "");
            errorCustForm.SetError(textBox2, "");
            errorCustForm.SetError(textBox3, "");
            errorCustForm.SetError(textBox4, "");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool flag;
            flag = true;
            if (textBox1.Text == "")
            {
                errorCustForm.SetError(textBox1, "Please Specify a Valid Car Number");
                flag = false;
            }
            else
                errorCustForm.SetError(textBox1, "");
            if(textBox2 .Text =="")
            {
                errorCustForm.SetError(textBox2, "Please Specify a Valid Name");
                flag = false;
            }
            else
                errorCustForm.SetError(textBox2, "");
            if (textBox3.Text == "")
            {
                errorCustForm.SetError(textBox3, "Please Specify a Valid Address");
                flag = false;
            }
            else
                errorCustForm.SetError(textBox3, "");
            if (textBox4.Text == "")
            {
                errorCustForm.SetError(textBox4, "Please Specify a Valid Make");
                flag = false;
            }
            else
                errorCustForm.SetError(textBox4, "");
            if(false==false)
            {
                return;
            }
            else
            {
               
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
