using App.Core.DTOs;
using App.Core.Interfaces;
using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace App.Presentation.WinForms.Views;

public partial class ReportView : Form
{
    private readonly IBookingRepository _bookingRepository;

    public ReportView(IBookingRepository bookingRepository)
    {
        InitializeComponent();
        _bookingRepository = bookingRepository;

        dtpEndDate.Value = DateTime.Now;
        dtpStartDate.Value = DateTime.Now.AddMonths(-1);

        btnSaveReport.Enabled = false;
    }

    private async void btnGenerateReport_Click(object sender, EventArgs e)
    {
        try
        {
            var startDate = dtpStartDate.Value.Date;
            var endDate = dtpEndDate.Value.Date;

            if (endDate < startDate)
            {
                MessageBox.Show("End date cannot be earlier than start date.", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Cursor = Cursors.WaitCursor;
            btnGenerateReport.Enabled = false;
            btnGenerateReport.Text = "Generating...";

            var reportData = await _bookingRepository.GetBookingsReportAsync(startDate, endDate);
            var reportList = reportData.ToList();

            if (reportList.Count == 0)
            {
                MessageBox.Show("No bookings found for the selected period.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnSaveReport.Enabled = false;
                dgvReport.DataSource = null;
                return;
            }

            dgvReport.DataSource = reportList;

            if (dgvReport.Columns.Count > 0)
            {
                dgvReport.Columns["BookingId"]?.HeaderText = "ID";
                dgvReport.Columns["BookingDate"]?.HeaderText = "Date";
                dgvReport.Columns["ClientName"]?.HeaderText = "Client";
                dgvReport.Columns["TourName"]?.HeaderText = "Tour";
                dgvReport.Columns["Destination"]?.HeaderText = "Destination";
                dgvReport.Columns["PaymentAmount"]?.HeaderText = "Payment amount";
                dgvReport.Columns["ManagerName"]?.HeaderText = "Manager";

                dgvReport.Columns["BookingDate"]?.DefaultCellStyle.Format = "dd.MM.yyyy";

                if (dgvReport.Columns["PaymentAmount"] != null)
                {
                    dgvReport.Columns["PaymentAmount"]?.DefaultCellStyle.Format = "N2";
                    dgvReport.Columns["PaymentAmount"]?.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
            }

            btnSaveReport.Enabled = true;
            MessageBox.Show($"Report generated successfully.\nTotal records: {reportList.Count}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error generating report: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            btnSaveReport.Enabled = false;
        }
        finally
        {
            this.Cursor = Cursors.Default;
            btnGenerateReport.Enabled = true;
            btnGenerateReport.Text = "Generate Report";
        }
    }

    private async void btnSaveReport_Click(object sender, EventArgs e)
    {
        if (dgvReport.Rows.Count == 0)
        {
            MessageBox.Show("No data to save.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        using SaveFileDialog saveFileDialog = new();
        saveFileDialog.Filter = "CSV |*.csv|Text file (*.txt)|*.txt";
        saveFileDialog.Title = "Save report as...";
        saveFileDialog.FileName = $"Booking_Report_{DateTime.Now:yyyy-MM-dd_HH-mm}.csv";

        if (saveFileDialog.ShowDialog() == DialogResult.OK)
        {
            try
            {
                var sb = new StringBuilder();

                var headers = dgvReport.Columns.Cast<DataGridViewColumn>();
                sb.AppendLine(string.Join(",", headers.Select(column => $"\"{column.HeaderText}\"").ToArray()));

                foreach (DataGridViewRow row in dgvReport.Rows)
                {
                    if (row.IsNewRow) continue;

                    var cells = row.Cells.Cast<DataGridViewCell>();
                    sb.AppendLine(string.Join(",", cells.Select(cell => FormatCsvValue(cell.Value?.ToString() ?? "")).ToArray()));
                }

                await File.WriteAllTextAsync(saveFileDialog.FileName, sb.ToString(), Encoding.UTF8);

                MessageBox.Show("Report saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    private static string FormatCsvValue(string value)
    {
        if (value.Contains(',') || value.Contains('"'))
        {
            return $"\"{value.Replace("\"", "\"\"")}\"";
        }
        return value;
    }
}
