namespace bbms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            btnHideShow = new LinkLabel();
            checkBox = new CheckBox();
            btnlogin = new Button();
            txtPassword = new TextBox();
            label3 = new Label();
            txtUsername = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnExit = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.BackColor = Color.DarkGray;
            panel1.Controls.Add(btnHideShow);
            panel1.Controls.Add(checkBox);
            panel1.Controls.Add(btnlogin);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Font = new Font("Segoe UI", 15F);
            panel1.Location = new Point(763, 125);
            panel1.Name = "panel1";
            panel1.Size = new Size(540, 758);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // btnHideShow
            // 
            btnHideShow.AutoSize = true;
            btnHideShow.Font = new Font("Segoe UI", 10F);
            btnHideShow.Location = new Point(348, 418);
            btnHideShow.Name = "btnHideShow";
            btnHideShow.Size = new Size(51, 23);
            btnHideShow.TabIndex = 7;
            btnHideShow.TabStop = true;
            btnHideShow.Text = "Show";
            btnHideShow.LinkClicked += linkLabel1_LinkClicked;
            // 
            // checkBox
            // 
            checkBox.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox.Location = new Point(110, 505);
            checkBox.Name = "checkBox";
            checkBox.Size = new Size(309, 93);
            checkBox.TabIndex = 6;
            checkBox.Text = "I am not a Robot.";
            checkBox.UseVisualStyleBackColor = true;
            checkBox.CheckedChanged += checkBox_CheckedChanged;
            // 
            // btnlogin
            // 
            btnlogin.BackColor = Color.DarkGray;
            btnlogin.FlatAppearance.BorderColor = Color.Red;
            btnlogin.FlatAppearance.BorderSize = 4;
            btnlogin.FlatStyle = FlatStyle.Flat;
            btnlogin.Font = new Font("Segoe UI", 19F);
            btnlogin.ForeColor = Color.Red;
            btnlogin.Location = new Point(84, 648);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(398, 70);
            btnlogin.TabIndex = 5;
            btnlogin.Text = "Login";
            btnlogin.UseVisualStyleBackColor = false;
            btnlogin.Click += button1_Click;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.Pink;
            txtPassword.Location = new Point(110, 444);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(289, 41);
            txtPassword.TabIndex = 4;
            txtPassword.TextAlign = HorizontalAlignment.Center;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // label3
            // 
            label3.Image = (Image)resources.GetObject("label3.Image");
            label3.ImageAlign = ContentAlignment.MiddleLeft;
            label3.Location = new Point(110, 383);
            label3.Name = "label3";
            label3.Size = new Size(150, 37);
            label3.TabIndex = 3;
            label3.Text = "Password";
            label3.TextAlign = ContentAlignment.MiddleRight;
            label3.Click += label3_Click;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.Pink;
            txtUsername.Location = new Point(110, 255);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(289, 41);
            txtUsername.TabIndex = 2;
            txtUsername.TextAlign = HorizontalAlignment.Center;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 15F);
            label2.Image = (Image)resources.GetObject("label2.Image");
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(110, 187);
            label2.Name = "label2";
            label2.Size = new Size(160, 35);
            label2.TabIndex = 1;
            label2.Text = "Username";
            label2.TextAlign = ContentAlignment.MiddleRight;
            label2.Click += label2_Click_1;
            // 
            // label1
            // 
            label1.BackColor = Color.Red;
            label1.Font = new Font("Segoe UI", 30F);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(540, 100);
            label1.TabIndex = 0;
            label1.Text = "LOGIN";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.BackColor = Color.White;
            btnExit.FlatAppearance.BorderColor = Color.CornflowerBlue;
            btnExit.FlatAppearance.BorderSize = 4;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btnExit.ForeColor = Color.Blue;
            btnExit.Location = new Point(1520, 3);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(72, 68);
            btnExit.TabIndex = 3;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1595, 1102);
            Controls.Add(btnExit);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox txtPassword;
        private Label label3;
        private TextBox txtUsername;
        private Label label2;
        private Button btnlogin;
        private CheckBox checkBox;
        private LinkLabel btnHideShow;
        private Label label4;
        private Button button1;
        private Button btnExit;
    }
}
