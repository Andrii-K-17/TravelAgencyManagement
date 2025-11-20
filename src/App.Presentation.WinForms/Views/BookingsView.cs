using App.Core.Entities;
using App.Core.Interfaces;
using System;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.Presentation.WinForms.Views;

public partial class BookingsView : Form
{
    private readonly IBookingRepository _bookingRepository;
    private readonly IClientRepository _clientRepository;
    private readonly ITourRepository _tourRepository;
    private readonly IEmployeeRepository _employeeRepository;
    private Booking? _selectedBooking;

    public BookingsView(IBookingRepository bookingRepository, IClientRepository clientRepository, ITourRepository tourRepository, IEmployeeRepository employeeRepository)
    {
        InitializeComponent();
        _bookingRepository = bookingRepository;
        _clientRepository = clientRepository;
        _tourRepository = tourRepository;
        _employeeRepository = employeeRepository;
    }

    private async void BookingsView_Load(object sender, EventArgs e)
    {
        await LoadComboBoxesAsync();
        await LoadBookingsAsync();
    }

    private async Task LoadComboBoxesAsync()
    {
        try
        {
            var clients = await _clientRepository.GetAllAsync();
            var clientList = clients.Select(c => new
            {
                c.ClientId,
                FullName = $"{c.LastName} {c.FirstName}"
            }).OrderBy(c => c.FullName).ToList();

            cmbClient.DataSource = clientList;
            cmbClient.DisplayMember = "FullName";
            cmbClient.ValueMember = "ClientId";
            cmbClient.SelectedIndex = -1;

            var tours = await _tourRepository.GetAllAsync();
            var tourList = tours.OrderBy(t => t.TourName).ToList();

            cmbTour.DataSource = tourList;
            cmbTour.DisplayMember = "TourName";
            cmbTour.ValueMember = "TourId";
            cmbTour.SelectedIndex = -1;

            var employees = await _employeeRepository.GetAllAsync();
            var empList = employees.Select(emp => new
            {
                emp.EmployeeId,
                FullName = $"{emp.LastName} {emp.FirstName} ({emp.Position})"
            }).OrderBy(x => x.FullName).ToList();

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

    private async Task LoadBookingsAsync()
    {
        try
        {
            dgvBookings.SelectionChanged -= dgvBookings_SelectionChanged;

            var bookings = await _bookingRepository.GetAllAsync();
            dgvBookings.DataSource = bookings.OrderByDescending(b => b.BookingDate).ToList();
            ConfigureGridColumns();
            SetFormToNewState();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error loading bookings: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            dgvBookings.SelectionChanged += dgvBookings_SelectionChanged;
        }
    }

    private void dgvBookings_SelectionChanged(object? sender, EventArgs e)
    {
        if (dgvBookings.CurrentRow != null && dgvBookings.CurrentRow.DataBoundItem is Booking booking)
        {
            _selectedBooking = booking;
            cmbClient.SelectedValue = _selectedBooking.ClientId;
            cmbTour.SelectedValue = _selectedBooking.TourId;
            cmbEmployee.SelectedValue = _selectedBooking.EmployeeId;
            dtpDate.Value = _selectedBooking.BookingDate;
            btnDelete.Enabled = true;
        }
    }

    private async void btnSave_Click(object sender, EventArgs e)
    {
        try
        {
            if (cmbClient.SelectedValue == null || cmbTour.SelectedValue == null || cmbEmployee.SelectedValue == null)
            {
                MessageBox.Show("Please select client, tour and employee.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int clientId = (int)cmbClient.SelectedValue;
            int tourId = (int)cmbTour.SelectedValue;
            int empId = (int)cmbEmployee.SelectedValue;

            if (_selectedBooking == null)
            {
                var newBooking = new Booking
                {
                    ClientId = clientId,
                    TourId = tourId,
                    EmployeeId = empId,
                    BookingDate = dtpDate.Value.Date,
                    Client = null!,
                    Tour = null!,
                    Employee = null!
                };
                await _bookingRepository.AddAsync(newBooking);
            }
            else
            {
                _selectedBooking.ClientId = clientId;
                _selectedBooking.TourId = tourId;
                _selectedBooking.EmployeeId = empId;
                _selectedBooking.BookingDate = dtpDate.Value.Date;

                await _bookingRepository.UpdateAsync(_selectedBooking);
            }

            await LoadBookingsAsync();
            MessageBox.Show("Booking saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error saving booking: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async void btnDelete_Click(object sender, EventArgs e)
    {
        if (_selectedBooking == null) return;

        if (MessageBox.Show($"Delete booking #{_selectedBooking.BookingId}?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        {
            try
            {
                await _bookingRepository.DeleteAsync(_selectedBooking);
                await LoadBookingsAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting booking: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    private void ConfigureGridColumns()
    {
        dgvBookings.Columns["BookingId"]!.HeaderText = "ID";
        dgvBookings.Columns["BookingDate"]!.HeaderText = "Booking Date";

        string[] hide = { "ClientId", "TourId", "EmployeeId", "Client", "Tour", "Employee", "Payments" };
        foreach (var col in hide)
        {
            dgvBookings.Columns[col]!.Visible = false;
        }

        dgvBookings.AutoResizeColumns();
    }

    private void SetFormToNewState()
    {
        cmbClient.SelectedIndex = -1;
        cmbTour.SelectedIndex = -1;
        cmbEmployee.SelectedIndex = -1;
        dtpDate.Value = DateTime.Now;
        _selectedBooking = null;
        dgvBookings.ClearSelection();
        btnDelete.Enabled = false;
        cmbClient.Focus();
    }
}
