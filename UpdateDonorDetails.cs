using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bbms
{
    public partial class UpdateDonorDetails : Form
    {
        function fn = new function();
        public UpdateDonorDetails()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtDonorID.Text.ToString());
            String query = "select * from newDonor where did = " + id + "";
            DataSet ds = fn.getData(query);
            int i = 2;

            if (ds.Tables[0].Rows.Count != 0)
            {
                txtName.Text = ds.Tables[0].Rows[0][1].ToString();
                txtFather.Text = ds.Tables[0].Rows[0][2].ToString();
                txtSurname.Text = ds.Tables[0].Rows[0][3].ToString();
                txtDOB.Text = ds.Tables[0].Rows[0][4].ToString();
                txtMobile.Text = ds.Tables[0].Rows[0][5].ToString();
                txtGender.Text = ds.Tables[0].Rows[0][6].ToString();
                txtEmail.Text = ds.Tables[0].Rows[0][7].ToString();
                txtBloodGroup.Text = ds.Tables[0].Rows[0][8].ToString();
                txtCity.Text = ds.Tables[0].Rows[0][9].ToString();
                txtAddress.Text = ds.Tables[0].Rows[0][10].ToString();
            }
            else
            {
                MessageBox.Show("The Donor ID you have Provided is Invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Close();
            //close button
        }

        private void txtDonorID_TextChanged(object sender, EventArgs e)
        {
            if (txtDonorID.Text == "")
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
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtDonorID.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)  //UPDATION QUERY
        {

            if (txtName.Text == "" && txtFather.Text == "" && txtSurname.Text == "" && txtMobile.Text == "" && txtGender.Text == "" && txtEmail.Text == "" && txtBloodGroup.Text == "" && txtCity.Text == "" && txtAddress.Text == "")
            {
                MessageBox.Show("Please Fill all the Fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtMobile.Text == "")
            {
                MessageBox.Show("Please Fill the mobile number field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!Regex.IsMatch(txtMobile.Text, @"^\d{10}$"))
            {
                MessageBox.Show("Please enter a valid phone number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Please enter a valid surname name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (txtEmail.Text == "")
            {
                MessageBox.Show("Please Fill the email's field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!Regex.IsMatch(txtEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Please enter a valid email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (txtGender.Text == "")
            {
                MessageBox.Show("Please Fill the Gender's field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (txtBloodGroup.Text == "")
            {
                MessageBox.Show("Please Fill the BloodGroup field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (txtCity.Text == "")
            {
                MessageBox.Show("Please Fill the city field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (txtAddress.Text == "")
            {
                MessageBox.Show("Please Fill the Address field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                String query = "update newDonor set dname ='" + txtName.Text + "',fname='" + txtFather.Text + "',mname='" + txtSurname.Text + "',dob='" + txtDOB.Text + "',mobile=" + txtMobile.Text + ",gender='" + txtGender.Text + "',email='" + txtEmail.Text + "',bloodgroup='" + txtBloodGroup.Text + "',city='" + txtCity.Text + "',daddress='" + txtAddress.Text + "'  where did =" + txtDonorID.Text + "";
                fn.setData(query);
                UpdateDonorDetails_Load(this, null);
            }

        }

        private void UpdateDonorDetails_Load(object sender, EventArgs e) //when the form will reload donorid will be cleared as i have written in my logic once donorid is been every text feild should cleared.
        {
            txtDonorID.Clear();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
