using System.Windows.Forms;

namespace App.Presentation.WinForms.Views;

partial class BookingsView
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
        DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
        splitContainer1 = new SplitContainer();
        dgvBookings = new DataGridView();
        groupBox1 = new GroupBox();
        tableLayoutPanel1 = new TableLayoutPanel();
        lblClient = new Label();
        cmbClient = new ComboBox();
        lblTour = new Label();
        cmbTour = new ComboBox();
        lblEmployee = new Label();
        cmbEmployee = new ComboBox();
        lblDate = new Label();
        dtpDate = new DateTimePicker();
        flpButtons = new FlowLayoutPanel();
        btnDelete = new Button();
        btnUpdate = new Button();
        ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
        splitContainer1.Panel1.SuspendLayout();
        splitContainer1.Panel2.SuspendLayout();
        splitContainer1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvBookings).BeginInit();
        groupBox1.SuspendLayout();
        tableLayoutPanel1.SuspendLayout();
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
        splitContainer1.Panel1.Controls.Add(dgvBookings);
        splitContainer1.Panel1.Padding = new Padding(10, 10, 10, 5);
        // 
        // splitContainer1.Panel2
        // 
        splitContainer1.Panel2.Controls.Add(groupBox1);
        splitContainer1.Panel2.Padding = new Padding(10, 5, 10, 10);
        splitContainer1.Size = new Size(1021, 700);
        splitContainer1.SplitterDistance = 350;
        splitContainer1.SplitterWidth = 6;
        splitContainer1.TabIndex = 0;
        // 
        // dgvBookings
        // 
        dgvBookings.AllowUserToAddRows = false;
        dgvBookings.AllowUserToDeleteRows = false;
        dgvBookings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvBookings.BackgroundColor = Color.White;
        dgvBookings.BorderStyle = BorderStyle.None;
        dgvBookings.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
        dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle3.BackColor = Color.FromArgb(248, 249, 250);
        dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        dataGridViewCellStyle3.ForeColor = Color.FromArgb(30, 30, 30);
        dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(248, 249, 250);
        dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(30, 30, 30);
        dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
        dgvBookings.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
        dgvBookings.ColumnHeadersHeight = 40;
        dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle4.BackColor = Color.White;
        dataGridViewCellStyle4.Font = new Font("Segoe UI", 10F);
        dataGridViewCellStyle4.ForeColor = Color.FromArgb(50, 50, 50);
        dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(0, 123, 255);
        dataGridViewCellStyle4.SelectionForeColor = Color.White;
        dataGridViewCellStyle4.SelectionBackColor = Color.Teal;
        dataGridViewCellStyle4.SelectionForeColor = Color.White;
        dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
        dgvBookings.DefaultCellStyle = dataGridViewCellStyle4;
        dgvBookings.Dock = DockStyle.Fill;
        dgvBookings.EnableHeadersVisualStyles = false;
        dgvBookings.GridColor = Color.FromArgb(222, 226, 230);
        dgvBookings.Location = new Point(10, 10);
        dgvBookings.MultiSelect = false;
        dgvBookings.Name = "dgvBookings";
        dgvBookings.ReadOnly = true;
        dgvBookings.RowHeadersVisible = false;
        dgvBookings.RowHeadersWidth = 62;
        dgvBookings.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvBookings.Size = new Size(1001, 335);
        dgvBookings.TabIndex = 0;
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
        groupBox1.Size = new Size(1001, 329);
        groupBox1.TabIndex = 0;
        groupBox1.TabStop = false;
        groupBox1.Text = "Booking details";
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.BackColor = Color.Transparent;
        tableLayoutPanel1.ColumnCount = 2;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tableLayoutPanel1.Controls.Add(lblClient, 0, 0);
        tableLayoutPanel1.Controls.Add(cmbClient, 1, 0);
        tableLayoutPanel1.Controls.Add(lblTour, 0, 1);
        tableLayoutPanel1.Controls.Add(cmbTour, 1, 1);
        tableLayoutPanel1.Controls.Add(lblEmployee, 0, 2);
        tableLayoutPanel1.Controls.Add(cmbEmployee, 1, 2);
        tableLayoutPanel1.Controls.Add(lblDate, 0, 3);
        tableLayoutPanel1.Controls.Add(dtpDate, 1, 3);
        tableLayoutPanel1.Dock = DockStyle.Fill;
        tableLayoutPanel1.Font = new Font("Segoe UI", 10F);
        tableLayoutPanel1.Location = new Point(10, 34);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 4;
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
        tableLayoutPanel1.Size = new Size(981, 218);
        tableLayoutPanel1.TabIndex = 0;
        // 
        // lblClient
        // 
        lblClient.Anchor = AnchorStyles.Left;
        lblClient.ForeColor = Color.FromArgb(80, 80, 80);
        lblClient.Location = new Point(3, 10);
        lblClient.Name = "lblClient";
        lblClient.Size = new Size(100, 33);
        lblClient.TabIndex = 0;
        lblClient.Text = "Select client:";
        // 
        // cmbClient
        // 
        cmbClient.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        cmbClient.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbClient.Font = new Font("Segoe UI", 11F);
        cmbClient.Location = new Point(153, 10);
        cmbClient.Name = "cmbClient";
        cmbClient.Size = new Size(825, 38);
        cmbClient.TabIndex = 1;
        // 
        // lblTour
        // 
        lblTour.Anchor = AnchorStyles.Left;
        lblTour.ForeColor = Color.FromArgb(80, 80, 80);
        lblTour.Location = new Point(3, 64);
        lblTour.Name = "lblTour";
        lblTour.Size = new Size(100, 33);
        lblTour.TabIndex = 2;
        lblTour.Text = "Select tour:";
        // 
        // cmbTour
        // 
        cmbTour.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        cmbTour.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbTour.Font = new Font("Segoe UI", 11F);
        cmbTour.Location = new Point(153, 64);
        cmbTour.Name = "cmbTour";
        cmbTour.Size = new Size(825, 38);
        cmbTour.TabIndex = 3;
        // 
        // lblEmployee
        // 
        lblEmployee.Anchor = AnchorStyles.Left;
        lblEmployee.ForeColor = Color.FromArgb(80, 80, 80);
        lblEmployee.Location = new Point(3, 118);
        lblEmployee.Name = "lblEmployee";
        lblEmployee.Size = new Size(100, 33);
        lblEmployee.TabIndex = 4;
        lblEmployee.Text = "Sales manager:";
        // 
        // cmbEmployee
        // 
        cmbEmployee.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        cmbEmployee.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbEmployee.Font = new Font("Segoe UI", 11F);
        cmbEmployee.Location = new Point(153, 118);
        cmbEmployee.Name = "cmbEmployee";
        cmbEmployee.Size = new Size(825, 38);
        cmbEmployee.TabIndex = 5;
        // 
        // lblDate
        // 
        lblDate.Anchor = AnchorStyles.Left;
        lblDate.ForeColor = Color.FromArgb(80, 80, 80);
        lblDate.Location = new Point(3, 175);
        lblDate.Name = "lblDate";
        lblDate.Size = new Size(100, 30);
        lblDate.TabIndex = 6;
        lblDate.Text = "Booking date:";
        // 
        // dtpDate
        // 
        dtpDate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        dtpDate.Font = new Font("Segoe UI", 11F);
        dtpDate.Format = DateTimePickerFormat.Short;
        dtpDate.Location = new Point(153, 171);
        dtpDate.Name = "dtpDate";
        dtpDate.Size = new Size(825, 37);
        dtpDate.TabIndex = 7;
        // 
        // flpButtons
        // 
        flpButtons.BackColor = Color.FromArgb(248, 249, 250);
        flpButtons.Controls.Add(btnDelete);
        flpButtons.Controls.Add(btnUpdate);
        flpButtons.Dock = DockStyle.Bottom;
        flpButtons.FlowDirection = FlowDirection.RightToLeft;
        flpButtons.Location = new Point(10, 252);
        flpButtons.Name = "flpButtons";
        flpButtons.Padding = new Padding(0, 0, 10, 0);
        flpButtons.Size = new Size(981, 67);
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
        btnDelete.Location = new Point(831, 10);
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
        btnUpdate.Location = new Point(681, 10);
        btnUpdate.Margin = new Padding(10);
        btnUpdate.Name = "btnUpdate";
        btnUpdate.Size = new Size(130, 45);
        btnUpdate.TabIndex = 1;
        btnUpdate.Text = "Save";
        btnUpdate.UseVisualStyleBackColor = false;
        btnUpdate.Click += btnSave_Click;
        // 
        // BookingsView
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(1021, 700);
        Controls.Add(splitContainer1);
        FormBorderStyle = FormBorderStyle.None;
        Name = "BookingsView";
        ShowIcon = false;
        Text = "Bookings management";
        Load += BookingsView_Load;
        splitContainer1.Panel1.ResumeLayout(false);
        splitContainer1.Panel2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
        splitContainer1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvBookings).EndInit();
        groupBox1.ResumeLayout(false);
        tableLayoutPanel1.ResumeLayout(false);
        flpButtons.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.SplitContainer splitContainer1;
    private System.Windows.Forms.DataGridView dgvBookings;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.FlowLayoutPanel flpButtons;
    private System.Windows.Forms.Button btnUpdate;
    private System.Windows.Forms.Button btnDelete;
    private System.Windows.Forms.Label lblClient;
    private System.Windows.Forms.ComboBox cmbClient;
    private System.Windows.Forms.Label lblTour;
    private System.Windows.Forms.ComboBox cmbTour;
    private System.Windows.Forms.Label lblEmployee;
    private System.Windows.Forms.ComboBox cmbEmployee;
    private System.Windows.Forms.Label lblDate;
    private System.Windows.Forms.DateTimePicker dtpDate;
}
