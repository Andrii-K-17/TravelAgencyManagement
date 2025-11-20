namespace App.Presentation.WinForms.Views
{
    partial class ReportView
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

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportView));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            pnlTop = new FlowLayoutPanel();
            label1 = new Label();
            dtpStartDate = new DateTimePicker();
            label2 = new Label();
            dtpEndDate = new DateTimePicker();
            btnGenerateReport = new Button();
            btnSaveReport = new Button();
            dgvReport = new DataGridView();
            pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReport).BeginInit();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.FromArgb(248, 249, 250);
            pnlTop.Controls.Add(label1);
            pnlTop.Controls.Add(dtpStartDate);
            pnlTop.Controls.Add(label2);
            pnlTop.Controls.Add(dtpEndDate);
            pnlTop.Controls.Add(btnGenerateReport);
            pnlTop.Controls.Add(btnSaveReport);
            resources.ApplyResources(pnlTop, "pnlTop");
            pnlTop.Name = "pnlTop";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.ForeColor = Color.FromArgb(80, 80, 80);
            label1.Name = "label1";
            // 
            // dtpStartDate
            // 
            resources.ApplyResources(dtpStartDate, "dtpStartDate");
            dtpStartDate.Format = DateTimePickerFormat.Short;
            dtpStartDate.Name = "dtpStartDate";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.ForeColor = Color.FromArgb(80, 80, 80);
            label2.Name = "label2";
            // 
            // dtpEndDate
            // 
            resources.ApplyResources(dtpEndDate, "dtpEndDate");
            dtpEndDate.Format = DateTimePickerFormat.Short;
            dtpEndDate.Name = "dtpEndDate";
            // 
            // btnGenerateReport
            // 
            btnGenerateReport.BackColor = Color.DarkCyan;
            btnGenerateReport.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(btnGenerateReport, "btnGenerateReport");
            btnGenerateReport.ForeColor = Color.White;
            btnGenerateReport.Name = "btnGenerateReport";
            btnGenerateReport.UseVisualStyleBackColor = false;
            btnGenerateReport.Click += btnGenerateReport_Click;
            // 
            // btnSaveReport
            // 
            btnSaveReport.BackColor = Color.RoyalBlue;
            btnSaveReport.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(btnSaveReport, "btnSaveReport");
            btnSaveReport.ForeColor = Color.White;
            btnSaveReport.Name = "btnSaveReport";
            btnSaveReport.UseVisualStyleBackColor = false;
            btnSaveReport.Click += btnSaveReport_Click;
            // 
            // dgvReport
            // 
            dgvReport.AllowUserToAddRows = false;
            dgvReport.AllowUserToDeleteRows = false;
            dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReport.BackgroundColor = Color.FromArgb(255, 255, 255);
            dgvReport.BorderStyle = BorderStyle.None;
            dgvReport.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 249, 250);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(30, 30, 30);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(248, 249, 250);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(30, 30, 30);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            resources.ApplyResources(dgvReport, "dgvReport");
            dgvReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(50, 50, 50);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 123, 255);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvReport.DefaultCellStyle = dataGridViewCellStyle2;
            dgvReport.EnableHeadersVisualStyles = false;
            dgvReport.GridColor = Color.FromArgb(222, 226, 230);
            dgvReport.Name = "dgvReport";
            dgvReport.ReadOnly = true;
            dgvReport.RowHeadersVisible = false;
            dgvReport.RowTemplate.Height = 35;
            dgvReport.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            // 
            // ReportView
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(dgvReport);
            Controls.Add(pnlTop);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ReportView";
            ShowIcon = false;
            pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvReport).EndInit();
            ResumeLayout(false);

        }

        private FlowLayoutPanel pnlTop;
        private Label label1;
        private Label label2;
        private DateTimePicker dtpEndDate;
        private DateTimePicker dtpStartDate;
        private Button btnGenerateReport;
        private DataGridView dgvReport;
        private Button btnSaveReport;
    }
}