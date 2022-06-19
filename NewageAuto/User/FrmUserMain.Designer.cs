namespace NewageAuto.User
{
    partial class FrmUserMain
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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BookingReturnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewBookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.BookingToolStripMenuItem,
            this.BookingReturnToolStripMenuItem,
            this.ViewBookingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(944, 29);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(58, 25);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(120, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // BookingToolStripMenuItem
            // 
            this.BookingToolStripMenuItem.Name = "BookingToolStripMenuItem";
            this.BookingToolStripMenuItem.Size = new System.Drawing.Size(97, 25);
            this.BookingToolStripMenuItem.Text = "Booking";
            this.BookingToolStripMenuItem.Click += new System.EventHandler(this.BookingToolStripMenuItem_Click);
            // 
            // BookingReturnToolStripMenuItem
            // 
            this.BookingReturnToolStripMenuItem.Name = "BookingReturnToolStripMenuItem";
            this.BookingReturnToolStripMenuItem.Size = new System.Drawing.Size(170, 25);
            this.BookingReturnToolStripMenuItem.Text = "Booking Return";
            this.BookingReturnToolStripMenuItem.Click += new System.EventHandler(this.BookingReturnToolStripMenuItem_Click);
            // 
            // ViewBookingToolStripMenuItem
            // 
            this.ViewBookingToolStripMenuItem.Name = "ViewBookingToolStripMenuItem";
            this.ViewBookingToolStripMenuItem.Size = new System.Drawing.Size(151, 25);
            this.ViewBookingToolStripMenuItem.Text = "View Booking";
            this.ViewBookingToolStripMenuItem.Click += new System.EventHandler(this.ViewBookingToolStripMenuItem_Click);
            // 
            // FrmUserMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmUserMain";
            this.Text = "FrmUserMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BookingReturnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ViewBookingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BookingToolStripMenuItem;
    }
}