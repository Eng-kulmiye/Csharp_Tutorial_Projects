using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_01___Personal_Information
{
    public partial class PersonalInfo : Form
    {
        public PersonalInfo()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFirstName.Text == "" || txtLastName.Text == "" || txtMonth.Text == ""
                    || txtDay.Text == "" || txtYear.Text == "")
                {
                    MessageBox.Show("Please fill the Blanks");
                }

                else
                {
                    lblFullName.Text = txtFirstName.Text + " " + txtLastName.Text;
                    lblDateOfBirth.Text = txtMonth.Text + " " + int.Parse(txtDay.Text) + ", " + int.Parse(txtYear.Text);
                    MessageBox.Show("Your Data has been Saved in the Output Section");
                    clear();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void clear()
        {
            txtFirstName.Text = " ";
            txtLastName.Text = " ";
            txtDay.Text = " ";
            txtMonth.Text = " ";
            txtYear.Text = " ";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtFirstName.Text = " ";
            txtLastName.Text = " ";

            txtDay.Text = " ";
            txtMonth.Text = " ";
            txtYear.Text = " ";
            lblFullName.Text = " ";
            lblDateOfBirth.Text = " ";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
