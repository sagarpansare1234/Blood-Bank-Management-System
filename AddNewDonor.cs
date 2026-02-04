using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using Microsoft.Office.Interop.Excel;

namespace bbms
{
    public partial class AddNewDonor : Form
    {
        function fn = new function();
        public AddNewDonor()
        {
            InitializeComponent();
        }

        private void AddNewDonor_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddNewDonor_Load_1(object sender, EventArgs e)
        {
            String query = "select max(did) from newDonor";
            DataSet ds = fn.getData(query);
            int count = int.Parse(ds.Tables[0].Rows[0][0].ToString());
            labelNewID.Text = (count + 1).ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelNewID_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (txtName.Text == "" && txtFather.Text == "" && txtSurname.Text == "" && txtMobile.Text == "" && txtGender.Text == "" && txtEmail.Text == "" && txtBloodGroup.Text == "" && txtCity.Text == "" && txtAddress.Text == "")
            {
                MessageBox.Show("Please Fill all the Fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (txtName.Text == "")
            {
                MessageBox.Show("Please Fill the name field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!Regex.IsMatch(txtName.Text, @"^[A-Za-z ]+$"))
            {
                MessageBox.Show("Please enter a valid name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //father
            else if (txtFather.Text == "")
            {
                MessageBox.Show("Please Fill the Father's name field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!Regex.IsMatch(txtFather.Text, @"^[A-Za-z ]+$"))
            {
                MessageBox.Show("Please enter a valid Father's name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //mother
            else if (txtSurname.Text == "")
            {
                MessageBox.Show("Please Fill the surname's field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!Regex.IsMatch(txtSurname.Text, @"^[A-Za-z ]+$"))
            {
                MessageBox.Show("Please enter a valid surname.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtMobile.Text == "")
            {
                MessageBox.Show("Please Fill the mobile number field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!Regex.IsMatch(txtMobile.Text, @"^\d{10}$"))
            {
                MessageBox.Show("Please enter a valid phone number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //gender
            else if (txtGender.Text == "")
            {
                MessageBox.Show("Please Fill the Gender's field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //email
            else if (txtEmail.Text == "")
            {
                MessageBox.Show("Please Fill the email's field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!Regex.IsMatch(txtEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Please enter a valid email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //bloodgroup
            else if (txtBloodGroup.Text == "")
            {
                MessageBox.Show("Please Fill the BloodGroup field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //city
            else if (txtCity.Text == "")
            {
                MessageBox.Show("Please Fill the city field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //adddress
            else if (txtAddress.Text == "")
            {
                MessageBox.Show("Please Fill the Address field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //data entry
            else
            {
                String dname = txtName.Text;
                String fname = txtFather.Text;
                String mname = txtSurname.Text;
                String dob = txtDOB.Text;
                Int64 mobile = Int64.Parse(txtMobile.Text);
                String gender = txtGender.Text;
                String email = txtEmail.Text;
                String bgroup = txtBloodGroup.Text;
                String city = txtCity.Text;
                String address = txtAddress.Text;

                String query = "insert into newDonor (dname,fname,mname,dob,mobile,gender,email,bloodgroup,city,daddress) values ('" + dname + "','" + fname + "','" + mname + "','" + dob + "'," + mobile + ",'" + gender + "','" + email + "','" + bgroup + "','" + city + "','" + address + "')";
                fn.setData(query);
            }



        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtFather.Clear();
            txtSurname.Clear();
            txtDOB.ResetText();
            txtMobile.Clear();
            txtGender.ResetText();
            txtEmail.Clear();
            txtBloodGroup.ResetText();
            txtCity.Clear();
            txtAddress.Clear();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
