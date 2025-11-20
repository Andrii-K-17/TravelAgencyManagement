namespace App.Presentation.WinForms.Views;

partial class EmployeesView
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
        DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
        splitContainer1 = new SplitContainer();
        dgvEmployees = new DataGridView();
        groupBox1 = new GroupBox();
        tableLayoutPanel1 = new TableLayoutPanel();
        label1 = new Label();
        label2 = new Label();
        txtLastName = new TextBox();
        label3 = new Label();
        txtPosition = new TextBox();
        label4 = new Label();
        txtPhone = new TextBox();
        label5 = new Label();
        txtEmail = new TextBox();
        label6 = new Label();
        dtpHireDate = new DateTimePicker();
        label7 = new Label();
        numSalary = new NumericUpDown();
        txtFirstName = new TextBox();
        flpButtons = new FlowLayoutPanel();
        btnDelete = new Button();
        btnUpdate = new Button();
        ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
        splitContainer1.Panel1.SuspendLayout();
        splitContainer1.Panel2.SuspendLayout();
        splitContainer1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvEmployees).BeginInit();
        groupBox1.SuspendLayout();
        tableLayoutPanel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numSalary).BeginInit();
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
        splitContainer1.Panel1.Controls.Add(dgvEmployees);
        splitContainer1.Panel1.Padding = new Padding(10, 10, 10, 5);
        // 
        // splitContainer1.Panel2
        // 
        splitContainer1.Panel2.Controls.Add(groupBox1);
        splitContainer1.Panel2.Padding = new Padding(10, 5, 10, 10);
        splitContainer1.Size = new Size(1021, 700);
        splitContainer1.SplitterDistance = 258;
        splitContainer1.SplitterWidth = 6;
        splitContainer1.TabIndex = 0;
        // 
        // dgvEmployees
        // 
        dgvEmployees.AllowUserToAddRows = false;
        dgvEmployees.AllowUserToDeleteRows = false;
        dgvEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvEmployees.BackgroundColor = Color.FromArgb(255, 255, 255);
        dgvEmployees.BorderStyle = BorderStyle.None;
        dgvEmployees.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
        dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 249, 250);
        dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        dataGridViewCellStyle1.ForeColor = Color.FromArgb(30, 30, 30);
        dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(248, 249, 250);
        dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(30, 30, 30);
        dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
        dgvEmployees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
        dgvEmployees.ColumnHeadersHeight = 40;
        dgvEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = Color.White;
        dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
        dataGridViewCellStyle2.ForeColor = Color.FromArgb(50, 50, 50);
        dataGridViewCellStyle2.SelectionBackColor = Color.Teal;
        dataGridViewCellStyle2.SelectionForeColor = Color.White;
        dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
        dgvEmployees.DefaultCellStyle = dataGridViewCellStyle2;
        dgvEmployees.Dock = DockStyle.Fill;
        dgvEmployees.EnableHeadersVisualStyles = false;
        dgvEmployees.GridColor = Color.FromArgb(222, 226, 230);
        dgvEmployees.Location = new Point(10, 10);
        dgvEmployees.Margin = new Padding(4, 5, 4, 5);
        dgvEmployees.MultiSelect = false;
        dgvEmployees.Name = "dgvEmployees";
        dgvEmployees.ReadOnly = true;
        dgvEmployees.RowHeadersVisible = false;
        dgvEmployees.RowHeadersWidth = 51;
        dgvEmployees.RowTemplate.Height = 35;
        dgvEmployees.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvEmployees.Size = new Size(1001, 243);
        dgvEmployees.TabIndex = 0;
        dgvEmployees.SelectionChanged += dgvEmployees_SelectionChanged;
        // 
        // groupBox1
        // 
        groupBox1.BackColor = Color.White;
        groupBox1.Controls.Add(tableLayoutPanel1);
        groupBox1.Controls.Add(flpButtons);
        groupBox1.Dock = DockStyle.Fill;
        groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        groupBox1.Location = new Point(10, 5);
        groupBox1.Margin = new Padding(4, 5, 4, 5);
        groupBox1.Name = "groupBox1";
        groupBox1.Padding = new Padding(10);
        groupBox1.Size = new Size(1001, 421);
        groupBox1.TabIndex = 0;
        groupBox1.TabStop = false;
        groupBox1.Text = "Employee details";
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.BackColor = Color.Transparent;
        tableLayoutPanel1.ColumnCount = 2;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tableLayoutPanel1.Controls.Add(label1, 0, 0);
        tableLayoutPanel1.Controls.Add(label2, 0, 1);
        tableLayoutPanel1.Controls.Add(txtLastName, 1, 1);
        tableLayoutPanel1.Controls.Add(label3, 0, 2);
        tableLayoutPanel1.Controls.Add(txtPosition, 1, 2);
        tableLayoutPanel1.Controls.Add(label4, 0, 3);
        tableLayoutPanel1.Controls.Add(txtPhone, 1, 3);
        tableLayoutPanel1.Controls.Add(label5, 0, 4);
        tableLayoutPanel1.Controls.Add(txtEmail, 1, 4);
        tableLayoutPanel1.Controls.Add(label6, 0, 5);
        tableLayoutPanel1.Controls.Add(dtpHireDate, 1, 5);
        tableLayoutPanel1.Controls.Add(label7, 0, 6);
        tableLayoutPanel1.Controls.Add(numSalary, 1, 6);
        tableLayoutPanel1.Controls.Add(txtFirstName, 1, 0);
        tableLayoutPanel1.Dock = DockStyle.Fill;
        tableLayoutPanel1.Font = new Font("Segoe UI", 10F);
        tableLayoutPanel1.Location = new Point(10, 34);
        tableLayoutPanel1.Margin = new Padding(4, 5, 4, 5);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.Padding = new Padding(0, 0, 10, 0);
        tableLayoutPanel1.RowCount = 7;
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.28571F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.28571F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.28571F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.28571F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.28571F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.28571F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.28571F));
        tableLayoutPanel1.Size = new Size(981, 310);
        tableLayoutPanel1.TabIndex = 0;
        // 
        // label1
        // 
        label1.Anchor = AnchorStyles.Left;
        label1.AutoSize = true;
        label1.ForeColor = Color.FromArgb(80, 80, 80);
        label1.Location = new Point(4, 8);
        label1.Margin = new Padding(4, 0, 4, 0);
        label1.Name = "label1";
        label1.Size = new Size(106, 28);
        label1.TabIndex = 0;
        label1.Text = "First name:";
        label1.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // label2
        // 
        label2.Anchor = AnchorStyles.Left;
        label2.AutoSize = true;
        label2.ForeColor = Color.FromArgb(80, 80, 80);
        label2.Location = new Point(4, 52);
        label2.Margin = new Padding(4, 0, 4, 0);
        label2.Name = "label2";
        label2.Size = new Size(103, 28);
        label2.TabIndex = 2;
        label2.Text = "Last name:";
        label2.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // txtLastName
        // 
        txtLastName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        txtLastName.Font = new Font("Segoe UI", 12F);
        txtLastName.Location = new Point(154, 49);
        txtLastName.Margin = new Padding(4, 5, 4, 5);
        txtLastName.Name = "txtLastName";
        txtLastName.Size = new Size(813, 39);
        txtLastName.TabIndex = 3;
        // 
        // label3
        // 
        label3.Anchor = AnchorStyles.Left;
        label3.AutoSize = true;
        label3.ForeColor = Color.FromArgb(80, 80, 80);
        label3.Location = new Point(4, 96);
        label3.Margin = new Padding(4, 0, 4, 0);
        label3.Name = "label3";
        label3.Size = new Size(86, 28);
        label3.TabIndex = 4;
        label3.Text = "Position:";
        label3.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // txtPosition
        // 
        txtPosition.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        txtPosition.Font = new Font("Segoe UI", 12F);
        txtPosition.Location = new Point(154, 93);
        txtPosition.Margin = new Padding(4, 5, 4, 5);
        txtPosition.Name = "txtPosition";
        txtPosition.Size = new Size(813, 39);
        txtPosition.TabIndex = 5;
        // 
        // label4
        // 
        label4.Anchor = AnchorStyles.Left;
        label4.AutoSize = true;
        label4.ForeColor = Color.FromArgb(80, 80, 80);
        label4.Location = new Point(4, 140);
        label4.Margin = new Padding(4, 0, 4, 0);
        label4.Name = "label4";
        label4.Size = new Size(71, 28);
        label4.TabIndex = 6;
        label4.Text = "Phone:";
        label4.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // txtPhone
        // 
        txtPhone.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        txtPhone.Font = new Font("Segoe UI", 12F);
        txtPhone.Location = new Point(154, 137);
        txtPhone.Margin = new Padding(4, 5, 4, 5);
        txtPhone.Name = "txtPhone";
        txtPhone.Size = new Size(813, 39);
        txtPhone.TabIndex = 7;
        // 
        // label5
        // 
        label5.Anchor = AnchorStyles.Left;
        label5.AutoSize = true;
        label5.ForeColor = Color.FromArgb(80, 80, 80);
        label5.Location = new Point(4, 184);
        label5.Margin = new Padding(4, 0, 4, 0);
        label5.Name = "label5";
        label5.Size = new Size(63, 28);
        label5.TabIndex = 8;
        label5.Text = "Email:";
        label5.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // txtEmail
        // 
        txtEmail.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        txtEmail.Font = new Font("Segoe UI", 12F);
        txtEmail.Location = new Point(154, 181);
        txtEmail.Margin = new Padding(4, 5, 4, 5);
        txtEmail.Name = "txtEmail";
        txtEmail.Size = new Size(813, 39);
        txtEmail.TabIndex = 9;
        // 
        // label6
        // 
        label6.Anchor = AnchorStyles.Left;
        label6.AutoSize = true;
        label6.ForeColor = Color.FromArgb(80, 80, 80);
        label6.Location = new Point(4, 228);
        label6.Margin = new Padding(4, 0, 4, 0);
        label6.Name = "label6";
        label6.Size = new Size(96, 28);
        label6.TabIndex = 10;
        label6.Text = "Hire date:";
        label6.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // dtpHireDate
        // 
        dtpHireDate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        dtpHireDate.Font = new Font("Segoe UI", 12F);
        dtpHireDate.Format = DateTimePickerFormat.Short;
        dtpHireDate.Location = new Point(154, 225);
        dtpHireDate.Margin = new Padding(4, 5, 4, 5);
        dtpHireDate.Name = "dtpHireDate";
        dtpHireDate.Size = new Size(813, 39);
        dtpHireDate.TabIndex = 11;
        // 
        // label7
        // 
        label7.Anchor = AnchorStyles.Left;
        label7.AutoSize = true;
        label7.ForeColor = Color.FromArgb(80, 80, 80);
        label7.Location = new Point(4, 273);
        label7.Margin = new Padding(4, 0, 4, 0);
        label7.Name = "label7";
        label7.Size = new Size(69, 28);
        label7.TabIndex = 12;
        label7.Text = "Salary:";
        label7.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // numSalary
        // 
        numSalary.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        numSalary.DecimalPlaces = 2;
        numSalary.Font = new Font("Segoe UI", 12F);
        numSalary.Location = new Point(154, 269);
        numSalary.Margin = new Padding(4, 5, 4, 5);
        numSalary.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
        numSalary.Name = "numSalary";
        numSalary.Size = new Size(813, 39);
        numSalary.TabIndex = 13;
        // 
        // txtFirstName
        // 
        txtFirstName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        txtFirstName.Font = new Font("Segoe UI", 12F);
        txtFirstName.Location = new Point(154, 5);
        txtFirstName.Margin = new Padding(4, 5, 4, 5);
        txtFirstName.Name = "txtFirstName";
        txtFirstName.Size = new Size(813, 39);
        txtFirstName.TabIndex = 1;
        // 
        // flpButtons
        // 
        flpButtons.BackColor = Color.FromArgb(248, 249, 250);
        flpButtons.Controls.Add(btnDelete);
        flpButtons.Controls.Add(btnUpdate);
        flpButtons.Dock = DockStyle.Bottom;
        flpButtons.FlowDirection = FlowDirection.RightToLeft;
        flpButtons.Location = new Point(10, 344);
        flpButtons.Margin = new Padding(4, 5, 4, 5);
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
        btnDelete.TabIndex = 2;
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
        // EmployeesView
        // 
        AutoScaleDimensions = new SizeF(11F, 28F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(1021, 700);
        Controls.Add(splitContainer1);
        Font = new Font("Segoe UI", 10F);
        FormBorderStyle = FormBorderStyle.None;
        Margin = new Padding(4, 5, 4, 5);
        MinimumSize = new Size(800, 700);
        Name = "EmployeesView";
        ShowIcon = false;
        Text = "Employees management";
        Load += EmployeesView_Load;
        splitContainer1.Panel1.ResumeLayout(false);
        splitContainer1.Panel2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
        splitContainer1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvEmployees).EndInit();
        groupBox1.ResumeLayout(false);
        tableLayoutPanel1.ResumeLayout(false);
        tableLayoutPanel1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)numSalary).EndInit();
        flpButtons.ResumeLayout(false);
        ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.SplitContainer splitContainer1;
    private System.Windows.Forms.DataGridView dgvEmployees;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.FlowLayoutPanel flpButtons;
    private System.Windows.Forms.Button btnUpdate;
    private System.Windows.Forms.Button btnDelete;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtFirstName;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtLastName;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtPosition;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox txtPhone;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox txtEmail;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.DateTimePicker dtpHireDate;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.NumericUpDown numSalary;
}
