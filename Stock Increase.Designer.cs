
namespace bbms
{
    partial class Stock_Increase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stock_Increase));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtBloodGroup = new ComboBox();
            txtUnits = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Mangal", 22.2F, FontStyle.Bold | FontStyle.Underline);
            label1.Location = new Point(367, 18);
            label1.Name = "label1";
            label1.Size = new Size(407, 66);
            label1.TabIndex = 0;
            label1.Text = "STOCK (INCREASE)";
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label2.Image = (Image)resources.GetObject("label2.Image");
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(111, 122);
            label2.Name = "label2";
            label2.Size = new Size(152, 40);
            label2.TabIndex = 1;
            label2.Text = "Blood Group";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label3.Location = new Point(558, 130);
            label3.Name = "label3";
            label3.Size = new Size(65, 32);
            label3.TabIndex = 2;
            label3.Text = "Units";
            // 
            // txtBloodGroup
            // 
            txtBloodGroup.DropDownStyle = ComboBoxStyle.DropDownList;
            txtBloodGroup.FormattingEnabled = true;
            txtBloodGroup.Items.AddRange(new object[] { "A+", "O+", "B+", "AB+", "A-", "O-", "B-", "AB-" });
            txtBloodGroup.Location = new Point(288, 130);
            txtBloodGroup.Name = "txtBloodGroup";
            txtBloodGroup.Size = new Size(180, 28);
            txtBloodGroup.TabIndex = 3;
            // 
            // txtUnits
            // 
            txtUnits.DropDownStyle = ComboBoxStyle.DropDownList;
            txtUnits.FormattingEnabled = true;
            txtUnits.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20" });
            txtUnits.Location = new Point(659, 133);
            txtUnits.Name = "txtUnits";
            txtUnits.Size = new Size(151, 28);
            txtUnits.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(874, 122);
            button1.Name = "button1";
            button1.Size = new Size(124, 46);
            button1.TabIndex = 5;
            button1.Text = "Increase";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(48, 641);
            button2.Name = "button2";
            button2.Size = new Size(94, 46);
            button2.TabIndex = 6;
            button2.Text = "Print";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(980, 641);
            button3.Name = "button3";
            button3.Size = new Size(94, 46);
            button3.TabIndex = 7;
            button3.Text = "Close";
            button3.TextAlign = ContentAlignment.MiddleRight;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(30, 195);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1072, 349);
            dataGridView1.TabIndex = 8;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // Stock_Increase
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1132, 699);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtUnits);
            Controls.Add(txtBloodGroup);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Stock_Increase";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Stock_Increase";
            Load += Stock_Increase_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox txtBloodGroup;
        private ComboBox txtUnits;
        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridView dataGridView1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}