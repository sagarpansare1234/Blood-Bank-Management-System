namespace bbms
{
    partial class DeleteDonor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteDonor));
            label1 = new Label();
            btnSearch = new Button();
            txtDonorID = new TextBox();
            label2 = new Label();
            txtGender = new ComboBox();
            txtMobile = new TextBox();
            txtSurname = new TextBox();
            txtFather = new TextBox();
            txtName = new TextBox();
            txtDOB = new DateTimePicker();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtAddress = new RichTextBox();
            txtBloodGroup = new ComboBox();
            txtCity = new TextBox();
            txtEmail = new TextBox();
            btnClose = new Button();
            btnReset = new Button();
            btnDelete = new Button();
            txtmail = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Mangal", 22.2F, FontStyle.Bold | FontStyle.Underline);
            label1.Location = new Point(403, 9);
            label1.Name = "label1";
            label1.Size = new Size(345, 66);
            label1.TabIndex = 0;
            label1.Text = "DELETE DONOR";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Transparent;
            btnSearch.FlatStyle = FlatStyle.Popup;
            btnSearch.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            btnSearch.Image = (Image)resources.GetObject("btnSearch.Image");
            btnSearch.ImageAlign = ContentAlignment.MiddleLeft;
            btnSearch.Location = new Point(647, 89);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(101, 46);
            btnSearch.TabIndex = 6;
            btnSearch.Text = "Search";
            btnSearch.TextAlign = ContentAlignment.MiddleRight;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtDonorID
            // 
            txtDonorID.Location = new Point(467, 100);
            txtDonorID.Name = "txtDonorID";
            txtDonorID.Size = new Size(160, 27);
            txtDonorID.TabIndex = 5;
            txtDonorID.TextChanged += txtDonorID_TextChanged;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            label2.Location = new Point(334, 100);
            label2.Name = "label2";
            label2.Size = new Size(107, 27);
            label2.TabIndex = 4;
            label2.Text = "Donor ID : ";
            // 
            // txtGender
            // 
            txtGender.DropDownStyle = ComboBoxStyle.DropDownList;
            txtGender.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            txtGender.FormattingEnabled = true;
            txtGender.Items.AddRange(new object[] { "Male", "Female", "Others" });
            txtGender.Location = new Point(192, 556);
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(328, 30);
            txtGender.TabIndex = 41;
            // 
            // txtMobile
            // 
            txtMobile.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            txtMobile.Location = new Point(192, 496);
            txtMobile.Name = "txtMobile";
            txtMobile.Size = new Size(328, 28);
            txtMobile.TabIndex = 40;
            // 
            // txtSurname
            // 
            txtSurname.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            txtSurname.Location = new Point(192, 356);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(328, 28);
            txtSurname.TabIndex = 39;
            // 
            // txtFather
            // 
            txtFather.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            txtFather.Location = new Point(192, 274);
            txtFather.Name = "txtFather";
            txtFather.Size = new Size(328, 28);
            txtFather.TabIndex = 38;
            // 
            // txtName
            // 
            txtName.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            txtName.Location = new Point(192, 196);
            txtName.Name = "txtName";
            txtName.Size = new Size(328, 28);
            txtName.TabIndex = 37;
            // 
            // txtDOB
            // 
            txtDOB.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            txtDOB.Format = DateTimePickerFormat.Short;
            txtDOB.Location = new Point(192, 432);
            txtDOB.Name = "txtDOB";
            txtDOB.Size = new Size(328, 28);
            txtDOB.TabIndex = 36;
            // 
            // label8
            // 
            label8.AutoEllipsis = true;
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            label8.Location = new Point(42, 564);
            label8.Name = "label8";
            label8.Size = new Size(76, 22);
            label8.TabIndex = 35;
            label8.Text = "Gender";
            // 
            // label7
            // 
            label7.AutoEllipsis = true;
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            label7.Location = new Point(42, 499);
            label7.Name = "label7";
            label7.Size = new Size(143, 22);
            label7.TabIndex = 34;
            label7.Text = "Mobile Number";
            // 
            // label6
            // 
            label6.AutoEllipsis = true;
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            label6.Location = new Point(42, 431);
            label6.Name = "label6";
            label6.Size = new Size(127, 22);
            label6.TabIndex = 33;
            label6.Text = "Date Of Birth";
            // 
            // label5
            // 
            label5.AutoEllipsis = true;
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            label5.Location = new Point(42, 356);
            label5.Name = "label5";
            label5.Size = new Size(89, 22);
            label5.TabIndex = 32;
            label5.Text = "Surname";
            // 
            // label4
            // 
            label4.AutoEllipsis = true;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            label4.Location = new Point(42, 277);
            label4.Name = "label4";
            label4.Size = new Size(125, 22);
            label4.TabIndex = 31;
            label4.Text = "Father Name";
            // 
            // label3
            // 
            label3.AutoEllipsis = true;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            label3.Location = new Point(42, 199);
            label3.Name = "label3";
            label3.Size = new Size(61, 22);
            label3.TabIndex = 30;
            label3.Text = "Name";
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            txtAddress.Location = new Point(773, 429);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(304, 158);
            txtAddress.TabIndex = 49;
            txtAddress.Text = "";
            // 
            // txtBloodGroup
            // 
            txtBloodGroup.DropDownStyle = ComboBoxStyle.DropDownList;
            txtBloodGroup.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            txtBloodGroup.FormattingEnabled = true;
            txtBloodGroup.Items.AddRange(new object[] { "A+", "B+", "AB+", "O+", "O-", "AB-", "A-", "B-" });
            txtBloodGroup.Location = new Point(773, 270);
            txtBloodGroup.Name = "txtBloodGroup";
            txtBloodGroup.Size = new Size(304, 30);
            txtBloodGroup.TabIndex = 48;
            // 
            // txtCity
            // 
            txtCity.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            txtCity.Location = new Point(773, 354);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(304, 28);
            txtCity.TabIndex = 47;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            txtEmail.Location = new Point(773, 197);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(304, 28);
            txtEmail.TabIndex = 46;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Transparent;
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(861, 667);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 36);
            btnClose.TabIndex = 51;
            btnClose.Text = "Close";
            btnClose.TextAlign = ContentAlignment.MiddleRight;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.Transparent;
            btnReset.FlatStyle = FlatStyle.Popup;
            btnReset.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            btnReset.Image = (Image)resources.GetObject("btnReset.Image");
            btnReset.ImageAlign = ContentAlignment.MiddleLeft;
            btnReset.Location = new Point(520, 667);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(96, 36);
            btnReset.TabIndex = 50;
            btnReset.Text = "Reset";
            btnReset.TextAlign = ContentAlignment.MiddleRight;
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Transparent;
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.ImageAlign = ContentAlignment.MiddleLeft;
            btnDelete.Location = new Point(136, 667);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(93, 36);
            btnDelete.TabIndex = 52;
            btnDelete.Text = "Delete";
            btnDelete.TextAlign = ContentAlignment.MiddleRight;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtmail
            // 
            txtmail.AutoEllipsis = true;
            txtmail.AutoSize = true;
            txtmail.BackColor = Color.Transparent;
            txtmail.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            txtmail.Location = new Point(615, 197);
            txtmail.Name = "txtmail";
            txtmail.Size = new Size(66, 22);
            txtmail.TabIndex = 53;
            txtmail.Text = "E-mail";
            // 
            // label10
            // 
            label10.AutoEllipsis = true;
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            label10.Location = new Point(615, 277);
            label10.Name = "label10";
            label10.Size = new Size(122, 22);
            label10.TabIndex = 54;
            label10.Text = "Blood Group";
            // 
            // label11
            // 
            label11.AutoEllipsis = true;
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            label11.Location = new Point(615, 354);
            label11.Name = "label11";
            label11.Size = new Size(45, 22);
            label11.TabIndex = 55;
            label11.Text = "City";
            label11.Click += label11_Click;
            // 
            // label12
            // 
            label12.AutoEllipsis = true;
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            label12.Location = new Point(615, 438);
            label12.Name = "label12";
            label12.Size = new Size(83, 22);
            label12.TabIndex = 56;
            label12.Text = "Address";
            // 
            // DeleteDonor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1117, 730);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(txtmail);
            Controls.Add(btnDelete);
            Controls.Add(btnClose);
            Controls.Add(btnReset);
            Controls.Add(txtAddress);
            Controls.Add(txtBloodGroup);
            Controls.Add(txtCity);
            Controls.Add(txtEmail);
            Controls.Add(txtGender);
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
            Name = "DeleteDonor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DeleteDonor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnSearch;
        private TextBox txtDonorID;
        private Label label2;
        private ComboBox txtGender;
        private TextBox txtMobile;
        private TextBox txtSurname;
        private TextBox txtFather;
        private TextBox txtName;
        private DateTimePicker txtDOB;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private RichTextBox txtAddress;
        private ComboBox txtBloodGroup;
        private TextBox txtCity;
        private TextBox txtEmail;
        private Button btnClose;
        private Button btnReset;
        private Button btnDelete;
        private Label txtmail;
        private Label label10;
        private Label label11;
        private Label label12;
    }
}