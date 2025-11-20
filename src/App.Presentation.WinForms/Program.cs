using App.Core.Interfaces;
using App.Infrastructure.Oracle.Data;
using App.Infrastructure.Oracle.Repositories;
using App.Presentation.WinForms.Views;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;
using System.Windows.Forms;

namespace App.Presentation.WinForms
{
    internal static class Program
    {
        public static IServiceProvider ServiceProvider { get; private set; } = null!;

        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var environment = Environment.GetEnvironmentVariable("APP_ENV") ?? "Production";
            var configuration = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{environment}.json", optional: true, reloadOnChange: true)
                .Build();

            var services = new ServiceCollection();
            ConfigureServices(services, configuration);
            ServiceProvider = services.BuildServiceProvider();

            Application.Run(ServiceProvider.GetRequiredService<MainView>());
        }

        private static void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<TourAgencyDbContext>(options =>
                options.UseOracle(configuration.GetConnectionString("OracleDbConnection")),
                ServiceLifetime.Transient);

            services.AddTransient<IClientRepository, OracleClientRepository>();
            services.AddTransient<ITourRepository, OracleTourRepository>();
            services.AddTransient<IBookingRepository, OracleBookingRepository>();
            services.AddTransient<IEmployeeRepository, OracleEmployeeRepository>();
            services.AddTransient<IHotelRepository, OracleHotelRepository>();
            services.AddTransient<IMealRepository, OracleMealRepository>();
            services.AddTransient<IPassportRepository, OraclePassportRepository>();
            services.AddTransient<IPaymentRepository, OraclePaymentRepository>();
            services.AddTransient<ITransportRepository, OracleTransportRepository>();

            services.AddTransient<MainView>();
            services.AddTransient<ClientsView>();
            services.AddTransient<ReportView>();
            services.AddTransient<ToursView>();
            services.AddTransient<EmployeesView>();
            services.AddTransient<MealsView>();
            services.AddTransient<HotelsView>();
            services.AddTransient<TransportView>();
            services.AddTransient<PaymentsView>();
            services.AddTransient<BookingsView>();
        }
    }
}
