namespace bbms
{
    partial class StockDecrease
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockDecrease));
            label1 = new Label();
            label2 = new Label();
            txtUnits = new ComboBox();
            txtBloodGroup = new ComboBox();
            label3 = new Label();
            btnDecrease = new Button();
            dataGridView1 = new DataGridView();
            button3 = new Button();
            button2 = new Button();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Mangal", 22.2F, FontStyle.Bold | FontStyle.Underline);
            label1.Location = new Point(378, 19);
            label1.Name = "label1";
            label1.Size = new Size(422, 66);
            label1.TabIndex = 0;
            label1.Text = "STOCK (DECREASE)";
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label2.Image = (Image)resources.GetObject("label2.Image");
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(116, 121);
            label2.Name = "label2";
            label2.Size = new Size(152, 40);
            label2.TabIndex = 2;
            label2.Text = "Blood Group";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtUnits
            // 
            txtUnits.DropDownStyle = ComboBoxStyle.DropDownList;
            txtUnits.FormattingEnabled = true;
            txtUnits.Items.AddRange(new object[] { "-1", "-2", "-3", "-4", "-5", "-6", "-7", "-8", "-9", "-10", "-11", "-12", "-13", "-14", "-15", "-16", "-17", "-18", "-19", "-20" });
            txtUnits.Location = new Point(662, 133);
            txtUnits.Name = "txtUnits";
            txtUnits.Size = new Size(151, 28);
            txtUnits.TabIndex = 8;
            // 
            // txtBloodGroup
            // 
            txtBloodGroup.DropDownStyle = ComboBoxStyle.DropDownList;
            txtBloodGroup.FormattingEnabled = true;
            txtBloodGroup.Items.AddRange(new object[] { "A+", "O+", "B+", "AB+", "A-", "O-", "B-", "AB-" });
            txtBloodGroup.Location = new Point(291, 130);
            txtBloodGroup.Name = "txtBloodGroup";
            txtBloodGroup.Size = new Size(180, 28);
            txtBloodGroup.TabIndex = 7;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label3.Location = new Point(561, 130);
            label3.Name = "label3";
            label3.Size = new Size(65, 32);
            label3.TabIndex = 6;
            label3.Text = "Units";
            // 
            // btnDecrease
            // 
            btnDecrease.BackColor = Color.Transparent;
            btnDecrease.FlatStyle = FlatStyle.Popup;
            btnDecrease.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnDecrease.Image = (Image)resources.GetObject("btnDecrease.Image");
            btnDecrease.ImageAlign = ContentAlignment.MiddleLeft;
            btnDecrease.Location = new Point(877, 122);
            btnDecrease.Name = "btnDecrease";
            btnDecrease.Size = new Size(130, 46);
            btnDecrease.TabIndex = 9;
            btnDecrease.Text = "Decrease";
            btnDecrease.TextAlign = ContentAlignment.MiddleRight;
            btnDecrease.UseVisualStyleBackColor = false;
            btnDecrease.Click += btnDecrease_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(35, 201);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1044, 339);
            dataGridView1.TabIndex = 10;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(989, 594);
            button3.Name = "button3";
            button3.Size = new Size(94, 46);
            button3.TabIndex = 12;
            button3.Text = "Close";
            button3.TextAlign = ContentAlignment.MiddleRight;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(57, 594);
            button2.Name = "button2";
            button2.Size = new Size(94, 46);
            button2.TabIndex = 11;
            button2.Text = "Print";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // StockDecrease
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1114, 652);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(btnDecrease);
            Controls.Add(txtUnits);
            Controls.Add(txtBloodGroup);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StockDecrease";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StockDecrease";
            Load += StockDecrease_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox txtUnits;
        private ComboBox txtBloodGroup;
        private Label label3;
        private Button btnDecrease;
        private DataGridView dataGridView1;
        private Button button3;
        private Button button2;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}