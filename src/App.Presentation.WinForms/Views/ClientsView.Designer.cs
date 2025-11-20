namespace App.Presentation.WinForms.Views;

partial class ClientsView
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
        DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientsView));
        dgvClients = new DataGridView();
        btnDelete = new Button();
        btnSave = new Button();
        txtPhone = new TextBox();
        txtLastName = new TextBox();
        txtFirstName = new TextBox();
        label4 = new Label();
        label3 = new Label();
        label2 = new Label();
        label1 = new Label();
        txtEmail = new TextBox();
        splitContainer1 = new SplitContainer();
        groupBox1 = new GroupBox();
        tableLayoutPanel1 = new TableLayoutPanel();
        txtIssuingCountry = new TextBox();
        label8 = new Label();
        dtpExpiryDate = new DateTimePicker();
        label7 = new Label();
        dtpIssueDate = new DateTimePicker();
        txtPassportNumber = new TextBox();
        label5 = new Label();
        label6 = new Label();
        flpButtons = new FlowLayoutPanel();
        ((System.ComponentModel.ISupportInitialize)dgvClients).BeginInit();
        ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
        splitContainer1.Panel1.SuspendLayout();
        splitContainer1.Panel2.SuspendLayout();
        splitContainer1.SuspendLayout();
        groupBox1.SuspendLayout();
        tableLayoutPanel1.SuspendLayout();
        flpButtons.SuspendLayout();
        SuspendLayout();
        // 
        // dgvClients
        // 
        dgvClients.AllowUserToAddRows = false;
        dgvClients.AllowUserToDeleteRows = false;
        dgvClients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvClients.BackgroundColor = Color.FromArgb(255, 255, 255);
        dgvClients.BorderStyle = BorderStyle.None;
        dgvClients.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
        dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 249, 250);
        dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        dataGridViewCellStyle1.ForeColor = Color.FromArgb(30, 30, 30);
        dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(248, 249, 250);
        dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(30, 30, 30);
        dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
        dgvClients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
        dgvClients.ColumnHeadersHeight = 40;
        dgvClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = Color.White;
        dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
        dataGridViewCellStyle2.ForeColor = Color.FromArgb(30, 30, 30);
        dataGridViewCellStyle2.SelectionBackColor = Color.Teal;
        dataGridViewCellStyle2.SelectionForeColor = Color.White;
        dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
        dgvClients.DefaultCellStyle = dataGridViewCellStyle2;
        dgvClients.Dock = DockStyle.Fill;
        dgvClients.EnableHeadersVisualStyles = false;
        dgvClients.GridColor = Color.FromArgb(222, 226, 230);
        dgvClients.Location = new Point(10, 10);
        dgvClients.Name = "dgvClients";
        dgvClients.ReadOnly = true;
        dgvClients.RowHeadersVisible = false;
        dgvClients.RowHeadersWidth = 62;
        dgvClients.RowTemplate.Height = 35;
        dgvClients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvClients.Size = new Size(1001, 335);
        dgvClients.TabIndex = 0;
        // 
        // btnDelete
        // 
        btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnDelete.BackColor = Color.Firebrick;
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
        // btnSave
        // 
        btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnSave.BackColor = Color.Teal;
        btnSave.FlatAppearance.BorderSize = 0;
        btnSave.FlatStyle = FlatStyle.Flat;
        btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        btnSave.ForeColor = Color.White;
        btnSave.Location = new Point(681, 10);
        btnSave.Margin = new Padding(10);
        btnSave.Name = "btnSave";
        btnSave.Size = new Size(130, 45);
        btnSave.TabIndex = 1;
        btnSave.Text = "Save";
        btnSave.UseVisualStyleBackColor = false;
        btnSave.Click += btnSave_Click;
        // 
        // txtPhone
        // 
        txtPhone.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        txtPhone.BackColor = Color.White;
        txtPhone.Font = new Font("Segoe UI", 12F);
        txtPhone.ForeColor = Color.FromArgb(30, 30, 30);
        txtPhone.Location = new Point(165, 148);
        txtPhone.Name = "txtPhone";
        txtPhone.Size = new Size(317, 39);
        txtPhone.TabIndex = 2;
        // 
        // txtLastName
        // 
        txtLastName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        txtLastName.BackColor = Color.White;
        txtLastName.Font = new Font("Segoe UI", 12F);
        txtLastName.ForeColor = Color.FromArgb(30, 30, 30);
        txtLastName.Location = new Point(165, 81);
        txtLastName.Name = "txtLastName";
        txtLastName.Size = new Size(317, 39);
        txtLastName.TabIndex = 1;
        // 
        // txtFirstName
        // 
        txtFirstName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        txtFirstName.BackColor = Color.White;
        txtFirstName.Font = new Font("Segoe UI", 12F);
        txtFirstName.ForeColor = Color.FromArgb(30, 30, 30);
        txtFirstName.Location = new Point(165, 14);
        txtFirstName.Name = "txtFirstName";
        txtFirstName.Size = new Size(317, 39);
        txtFirstName.TabIndex = 0;
        // 
        // label4
        // 
        label4.Anchor = AnchorStyles.Left;
        label4.AutoSize = true;
        label4.Font = new Font("Segoe UI", 10F);
        label4.ForeColor = Color.FromArgb(80, 80, 80);
        label4.Location = new Point(3, 220);
        label4.Name = "label4";
        label4.Size = new Size(63, 28);
        label4.TabIndex = 3;
        label4.Text = "Email:";
        label4.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // label3
        // 
        label3.Anchor = AnchorStyles.Left;
        label3.AutoSize = true;
        label3.Font = new Font("Segoe UI", 10F);
        label3.ForeColor = Color.FromArgb(80, 80, 80);
        label3.Location = new Point(3, 153);
        label3.Name = "label3";
        label3.Size = new Size(71, 28);
        label3.TabIndex = 2;
        label3.Text = "Phone:";
        label3.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // label2
        // 
        label2.Anchor = AnchorStyles.Left;
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI", 10F);
        label2.ForeColor = Color.FromArgb(80, 80, 80);
        label2.Location = new Point(3, 86);
        label2.Name = "label2";
        label2.Size = new Size(103, 28);
        label2.TabIndex = 1;
        label2.Text = "Last name:";
        label2.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // label1
        // 
        label1.Anchor = AnchorStyles.Left;
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 10F);
        label1.ForeColor = Color.FromArgb(80, 80, 80);
        label1.Location = new Point(3, 19);
        label1.Name = "label1";
        label1.Size = new Size(106, 28);
        label1.TabIndex = 0;
        label1.Text = "First name:";
        label1.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // txtEmail
        // 
        txtEmail.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        txtEmail.BackColor = Color.White;
        txtEmail.Font = new Font("Segoe UI", 12F);
        txtEmail.ForeColor = Color.FromArgb(30, 30, 30);
        txtEmail.Location = new Point(165, 215);
        txtEmail.Name = "txtEmail";
        txtEmail.Size = new Size(317, 39);
        txtEmail.TabIndex = 3;
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
        splitContainer1.Panel1.Controls.Add(dgvClients);
        splitContainer1.Panel1.Padding = new Padding(10, 10, 10, 5);
        // 
        // splitContainer1.Panel2
        // 
        splitContainer1.Panel2.Controls.Add(groupBox1);
        splitContainer1.Panel2.Padding = new Padding(10, 5, 10, 10);
        splitContainer1.Size = new Size(1021, 750);
        splitContainer1.SplitterDistance = 350;
        splitContainer1.SplitterWidth = 6;
        splitContainer1.TabIndex = 7;
        // 
        // groupBox1
        // 
        groupBox1.BackColor = Color.FromArgb(255, 255, 255);
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
        groupBox1.Text = "Client and passport details";
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.BackColor = Color.Transparent;
        tableLayoutPanel1.ColumnCount = 4;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 162F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 162F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tableLayoutPanel1.Controls.Add(txtIssuingCountry, 3, 3);
        tableLayoutPanel1.Controls.Add(label8, 2, 3);
        tableLayoutPanel1.Controls.Add(dtpExpiryDate, 3, 2);
        tableLayoutPanel1.Controls.Add(label7, 2, 2);
        tableLayoutPanel1.Controls.Add(dtpIssueDate, 3, 1);
        tableLayoutPanel1.Controls.Add(txtPassportNumber, 3, 0);
        tableLayoutPanel1.Controls.Add(txtEmail, 1, 3);
        tableLayoutPanel1.Controls.Add(txtFirstName, 1, 0);
        tableLayoutPanel1.Controls.Add(txtLastName, 1, 1);
        tableLayoutPanel1.Controls.Add(label4, 0, 3);
        tableLayoutPanel1.Controls.Add(label3, 0, 2);
        tableLayoutPanel1.Controls.Add(label2, 0, 1);
        tableLayoutPanel1.Controls.Add(label1, 0, 0);
        tableLayoutPanel1.Controls.Add(txtPhone, 1, 2);
        tableLayoutPanel1.Controls.Add(label6, 2, 1);
        tableLayoutPanel1.Controls.Add(label5, 2, 0);
        tableLayoutPanel1.Dock = DockStyle.Fill;
        tableLayoutPanel1.Location = new Point(10, 34);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.Padding = new Padding(0, 0, 10, 0);
        tableLayoutPanel1.RowCount = 4;
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
        tableLayoutPanel1.Size = new Size(981, 268);
        tableLayoutPanel1.TabIndex = 0;
        // 
        // txtIssuingCountry
        // 
        txtIssuingCountry.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        txtIssuingCountry.BackColor = Color.White;
        txtIssuingCountry.Font = new Font("Segoe UI", 12F);
        txtIssuingCountry.ForeColor = Color.FromArgb(30, 30, 30);
        txtIssuingCountry.Location = new Point(650, 215);
        txtIssuingCountry.Name = "txtIssuingCountry";
        txtIssuingCountry.Size = new Size(318, 39);
        txtIssuingCountry.TabIndex = 7;
        // 
        // label8
        // 
        label8.Anchor = AnchorStyles.Left;
        label8.AutoSize = true;
        label8.Font = new Font("Segoe UI", 10F);
        label8.ForeColor = Color.FromArgb(80, 80, 80);
        label8.Location = new Point(488, 220);
        label8.Name = "label8";
        label8.Size = new Size(148, 28);
        label8.TabIndex = 7;
        label8.Text = "Issuing country:";
        label8.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // dtpExpiryDate
        // 
        dtpExpiryDate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        dtpExpiryDate.Font = new Font("Segoe UI", 12F);
        dtpExpiryDate.Format = DateTimePickerFormat.Short;
        dtpExpiryDate.Location = new Point(650, 148);
        dtpExpiryDate.Name = "dtpExpiryDate";
        dtpExpiryDate.Size = new Size(318, 39);
        dtpExpiryDate.TabIndex = 6;
        // 
        // label7
        // 
        label7.Anchor = AnchorStyles.Left;
        label7.AutoSize = true;
        label7.Font = new Font("Segoe UI", 10F);
        label7.ForeColor = Color.FromArgb(80, 80, 80);
        label7.Location = new Point(488, 153);
        label7.Name = "label7";
        label7.Size = new Size(113, 28);
        label7.TabIndex = 6;
        label7.Text = "Expiry date:";
        label7.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // dtpIssueDate
        // 
        dtpIssueDate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        dtpIssueDate.Font = new Font("Segoe UI", 12F);
        dtpIssueDate.Format = DateTimePickerFormat.Short;
        dtpIssueDate.Location = new Point(650, 81);
        dtpIssueDate.Name = "dtpIssueDate";
        dtpIssueDate.Size = new Size(318, 39);
        dtpIssueDate.TabIndex = 5;
        // 
        // txtPassportNumber
        // 
        txtPassportNumber.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        txtPassportNumber.BackColor = Color.White;
        txtPassportNumber.Font = new Font("Segoe UI", 12F);
        txtPassportNumber.ForeColor = Color.FromArgb(30, 30, 30);
        txtPassportNumber.Location = new Point(650, 14);
        txtPassportNumber.Name = "txtPassportNumber";
        txtPassportNumber.Size = new Size(318, 39);
        txtPassportNumber.TabIndex = 4;
        // 
        // label5
        // 
        label5.Anchor = AnchorStyles.Left;
        label5.AutoSize = true;
        label5.Font = new Font("Segoe UI", 10F);
        label5.ForeColor = Color.FromArgb(80, 80, 80);
        label5.Location = new Point(488, 5);
        label5.Name = "label5";
        label5.RightToLeft = RightToLeft.No;
        label5.Size = new Size(91, 56);
        label5.TabIndex = 4;
        label5.Text = "Passport number:";
        label5.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // label6
        // 
        label6.Anchor = AnchorStyles.Left;
        label6.AutoSize = true;
        label6.Font = new Font("Segoe UI", 10F);
        label6.ForeColor = Color.FromArgb(80, 80, 80);
        label6.Location = new Point(488, 86);
        label6.Name = "label6";
        label6.Size = new Size(102, 28);
        label6.TabIndex = 5;
        label6.Text = "Issue date:";
        label6.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // flpButtons
        // 
        flpButtons.BackColor = Color.FromArgb(248, 249, 250);
        flpButtons.Controls.Add(btnDelete);
        flpButtons.Controls.Add(btnSave);
        flpButtons.Dock = DockStyle.Bottom;
        flpButtons.FlowDirection = FlowDirection.RightToLeft;
        flpButtons.Location = new Point(10, 302);
        flpButtons.Name = "flpButtons";
        flpButtons.Padding = new Padding(0, 0, 10, 0);
        flpButtons.Size = new Size(981, 67);
        flpButtons.TabIndex = 1;
        // 
        // ClientsView
        // 
        AutoScaleDimensions = new SizeF(11F, 28F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(255, 255, 255);
        ClientSize = new Size(1021, 750);
        Controls.Add(splitContainer1);
        Font = new Font("Segoe UI", 10F);
        ForeColor = Color.FromArgb(30, 30, 30);
        FormBorderStyle = FormBorderStyle.None;
        Icon = (Icon)resources.GetObject("$this.Icon");
        MinimumSize = new Size(800, 750);
        Name = "ClientsView";
        ShowIcon = false;
        Text = "Clients and Passport Management";
        Load += ClientsView_Load;
        ((System.ComponentModel.ISupportInitialize)dgvClients).EndInit();
        splitContainer1.Panel1.ResumeLayout(false);
        splitContainer1.Panel2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
        splitContainer1.ResumeLayout(false);
        groupBox1.ResumeLayout(false);
        tableLayoutPanel1.ResumeLayout(false);
        tableLayoutPanel1.PerformLayout();
        flpButtons.ResumeLayout(false);
        ResumeLayout(false);

    }

    #endregion

    private DataGridView dgvClients;
    private Label label4;
    private Label label3;
    private Label label2;
    private Label label1;
    private TextBox txtFirstName;
    private TextBox txtPhone;
    private TextBox txtLastName;
    private TextBox txtEmail;
    private Button btnDelete;
    private Button btnSave;
    private SplitContainer splitContainer1;
    private GroupBox groupBox1;
    private TableLayoutPanel tableLayoutPanel1;
    private FlowLayoutPanel flpButtons;
    private Label label5;
    private TextBox txtPassportNumber;
    private Label label6;
    private DateTimePicker dtpIssueDate;
    private Label label7;
    private DateTimePicker dtpExpiryDate;
    private Label label8;
    private TextBox txtIssuingCountry;
}
