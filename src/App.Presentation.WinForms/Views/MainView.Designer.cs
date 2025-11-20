using System.Windows.Forms;

namespace App.Presentation.WinForms.Views
{
    partial class MainView
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

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            oracleCommandBuilder1 = new Oracle.ManagedDataAccess.Client.OracleCommandBuilder();
            contextMenuStrip1 = new ContextMenuStrip(components);
            contextMenuStrip2 = new ContextMenuStrip(components);
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            manageToolStripMenuItem = new ToolStripMenuItem();
            clientsToolStripMenuItem = new ToolStripMenuItem();
            toursToolStripMenuItem = new ToolStripMenuItem();
            employeesToolStripMenuItem = new ToolStripMenuItem();
            mealsToolStripMenuItem = new ToolStripMenuItem();
            hotelsToolStripMenuItem = new ToolStripMenuItem();
            transportToolStripMenuItem = new ToolStripMenuItem();
            PaymentsToolStripMenuItem = new ToolStripMenuItem();
            bookingsToolStripMenuItem = new ToolStripMenuItem();
            reportsToolStripMenuItem = new ToolStripMenuItem();
            bookingsReportToolStripMenuItem = new ToolStripMenuItem();
            pnlMdiBackground = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.ImageScalingSize = new Size(24, 24);
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(61, 4);
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.White;
            menuStrip1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, manageToolStripMenuItem, reportsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(8, 3, 0, 3);
            menuStrip1.Size = new Size(1258, 35);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.BackColor = Color.White;
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            fileToolStripMenuItem.ForeColor = Color.FromArgb(30, 30, 30);
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(54, 29);
            fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.BackColor = Color.White;
            exitToolStripMenuItem.ForeColor = Color.FromArgb(30, 30, 30);
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(141, 34);
            exitToolStripMenuItem.Text = "E&xit";
            exitToolStripMenuItem.Click += mnuFileExit_Click;
            // 
            // manageToolStripMenuItem
            // 
            manageToolStripMenuItem.BackColor = Color.White;
            manageToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clientsToolStripMenuItem, toursToolStripMenuItem, employeesToolStripMenuItem, mealsToolStripMenuItem, hotelsToolStripMenuItem, transportToolStripMenuItem, PaymentsToolStripMenuItem, bookingsToolStripMenuItem });
            manageToolStripMenuItem.ForeColor = Color.FromArgb(30, 30, 30);
            manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            manageToolStripMenuItem.Size = new Size(92, 29);
            manageToolStripMenuItem.Text = "Manage";
            // 
            // clientsToolStripMenuItem
            // 
            clientsToolStripMenuItem.BackColor = Color.White;
            clientsToolStripMenuItem.ForeColor = Color.FromArgb(30, 30, 30);
            clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            clientsToolStripMenuItem.Size = new Size(270, 34);
            clientsToolStripMenuItem.Text = "&Clients";
            clientsToolStripMenuItem.Click += mnuShowClients_Click;
            // 
            // toursToolStripMenuItem
            // 
            toursToolStripMenuItem.BackColor = Color.White;
            toursToolStripMenuItem.ForeColor = Color.FromArgb(30, 30, 30);
            toursToolStripMenuItem.Name = "toursToolStripMenuItem";
            toursToolStripMenuItem.Size = new Size(270, 34);
            toursToolStripMenuItem.Text = "&Tours";
            toursToolStripMenuItem.Click += mnuShowTours_Click;
            // 
            // employeesToolStripMenuItem
            // 
            employeesToolStripMenuItem.BackColor = Color.White;
            employeesToolStripMenuItem.ForeColor = Color.FromArgb(30, 30, 30);
            employeesToolStripMenuItem.Name = "employeesToolStripMenuItem";
            employeesToolStripMenuItem.Size = new Size(270, 34);
            employeesToolStripMenuItem.Text = "&Employees";
            employeesToolStripMenuItem.Click += mnuShowEmployees_Click;
            // 
            // mealsToolStripMenuItem
            // 
            mealsToolStripMenuItem.BackColor = Color.White;
            mealsToolStripMenuItem.ForeColor = Color.FromArgb(30, 30, 30);
            mealsToolStripMenuItem.Name = "mealsToolStripMenuItem";
            mealsToolStripMenuItem.Size = new Size(270, 34);
            mealsToolStripMenuItem.Text = "&Meals";
            mealsToolStripMenuItem.Click += mnuShowMeals_Click;
            // 
            // hotelsToolStripMenuItem
            // 
            hotelsToolStripMenuItem.BackColor = Color.White;
            hotelsToolStripMenuItem.ForeColor = Color.FromArgb(30, 30, 30);
            hotelsToolStripMenuItem.Name = "hotelsToolStripMenuItem";
            hotelsToolStripMenuItem.Size = new Size(270, 34);
            hotelsToolStripMenuItem.Text = "&Hotels";
            hotelsToolStripMenuItem.Click += mnuShowHotels_Click;
            // 
            // transportToolStripMenuItem
            // 
            transportToolStripMenuItem.BackColor = Color.White;
            transportToolStripMenuItem.ForeColor = Color.FromArgb(30, 30, 30);
            transportToolStripMenuItem.Name = "transportToolStripMenuItem";
            transportToolStripMenuItem.Size = new Size(270, 34);
            transportToolStripMenuItem.Text = "&Transport";
            transportToolStripMenuItem.Click += mnuShowTransport_Click;
            // 
            // PaymentsToolStripMenuItem
            // 
            PaymentsToolStripMenuItem.BackColor = Color.White;
            PaymentsToolStripMenuItem.ForeColor = Color.FromArgb(30, 30, 30);
            PaymentsToolStripMenuItem.Name = "PaymentsToolStripMenuItem";
            PaymentsToolStripMenuItem.Size = new Size(270, 34);
            PaymentsToolStripMenuItem.Text = "&Payments";
            PaymentsToolStripMenuItem.Click += mnuShowPayments_Click;
            // 
            // bookingsToolStripMenuItem
            // 
            bookingsToolStripMenuItem.BackColor = Color.White;
            bookingsToolStripMenuItem.ForeColor = Color.FromArgb(30, 30, 30);
            bookingsToolStripMenuItem.Name = "bookingsToolStripMenuItem";
            bookingsToolStripMenuItem.Size = new Size(270, 34);
            bookingsToolStripMenuItem.Text = "&Bookings";
            bookingsToolStripMenuItem.Click += mnuShowBookings_Click;
            // 
            // reportsToolStripMenuItem
            // 
            reportsToolStripMenuItem.BackColor = Color.White;
            reportsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { bookingsReportToolStripMenuItem });
            reportsToolStripMenuItem.ForeColor = Color.FromArgb(30, 30, 30);
            reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            reportsToolStripMenuItem.Size = new Size(89, 29);
            reportsToolStripMenuItem.Text = "&Reports";
            // 
            // bookingsReportToolStripMenuItem
            // 
            bookingsReportToolStripMenuItem.BackColor = Color.White;
            bookingsReportToolStripMenuItem.ForeColor = Color.FromArgb(30, 30, 30);
            bookingsReportToolStripMenuItem.Name = "bookingsReportToolStripMenuItem";
            bookingsReportToolStripMenuItem.Size = new Size(242, 34);
            bookingsReportToolStripMenuItem.Text = "&Bookings report";
            bookingsReportToolStripMenuItem.Click += mnuShowReport_Click;
            // 
            // pnlMdiBackground
            // 
            pnlMdiBackground.BackColor = Color.White;
            pnlMdiBackground.BackgroundImageLayout = ImageLayout.None;
            pnlMdiBackground.Dock = DockStyle.Fill;
            pnlMdiBackground.Location = new Point(0, 35);
            pnlMdiBackground.Name = "pnlMdiBackground";
            pnlMdiBackground.Size = new Size(1258, 659);
            pnlMdiBackground.TabIndex = 7;
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1258, 694);
            Controls.Add(pnlMdiBackground);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(1280, 700);
            Name = "MainView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tour management system";
            Load += MainView_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Oracle.ManagedDataAccess.Client.OracleCommandBuilder oracleCommandBuilder1;
        private ContextMenuStrip contextMenuStrip1;
        private ContextMenuStrip contextMenuStrip2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem manageToolStripMenuItem;
        private ToolStripMenuItem clientsToolStripMenuItem;
        private ToolStripMenuItem toursToolStripMenuItem;
        private ToolStripMenuItem reportsToolStripMenuItem;
        private ToolStripMenuItem bookingsReportToolStripMenuItem;
        private Panel pnlMdiBackground;
        private ToolStripMenuItem employeesToolStripMenuItem;
        private ToolStripMenuItem mealsToolStripMenuItem;
        private ToolStripMenuItem hotelsToolStripMenuItem;
        private ToolStripMenuItem transportToolStripMenuItem;
        private ToolStripMenuItem PaymentsToolStripMenuItem;
        private ToolStripMenuItem bookingsToolStripMenuItem;
    }
}
