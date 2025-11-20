using App.Core.Entities;
using App.Core.Interfaces;
using System;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.Presentation.WinForms.Views;

public partial class HotelsView : Form
{
    private readonly IHotelRepository _hotelRepository;
    private readonly ITourRepository _tourRepository;
    private Hotel? _selectedHotel;

    public HotelsView(IHotelRepository hotelRepository, ITourRepository tourRepository)
    {
        InitializeComponent();
        _hotelRepository = hotelRepository;
        _tourRepository = tourRepository;
    }

    private async void HotelsView_Load(object sender, EventArgs e)
    {
        await LoadToursToComboBoxAsync();
        await LoadHotelsAsync();
    }

    private async Task LoadToursToComboBoxAsync()
    {
        try
        {
            var tours = await _tourRepository.GetAllAsync();
            cmbTour.DataSource = tours.OrderBy(t => t.TourName).ToList();
            cmbTour.DisplayMember = "TourName";
            cmbTour.ValueMember = "TourId";
            cmbTour.SelectedIndex = -1;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error loading tours: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async Task LoadHotelsAsync()
    {
        try
        {
            dgvHotels.SelectionChanged -= dgvHotels_SelectionChanged;

            var hotels = await _hotelRepository.GetAllAsync();
            dgvHotels.DataSource = hotels.OrderBy(h => h.HotelName).ToList();

            ConfigureGridColumns();
            SetFormToNewState();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error loading hotels: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            dgvHotels.SelectionChanged += dgvHotels_SelectionChanged;
        }
    }

    private void dgvHotels_SelectionChanged(object? sender, EventArgs e)
    {
        if (dgvHotels.CurrentRow != null && dgvHotels.CurrentRow.DataBoundItem is Hotel hotel)
        {
            _selectedHotel = hotel;

            cmbTour.SelectedValue = _selectedHotel.TourId;
            txtHotelName.Text = _selectedHotel.HotelName;
            txtLocation.Text = _selectedHotel.Location;
            numStars.Value = _selectedHotel.Stars;
            txtPhone.Text = _selectedHotel.Phone;
            txtEmail.Text = _selectedHotel.Email;

            btnDelete.Enabled = true;
        }
    }

    private async void btnSave_Click(object sender, EventArgs e)
    {
        try
        {
            if (cmbTour.SelectedValue == null)
            {
                MessageBox.Show("Please select a tour.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtHotelName.Text) || string.IsNullOrWhiteSpace(txtLocation.Text))
            {
                MessageBox.Show("Hotel name and location are required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int tourId = (int)cmbTour.SelectedValue;

            if (_selectedHotel == null)
            {
                var newHotel = new Hotel
                {
                    TourId = tourId,
                    HotelName = txtHotelName.Text.Trim(),
                    Location = txtLocation.Text.Trim(),
                    Stars = (int)numStars.Value,
                    Phone = txtPhone.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    Tour = null!
                };
                await _hotelRepository.AddAsync(newHotel);
            }
            else
            {
                _selectedHotel.TourId = tourId;
                _selectedHotel.HotelName = txtHotelName.Text.Trim();
                _selectedHotel.Location = txtLocation.Text.Trim();
                _selectedHotel.Stars = (int)numStars.Value;
                _selectedHotel.Phone = txtPhone.Text.Trim();
                _selectedHotel.Email = txtEmail.Text.Trim();
                await _hotelRepository.UpdateAsync(_selectedHotel);
            }

            await LoadHotelsAsync();
            MessageBox.Show("Hotel saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error saving hotel: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async void btnDelete_Click(object sender, EventArgs e)
    {
        if (_selectedHotel == null) return;

        if (MessageBox.Show($"Delete hotel '{_selectedHotel.HotelName}'?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        {
            try
            {
                await _hotelRepository.DeleteAsync(_selectedHotel);
                await LoadHotelsAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting hotel: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    private void ConfigureGridColumns()
    {
        dgvHotels.Columns["HotelId"]!.HeaderText = "ID";
        dgvHotels.Columns["HotelName"]!.HeaderText = "Hotel Name";
        dgvHotels.Columns["Location"]!.HeaderText = "Location";
        dgvHotels.Columns["Stars"]!.HeaderText = "Stars";
        dgvHotels.Columns["Phone"]!.HeaderText = "Phone";
        dgvHotels.Columns["Email"]!.HeaderText = "Email";

        dgvHotels.Columns["TourId"]!.Visible = false;
        dgvHotels.Columns["Tour"]!.Visible = false;
        dgvHotels.AutoResizeColumns();
    }

    private void SetFormToNewState()
    {
        cmbTour.SelectedIndex = -1;
        txtHotelName.Text = "";
        txtLocation.Text = "";
        numStars.Value = 5;
        txtPhone.Text = "";
        txtEmail.Text = "";

        _selectedHotel = null;
        dgvHotels.ClearSelection();
        btnDelete.Enabled = false;
        cmbTour.Focus();
    }
}
