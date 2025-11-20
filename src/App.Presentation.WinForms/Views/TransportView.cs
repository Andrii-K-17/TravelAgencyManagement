using App.Core.Entities;
using App.Core.Interfaces;
using System;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.Presentation.WinForms.Views;

public partial class TransportView : Form
{
    private readonly ITransportRepository _transportRepository;
    private readonly ITourRepository _tourRepository;
    private readonly IEmployeeRepository _employeeRepository;
    private Transport? _selectedTransport;

    public TransportView(ITransportRepository transportRepository, ITourRepository tourRepository, IEmployeeRepository employeeRepository)
    {
        InitializeComponent();
        _transportRepository = transportRepository;
        _tourRepository = tourRepository;
        _employeeRepository = employeeRepository;
    }

    private async void TransportView_Load(object sender, EventArgs e)
    {
        await LoadComboBoxesAsync();
        await LoadTransportsAsync();
    }

    private async Task LoadComboBoxesAsync()
    {
        try
        {
            var tours = await _tourRepository.GetAllAsync();
            cmbTour.DataSource = tours.OrderBy(t => t.TourName).ToList();
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

    private async Task LoadTransportsAsync()
    {
        try
        {
            dgvTransports.SelectionChanged -= dgvTransports_SelectionChanged;

            var transports = await _transportRepository.GetAllAsync();
            dgvTransports.DataSource = transports.OrderByDescending(t => t.DepartureDate).ToList();

            ConfigureGridColumns();
            SetFormToNewState();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error loading transport: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            dgvTransports.SelectionChanged += dgvTransports_SelectionChanged;
        }
    }

    private void dgvTransports_SelectionChanged(object? sender, EventArgs e)
    {
        if (dgvTransports.CurrentRow != null && dgvTransports.CurrentRow.DataBoundItem is Transport transport)
        {
            _selectedTransport = transport;

            cmbTour.SelectedValue = _selectedTransport.TourId;
            cmbEmployee.SelectedValue = _selectedTransport.EmployeeId;

            cmbType.Text = _selectedTransport.TransportType;
            txtRoute.Text = _selectedTransport.RouteNumber;

            dtpDepDate.Value = _selectedTransport.DepartureDate;
            dtpDepTime.Value = _selectedTransport.DepartureTime;

            txtFrom.Text = _selectedTransport.DeparturePlace;
            txtTo.Text = _selectedTransport.ArrivalPlace;
            numPrice.Value = _selectedTransport.Price;

            btnDelete.Enabled = true;
        }
    }

    private async void btnSave_Click(object sender, EventArgs e)
    {
        try
        {
            if (cmbTour.SelectedValue == null || cmbEmployee.SelectedValue == null)
            {
                MessageBox.Show("Please select both tour and employee.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtRoute.Text) || string.IsNullOrWhiteSpace(txtFrom.Text) || string.IsNullOrWhiteSpace(txtTo.Text))
            {
                MessageBox.Show("Route, departure and arrival places are required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int tourId = (int)cmbTour.SelectedValue;
            int empId = (int)cmbEmployee.SelectedValue;
            var depDate = dtpDepDate.Value.Date;
            var depTime = dtpDepTime.Value;

            if (_selectedTransport == null)
            {
                var newTransport = new Transport
                {
                    TourId = tourId,
                    EmployeeId = empId,
                    TransportType = cmbType.Text,
                    RouteNumber = txtRoute.Text.Trim(),
                    DepartureDate = depDate,
                    DepartureTime = depTime,
                    DeparturePlace = txtFrom.Text.Trim(),
                    ArrivalPlace = txtTo.Text.Trim(),
                    Price = numPrice.Value,
                    Tour = null!,
                    Employee = null!
                };
                await _transportRepository.AddAsync(newTransport);
            }
            else
            {
                _selectedTransport.TourId = tourId;
                _selectedTransport.EmployeeId = empId;
                _selectedTransport.TransportType = cmbType.Text;
                _selectedTransport.RouteNumber = txtRoute.Text.Trim();
                _selectedTransport.DepartureDate = depDate;
                _selectedTransport.DepartureTime = depTime;
                _selectedTransport.DeparturePlace = txtFrom.Text.Trim();
                _selectedTransport.ArrivalPlace = txtTo.Text.Trim();
                _selectedTransport.Price = numPrice.Value;

                await _transportRepository.UpdateAsync(_selectedTransport);
            }

            await LoadTransportsAsync();
            MessageBox.Show("Transport saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error saving transport: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async void btnDelete_Click(object sender, EventArgs e)
    {
        if (_selectedTransport == null) return;

        if (MessageBox.Show($"Delete transport route '{_selectedTransport.RouteNumber}'?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        {
            try
            {
                await _transportRepository.DeleteAsync(_selectedTransport);
                await LoadTransportsAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting transport: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    private void ConfigureGridColumns()
    {
        dgvTransports.Columns["TransportId"]!.HeaderText = "ID";
        dgvTransports.Columns["TransportType"]!.HeaderText = "Type";
        dgvTransports.Columns["RouteNumber"]!.HeaderText = "Route No.";
        dgvTransports.Columns["DepartureDate"]!.HeaderText = "Departure date";
        dgvTransports.Columns["DeparturePlace"]!.HeaderText = "From";
        dgvTransports.Columns["ArrivalPlace"]!.HeaderText = "To";
        dgvTransports.Columns["Price"]!.HeaderText = "Price";
        dgvTransports.Columns["Price"]!.DefaultCellStyle.Format = "N2";

        string[] hide = ["TourId", "EmployeeId", "Tour", "Employee", "DepartureTime"];
        foreach (var col in hide)
        {
            dgvTransports.Columns[col]!.Visible = false;
        }

        dgvTransports.AutoResizeColumns();
    }

    private void SetFormToNewState()
    {
        cmbTour.SelectedIndex = -1;
        cmbEmployee.SelectedIndex = -1;
        cmbType.SelectedIndex = 0;
        txtRoute.Text = "";
        txtFrom.Text = "";
        txtTo.Text = "";
        numPrice.Value = 0;
        dtpDepDate.Value = DateTime.Now;
        dtpDepTime.Value = DateTime.Now;

        _selectedTransport = null;
        dgvTransports.ClearSelection();
        btnDelete.Enabled = false;
        cmbTour.Focus();
    }
}
