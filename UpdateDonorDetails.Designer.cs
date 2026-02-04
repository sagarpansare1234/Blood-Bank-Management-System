
namespace bbms
{
    partial class UpdateDonorDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateDonorDetails));
            label1 = new Label();
            label2 = new Label();
            txtDonorID = new TextBox();
            btnSearch = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtDOB = new DateTimePicker();
            txtName = new TextBox();
            txtFather = new TextBox();
            txtSurname = new TextBox();
            txtMobile = new TextBox();
            txtEmail = new TextBox();
            txtCity = new TextBox();
            txtBloodGroup = new ComboBox();
            txtAddress = new RichTextBox();
            txtGender = new ComboBox();
            btnUpdate = new Button();
            btnReset = new Button();
            btnClose = new Button();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label13 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Mangal", 22.2F, FontStyle.Bold | FontStyle.Underline);
            label1.Location = new Point(287, 9);
            label1.Name = "label1";
            label1.Size = new Size(533, 66);
            label1.TabIndex = 0;
            label1.Text = "UPDATE DONOR DETAILS";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            label2.Location = new Point(337, 112);
            label2.Name = "label2";
            label2.Size = new Size(107, 22);
            label2.TabIndex = 1;
            label2.Text = "Donor ID : ";
            // 
            // txtDonorID
            // 
            txtDonorID.Location = new Point(444, 109);
            txtDonorID.Name = "txtDonorID";
            txtDonorID.Size = new Size(178, 27);
            txtDonorID.TabIndex = 2;
            txtDonorID.TextChanged += txtDonorID_TextChanged;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Silver;
            btnSearch.FlatStyle = FlatStyle.Popup;
            btnSearch.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            btnSearch.Image = (Image)resources.GetObject("btnSearch.Image");
            btnSearch.ImageAlign = ContentAlignment.MiddleLeft;
            btnSearch.Location = new Point(656, 101);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(101, 49);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.TextAlign = ContentAlignment.MiddleRight;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoEllipsis = true;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            label3.Location = new Point(53, 190);
            label3.Name = "label3";
            label3.Size = new Size(61, 22);
            label3.TabIndex = 4;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.AutoEllipsis = true;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            label4.Location = new Point(53, 268);
            label4.Name = "label4";
            label4.Size = new Size(125, 22);
            label4.TabIndex = 5;
            label4.Text = "Father Name";
            // 
            // label5
            // 
            label5.AutoEllipsis = true;
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            label5.Location = new Point(53, 347);
            label5.Name = "label5";
            label5.Size = new Size(89, 22);
            label5.TabIndex = 6;
            label5.Text = "Surname";
            // 
            // label6
            // 
            label6.AutoEllipsis = true;
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            label6.Location = new Point(53, 422);
            label6.Name = "label6";
            label6.Size = new Size(127, 22);
            label6.TabIndex = 7;
            label6.Text = "Date Of Birth";
            // 
            // label7
            // 
            label7.AutoEllipsis = true;
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            label7.Location = new Point(53, 490);
            label7.Name = "label7";
            label7.Size = new Size(143, 22);
            label7.TabIndex = 8;
            label7.Text = "Mobile Number";
            // 
            // label8
            // 
            label8.AutoEllipsis = true;
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            label8.Location = new Point(53, 555);
            label8.Name = "label8";
            label8.Size = new Size(76, 22);
            label8.TabIndex = 9;
            label8.Text = "Gender";
            // 
            // txtDOB
            // 
            txtDOB.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            txtDOB.Format = DateTimePickerFormat.Short;
            txtDOB.Location = new Point(203, 423);
            txtDOB.Name = "txtDOB";
            txtDOB.Size = new Size(328, 28);
            txtDOB.TabIndex = 14;
            // 
            // txtName
            // 
            txtName.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            txtName.Location = new Point(203, 187);
            txtName.Name = "txtName";
            txtName.Size = new Size(328, 28);
            txtName.TabIndex = 15;
            // 
            // txtFather
            // 
            txtFather.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            txtFather.Location = new Point(203, 265);
            txtFather.Name = "txtFather";
            txtFather.Size = new Size(328, 28);
            txtFather.TabIndex = 16;
            // 
            // txtSurname
            // 
            txtSurname.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            txtSurname.Location = new Point(203, 347);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(328, 28);
            txtSurname.TabIndex = 17;
            txtSurname.TextChanged += txtSurname_TextChanged;
            // 
            // txtMobile
            // 
            txtMobile.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            txtMobile.Location = new Point(203, 487);
            txtMobile.Name = "txtMobile";
            txtMobile.Size = new Size(328, 28);
            txtMobile.TabIndex = 18;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            txtEmail.Location = new Point(787, 187);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(304, 28);
            txtEmail.TabIndex = 20;
            // 
            // txtCity
            // 
            txtCity.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            txtCity.Location = new Point(787, 344);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(304, 28);
            txtCity.TabIndex = 22;
            // 
            // txtBloodGroup
            // 
            txtBloodGroup.DropDownStyle = ComboBoxStyle.DropDownList;
            txtBloodGroup.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            txtBloodGroup.FormattingEnabled = true;
            txtBloodGroup.Items.AddRange(new object[] { "A+", "B+", "AB+", "O+", "O-", "AB-", "A-", "B-" });
            txtBloodGroup.Location = new Point(787, 260);
            txtBloodGroup.Name = "txtBloodGroup";
            txtBloodGroup.Size = new Size(304, 30);
            txtBloodGroup.TabIndex = 24;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            txtAddress.Location = new Point(787, 419);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(304, 158);
            txtAddress.TabIndex = 25;
            txtAddress.Text = "";
            // 
            // txtGender
            // 
            txtGender.DropDownStyle = ComboBoxStyle.DropDownList;
            txtGender.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            txtGender.FormattingEnabled = true;
            txtGender.Items.AddRange(new object[] { "Male", "Female", "Others" });
            txtGender.Location = new Point(203, 547);
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(328, 30);
            txtGender.TabIndex = 29;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Silver;
            btnUpdate.FlatStyle = FlatStyle.Popup;
            btnUpdate.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            btnUpdate.Image = (Image)resources.GetObject("btnUpdate.Image");
            btnUpdate.ImageAlign = ContentAlignment.MiddleLeft;
            btnUpdate.Location = new Point(173, 630);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(109, 56);
            btnUpdate.TabIndex = 30;
            btnUpdate.Text = "Update";
            btnUpdate.TextAlign = ContentAlignment.MiddleRight;
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.Silver;
            btnReset.FlatStyle = FlatStyle.Popup;
            btnReset.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            btnReset.Image = (Image)resources.GetObject("btnReset.Image");
            btnReset.ImageAlign = ContentAlignment.MiddleLeft;
            btnReset.Location = new Point(517, 630);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(96, 56);
            btnReset.TabIndex = 31;
            btnReset.Text = "Reset";
            btnReset.TextAlign = ContentAlignment.MiddleRight;
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Silver;
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(858, 630);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 56);
            btnClose.TabIndex = 32;
            btnClose.Text = "Close";
            btnClose.TextAlign = ContentAlignment.MiddleRight;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += button4_Click_1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.FlatStyle = FlatStyle.Popup;
            label9.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            label9.ForeColor = SystemColors.ControlText;
            label9.Location = new Point(635, 193);
            label9.Name = "label9";
            label9.Size = new Size(66, 22);
            label9.TabIndex = 33;
            label9.Text = "E-mail";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            label10.ForeColor = SystemColors.ControlText;
            label10.Location = new Point(635, 268);
            label10.Name = "label10";
            label10.Size = new Size(122, 22);
            label10.TabIndex = 34;
            label10.Text = "Blood Group";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            label11.ForeColor = SystemColors.ControlText;
            label11.Location = new Point(635, 347);
            label11.Name = "label11";
            label11.Size = new Size(45, 22);
            label11.TabIndex = 35;
            label11.Text = "City";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            label13.ForeColor = SystemColors.ControlText;
            label13.Location = new Point(635, 419);
            label13.Name = "label13";
            label13.Size = new Size(83, 22);
            label13.TabIndex = 36;
            label13.Text = "Address";
            label13.Click += label13_Click;
            // 
            // UpdateDonorDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1117, 723);
            Controls.Add(label13);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(btnClose);
            Controls.Add(btnReset);
            Controls.Add(btnUpdate);
            Controls.Add(txtGender);
            Controls.Add(txtAddress);
            Controls.Add(txtBloodGroup);
            Controls.Add(txtCity);
            Controls.Add(txtEmail);
            Controls.Add(txtMobile);
            Controls.Add(txtSurname);
            Controls.Add(txtFather);
            Controls.Add(txtName);
            Controls.Add(txtDOB);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnSearch);
            Controls.Add(txtDonorID);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UpdateDonorDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UpdateDonorDetails";
            Load += UpdateDonorDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtDonorID;
        private Button btnSearch;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private DateTimePicker txtDOB;
        private TextBox txtName;
        private TextBox txtFather;
        private TextBox txtMother;
        private TextBox txtMobile;
        private TextBox txtEmail;
        private TextBox txtCity;
        private ComboBox txtBloodGroup;
        private RichTextBox txtAddress;
        private ComboBox txtGender;
        private Button btnUpdate;
        private Button btnReset;
        private Button btnClose;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label13;
        private TextBox txtSurname;
    }
}