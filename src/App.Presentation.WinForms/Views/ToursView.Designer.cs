namespace App.Presentation.WinForms.Views
{
    partial class ToursView
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
            dgvTours = new DataGridView();
            groupBox1 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblTourName = new Label();
            txtTourName = new TextBox();
            lblDestination = new Label();
            txtDestination = new TextBox();
            lblStartDate = new Label();
            dtpStartDate = new DateTimePicker();
            lblEndDate = new Label();
            dtpEndDate = new DateTimePicker();
            lblPrice = new Label();
            numPrice = new NumericUpDown();
            flpButtons = new FlowLayoutPanel();
            btnDelete = new Button();
            btnUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTours).BeginInit();
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
            splitContainer1.Panel1.Controls.Add(dgvTours);
            splitContainer1.Panel1.Padding = new Padding(10, 10, 10, 5);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(groupBox1);
            splitContainer1.Panel2.Padding = new Padding(10, 5, 10, 10);
            splitContainer1.Size = new Size(1021, 700);
            splitContainer1.SplitterDistance = 318;
            splitContainer1.SplitterWidth = 6;
            splitContainer1.TabIndex = 0;
            // 
            // dgvTours
            // 
            dgvTours.AllowUserToAddRows = false;
            dgvTours.AllowUserToDeleteRows = false;
            dgvTours.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTours.BackgroundColor = Color.FromArgb(255, 255, 255);
            dgvTours.BorderStyle = BorderStyle.None;
            dgvTours.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 249, 250);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(30, 30, 30);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(248, 249, 250);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(30, 30, 30);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvTours.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvTours.ColumnHeadersHeight = 40;
            dgvTours.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(50, 50, 50);
            dataGridViewCellStyle2.SelectionBackColor = Color.Teal;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvTours.DefaultCellStyle = dataGridViewCellStyle2;
            dgvTours.Dock = DockStyle.Fill;
            dgvTours.EnableHeadersVisualStyles = false;
            dgvTours.GridColor = Color.FromArgb(222, 226, 230);
            dgvTours.Location = new Point(10, 10);
            dgvTours.Margin = new Padding(4, 5, 4, 5);
            dgvTours.MultiSelect = false;
            dgvTours.Name = "dgvTours";
            dgvTours.ReadOnly = true;
            dgvTours.RowHeadersVisible = false;
            dgvTours.RowHeadersWidth = 51;
            dgvTours.RowTemplate.Height = 35;
            dgvTours.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTours.Size = new Size(1001, 303);
            dgvTours.TabIndex = 0;
            dgvTours.SelectionChanged += dgvTours_SelectionChanged;
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
            groupBox1.Size = new Size(1001, 361);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tour details";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(lblTourName, 0, 0);
            tableLayoutPanel1.Controls.Add(txtTourName, 1, 0);
            tableLayoutPanel1.Controls.Add(lblDestination, 0, 1);
            tableLayoutPanel1.Controls.Add(txtDestination, 1, 1);
            tableLayoutPanel1.Controls.Add(lblStartDate, 0, 2);
            tableLayoutPanel1.Controls.Add(dtpStartDate, 1, 2);
            tableLayoutPanel1.Controls.Add(lblEndDate, 0, 3);
            tableLayoutPanel1.Controls.Add(dtpEndDate, 1, 3);
            tableLayoutPanel1.Controls.Add(lblPrice, 0, 4);
            tableLayoutPanel1.Controls.Add(numPrice, 1, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Font = new Font("Segoe UI", 10F);
            tableLayoutPanel1.Location = new Point(10, 34);
            tableLayoutPanel1.Margin = new Padding(4, 5, 4, 5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(0, 0, 10, 0);
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(981, 250);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lblTourName
            // 
            lblTourName.Anchor = AnchorStyles.Left;
            lblTourName.AutoSize = true;
            lblTourName.ForeColor = Color.FromArgb(80, 80, 80);
            lblTourName.Location = new Point(4, 11);
            lblTourName.Margin = new Padding(4, 0, 4, 0);
            lblTourName.Name = "lblTourName";
            lblTourName.Size = new Size(107, 28);
            lblTourName.TabIndex = 0;
            lblTourName.Text = "Tour name:";
            lblTourName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtTourName
            // 
            txtTourName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtTourName.Font = new Font("Segoe UI", 12F);
            txtTourName.Location = new Point(154, 5);
            txtTourName.Margin = new Padding(4, 5, 4, 5);
            txtTourName.Name = "txtTourName";
            txtTourName.Size = new Size(813, 39);
            txtTourName.TabIndex = 1;
            // 
            // lblDestination
            // 
            lblDestination.Anchor = AnchorStyles.Left;
            lblDestination.AutoSize = true;
            lblDestination.ForeColor = Color.FromArgb(80, 80, 80);
            lblDestination.Location = new Point(4, 61);
            lblDestination.Margin = new Padding(4, 0, 4, 0);
            lblDestination.Name = "lblDestination";
            lblDestination.Size = new Size(116, 28);
            lblDestination.TabIndex = 2;
            lblDestination.Text = "Destination:";
            lblDestination.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtDestination
            // 
            txtDestination.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtDestination.Font = new Font("Segoe UI", 12F);
            txtDestination.Location = new Point(154, 55);
            txtDestination.Margin = new Padding(4, 5, 4, 5);
            txtDestination.Name = "txtDestination";
            txtDestination.Size = new Size(813, 39);
            txtDestination.TabIndex = 3;
            // 
            // lblStartDate
            // 
            lblStartDate.Anchor = AnchorStyles.Left;
            lblStartDate.AutoSize = true;
            lblStartDate.ForeColor = Color.FromArgb(80, 80, 80);
            lblStartDate.Location = new Point(4, 111);
            lblStartDate.Margin = new Padding(4, 0, 4, 0);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(101, 28);
            lblStartDate.TabIndex = 4;
            lblStartDate.Text = "Start date:";
            lblStartDate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dtpStartDate
            // 
            dtpStartDate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dtpStartDate.Font = new Font("Segoe UI", 12F);
            dtpStartDate.Format = DateTimePickerFormat.Short;
            dtpStartDate.Location = new Point(154, 105);
            dtpStartDate.Margin = new Padding(4, 5, 4, 5);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(813, 39);
            dtpStartDate.TabIndex = 5;
            // 
            // lblEndDate
            // 
            lblEndDate.Anchor = AnchorStyles.Left;
            lblEndDate.AutoSize = true;
            lblEndDate.ForeColor = Color.FromArgb(80, 80, 80);
            lblEndDate.Location = new Point(4, 161);
            lblEndDate.Margin = new Padding(4, 0, 4, 0);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new Size(93, 28);
            lblEndDate.TabIndex = 6;
            lblEndDate.Text = "End date:";
            lblEndDate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dtpEndDate
            // 
            dtpEndDate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dtpEndDate.Font = new Font("Segoe UI", 12F);
            dtpEndDate.Format = DateTimePickerFormat.Short;
            dtpEndDate.Location = new Point(154, 155);
            dtpEndDate.Margin = new Padding(4, 5, 4, 5);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(813, 39);
            dtpEndDate.TabIndex = 7;
            // 
            // lblPrice
            // 
            lblPrice.Anchor = AnchorStyles.Left;
            lblPrice.AutoSize = true;
            lblPrice.ForeColor = Color.FromArgb(80, 80, 80);
            lblPrice.Location = new Point(4, 211);
            lblPrice.Margin = new Padding(4, 0, 4, 0);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(58, 28);
            lblPrice.TabIndex = 8;
            lblPrice.Text = "Price:";
            lblPrice.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // numPrice
            // 
            numPrice.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            numPrice.DecimalPlaces = 2;
            numPrice.Font = new Font("Segoe UI", 12F);
            numPrice.Location = new Point(154, 205);
            numPrice.Margin = new Padding(4, 5, 4, 5);
            numPrice.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numPrice.Name = "numPrice";
            numPrice.Size = new Size(813, 39);
            numPrice.TabIndex = 9;
            // 
            // flpButtons
            // 
            flpButtons.BackColor = Color.FromArgb(248, 249, 250);
            flpButtons.Controls.Add(btnDelete);
            flpButtons.Controls.Add(btnUpdate);
            flpButtons.Dock = DockStyle.Bottom;
            flpButtons.FlowDirection = FlowDirection.RightToLeft;
            flpButtons.Location = new Point(10, 284);
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
            // ToursView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1021, 700);
            Controls.Add(splitContainer1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            MinimumSize = new Size(800, 700);
            Name = "ToursView";
            ShowIcon = false;
            Text = "Tours Management";
            Load += ToursView_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTours).EndInit();
            groupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numPrice).EndInit();
            flpButtons.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private DataGridView dgvTours;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblTourName;
        private TextBox txtTourName;
        private Label lblDestination;
        private TextBox txtDestination;
        private Label lblStartDate;
        private DateTimePicker dtpStartDate;
        private Label lblEndDate;
        private DateTimePicker dtpEndDate;
        private Label lblPrice;
        private NumericUpDown numPrice;
        private FlowLayoutPanel flpButtons;
        private Button btnUpdate;
        private Button btnDelete;
    }
}
