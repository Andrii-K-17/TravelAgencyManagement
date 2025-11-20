namespace App.Presentation.WinForms.Views;

partial class PaymentsView
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
        dgvPayments = new DataGridView();
        groupBox1 = new GroupBox();
        tableLayoutPanel1 = new TableLayoutPanel();
        lblBooking = new Label();
        cmbBooking = new ComboBox();
        lblEmployee = new Label();
        cmbEmployee = new ComboBox();
        lblTransaction = new Label();
        txtTransaction = new TextBox();
        lblAmount = new Label();
        numAmount = new NumericUpDown();
        lblMethod = new Label();
        cmbMethod = new ComboBox();
        lblDate = new Label();
        dtpDate = new DateTimePicker();
        flpButtons = new FlowLayoutPanel();
        btnDelete = new Button();
        btnUpdate = new Button();
        ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
        splitContainer1.Panel1.SuspendLayout();
        splitContainer1.Panel2.SuspendLayout();
        splitContainer1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvPayments).BeginInit();
        groupBox1.SuspendLayout();
        tableLayoutPanel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numAmount).BeginInit();
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
        splitContainer1.Panel1.Controls.Add(dgvPayments);
        splitContainer1.Panel1.Padding = new Padding(10, 10, 10, 5);
        // 
        // splitContainer1.Panel2
        // 
        splitContainer1.Panel2.Controls.Add(groupBox1);
        splitContainer1.Panel2.Padding = new Padding(10, 5, 10, 10);
        splitContainer1.Size = new Size(1021, 700);
        splitContainer1.SplitterDistance = 300;
        splitContainer1.SplitterWidth = 6;
        splitContainer1.TabIndex = 0;
        // 
        // dgvPayments
        // 
        dgvPayments.AllowUserToAddRows = false;
        dgvPayments.AllowUserToDeleteRows = false;
        dgvPayments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvPayments.BackgroundColor = Color.White;
        dgvPayments.BorderStyle = BorderStyle.None;
        dgvPayments.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
        dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 249, 250);
        dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        dataGridViewCellStyle1.ForeColor = Color.FromArgb(30, 30, 30);
        dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(248, 249, 250);
        dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(30, 30, 30);
        dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
        dgvPayments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
        dgvPayments.ColumnHeadersHeight = 40;
        dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = Color.White;
        dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
        dataGridViewCellStyle2.ForeColor = Color.FromArgb(50, 50, 50);
        dataGridViewCellStyle2.SelectionBackColor = Color.Teal;
        dataGridViewCellStyle2.SelectionForeColor = Color.White;
        dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
        dgvPayments.DefaultCellStyle = dataGridViewCellStyle2;
        dgvPayments.Dock = DockStyle.Fill;
        dgvPayments.EnableHeadersVisualStyles = false;
        dgvPayments.GridColor = Color.FromArgb(222, 226, 230);
        dgvPayments.Location = new Point(10, 10);
        dgvPayments.MultiSelect = false;
        dgvPayments.Name = "dgvPayments";
        dgvPayments.ReadOnly = true;
        dgvPayments.RowHeadersVisible = false;
        dgvPayments.RowHeadersWidth = 62;
        dgvPayments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvPayments.Size = new Size(1001, 285);
        dgvPayments.TabIndex = 0;
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
        groupBox1.Size = new Size(1001, 379);
        groupBox1.TabIndex = 0;
        groupBox1.TabStop = false;
        groupBox1.Text = "Payment details";
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.BackColor = Color.Transparent;
        tableLayoutPanel1.ColumnCount = 2;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 171F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tableLayoutPanel1.Controls.Add(lblBooking, 0, 0);
        tableLayoutPanel1.Controls.Add(cmbBooking, 1, 0);
        tableLayoutPanel1.Controls.Add(lblEmployee, 0, 1);
        tableLayoutPanel1.Controls.Add(cmbEmployee, 1, 1);
        tableLayoutPanel1.Controls.Add(lblTransaction, 0, 2);
        tableLayoutPanel1.Controls.Add(txtTransaction, 1, 2);
        tableLayoutPanel1.Controls.Add(lblAmount, 0, 3);
        tableLayoutPanel1.Controls.Add(numAmount, 1, 3);
        tableLayoutPanel1.Controls.Add(lblMethod, 0, 4);
        tableLayoutPanel1.Controls.Add(cmbMethod, 1, 4);
        tableLayoutPanel1.Controls.Add(lblDate, 0, 5);
        tableLayoutPanel1.Controls.Add(dtpDate, 1, 5);
        tableLayoutPanel1.Dock = DockStyle.Fill;
        tableLayoutPanel1.Font = new Font("Segoe UI", 10F);
        tableLayoutPanel1.Location = new Point(10, 34);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 6;
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66F));
        tableLayoutPanel1.Size = new Size(981, 268);
        tableLayoutPanel1.TabIndex = 0;
        // 
        // lblBooking
        // 
        lblBooking.Anchor = AnchorStyles.Left;
        lblBooking.ForeColor = Color.FromArgb(80, 80, 80);
        lblBooking.Location = new Point(3, 6);
        lblBooking.Name = "lblBooking";
        lblBooking.Size = new Size(154, 31);
        lblBooking.TabIndex = 0;
        lblBooking.Text = "Booking:";
        // 
        // cmbBooking
        // 
        cmbBooking.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        cmbBooking.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbBooking.Font = new Font("Segoe UI", 11F);
        cmbBooking.Location = new Point(174, 3);
        cmbBooking.Name = "cmbBooking";
        cmbBooking.Size = new Size(804, 38);
        cmbBooking.TabIndex = 1;
        // 
        // lblEmployee
        // 
        lblEmployee.Anchor = AnchorStyles.Left;
        lblEmployee.ForeColor = Color.FromArgb(80, 80, 80);
        lblEmployee.Location = new Point(3, 50);
        lblEmployee.Name = "lblEmployee";
        lblEmployee.Size = new Size(154, 31);
        lblEmployee.TabIndex = 2;
        lblEmployee.Text = "Manager:";
        // 
        // cmbEmployee
        // 
        cmbEmployee.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        cmbEmployee.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbEmployee.Font = new Font("Segoe UI", 11F);
        cmbEmployee.Location = new Point(174, 47);
        cmbEmployee.Name = "cmbEmployee";
        cmbEmployee.Size = new Size(804, 38);
        cmbEmployee.TabIndex = 3;
        // 
        // lblTransaction
        // 
        lblTransaction.Anchor = AnchorStyles.Left;
        lblTransaction.ForeColor = Color.FromArgb(80, 80, 80);
        lblTransaction.Location = new Point(3, 95);
        lblTransaction.Name = "lblTransaction";
        lblTransaction.Size = new Size(154, 30);
        lblTransaction.TabIndex = 4;
        lblTransaction.Text = "Transaction No.:";
        // 
        // txtTransaction
        // 
        txtTransaction.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        txtTransaction.Font = new Font("Segoe UI", 11F);
        txtTransaction.Location = new Point(174, 91);
        txtTransaction.Name = "txtTransaction";
        txtTransaction.Size = new Size(804, 37);
        txtTransaction.TabIndex = 5;
        // 
        // lblAmount
        // 
        lblAmount.Anchor = AnchorStyles.Left;
        lblAmount.ForeColor = Color.FromArgb(80, 80, 80);
        lblAmount.Location = new Point(3, 139);
        lblAmount.Name = "lblAmount";
        lblAmount.Size = new Size(100, 30);
        lblAmount.TabIndex = 6;
        lblAmount.Text = "Amount:";
        // 
        // numAmount
        // 
        numAmount.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        numAmount.DecimalPlaces = 2;
        numAmount.Font = new Font("Segoe UI", 11F);
        numAmount.Location = new Point(174, 135);
        numAmount.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
        numAmount.Name = "numAmount";
        numAmount.Size = new Size(804, 37);
        numAmount.TabIndex = 7;
        // 
        // lblMethod
        // 
        lblMethod.Anchor = AnchorStyles.Left;
        lblMethod.ForeColor = Color.FromArgb(80, 80, 80);
        lblMethod.Location = new Point(3, 182);
        lblMethod.Name = "lblMethod";
        lblMethod.Size = new Size(165, 31);
        lblMethod.TabIndex = 8;
        lblMethod.Text = "Payment method:";
        // 
        // cmbMethod
        // 
        cmbMethod.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        cmbMethod.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbMethod.Font = new Font("Segoe UI", 11F);
        cmbMethod.Items.AddRange(new object[] { "Card", "Cash", "Bank transfer", "PayPal", "Crypto" });
        cmbMethod.Location = new Point(174, 179);
        cmbMethod.Name = "cmbMethod";
        cmbMethod.Size = new Size(804, 38);
        cmbMethod.TabIndex = 9;
        // 
        // lblDate
        // 
        lblDate.Anchor = AnchorStyles.Left;
        lblDate.ForeColor = Color.FromArgb(80, 80, 80);
        lblDate.Location = new Point(3, 227);
        lblDate.Name = "lblDate";
        lblDate.Size = new Size(165, 33);
        lblDate.TabIndex = 10;
        lblDate.Text = "Payment date:";
        // 
        // dtpDate
        // 
        dtpDate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        dtpDate.Font = new Font("Segoe UI", 11F);
        dtpDate.Format = DateTimePickerFormat.Short;
        dtpDate.Location = new Point(174, 225);
        dtpDate.Name = "dtpDate";
        dtpDate.Size = new Size(804, 37);
        dtpDate.TabIndex = 11;
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
        // PaymentsView
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(1021, 700);
        Controls.Add(splitContainer1);
        FormBorderStyle = FormBorderStyle.None;
        Name = "PaymentsView";
        ShowIcon = false;
        Text = "Payments management";
        Load += PaymentsView_Load;
        splitContainer1.Panel1.ResumeLayout(false);
        splitContainer1.Panel2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
        splitContainer1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvPayments).EndInit();
        groupBox1.ResumeLayout(false);
        tableLayoutPanel1.ResumeLayout(false);
        tableLayoutPanel1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)numAmount).EndInit();
        flpButtons.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.SplitContainer splitContainer1;
    private System.Windows.Forms.DataGridView dgvPayments;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.FlowLayoutPanel flpButtons;
    private System.Windows.Forms.Button btnUpdate;
    private System.Windows.Forms.Button btnDelete;
    private System.Windows.Forms.Label lblBooking;
    private System.Windows.Forms.ComboBox cmbBooking;
    private System.Windows.Forms.Label lblEmployee;
    private System.Windows.Forms.ComboBox cmbEmployee;
    private System.Windows.Forms.Label lblAmount;
    private System.Windows.Forms.NumericUpDown numAmount;
    private System.Windows.Forms.Label lblDate;
    private System.Windows.Forms.DateTimePicker dtpDate;
    private System.Windows.Forms.Label lblTransaction;
    private System.Windows.Forms.TextBox txtTransaction;
    private System.Windows.Forms.Label lblMethod;
    private System.Windows.Forms.ComboBox cmbMethod;
}
