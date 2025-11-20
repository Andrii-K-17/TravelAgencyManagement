using App.Core.Entities;
using App.Core.Interfaces;
using System;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.Presentation.WinForms.Views;

public partial class PaymentsView : Form
{
    private readonly IPaymentRepository _paymentRepository;
    private readonly IBookingRepository _bookingRepository;
    private readonly IEmployeeRepository _employeeRepository;
    private Payment? _selectedPayment;

    public PaymentsView(IPaymentRepository paymentRepository, IBookingRepository bookingRepository, IEmployeeRepository employeeRepository)
    {
        InitializeComponent();
        _paymentRepository = paymentRepository;
        _bookingRepository = bookingRepository;
        _employeeRepository = employeeRepository;
    }

    private async void PaymentsView_Load(object sender, EventArgs e)
    {
        await LoadComboBoxesAsync();
        await LoadPaymentsAsync();
    }

    private async Task LoadComboBoxesAsync()
    {
        try
        {
            var bookings = await _bookingRepository.GetAllAsync();
            var bookingList = bookings.Select(b => new
            {
                b.BookingId,
                Display = $"Booking #{b.BookingId} ({b.BookingDate:d})"
            }).OrderByDescending(b => b.BookingId).ToList();

            cmbBooking.DataSource = bookingList;
            cmbBooking.DisplayMember = "Display";
            cmbBooking.ValueMember = "BookingId";
            cmbBooking.SelectedIndex = -1;

            var employees = await _employeeRepository.GetAllAsync();
            var empList = employees.Select(e => new
            {
                e.EmployeeId,
                FullName = $"{e.LastName} {e.FirstName}"
            }).OrderBy(e => e.FullName).ToList();

            cmbEmployee.DataSource = empList;
            cmbEmployee.DisplayMember = "FullName";
            cmbEmployee.ValueMember = "EmployeeId";
            cmbEmployee.SelectedIndex = -1;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error loading lists: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async Task LoadPaymentsAsync()
    {
        try
        {
            dgvPayments.SelectionChanged -= dgvPayments_SelectionChanged;

            var payments = await _paymentRepository.GetAllAsync();
            dgvPayments.DataSource = payments.OrderByDescending(p => p.PaymentDate).ToList();

            ConfigureGridColumns();
            SetFormToNewState();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error loading payments: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            dgvPayments.SelectionChanged += dgvPayments_SelectionChanged;
        }
    }

    private void dgvPayments_SelectionChanged(object? sender, EventArgs e)
    {
        if (dgvPayments.CurrentRow != null && dgvPayments.CurrentRow.DataBoundItem is Payment payment)
        {
            _selectedPayment = payment;

            cmbBooking.SelectedValue = _selectedPayment.BookingId;
            cmbEmployee.SelectedValue = _selectedPayment.EmployeeId;
            numAmount.Value = _selectedPayment.Amount;
            dtpDate.Value = _selectedPayment.PaymentDate;
            txtTransaction.Text = _selectedPayment.TransactionNumber;
            cmbMethod.Text = _selectedPayment.PaymentMethod;

            btnDelete.Enabled = true;
        }
    }

    private async void btnSave_Click(object sender, EventArgs e)
    {
        try
        {
            if (cmbBooking.SelectedValue == null || cmbEmployee.SelectedValue == null)
            {
                MessageBox.Show("Please select booking and employee.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtTransaction.Text) || string.IsNullOrWhiteSpace(cmbMethod.Text))
            {
                MessageBox.Show("Transaction number and payment method are required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (numAmount.Value <= 0)
            {
                MessageBox.Show("Amount must be greater than 0.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int bookingId = (int)cmbBooking.SelectedValue;
            int empId = (int)cmbEmployee.SelectedValue;
            if (_selectedPayment == null)
            {
                var newPayment = new Payment
                {
                    BookingId = bookingId,
                    EmployeeId = empId,
                    Amount = numAmount.Value,
                    PaymentDate = dtpDate.Value,
                    TransactionNumber = txtTransaction.Text.Trim(),
                    PaymentMethod = cmbMethod.Text,
                    Booking = null!,
                    Employee = null!
                };
                await _paymentRepository.AddAsync(newPayment);
            }
            else
            {
                _selectedPayment.BookingId = bookingId;
                _selectedPayment.EmployeeId = empId;
                _selectedPayment.Amount = numAmount.Value;
                _selectedPayment.PaymentDate = dtpDate.Value;
                _selectedPayment.TransactionNumber = txtTransaction.Text.Trim();
                _selectedPayment.PaymentMethod = cmbMethod.Text;

                await _paymentRepository.UpdateAsync(_selectedPayment);
            }

            await LoadPaymentsAsync();
            MessageBox.Show("Payment saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error saving payment: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async void btnDelete_Click(object sender, EventArgs e)
    {
        if (_selectedPayment == null) return;

        if (MessageBox.Show($"Delete payment transaction '{_selectedPayment.TransactionNumber}'?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        {
            try
            {
                await _paymentRepository.DeleteAsync(_selectedPayment);
                await LoadPaymentsAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting payment: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    private void ConfigureGridColumns()
    {
        dgvPayments.Columns["PaymentId"]!.HeaderText = "ID";
        dgvPayments.Columns["PaymentDate"]!.HeaderText = "Date";
        dgvPayments.Columns["TransactionNumber"]!.HeaderText = "Transaction No.";
        dgvPayments.Columns["PaymentMethod"]!.HeaderText = "Method";
        dgvPayments.Columns["Amount"]!.HeaderText = "Amount";
        dgvPayments.Columns["Amount"]!.DefaultCellStyle.Format = "N2";

        string[] hide = ["BookingId", "EmployeeId", "Booking", "Employee"];
        foreach (var col in hide)
        {
            dgvPayments.Columns[col]!.Visible = false;
        }
        dgvPayments.AutoResizeColumns();
    }

    private void SetFormToNewState()
    {
        cmbBooking.SelectedIndex = -1;
        cmbEmployee.SelectedIndex = -1;
        cmbMethod.SelectedIndex = 0;
        txtTransaction.Text = "";
        numAmount.Value = 0;
        dtpDate.Value = DateTime.Now;
        _selectedPayment = null;
        dgvPayments.ClearSelection();
        btnDelete.Enabled = false;
        cmbBooking.Focus();
    }
}
