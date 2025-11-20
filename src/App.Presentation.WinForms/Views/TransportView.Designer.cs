namespace App.Presentation.WinForms.Views
{
    partial class TransportView
    {
        private System.ComponentModel.IContainer components = null;

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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            splitContainer1 = new SplitContainer();
            dgvTransports = new DataGridView();
            groupBox1 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblTour = new Label();
            cmbTour = new ComboBox();
            lblEmployee = new Label();
            cmbEmployee = new ComboBox();
            lblType = new Label();
            cmbType = new ComboBox();
            lblRoute = new Label();
            txtRoute = new TextBox();
            lblDepDate = new Label();
            dtpDepDate = new DateTimePicker();
            lblDepTime = new Label();
            dtpDepTime = new DateTimePicker();
            lblFrom = new Label();
            txtFrom = new TextBox();
            lblTo = new Label();
            txtTo = new TextBox();
            lblPrice = new Label();
            numPrice = new NumericUpDown();
            flpButtons = new FlowLayoutPanel();
            btnDelete = new Button();
            btnUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransports).BeginInit();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numPrice).BeginInit();
            flpButtons.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.BackColor = Color.FromArgb(222, 226, 230);
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dgvTransports);
            splitContainer1.Panel1.Padding = new Padding(10, 10, 10, 5);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(groupBox1);
            splitContainer1.Panel2.Padding = new Padding(10, 5, 10, 10);
            splitContainer1.Size = new Size(1100, 750);
            splitContainer1.SplitterDistance = 350;
            splitContainer1.SplitterWidth = 6;
            splitContainer1.TabIndex = 0;
            // 
            // dgvTransports
            // 
            dgvTransports.AllowUserToAddRows = false;
            dgvTransports.AllowUserToDeleteRows = false;
            dgvTransports.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTransports.BackgroundColor = Color.White;
            dgvTransports.BorderStyle = BorderStyle.None;
            dgvTransports.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 249, 250);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(30, 30, 30);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(248, 249, 250);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(30, 30, 30);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvTransports.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvTransports.ColumnHeadersHeight = 40;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(50, 50, 50);
            dataGridViewCellStyle2.SelectionBackColor = Color.Teal;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvTransports.DefaultCellStyle = dataGridViewCellStyle2;
            dgvTransports.Dock = DockStyle.Fill;
            dgvTransports.EnableHeadersVisualStyles = false;
            dgvTransports.GridColor = Color.FromArgb(222, 226, 230);
            dgvTransports.Location = new Point(10, 10);
            dgvTransports.MultiSelect = false;
            dgvTransports.Name = "dgvTransports";
            dgvTransports.ReadOnly = true;
            dgvTransports.RowHeadersVisible = false;
            dgvTransports.RowHeadersWidth = 62;
            dgvTransports.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTransports.Size = new Size(1080, 335);
            dgvTransports.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Controls.Add(flpButtons);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox1.Location = new Point(10, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(10);
            groupBox1.Size = new Size(1080, 379);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Transport details";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 130F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 130F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(lblTour, 0, 0);
            tableLayoutPanel1.Controls.Add(cmbTour, 1, 0);
            tableLayoutPanel1.Controls.Add(lblEmployee, 2, 0);
            tableLayoutPanel1.Controls.Add(cmbEmployee, 3, 0);
            tableLayoutPanel1.Controls.Add(lblType, 0, 1);
            tableLayoutPanel1.Controls.Add(cmbType, 1, 1);
            tableLayoutPanel1.Controls.Add(lblRoute, 2, 1);
            tableLayoutPanel1.Controls.Add(txtRoute, 3, 1);
            tableLayoutPanel1.Controls.Add(lblDepDate, 0, 2);
            tableLayoutPanel1.Controls.Add(dtpDepDate, 1, 2);
            tableLayoutPanel1.Controls.Add(lblDepTime, 2, 2);
            tableLayoutPanel1.Controls.Add(dtpDepTime, 3, 2);
            tableLayoutPanel1.Controls.Add(lblFrom, 0, 3);
            tableLayoutPanel1.Controls.Add(txtFrom, 1, 3);
            tableLayoutPanel1.Controls.Add(lblTo, 2, 3);
            tableLayoutPanel1.Controls.Add(txtTo, 3, 3);
            tableLayoutPanel1.Controls.Add(lblPrice, 0, 4);
            tableLayoutPanel1.Controls.Add(numPrice, 1, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Font = new Font("Segoe UI", 10F);
            tableLayoutPanel1.Location = new Point(10, 34);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(1060, 268);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lblTour
            // 
            lblTour.Anchor = AnchorStyles.Left;
            lblTour.ForeColor = Color.FromArgb(80, 80, 80);
            lblTour.Location = new Point(3, 11);
            lblTour.Name = "lblTour";
            lblTour.Size = new Size(100, 30);
            lblTour.TabIndex = 0;
            lblTour.Text = "Select Tour:";
            // 
            // cmbTour
            // 
            cmbTour.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbTour.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTour.Font = new Font("Segoe UI", 11F);
            cmbTour.Location = new Point(133, 7);
            cmbTour.Name = "cmbTour";
            cmbTour.Size = new Size(394, 38);
            cmbTour.TabIndex = 1;
            // 
            // lblEmployee
            // 
            lblEmployee.Anchor = AnchorStyles.Left;
            lblEmployee.ForeColor = Color.FromArgb(80, 80, 80);
            lblEmployee.Location = new Point(533, 11);
            lblEmployee.Name = "lblEmployee";
            lblEmployee.Size = new Size(100, 30);
            lblEmployee.TabIndex = 2;
            lblEmployee.Text = "Manager:";
            // 
            // cmbEmployee
            // 
            cmbEmployee.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbEmployee.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEmployee.Font = new Font("Segoe UI", 11F);
            cmbEmployee.Location = new Point(663, 7);
            cmbEmployee.Name = "cmbEmployee";
            cmbEmployee.Size = new Size(394, 38);
            cmbEmployee.TabIndex = 3;
            // 
            // lblType
            // 
            lblType.Anchor = AnchorStyles.Left;
            lblType.ForeColor = Color.FromArgb(80, 80, 80);
            lblType.Location = new Point(3, 64);
            lblType.Name = "lblType";
            lblType.Size = new Size(100, 30);
            lblType.TabIndex = 4;
            lblType.Text = "Transport type:";
            // 
            // cmbType
            // 
            cmbType.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbType.Font = new Font("Segoe UI", 11F);
            cmbType.Items.AddRange(new object[] { "Bus", "Plane", "Train", "Ship", "Minivan" });
            cmbType.Location = new Point(133, 60);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(394, 38);
            cmbType.TabIndex = 5;
            // 
            // lblRoute
            // 
            lblRoute.Anchor = AnchorStyles.Left;
            lblRoute.ForeColor = Color.FromArgb(80, 80, 80);
            lblRoute.Location = new Point(533, 64);
            lblRoute.Name = "lblRoute";
            lblRoute.Size = new Size(100, 30);
            lblRoute.TabIndex = 6;
            lblRoute.Text = "Route number:";
            // 
            // txtRoute
            // 
            txtRoute.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtRoute.Font = new Font("Segoe UI", 11F);
            txtRoute.Location = new Point(663, 61);
            txtRoute.Name = "txtRoute";
            txtRoute.Size = new Size(394, 37);
            txtRoute.TabIndex = 7;
            // 
            // lblDepDate
            // 
            lblDepDate.Anchor = AnchorStyles.Left;
            lblDepDate.ForeColor = Color.FromArgb(80, 80, 80);
            lblDepDate.Location = new Point(3, 117);
            lblDepDate.Name = "lblDepDate";
            lblDepDate.Size = new Size(124, 30);
            lblDepDate.TabIndex = 8;
            lblDepDate.Text = "Dep. date:";
            // 
            // dtpDepDate
            // 
            dtpDepDate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dtpDepDate.Font = new Font("Segoe UI", 11F);
            dtpDepDate.Format = DateTimePickerFormat.Short;
            dtpDepDate.Location = new Point(133, 114);
            dtpDepDate.Name = "dtpDepDate";
            dtpDepDate.Size = new Size(394, 37);
            dtpDepDate.TabIndex = 9;
            // 
            // lblDepTime
            // 
            lblDepTime.Anchor = AnchorStyles.Left;
            lblDepTime.ForeColor = Color.FromArgb(80, 80, 80);
            lblDepTime.Location = new Point(533, 117);
            lblDepTime.Name = "lblDepTime";
            lblDepTime.Size = new Size(124, 30);
            lblDepTime.TabIndex = 10;
            lblDepTime.Text = "Dep. time:";
            // 
            // dtpDepTime
            // 
            dtpDepTime.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dtpDepTime.Font = new Font("Segoe UI", 11F);
            dtpDepTime.Format = DateTimePickerFormat.Time;
            dtpDepTime.Location = new Point(663, 114);
            dtpDepTime.Name = "dtpDepTime";
            dtpDepTime.ShowUpDown = true;
            dtpDepTime.Size = new Size(394, 37);
            dtpDepTime.TabIndex = 11;
            // 
            // lblFrom
            // 
            lblFrom.Anchor = AnchorStyles.Left;
            lblFrom.ForeColor = Color.FromArgb(80, 80, 80);
            lblFrom.Location = new Point(3, 170);
            lblFrom.Name = "lblFrom";
            lblFrom.Size = new Size(100, 30);
            lblFrom.TabIndex = 12;
            lblFrom.Text = "From:";
            // 
            // txtFrom
            // 
            txtFrom.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtFrom.Font = new Font("Segoe UI", 11F);
            txtFrom.Location = new Point(133, 167);
            txtFrom.Name = "txtFrom";
            txtFrom.Size = new Size(394, 37);
            txtFrom.TabIndex = 13;
            // 
            // lblTo
            // 
            lblTo.Anchor = AnchorStyles.Left;
            lblTo.ForeColor = Color.FromArgb(80, 80, 80);
            lblTo.Location = new Point(533, 170);
            lblTo.Name = "lblTo";
            lblTo.Size = new Size(100, 30);
            lblTo.TabIndex = 14;
            lblTo.Text = "To:";
            // 
            // txtTo
            // 
            txtTo.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtTo.Font = new Font("Segoe UI", 11F);
            txtTo.Location = new Point(663, 167);
            txtTo.Name = "txtTo";
            txtTo.Size = new Size(394, 37);
            txtTo.TabIndex = 15;
            // 
            // lblPrice
            // 
            lblPrice.Anchor = AnchorStyles.Left;
            lblPrice.ForeColor = Color.FromArgb(80, 80, 80);
            lblPrice.Location = new Point(3, 225);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(100, 30);
            lblPrice.TabIndex = 16;
            lblPrice.Text = "Price:";
            // 
            // numPrice
            // 
            numPrice.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            numPrice.DecimalPlaces = 2;
            numPrice.Font = new Font("Segoe UI", 11F);
            numPrice.Location = new Point(133, 221);
            numPrice.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numPrice.Name = "numPrice";
            numPrice.Size = new Size(394, 37);
            numPrice.TabIndex = 17;
            // 
            // flpButtons
            // 
            flpButtons.BackColor = Color.FromArgb(248, 249, 250);
            flpButtons.Controls.Add(btnDelete);
            flpButtons.Controls.Add(btnUpdate);
            flpButtons.Dock = DockStyle.Bottom;
            flpButtons.FlowDirection = FlowDirection.RightToLeft;
            flpButtons.Location = new Point(10, 302);
            flpButtons.Name = "flpButtons";
            flpButtons.Padding = new Padding(0, 0, 10, 0);
            flpButtons.Size = new Size(1060, 67);
            flpButtons.TabIndex = 1;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.BackColor = Color.Firebrick;
            btnDelete.Enabled = false;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(910, 10);
            btnDelete.Margin = new Padding(10);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(130, 45);
            btnDelete.TabIndex = 0;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnUpdate.BackColor = Color.Teal;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(760, 10);
            btnUpdate.Margin = new Padding(10);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(130, 45);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Save";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnSave_Click;
            // 
            // TransportView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1100, 750);
            Controls.Add(splitContainer1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TransportView";
            ShowIcon = false;
            Text = "Transport management";
            Load += TransportView_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTransports).EndInit();
            groupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numPrice).EndInit();
            flpButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvTransports;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flpButtons;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblTour;
        private System.Windows.Forms.ComboBox cmbTour;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.ComboBox cmbEmployee;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label lblRoute;
        private System.Windows.Forms.TextBox txtRoute;
        private System.Windows.Forms.Label lblDepDate;
        private System.Windows.Forms.DateTimePicker dtpDepDate;
        private System.Windows.Forms.Label lblDepTime;
        private System.Windows.Forms.DateTimePicker dtpDepTime;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.NumericUpDown numPrice;
    }
}
