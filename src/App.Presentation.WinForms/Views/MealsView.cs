using App.Core.Entities;
using App.Core.Interfaces;
using System;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.Presentation.WinForms.Views;

public partial class MealsView : Form
{
    private readonly IMealRepository _mealRepository;
    private readonly ITourRepository _tourRepository;
    private Meal? _selectedMeal;
    public MealsView(IMealRepository mealRepository, ITourRepository tourRepository)
    {
        InitializeComponent();
        _mealRepository = mealRepository;
        _tourRepository = tourRepository;
    }

    private async void MealsView_Load(object sender, EventArgs e)
    {
        await LoadToursToComboBoxAsync();
        await LoadMealsAsync();
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
            MessageBox.Show($"Error loading tours list: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async Task LoadMealsAsync()
    {
        try
        {
            dgvMeals.SelectionChanged -= dgvMeals_SelectionChanged;

            var meals = await _mealRepository.GetAllAsync();
            dgvMeals.DataSource = meals.OrderByDescending(m => m.MealId).ToList();

            ConfigureGridColumns();
            SetFormToNewState();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error loading meals: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            dgvMeals.SelectionChanged += dgvMeals_SelectionChanged;
        }
    }

    private void dgvMeals_SelectionChanged(object? sender, EventArgs e)
    {
        if (dgvMeals.CurrentRow != null && dgvMeals.CurrentRow.DataBoundItem is Meal meal)
        {
            _selectedMeal = meal;

            cmbMealType.Text = _selectedMeal.MealType;
            txtDescription.Text = _selectedMeal.Description;
            cmbTour.SelectedValue = _selectedMeal.TourId;

            btnDelete.Enabled = true;
        }
    }

    private async void btnSave_Click(object sender, EventArgs e)
    {
        try
        {
            if (cmbTour.SelectedValue == null)
            {
                MessageBox.Show("Please select a tour.", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(cmbMealType.Text))
            {
                MessageBox.Show("Meal type is required.", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedTourId = (int)cmbTour.SelectedValue;

            if (_selectedMeal == null)
            {
                var newMeal = new Meal
                {
                    TourId = selectedTourId,
                    MealType = cmbMealType.Text.Trim(),
                    Description = txtDescription.Text.Trim(),
                    Tour = null!
                };
                await _mealRepository.AddAsync(newMeal);
            }
            else
            {
                _selectedMeal.TourId = selectedTourId;
                _selectedMeal.MealType = cmbMealType.Text.Trim();
                _selectedMeal.Description = txtDescription.Text.Trim();
                await _mealRepository.UpdateAsync(_selectedMeal);
            }

            await LoadMealsAsync();
            MessageBox.Show("Meal saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error saving meal: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async void btnDelete_Click(object sender, EventArgs e)
    {
        if (_selectedMeal == null) return;

        var confirmResult = MessageBox.Show(
            $"Are you sure you want to delete this meal ({_selectedMeal.MealType})?",
            "Confirm deletion",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

        if (confirmResult == DialogResult.Yes)
        {
            try
            {
                await _mealRepository.DeleteAsync(_selectedMeal);
                await LoadMealsAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting meal: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    private void ConfigureGridColumns()
    {
        dgvMeals.Columns["MealId"]!.HeaderText = "ID";
        dgvMeals.Columns["TourId"]!.Visible = false;
        dgvMeals.Columns["MealType"]!.HeaderText = "Meal type";
        dgvMeals.Columns["Description"]!.HeaderText = "Description";

        dgvMeals.Columns["Tour"]!.Visible = false;

        dgvMeals.AutoResizeColumns();
    }

    private void SetFormToNewState()
    {
        cmbTour.SelectedIndex = -1;
        cmbMealType.SelectedIndex = -1;
        cmbMealType.Text = "";
        txtDescription.Text = "";

        _selectedMeal = null;
        dgvMeals.ClearSelection();
        btnDelete.Enabled = false;
        cmbTour.Focus();
    }
}
