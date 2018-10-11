namespace CouchDBCA
{
    partial class MainMenu
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.addCarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeCarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateCarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchByMakeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCarToolStripMenuItem,
            this.removeCarToolStripMenuItem,
            this.updateCarToolStripMenuItem,
            this.searchByMakeToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1158, 42);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // addCarToolStripMenuItem
            // 
            this.addCarToolStripMenuItem.Name = "addCarToolStripMenuItem";
            this.addCarToolStripMenuItem.Size = new System.Drawing.Size(112, 36);
            this.addCarToolStripMenuItem.Text = "Add Car";
            this.addCarToolStripMenuItem.Click += new System.EventHandler(this.addCarToolStripMenuItem_Click);
            // 
            // removeCarToolStripMenuItem
            // 
            this.removeCarToolStripMenuItem.Name = "removeCarToolStripMenuItem";
            this.removeCarToolStripMenuItem.Size = new System.Drawing.Size(155, 36);
            this.removeCarToolStripMenuItem.Text = "Remove Car";
            this.removeCarToolStripMenuItem.Click += new System.EventHandler(this.removeCarToolStripMenuItem_Click);
            // 
            // updateCarToolStripMenuItem
            // 
            this.updateCarToolStripMenuItem.Name = "updateCarToolStripMenuItem";
            this.updateCarToolStripMenuItem.Size = new System.Drawing.Size(146, 36);
            this.updateCarToolStripMenuItem.Text = "Update Car";
            this.updateCarToolStripMenuItem.Click += new System.EventHandler(this.updateCarToolStripMenuItem_Click);
            // 
            // searchByMakeToolStripMenuItem
            // 
            this.searchByMakeToolStripMenuItem.Name = "searchByMakeToolStripMenuItem";
            this.searchByMakeToolStripMenuItem.Size = new System.Drawing.Size(197, 38);
            this.searchByMakeToolStripMenuItem.Text = "Search By Make";
            this.searchByMakeToolStripMenuItem.Click += new System.EventHandler(this.searchByMakeToolStripMenuItem_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1158, 841);
            this.Controls.Add(this.menuStrip2);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem addCarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeCarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateCarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchByMakeToolStripMenuItem;
    }
}