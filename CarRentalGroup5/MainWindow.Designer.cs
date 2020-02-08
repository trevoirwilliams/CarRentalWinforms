namespace CarRentalGroup5
{
    partial class MainWindow
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.manageVehiclesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listVehiclesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRemoveVehiclesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editVehiclesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageRentalsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rentalRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.archiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutDevelopersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageVehiclesToolStripMenuItem,
            this.manageRentalsToolStripMenuItem,
            this.aboutDevelopersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // manageVehiclesToolStripMenuItem
            // 
            this.manageVehiclesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listVehiclesToolStripMenuItem,
            this.addRemoveVehiclesToolStripMenuItem,
            this.editVehiclesToolStripMenuItem});
            this.manageVehiclesToolStripMenuItem.Name = "manageVehiclesToolStripMenuItem";
            this.manageVehiclesToolStripMenuItem.Size = new System.Drawing.Size(134, 24);
            this.manageVehiclesToolStripMenuItem.Text = "Manage Vehicles";
            // 
            // listVehiclesToolStripMenuItem
            // 
            this.listVehiclesToolStripMenuItem.Name = "listVehiclesToolStripMenuItem";
            this.listVehiclesToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.listVehiclesToolStripMenuItem.Text = "Vehicle Listing";
            this.listVehiclesToolStripMenuItem.Click += new System.EventHandler(this.listVehiclesToolStripMenuItem_Click);
            // 
            // addRemoveVehiclesToolStripMenuItem
            // 
            this.addRemoveVehiclesToolStripMenuItem.Name = "addRemoveVehiclesToolStripMenuItem";
            this.addRemoveVehiclesToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.addRemoveVehiclesToolStripMenuItem.Text = "Add/Remove Vehicles";
            // 
            // editVehiclesToolStripMenuItem
            // 
            this.editVehiclesToolStripMenuItem.Name = "editVehiclesToolStripMenuItem";
            this.editVehiclesToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.editVehiclesToolStripMenuItem.Text = "Edit Vehicles";
            // 
            // manageRentalsToolStripMenuItem
            // 
            this.manageRentalsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rentalRecordsToolStripMenuItem,
            this.toolStripSeparator1});
            this.manageRentalsToolStripMenuItem.Name = "manageRentalsToolStripMenuItem";
            this.manageRentalsToolStripMenuItem.Size = new System.Drawing.Size(129, 24);
            this.manageRentalsToolStripMenuItem.Text = "Manage Rentals";
            // 
            // rentalRecordsToolStripMenuItem
            // 
            this.rentalRecordsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem,
            this.archiveToolStripMenuItem});
            this.rentalRecordsToolStripMenuItem.Name = "rentalRecordsToolStripMenuItem";
            this.rentalRecordsToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.rentalRecordsToolStripMenuItem.Text = "Rental Records";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // archiveToolStripMenuItem
            // 
            this.archiveToolStripMenuItem.Name = "archiveToolStripMenuItem";
            this.archiveToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.archiveToolStripMenuItem.Text = "Archive";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(188, 6);
            // 
            // aboutDevelopersToolStripMenuItem
            // 
            this.aboutDevelopersToolStripMenuItem.Name = "aboutDevelopersToolStripMenuItem";
            this.aboutDevelopersToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.aboutDevelopersToolStripMenuItem.Text = "About Developers";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "VTDI Car Rentals ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem manageVehiclesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listVehiclesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRemoveVehiclesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editVehiclesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageRentalsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rentalRecordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem archiveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem aboutDevelopersToolStripMenuItem;
    }
}