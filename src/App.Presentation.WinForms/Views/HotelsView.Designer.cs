namespace App.Presentation.WinForms.Views;

partial class HotelsView
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
        dgvHotels = new DataGridView();
        groupBox1 = new GroupBox();
        tableLayoutPanel1 = new TableLayoutPanel();
        lblTour = new Label();
        cmbTour = new ComboBox();
        lblHotelName = new Label();
        txtHotelName = new TextBox();
        lblLocation = new Label();
        txtLocation = new TextBox();
        lblStars = new Label();
        numStars = new NumericUpDown();
        lblPhone = new Label();
        txtPhone = new TextBox();
        lblEmail = new Label();
        txtEmail = new TextBox();
        flpButtons = new FlowLayoutPanel();
        btnDelete = new Button();
        btnUpdate = new Button();
        ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
        splitContainer1.Panel1.SuspendLayout();
        splitContainer1.Panel2.SuspendLayout();
        splitContainer1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvHotels).BeginInit();
        groupBox1.SuspendLayout();
        tableLayoutPanel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numStars).BeginInit();
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
        splitContainer1.Panel1.Controls.Add(dgvHotels);
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
        // dgvHotels
        // 
        dgvHotels.AllowUserToAddRows = false;
        dgvHotels.AllowUserToDeleteRows = false;
        dgvHotels.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvHotels.BackgroundColor = Color.White;
        dgvHotels.BorderStyle = BorderStyle.None;
        dgvHotels.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
        dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 249, 250);
        dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        dataGridViewCellStyle1.ForeColor = Color.FromArgb(30, 30, 30);
        dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(248, 249, 250);
        dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(30, 30, 30);
        dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
        dgvHotels.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
        dgvHotels.ColumnHeadersHeight = 40;
        dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = Color.White;
        dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
        dataGridViewCellStyle2.ForeColor = Color.FromArgb(50, 50, 50);
        dataGridViewCellStyle2.NullValue = null;
        dataGridViewCellStyle2.SelectionBackColor = Color.Teal;
        dataGridViewCellStyle2.SelectionForeColor = Color.White;
        dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
        dgvHotels.DefaultCellStyle = dataGridViewCellStyle2;
        dgvHotels.Dock = DockStyle.Fill;
        dgvHotels.EnableHeadersVisualStyles = false;
        dgvHotels.GridColor = Color.FromArgb(222, 226, 230);
        dgvHotels.Location = new Point(10, 10);
        dgvHotels.MultiSelect = false;
        dgvHotels.Name = "dgvHotels";
        dgvHotels.ReadOnly = true;
        dgvHotels.RowHeadersVisible = false;
        dgvHotels.RowHeadersWidth = 62;
        dgvHotels.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvHotels.Size = new Size(1001, 285);
        dgvHotels.TabIndex = 0;
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
        groupBox1.Text = "Hotel details";
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.BackColor = Color.Transparent;
        tableLayoutPanel1.ColumnCount = 2;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tableLayoutPanel1.Controls.Add(lblTour, 0, 0);
        tableLayoutPanel1.Controls.Add(cmbTour, 1, 0);
        tableLayoutPanel1.Controls.Add(lblHotelName, 0, 1);
        tableLayoutPanel1.Controls.Add(txtHotelName, 1, 1);
        tableLayoutPanel1.Controls.Add(lblLocation, 0, 2);
        tableLayoutPanel1.Controls.Add(txtLocation, 1, 2);
        tableLayoutPanel1.Controls.Add(lblStars, 0, 3);
        tableLayoutPanel1.Controls.Add(numStars, 1, 3);
        tableLayoutPanel1.Controls.Add(lblPhone, 0, 4);
        tableLayoutPanel1.Controls.Add(txtPhone, 1, 4);
        tableLayoutPanel1.Controls.Add(lblEmail, 0, 5);
        tableLayoutPanel1.Controls.Add(txtEmail, 1, 5);
        tableLayoutPanel1.Dock = DockStyle.Fill;
        tableLayoutPanel1.Font = new Font("Segoe UI", 10F);
        tableLayoutPanel1.Location = new Point(10, 34);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 6;
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6F));
        tableLayoutPanel1.Size = new Size(981, 268);
        tableLayoutPanel1.TabIndex = 0;
        // 
        // lblTour
        // 
        lblTour.Anchor = AnchorStyles.Left;
        lblTour.ForeColor = Color.FromArgb(80, 80, 80);
        lblTour.Location = new Point(3, 6);
        lblTour.Name = "lblTour";
        lblTour.Size = new Size(144, 31);
        lblTour.TabIndex = 0;
        lblTour.Text = "Select tour:";
        // 
        // cmbTour
        // 
        cmbTour.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        cmbTour.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbTour.Font = new Font("Segoe UI", 11F);
        cmbTour.Location = new Point(153, 3);
        cmbTour.Name = "cmbTour";
        cmbTour.Size = new Size(825, 38);
        cmbTour.TabIndex = 1;
        // 
        // lblHotelName
        // 
        lblHotelName.Anchor = AnchorStyles.Left;
        lblHotelName.ForeColor = Color.FromArgb(80, 80, 80);
        lblHotelName.Location = new Point(3, 51);
        lblHotelName.Name = "lblHotelName";
        lblHotelName.Size = new Size(144, 30);
        lblHotelName.TabIndex = 2;
        lblHotelName.Text = "Hotel name:";
        // 
        // txtHotelName
        // 
        txtHotelName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        txtHotelName.Font = new Font("Segoe UI", 11F);
        txtHotelName.Location = new Point(153, 47);
        txtHotelName.Name = "txtHotelName";
        txtHotelName.Size = new Size(825, 37);
        txtHotelName.TabIndex = 3;
        // 
        // lblLocation
        // 
        lblLocation.Anchor = AnchorStyles.Left;
        lblLocation.ForeColor = Color.FromArgb(80, 80, 80);
        lblLocation.Location = new Point(3, 98);
        lblLocation.Name = "lblLocation";
        lblLocation.Size = new Size(100, 23);
        lblLocation.TabIndex = 4;
        lblLocation.Text = "Location:";
        // 
        // txtLocation
        // 
        txtLocation.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        txtLocation.Font = new Font("Segoe UI", 11F);
        txtLocation.Location = new Point(153, 91);
        txtLocation.Name = "txtLocation";
        txtLocation.Size = new Size(825, 37);
        txtLocation.TabIndex = 5;
        // 
        // lblStars
        // 
        lblStars.Anchor = AnchorStyles.Left;
        lblStars.ForeColor = Color.FromArgb(80, 80, 80);
        lblStars.Location = new Point(3, 139);
        lblStars.Name = "lblStars";
        lblStars.Size = new Size(144, 30);
        lblStars.TabIndex = 6;
        lblStars.Text = "Stars (1-5):";
        // 
        // numStars
        // 
        numStars.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        numStars.Font = new Font("Segoe UI", 11F);
        numStars.Location = new Point(153, 135);
        numStars.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
        numStars.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        numStars.Name = "numStars";
        numStars.Size = new Size(825, 37);
        numStars.TabIndex = 7;
        numStars.Value = new decimal(new int[] { 3, 0, 0, 0 });
        // 
        // lblPhone
        // 
        lblPhone.Anchor = AnchorStyles.Left;
        lblPhone.ForeColor = Color.FromArgb(80, 80, 80);
        lblPhone.Location = new Point(3, 183);
        lblPhone.Name = "lblPhone";
        lblPhone.Size = new Size(100, 30);
        lblPhone.TabIndex = 8;
        lblPhone.Text = "Phone:";
        // 
        // txtPhone
        // 
        txtPhone.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        txtPhone.Font = new Font("Segoe UI", 11F);
        txtPhone.Location = new Point(153, 179);
        txtPhone.Name = "txtPhone";
        txtPhone.Size = new Size(825, 37);
        txtPhone.TabIndex = 9;
        // 
        // lblEmail
        // 
        lblEmail.Anchor = AnchorStyles.Left;
        lblEmail.ForeColor = Color.FromArgb(80, 80, 80);
        lblEmail.Location = new Point(3, 227);
        lblEmail.Name = "lblEmail";
        lblEmail.Size = new Size(100, 33);
        lblEmail.TabIndex = 10;
        lblEmail.Text = "Email:";
        // 
        // txtEmail
        // 
        txtEmail.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        txtEmail.Font = new Font("Segoe UI", 11F);
        txtEmail.Location = new Point(153, 225);
        txtEmail.Name = "txtEmail";
        txtEmail.Size = new Size(825, 37);
        txtEmail.TabIndex = 11;
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
        // HotelsView
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(1021, 700);
        Controls.Add(splitContainer1);
        FormBorderStyle = FormBorderStyle.None;
        Name = "HotelsView";
        ShowIcon = false;
        Text = "Hotels management";
        Load += HotelsView_Load;
        splitContainer1.Panel1.ResumeLayout(false);
        splitContainer1.Panel2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
        splitContainer1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvHotels).EndInit();
        groupBox1.ResumeLayout(false);
        tableLayoutPanel1.ResumeLayout(false);
        tableLayoutPanel1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)numStars).EndInit();
        flpButtons.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.SplitContainer splitContainer1;
    private System.Windows.Forms.DataGridView dgvHotels;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.FlowLayoutPanel flpButtons;
    private System.Windows.Forms.Button btnUpdate;
    private System.Windows.Forms.Button btnDelete;
    private System.Windows.Forms.Label lblTour;
    private System.Windows.Forms.ComboBox cmbTour;
    private System.Windows.Forms.Label lblHotelName;
    private System.Windows.Forms.TextBox txtHotelName;
    private System.Windows.Forms.Label lblLocation;
    private System.Windows.Forms.TextBox txtLocation;
    private System.Windows.Forms.Label lblStars;
    private System.Windows.Forms.NumericUpDown numStars;
    private System.Windows.Forms.Label lblPhone;
    private System.Windows.Forms.TextBox txtPhone;
    private System.Windows.Forms.Label lblEmail;
    private System.Windows.Forms.TextBox txtEmail;
}
