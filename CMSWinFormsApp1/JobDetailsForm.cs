using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMSWinFormsApp1
{
    public partial class JobDetailsForm : Form
    {
        public JobDetailsForm()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textCarNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void JobDetailsForm_Leave(object sender, EventArgs e)
        {
             
        }

        private void textCarNo_Leave(object sender, EventArgs e)
        {
            if((textCarNo.Text =="")||(textCarNo.Text ==null  ))
            {
                MessageBox.Show("Please Specify a Valid Car Number");
                textCarNo.Focus();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (textCarNo.Text.Length < 6)
                {
                    MessageBox.Show("Please Specify a Valid Car Number ");
                    textCarNo.Focus();
                    return;
                }
                if (Convert.ToInt32(textWorkerID.Text) < 1)
                {
                    MessageBox.Show("Please Specify a Valid Worker ID ");
                    textWorkerID.Focus();
                    return;
                }
                if (Convert.ToDateTime(dateTimePicker1.Text) > DateTime.Today)
                {
                    MessageBox.Show("Please Specify a Valid Date ");
                    dateTimePicker1.Focus();
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
