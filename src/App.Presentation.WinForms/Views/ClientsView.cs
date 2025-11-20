using App.Core.Entities;
using App.Core.Interfaces;
using App.Infrastructure.Oracle.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using App.Core.DTOs;

namespace App.Presentation.WinForms.Views;

public partial class ClientsView : Form
{
    private readonly IClientRepository _clientRepository;
    private Client? _selectedClient;
    private IEnumerable<Client>? _clients;

    public ClientsView(IClientRepository clientRepository)
    {
        InitializeComponent();
        _clientRepository = clientRepository;
    }

    private async void ClientsView_Load(object? sender, EventArgs e)
    {
        await LoadClientsAsync();
    }

    private static Passport? TryGetPassport(Client client)
    {
        return client.Passports.FirstOrDefault();
    }

    private async Task LoadClientsAsync()
    {
        try
        {
            dgvClients.SelectionChanged -= dgvClients_SelectionChanged;

            _clients = await _clientRepository.GetAllWithPassportsAsync();
            var clientDtos = _clients.Select(c =>
            {
                var passport = TryGetPassport(c);
                return new ClientDisplayDto
                {
                    ClientId = c.ClientId,
                    FirstName = c.FirstName,
                    LastName = c.LastName,
                    Phone = c.Phone,
                    Email = c.Email,
                    PassportNumber = passport?.PassportNumber ?? string.Empty,
                    IssueDate = passport?.IssueDate,
                    ExpiryDate = passport?.ExpiryDate,
                    IssuingCountry = passport?.IssuingCountry ?? string.Empty,
                    SourceClient = c
                };
            }).ToList();

            dgvClients.DataSource = clientDtos;
            ConfigureGridColumns();
            SetFormToNewState();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error loading clients: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            dgvClients.SelectionChanged += dgvClients_SelectionChanged;
        }
    }

    private void ConfigureGridColumns()
    {
        dgvClients.Columns["ClientId"]?.HeaderText = "ID";
        dgvClients.Columns["FirstName"]?.HeaderText = "First name";
        dgvClients.Columns["LastName"]?.HeaderText = "Last name";
        dgvClients.Columns["Phone"]?.HeaderText = "Phone";
        dgvClients.Columns["Email"]?.HeaderText = "Email";

        dgvClients.Columns["PassportNumber"]?.HeaderText = "Passport number";
        dgvClients.Columns["IssueDate"]?.HeaderText = "Issue date";
        dgvClients.Columns["ExpiryDate"]?.HeaderText = "Expiry date";
        dgvClients.Columns["IssuingCountry"]?.HeaderText = "Issuing country";

        dgvClients.Columns["SourceClient"]?.Visible = false;
        dgvClients.AutoResizeColumns();
    }

    private void dgvClients_SelectionChanged(object? sender, EventArgs e)
    {
        if (dgvClients.CurrentRow != null && dgvClients.CurrentRow.DataBoundItem is ClientDisplayDto selectedDto)
        {
            _selectedClient = selectedDto.SourceClient;
            Passport? passport = TryGetPassport(_selectedClient);

            txtFirstName.Text = _selectedClient.FirstName;
            txtLastName.Text = _selectedClient.LastName;
            txtPhone.Text = _selectedClient.Phone;
            txtEmail.Text = _selectedClient.Email;

            if (passport != null)
            {
                txtPassportNumber.Text = passport.PassportNumber;
                dtpIssueDate.Value = passport.IssueDate;
                dtpExpiryDate.Value = passport.ExpiryDate;
                txtIssuingCountry.Text = passport.IssuingCountry;
            }
            else
            {
                ClearPassportFields();
            }

            btnDelete.Enabled = true;
        }
    }

    private async void btnSave_Click(object sender, EventArgs e)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) || string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtPhone.Text) || string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("First name, last name, phone number and email are required.", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!string.IsNullOrWhiteSpace(txtPassportNumber.Text) || !string.IsNullOrWhiteSpace(txtIssuingCountry.Text))
            {
                if (string.IsNullOrWhiteSpace(txtPassportNumber.Text) || string.IsNullOrWhiteSpace(txtIssuingCountry.Text) || dtpIssueDate.Value >= dtpExpiryDate.Value)
                {
                    MessageBox.Show("To save your passport, fill in the number, country of issue, and the expiration date must be later than the date of issue.", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            if (_selectedClient == null)
            {
                var newClient = new Client
                {
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    Phone = txtPhone.Text,
                    Email = txtEmail.Text
                };

                if (!string.IsNullOrWhiteSpace(txtPassportNumber.Text))
                {
                    var newPassport = CreatePassportFromForm(newClient);
                    newClient.Passports.Add(newPassport);
                }

                await _clientRepository.AddAsync(newClient);
            }
            else
            {
                _selectedClient.FirstName = txtFirstName.Text;
                _selectedClient.LastName = txtLastName.Text;
                _selectedClient.Phone = txtPhone.Text;
                _selectedClient.Email = txtEmail.Text;

                UpdatePassportData(_selectedClient);

                await _clientRepository.UpdateAsync(_selectedClient);
            }

            await LoadClientsAsync();
            MessageBox.Show("Saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            SetFormToNewState();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error saving data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    
    private Passport CreatePassportFromForm(Client client)
    {
        return new Passport
        {
            Client = client,
            ClientId = client.ClientId,
            PassportNumber = txtPassportNumber.Text,
            IssueDate = dtpIssueDate.Value.Date,
            ExpiryDate = dtpExpiryDate.Value.Date,
            IssuingCountry = txtIssuingCountry.Text,
        };
    }

    private void UpdatePassportData(Client client)
    {
        Passport? existingPassport = TryGetPassport(client);
        bool passportDataProvided = !string.IsNullOrWhiteSpace(txtPassportNumber.Text);
        if (passportDataProvided)
        {
            if (existingPassport == null)
            {
                client.Passports.Add(CreatePassportFromForm(client));
            }
            else
            {
                existingPassport.PassportNumber = txtPassportNumber.Text;
                existingPassport.IssueDate = dtpIssueDate.Value.Date;
                existingPassport.ExpiryDate = dtpExpiryDate.Value.Date;
                existingPassport.IssuingCountry = txtIssuingCountry.Text;
            }
        }
    }

    private async void btnDelete_Click(object sender, EventArgs e)
    {
        if (_selectedClient == null)
        {
            MessageBox.Show("Please select a client to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var confirmResult = MessageBox.Show(
            $"Are you sure you want to delete {_selectedClient.FirstName} {_selectedClient.LastName}?",
            "Confirm deletion",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

        if (confirmResult == DialogResult.Yes)
        {
            try
            {
                await _clientRepository.DeleteAsync(_selectedClient);
                await LoadClientsAsync();
                MessageBox.Show("Deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SetFormToNewState();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting record: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    private void ClearPassportFields()
    {
        txtPassportNumber.Text = "";
        dtpIssueDate.Value = DateTime.Today;
        dtpExpiryDate.Value = DateTime.Today;
        txtIssuingCountry.Text = "";
    }

    private void SetFormToNewState()
    {
        txtFirstName.Text = "";
        txtLastName.Text = "";
        txtPhone.Text = "";
        txtEmail.Text = "";
        ClearPassportFields();
        _selectedClient = null;
        dgvClients.ClearSelection();
        btnDelete.Enabled = false;
        txtFirstName.Focus();
    }

    private class ClientDisplayDto
    {
        public int ClientId { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PassportNumber { get; set; } = string.Empty;
        public DateTime? IssueDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string IssuingCountry { get; set; } = string.Empty;
        public Client SourceClient { get; set; } = null!;
    }
}
