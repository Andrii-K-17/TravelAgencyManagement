using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

namespace App.Presentation.WinForms.Views;

public partial class MainView : Form
{
    private readonly IServiceProvider _serviceProvider;
    private Form? activeForm = null;

    public MainView(IServiceProvider serviceProvider)
    {
        InitializeComponent();
        _serviceProvider = serviceProvider;
    }

    private void ShowChildForm<TForm>() where TForm : Form
    {
        if (activeForm != null)
        {
            activeForm.Close();
        }

        activeForm = _serviceProvider.GetRequiredService<TForm>();

        activeForm.MdiParent = this;
        activeForm.FormBorderStyle = FormBorderStyle.None;
        activeForm.Dock = DockStyle.Fill;

        activeForm.Show();
    }

    private void mnuShowClients_Click(object sender, EventArgs e)
    {
        ShowChildForm<ClientsView>();
    }

    private void mnuShowReport_Click(object sender, EventArgs e)
    {
        ShowChildForm<ReportView>();
    }

    private void mnuShowTours_Click(object sender, EventArgs e)
    {
        ShowChildForm<ToursView>();
    }

    private void mnuShowEmployees_Click(object sender, EventArgs e)
    {
        ShowChildForm<EmployeesView>();
    }

    private void mnuShowMeals_Click(object sender, EventArgs e)
    {
        ShowChildForm<MealsView>();
    }

    private void mnuShowHotels_Click(object sender, EventArgs e)
    {
        ShowChildForm<HotelsView>();
    }

    private void mnuShowTransport_Click(object sender, EventArgs e)
    {
        ShowChildForm<TransportView>();
    }

    private void mnuShowPayments_Click(object sender, EventArgs e)
    {
        ShowChildForm<PaymentsView>();
    }

    private void mnuShowBookings_Click(object sender, EventArgs e)
    {
        ShowChildForm<BookingsView>();
    }

    private void MainView_Load(object sender, EventArgs e)
    {
        pnlMdiBackground.SendToBack();
    }

    private void mnuFileExit_Click(object sender, EventArgs e)
    {
        var result = MessageBox.Show(
            "Are you sure you want to exit the application?",
            "Confirm exit",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

        if (result == DialogResult.Yes)
        {
            this.Close();
        }
    }
}
