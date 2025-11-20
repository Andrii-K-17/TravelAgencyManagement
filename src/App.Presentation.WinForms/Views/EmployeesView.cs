using App.Core.Entities;
using App.Core.Interfaces;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.Presentation.WinForms.Views;

public partial class EmployeesView : Form
{
    private readonly IEmployeeRepository _employeeRepository;
    private Employee? _selectedEmployee;

    public EmployeesView(IEmployeeRepository employeeRepository)
    {
        InitializeComponent();
        _employeeRepository = employeeRepository;
    }

    private async void EmployeesView_Load(object sender, EventArgs e)
    {
        await LoadEmployeesAsync();
    }

    private async Task LoadEmployeesAsync()
    {
        try
        {
            dgvEmployees.SelectionChanged -= dgvEmployees_SelectionChanged;

            var employees = await _employeeRepository.GetAllAsync();
            dgvEmployees.DataSource = employees.ToList();

            ConfigureGridColumns();
            SetFormToNewState();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error loading employees: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            dgvEmployees.SelectionChanged += dgvEmployees_SelectionChanged;
        }
    }

    private void dgvEmployees_SelectionChanged(object? sender, EventArgs e)
    {
        if (dgvEmployees.CurrentRow != null && dgvEmployees.CurrentRow.DataBoundItem is Employee employee)
        {
            _selectedEmployee = employee;

            txtFirstName.Text = _selectedEmployee.FirstName;
            txtLastName.Text = _selectedEmployee.LastName;
            txtPosition.Text = _selectedEmployee.Position;
            txtPhone.Text = _selectedEmployee.Phone;
            txtEmail.Text = _selectedEmployee.Email;
            dtpHireDate.Value = _selectedEmployee.HireDate;
            numSalary.Value = _selectedEmployee.Salary;

            btnDelete.Enabled = true;
        }
    }

    private async void btnSave_Click(object sender, EventArgs e)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show("First name is required.", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFirstName.Focus();
                return;
            }

            if (txtFirstName.Text.Length > 30)
            {
                MessageBox.Show("First name cannot exceed 30 characters.", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFirstName.Focus();
                return;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(txtFirstName.Text, @"^[a-zA-Zа-яА-ЯіІїЇєЄґҐ\s'-]+$"))
            {
                MessageBox.Show("First name can only contain letters, spaces, hyphens and apostrophes.", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFirstName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Last name is required.", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLastName.Focus();
                return;
            }

            if (txtLastName.Text.Length > 30)
            {
                MessageBox.Show("Last name cannot exceed 30 characters.", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLastName.Focus();
                return;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(txtLastName.Text, @"^[a-zA-Zа-яА-ЯіІїЇєЄґҐ\s'-]+$"))
            {
                MessageBox.Show("Last name can only contain letters, spaces, hyphens and apostrophes.", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLastName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPosition.Text))
            {
                MessageBox.Show("Position is required.", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPosition.Focus();
                return;
            }

            if (txtPosition.Text.Length > 50)
            {
                MessageBox.Show("Position cannot exceed 50 characters.", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPosition.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Email is required.", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(txtEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Invalid email format.", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }

            if (!string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(txtPhone.Text, @"^\+?380\d{9}$"))
                {
                    MessageBox.Show("Phone must be in format: +380XXXXXXXXX", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPhone.Focus();
                    return;
                }
            }

            if (dtpHireDate.Value > DateTime.Now)
            {
                MessageBox.Show("Hire date cannot be in the future.", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpHireDate.Focus();
                return;
            }

            if (numSalary.Value <= 0)
            {
                MessageBox.Show("Salary must be greater than 0.", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numSalary.Focus();
                return;
            }

            if (numSalary.Value > 999999.99m)
            {
                MessageBox.Show("Salary cannot exceed 999,999.99.", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numSalary.Focus();
                return;
            }

            if (_selectedEmployee == null)
            {
                var newEmployee = new Employee
                {
                    FirstName = txtFirstName.Text.Trim(),
                    LastName = txtLastName.Text.Trim(),
                    Position = txtPosition.Text.Trim(),
                    Phone = txtPhone.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    HireDate = dtpHireDate.Value,
                    Salary = numSalary.Value
                };
                await _employeeRepository.AddAsync(newEmployee);
            }
            else
            {
                _selectedEmployee.FirstName = txtFirstName.Text.Trim();
                _selectedEmployee.LastName = txtLastName.Text.Trim();
                _selectedEmployee.Position = txtPosition.Text.Trim();
                _selectedEmployee.Phone = txtPhone.Text.Trim();
                _selectedEmployee.Email = txtEmail.Text.Trim();
                _selectedEmployee.HireDate = dtpHireDate.Value;
                _selectedEmployee.Salary = numSalary.Value;
                await _employeeRepository.UpdateAsync(_selectedEmployee);
            }

            await LoadEmployeesAsync();
            MessageBox.Show("Employee saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            SetFormToNewState();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error saving employee: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async void btnDelete_Click(object sender, EventArgs e)
    {
        if (_selectedEmployee == null)
        {
            MessageBox.Show("Please select an employee to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var confirmResult = MessageBox.Show(
            $"Are you sure you want to delete '{_selectedEmployee.FirstName} {_selectedEmployee.LastName}'?",
            "Confirm Deletion",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

        if (confirmResult == DialogResult.Yes)
        {
            try
            {
                await _employeeRepository.DeleteAsync(_selectedEmployee);
                await LoadEmployeesAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting employee: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    private void ConfigureGridColumns()
    {
        dgvEmployees.Columns["EmployeeId"]?.HeaderText = "ID";
        dgvEmployees.Columns["FirstName"]?.HeaderText = "First name";
        dgvEmployees.Columns["LastName"]?.HeaderText = "Last name";
        dgvEmployees.Columns["HireDate"]?.HeaderText = "Hire date";

        string[] hide = ["Bookings", "Payments", "Transports"];
        foreach (var col in hide)
        {
            dgvEmployees.Columns[col]!.Visible = false;
        }
        dgvEmployees.AutoResizeColumns();
    }

    private void SetFormToNewState()
    {
        txtFirstName.Text = "";
        txtLastName.Text = "";
        txtPosition.Text = "";
        txtPhone.Text = "";
        txtEmail.Text = "";
        dtpHireDate.Value = DateTime.Now;
        numSalary.Value = 0;

        _selectedEmployee = null;
        dgvEmployees.ClearSelection();
        btnDelete.Enabled = false;
        txtFirstName.Focus();
    }
}
