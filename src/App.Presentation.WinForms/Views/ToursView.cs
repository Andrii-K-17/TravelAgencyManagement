using App.Core.Entities;
using App.Core.Interfaces;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.Presentation.WinForms.Views;

public partial class ToursView : Form
{
    private readonly ITourRepository _tourRepository;
    private Tour? _selectedTour;

    public ToursView(ITourRepository tourRepository)
    {
        InitializeComponent();
        _tourRepository = tourRepository;
    }

    private async void ToursView_Load(object sender, EventArgs e)
    {
        await LoadToursAsync();
    }

    private async Task LoadToursAsync()
    {
        try
        {
            dgvTours.SelectionChanged -= dgvTours_SelectionChanged;

            var tours = await _tourRepository.GetAllAsync();
            dgvTours.DataSource = tours.ToList();

            ConfigureGridColumns();
            SetFormToNewState();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error loading tours: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            dgvTours.SelectionChanged += dgvTours_SelectionChanged;
        }
    }

    private void dgvTours_SelectionChanged(object? sender, EventArgs e)
    {
        if (dgvTours.CurrentRow != null && dgvTours.CurrentRow.DataBoundItem is Tour tour)
        {
            _selectedTour = tour;

            txtTourName.Text = _selectedTour.TourName;
            txtDestination.Text = _selectedTour.Destination;
            dtpStartDate.Value = _selectedTour.StartDate;
            dtpEndDate.Value = _selectedTour.EndDate;
            numPrice.Value = _selectedTour.Price;

            btnDelete.Enabled = true;
        }
    }

    private async void btnSave_Click(object sender, EventArgs e)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(txtTourName.Text))
            {
                MessageBox.Show("Tour name is required.", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTourName.Focus();
                return;
            }

            if (txtTourName.Text.Length > 50)
            {
                MessageBox.Show("Tour name cannot exceed 50 characters.", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTourName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDestination.Text))
            {
                MessageBox.Show("Destination is required.", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDestination.Focus();
                return;
            }

            if (txtDestination.Text.Length > 50)
            {
                MessageBox.Show("Destination cannot exceed 50 characters.", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDestination.Focus();
                return;
            }

            if (dtpEndDate.Value <= dtpStartDate.Value)
            {
                MessageBox.Show("End date must be after start date.", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpEndDate.Focus();
                return;
            }

            if (numPrice.Value <= 0)
            {
                MessageBox.Show("Price must be greater than 0.", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numPrice.Focus();
                return;
            }

            if (numPrice.Value > 999999.99m)
            {
                MessageBox.Show("Price cannot exceed 999,999.99.", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numPrice.Focus();
                return;
            }
            
            if (_selectedTour == null)
            {
                var newTour = new Tour
                {
                    TourName = txtTourName.Text.Trim(),
                    Destination = txtDestination.Text.Trim(),
                    StartDate = dtpStartDate.Value,
                    EndDate = dtpEndDate.Value,
                    Price = numPrice.Value
                };
                await _tourRepository.AddAsync(newTour);
            }
            else
            {
                _selectedTour.TourName = txtTourName.Text.Trim();
                _selectedTour.Destination = txtDestination.Text.Trim();
                _selectedTour.StartDate = dtpStartDate.Value;
                _selectedTour.EndDate = dtpEndDate.Value;
                _selectedTour.Price = numPrice.Value;
                await _tourRepository.UpdateAsync(_selectedTour);
            }

            await LoadToursAsync();
            MessageBox.Show("Tour saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            SetFormToNewState();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error saving tour: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async void btnDelete_Click(object sender, EventArgs e)
    {
        if (_selectedTour == null)
        {
            MessageBox.Show("Please select a tour to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var confirmResult = MessageBox.Show(
            $"Are you sure you want to delete '{_selectedTour.TourName}'?",
            "Confirm Deletion",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

        if (confirmResult == DialogResult.Yes)
        {
            try
            {
                await _tourRepository.DeleteAsync(_selectedTour);
                await LoadToursAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting tour: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    private void ConfigureGridColumns()
    {
        dgvTours.Columns["TourId"]?.HeaderText = "ID";
        dgvTours.Columns["TourName"]?.HeaderText = "Tour name";
        dgvTours.Columns["StartDate"]?.HeaderText = "Start date";
        dgvTours.Columns["EndDate"]?.HeaderText = "End date";
        dgvTours.Columns["Price"]?.HeaderText = "Price";

        string[] hide = ["Bookings", "Hotels", "Meals", "Transports"];
        foreach (var col in hide)
        {
            dgvTours.Columns[col]!.Visible = false;
        }

        dgvTours.AutoResizeColumns();
    }

    private void SetFormToNewState()
    {
        txtTourName.Text = "";
        txtDestination.Text = "";
        dtpStartDate.Value = DateTime.Now;
        dtpEndDate.Value = DateTime.Now.AddDays(7);
        numPrice.Value = 0;

        _selectedTour = null;
        dgvTours.ClearSelection();
        btnDelete.Enabled = false;
        txtTourName.Focus();
    }
}
