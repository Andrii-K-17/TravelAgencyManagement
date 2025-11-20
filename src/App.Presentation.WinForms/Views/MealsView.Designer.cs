namespace App.Presentation.WinForms.Views
{
    partial class MealsView
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
            dgvMeals = new DataGridView();
            groupBox1 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblTour = new Label();
            cmbTour = new ComboBox();
            lblMealType = new Label();
            cmbMealType = new ComboBox();
            lblDescription = new Label();
            txtDescription = new TextBox();
            flpButtons = new FlowLayoutPanel();
            btnDelete = new Button();
            btnUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMeals).BeginInit();
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
            splitContainer1.Panel1.Controls.Add(dgvMeals);
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
            // dgvMeals
            // 
            dgvMeals.AllowUserToAddRows = false;
            dgvMeals.AllowUserToDeleteRows = false;
            dgvMeals.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMeals.BackgroundColor = Color.FromArgb(255, 255, 255);
            dgvMeals.BorderStyle = BorderStyle.None;
            dgvMeals.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 249, 250);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(30, 30, 30);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(248, 249, 250);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(30, 30, 30);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvMeals.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvMeals.ColumnHeadersHeight = 40;
            dgvMeals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(50, 50, 50);
            dataGridViewCellStyle2.SelectionBackColor = Color.Teal;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvMeals.DefaultCellStyle = dataGridViewCellStyle2;
            dgvMeals.Dock = DockStyle.Fill;
            dgvMeals.EnableHeadersVisualStyles = false;
            dgvMeals.GridColor = Color.FromArgb(222, 226, 230);
            dgvMeals.Location = new Point(10, 10);
            dgvMeals.MultiSelect = false;
            dgvMeals.Name = "dgvMeals";
            dgvMeals.ReadOnly = true;
            dgvMeals.RowHeadersVisible = false;
            dgvMeals.RowHeadersWidth = 62;
            dgvMeals.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMeals.Size = new Size(1001, 335);
            dgvMeals.TabIndex = 0;
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
            groupBox1.Text = "Meal details";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(lblTour, 0, 0);
            tableLayoutPanel1.Controls.Add(cmbTour, 1, 0);
            tableLayoutPanel1.Controls.Add(lblMealType, 0, 1);
            tableLayoutPanel1.Controls.Add(cmbMealType, 1, 1);
            tableLayoutPanel1.Controls.Add(txtDescription, 1, 2);
            tableLayoutPanel1.Controls.Add(lblDescription, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Font = new Font("Segoe UI", 10F);
            tableLayoutPanel1.Location = new Point(10, 34);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(981, 218);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lblTour
            // 
            lblTour.Anchor = AnchorStyles.Left;
            lblTour.AutoSize = true;
            lblTour.ForeColor = Color.FromArgb(80, 80, 80);
            lblTour.Location = new Point(3, 11);
            lblTour.Name = "lblTour";
            lblTour.Size = new Size(110, 28);
            lblTour.TabIndex = 0;
            lblTour.Text = "Select tour:";
            // 
            // cmbTour
            // 
            cmbTour.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbTour.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTour.Font = new Font("Segoe UI", 12F);
            cmbTour.FormattingEnabled = true;
            cmbTour.Location = new Point(153, 5);
            cmbTour.Name = "cmbTour";
            cmbTour.Size = new Size(825, 40);
            cmbTour.TabIndex = 1;
            // 
            // lblMealType
            // 
            lblMealType.Anchor = AnchorStyles.Left;
            lblMealType.AutoSize = true;
            lblMealType.ForeColor = Color.FromArgb(80, 80, 80);
            lblMealType.Location = new Point(3, 61);
            lblMealType.Name = "lblMealType";
            lblMealType.Size = new Size(103, 28);
            lblMealType.TabIndex = 2;
            lblMealType.Text = "Meal type:";
            // 
            // cmbMealType
            // 
            cmbMealType.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbMealType.Font = new Font("Segoe UI", 12F);
            cmbMealType.FormattingEnabled = true;
            cmbMealType.Items.AddRange(new object[] { "Breakfast", "Half board", "Full board", "All inclusive", "Ultra all inclusive", "No meals" });
            cmbMealType.Location = new Point(153, 55);
            cmbMealType.Name = "cmbMealType";
            cmbMealType.Size = new Size(825, 40);
            cmbMealType.TabIndex = 3;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.ForeColor = Color.FromArgb(80, 80, 80);
            lblDescription.Location = new Point(3, 100);
            lblDescription.Name = "lblDescription";
            lblDescription.Padding = new Padding(0, 10, 0, 0);
            lblDescription.Size = new Size(116, 38);
            lblDescription.TabIndex = 4;
            lblDescription.Text = "Description:";
            // 
            // txtDescription
            // 
            txtDescription.Dock = DockStyle.Fill;
            txtDescription.Font = new Font("Segoe UI", 12F);
            txtDescription.Location = new Point(153, 103);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(825, 92);
            txtDescription.TabIndex = 5;
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
            // MealsView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1021, 700);
            Controls.Add(splitContainer1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MealsView";
            ShowIcon = false;
            Text = "Meals management";
            Load += MealsView_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMeals).EndInit();
            groupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            flpButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private DataGridView dgvMeals;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flpButtons;
        private Button btnUpdate;
        private Button btnDelete;
        private Label lblTour;
        private ComboBox cmbTour;
        private Label lblMealType;
        private ComboBox cmbMealType;
        private Label lblDescription;
        private TextBox txtDescription;
    }
}
