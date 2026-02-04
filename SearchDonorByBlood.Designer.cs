namespace bbms
{
    partial class SearchDonorByBlood
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchDonorByBlood));
            label1 = new Label();
            label2 = new Label();
            txtSearchBlood = new TextBox();
            dataGridView1 = new DataGridView();
            btnPrint = new Button();
            btnClose = new Button();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Mangal", 22.2F, FontStyle.Bold | FontStyle.Underline);
            label1.Location = new Point(197, 20);
            label1.Name = "label1";
            label1.Size = new Size(740, 66);
            label1.TabIndex = 0;
            label1.Text = "SEARCH DONOR BY BLOOD-GROUP";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Image = (Image)resources.GetObject("label2.Image");
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(267, 115);
            label2.Name = "label2";
            label2.Size = new Size(152, 32);
            label2.TabIndex = 1;
            label2.Text = "Blood Group";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtSearchBlood
            // 
            txtSearchBlood.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            txtSearchBlood.Location = new Point(454, 120);
            txtSearchBlood.Name = "txtSearchBlood";
            txtSearchBlood.Size = new Size(275, 30);
            txtSearchBlood.TabIndex = 2;
            txtSearchBlood.TextChanged += textBox1_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(40, 190);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1078, 420);
            dataGridView1.TabIndex = 3;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.Transparent;
            btnPrint.FlatStyle = FlatStyle.Popup;
            btnPrint.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnPrint.Image = (Image)resources.GetObject("btnPrint.Image");
            btnPrint.ImageAlign = ContentAlignment.MiddleLeft;
            btnPrint.Location = new Point(115, 650);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(87, 55);
            btnPrint.TabIndex = 4;
            btnPrint.Text = "Print";
            btnPrint.TextAlign = ContentAlignment.MiddleRight;
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += btnPrint_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Transparent;
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(956, 650);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(93, 55);
            btnClose.TabIndex = 5;
            btnClose.Text = "Close";
            btnClose.TextAlign = ContentAlignment.MiddleRight;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // SearchDonorByBlood
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1150, 717);
            Controls.Add(btnClose);
            Controls.Add(btnPrint);
            Controls.Add(dataGridView1);
            Controls.Add(txtSearchBlood);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SearchDonorByBlood";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SearchDonorByBlood";
            Load += SearchDonorByBlood_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtSearchBlood;
        private DataGridView dataGridView1;
        private Button btnPrint;
        private Button btnClose;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}