namespace bbms
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            btnExit = new Button();
            menuStrip1 = new MenuStrip();
            donorToolStripMenuItem = new ToolStripMenuItem();
            addNewDonorToolStripMenuItem = new ToolStripMenuItem();
            updateDetailsToolStripMenuItem = new ToolStripMenuItem();
            allDonorToolStripMenuItem = new ToolStripMenuItem();
            searchBloodDonorToolStripMenuItem = new ToolStripMenuItem();
            locationToolStripMenuItem = new ToolStripMenuItem();
            bloodGroupToolStripMenuItem = new ToolStripMenuItem();
            stockToolStripMenuItem = new ToolStripMenuItem();
            increaseToolStripMenuItem = new ToolStripMenuItem();
            decreaseToolStripMenuItem = new ToolStripMenuItem();
            detailsToolStripMenuItem = new ToolStripMenuItem();
            deleteDonorToolStripMenuItem = new ToolStripMenuItem();
            deleteDonorToolStripMenuItem1 = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.BackColor = Color.White;
            btnExit.FlatAppearance.BorderColor = Color.CornflowerBlue;
            btnExit.FlatAppearance.BorderSize = 4;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnExit.ForeColor = Color.Blue;
            btnExit.Location = new Point(1075, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(54, 47);
            btnExit.TabIndex = 2;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(255, 128, 0);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { donorToolStripMenuItem, searchBloodDonorToolStripMenuItem, stockToolStripMenuItem, deleteDonorToolStripMenuItem, logoutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1143, 68);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // donorToolStripMenuItem
            // 
            donorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addNewDonorToolStripMenuItem, updateDetailsToolStripMenuItem, allDonorToolStripMenuItem });
            donorToolStripMenuItem.Image = (Image)resources.GetObject("donorToolStripMenuItem.Image");
            donorToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            donorToolStripMenuItem.Name = "donorToolStripMenuItem";
            donorToolStripMenuItem.Size = new Size(115, 64);
            donorToolStripMenuItem.Text = "Donor";
            donorToolStripMenuItem.Click += donorToolStripMenuItem_Click;
            // 
            // addNewDonorToolStripMenuItem
            // 
            addNewDonorToolStripMenuItem.Image = (Image)resources.GetObject("addNewDonorToolStripMenuItem.Image");
            addNewDonorToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            addNewDonorToolStripMenuItem.Name = "addNewDonorToolStripMenuItem";
            addNewDonorToolStripMenuItem.Size = new Size(206, 26);
            addNewDonorToolStripMenuItem.Text = "Add New Donor";
            addNewDonorToolStripMenuItem.Click += addNewDonorToolStripMenuItem_Click;
            // 
            // updateDetailsToolStripMenuItem
            // 
            updateDetailsToolStripMenuItem.Image = (Image)resources.GetObject("updateDetailsToolStripMenuItem.Image");
            updateDetailsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            updateDetailsToolStripMenuItem.Name = "updateDetailsToolStripMenuItem";
            updateDetailsToolStripMenuItem.Size = new Size(206, 26);
            updateDetailsToolStripMenuItem.Text = "Update Details";
            updateDetailsToolStripMenuItem.Click += updateDetailsToolStripMenuItem_Click;
            // 
            // allDonorToolStripMenuItem
            // 
            allDonorToolStripMenuItem.Image = (Image)resources.GetObject("allDonorToolStripMenuItem.Image");
            allDonorToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            allDonorToolStripMenuItem.Name = "allDonorToolStripMenuItem";
            allDonorToolStripMenuItem.Size = new Size(206, 26);
            allDonorToolStripMenuItem.Text = "All Donor Details";
            allDonorToolStripMenuItem.Click += allDonorToolStripMenuItem_Click;
            // 
            // searchBloodDonorToolStripMenuItem
            // 
            searchBloodDonorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { locationToolStripMenuItem, bloodGroupToolStripMenuItem });
            searchBloodDonorToolStripMenuItem.Image = (Image)resources.GetObject("searchBloodDonorToolStripMenuItem.Image");
            searchBloodDonorToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            searchBloodDonorToolStripMenuItem.Name = "searchBloodDonorToolStripMenuItem";
            searchBloodDonorToolStripMenuItem.Size = new Size(207, 64);
            searchBloodDonorToolStripMenuItem.Text = "Search Blood Donor";
            // 
            // locationToolStripMenuItem
            // 
            locationToolStripMenuItem.Image = (Image)resources.GetObject("locationToolStripMenuItem.Image");
            locationToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            locationToolStripMenuItem.Name = "locationToolStripMenuItem";
            locationToolStripMenuItem.Size = new Size(177, 26);
            locationToolStripMenuItem.Text = "Location";
            locationToolStripMenuItem.Click += locationToolStripMenuItem_Click;
            // 
            // bloodGroupToolStripMenuItem
            // 
            bloodGroupToolStripMenuItem.Image = (Image)resources.GetObject("bloodGroupToolStripMenuItem.Image");
            bloodGroupToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            bloodGroupToolStripMenuItem.Name = "bloodGroupToolStripMenuItem";
            bloodGroupToolStripMenuItem.Size = new Size(177, 26);
            bloodGroupToolStripMenuItem.Text = "Blood Group";
            bloodGroupToolStripMenuItem.Click += bloodGroupToolStripMenuItem_Click;
            // 
            // stockToolStripMenuItem
            // 
            stockToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { increaseToolStripMenuItem, decreaseToolStripMenuItem, detailsToolStripMenuItem });
            stockToolStripMenuItem.Image = (Image)resources.GetObject("stockToolStripMenuItem.Image");
            stockToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            stockToolStripMenuItem.Size = new Size(109, 64);
            stockToolStripMenuItem.Text = "Stock";
            // 
            // increaseToolStripMenuItem
            // 
            increaseToolStripMenuItem.Image = (Image)resources.GetObject("increaseToolStripMenuItem.Image");
            increaseToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            increaseToolStripMenuItem.Name = "increaseToolStripMenuItem";
            increaseToolStripMenuItem.Size = new Size(153, 26);
            increaseToolStripMenuItem.Text = "Increase";
            increaseToolStripMenuItem.Click += increaseToolStripMenuItem_Click;
            // 
            // decreaseToolStripMenuItem
            // 
            decreaseToolStripMenuItem.Image = (Image)resources.GetObject("decreaseToolStripMenuItem.Image");
            decreaseToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            decreaseToolStripMenuItem.Name = "decreaseToolStripMenuItem";
            decreaseToolStripMenuItem.Size = new Size(153, 26);
            decreaseToolStripMenuItem.Text = "Decrease";
            decreaseToolStripMenuItem.Click += decreaseToolStripMenuItem_Click;
            // 
            // detailsToolStripMenuItem
            // 
            detailsToolStripMenuItem.Image = (Image)resources.GetObject("detailsToolStripMenuItem.Image");
            detailsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            detailsToolStripMenuItem.Name = "detailsToolStripMenuItem";
            detailsToolStripMenuItem.Size = new Size(153, 26);
            detailsToolStripMenuItem.Text = "Details";
            detailsToolStripMenuItem.Click += detailsToolStripMenuItem_Click;
            // 
            // deleteDonorToolStripMenuItem
            // 
            deleteDonorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { deleteDonorToolStripMenuItem1 });
            deleteDonorToolStripMenuItem.Image = (Image)resources.GetObject("deleteDonorToolStripMenuItem.Image");
            deleteDonorToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            deleteDonorToolStripMenuItem.Name = "deleteDonorToolStripMenuItem";
            deleteDonorToolStripMenuItem.Size = new Size(163, 64);
            deleteDonorToolStripMenuItem.Text = "Delete Donor";
            deleteDonorToolStripMenuItem.Click += deleteDonorToolStripMenuItem_Click;
            // 
            // deleteDonorToolStripMenuItem1
            // 
            deleteDonorToolStripMenuItem1.Image = (Image)resources.GetObject("deleteDonorToolStripMenuItem1.Image");
            deleteDonorToolStripMenuItem1.ImageScaling = ToolStripItemImageScaling.None;
            deleteDonorToolStripMenuItem1.Name = "deleteDonorToolStripMenuItem1";
            deleteDonorToolStripMenuItem1.Size = new Size(224, 26);
            deleteDonorToolStripMenuItem1.Text = "Delete Donor";
            deleteDonorToolStripMenuItem1.Click += deleteDonorToolStripMenuItem1_Click;
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Image = (Image)resources.GetObject("logoutToolStripMenuItem.Image");
            logoutToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(136, 64);
            logoutToolStripMenuItem.Text = "Log Out";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1143, 622);
            Controls.Add(btnExit);
            Controls.Add(menuStrip1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Name = "Dashboard";
            Text = "Dashboard";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExit;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem donorToolStripMenuItem;
        private ToolStripMenuItem searchBloodDonorToolStripMenuItem;
        private ToolStripMenuItem stockToolStripMenuItem;
        private ToolStripMenuItem deleteDonorToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem addNewDonorToolStripMenuItem;
        private ToolStripMenuItem updateDetailsToolStripMenuItem;
        private ToolStripMenuItem allDonorToolStripMenuItem;
        private ToolStripMenuItem locationToolStripMenuItem;
        private ToolStripMenuItem bloodGroupToolStripMenuItem;
        private ToolStripMenuItem increaseToolStripMenuItem;
        private ToolStripMenuItem decreaseToolStripMenuItem;
        private ToolStripMenuItem detailsToolStripMenuItem;
        private ToolStripMenuItem deleteDonorToolStripMenuItem1;
    }
}