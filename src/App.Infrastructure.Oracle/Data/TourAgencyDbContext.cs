using App.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace App.Infrastructure.Oracle.Data;

/// <summary>
/// Database context for EF Core (describes tables and relationships).
/// </summary>
public class TourAgencyDbContext(DbContextOptions<TourAgencyDbContext> options) : DbContext(options)
{
    public DbSet<Client> Clients { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Tour> Tours { get; set; }
    public DbSet<Hotel> Hotels { get; set; }
    public DbSet<Meal> Meals { get; set; }
    public DbSet<Passport> Passports { get; set; }
    public DbSet<Booking> Bookings { get; set; }
    public DbSet<Payment> Payments { get; set; }
    public DbSet<Transport> Transports { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Client>(e =>
        {
            e.ToTable("CLIENTS");
            e.HasKey(c => c.ClientId);
            e.Property(c => c.ClientId).HasColumnName("CLIENT_ID").ValueGeneratedOnAdd();
            e.Property(c => c.FirstName).HasColumnName("FIRST_NAME").HasMaxLength(30);
            e.Property(c => c.LastName).HasColumnName("LAST_NAME").HasMaxLength(30);
            e.Property(c => c.Phone).HasColumnName("PHONE").HasMaxLength(15);
            e.Property(c => c.Email).HasColumnName("EMAIL").HasMaxLength(50);
        });

        modelBuilder.Entity<Employee>(e =>
        {
            e.ToTable("EMPLOYEES");
            e.HasKey(emp => emp.EmployeeId);
            e.Property(emp => emp.EmployeeId).HasColumnName("EMPLOYEE_ID").ValueGeneratedOnAdd();
            e.Property(emp => emp.FirstName).HasColumnName("FIRST_NAME").HasMaxLength(30);
            e.Property(emp => emp.LastName).HasColumnName("LAST_NAME").HasMaxLength(30);
            e.Property(emp => emp.Position).HasColumnName("POSITION").HasMaxLength(50);
            e.Property(emp => emp.Phone).HasColumnName("PHONE").HasMaxLength(15);
            e.Property(emp => emp.Email).HasColumnName("EMAIL").HasMaxLength(50);
            e.Property(emp => emp.HireDate).HasColumnName("HIRE_DATE");
            e.Property(emp => emp.Salary).HasColumnName("SALARY").HasColumnType("NUMBER(8, 2)");
        });

        modelBuilder.Entity<Tour>(e =>
        {
            e.ToTable("TOURS");
            e.HasKey(t => t.TourId);
            e.Property(t => t.TourId).HasColumnName("TOUR_ID").ValueGeneratedOnAdd();
            e.Property(t => t.TourName).HasColumnName("TOUR_NAME").HasMaxLength(50);
            e.Property(t => t.Destination).HasColumnName("DESTINATION").HasMaxLength(50);
            e.Property(t => t.StartDate).HasColumnName("START_DATE");
            e.Property(t => t.EndDate).HasColumnName("END_DATE");
            e.Property(t => t.Price).HasColumnName("PRICE").HasColumnType("NUMBER(8, 2)");
        });

        modelBuilder.Entity<Hotel>(e =>
        {
            e.ToTable("HOTELS");
            e.HasKey(h => h.HotelId);
            e.Property(h => h.HotelId).HasColumnName("HOTEL_ID").ValueGeneratedOnAdd();
            e.Property(h => h.HotelName).HasColumnName("HOTEL_NAME").HasMaxLength(50);
            e.Property(h => h.Location).HasColumnName("LOCATION").HasMaxLength(50);
            e.Property(h => h.Stars).HasColumnName("STARS").HasColumnType("NUMBER(2)");
            e.Property(h => h.Phone).HasColumnName("PHONE").HasMaxLength(15);
            e.Property(h => h.Email).HasColumnName("EMAIL").HasMaxLength(50);
            e.Property(h => h.TourId).HasColumnName("TOUR_ID");

            e.HasOne(h => h.Tour)
             .WithMany(t => t.Hotels)
             .HasForeignKey(h => h.TourId)
             .OnDelete(DeleteBehavior.Cascade)
             .HasConstraintName("HOTELS_TOURS_FK");
        });

        modelBuilder.Entity<Meal>(e =>
        {
            e.ToTable("MEALS");
            e.HasKey(m => m.MealId);
            e.Property(m => m.MealId).HasColumnName("MEAL_ID").ValueGeneratedOnAdd();
            e.Property(m => m.TourId).HasColumnName("TOUR_ID");
            e.Property(m => m.MealType).HasColumnName("MEAL_TYPE").HasMaxLength(30);
            e.Property(m => m.Description).HasColumnName("DESCRIPTION").HasMaxLength(250);

            e.HasOne(m => m.Tour)
             .WithMany(t => t.Meals)
             .HasForeignKey(m => m.TourId)
             .OnDelete(DeleteBehavior.Cascade)
             .HasConstraintName("MEALS_TOURS_FK");
        });

        modelBuilder.Entity<Passport>(e =>
        {
            e.ToTable("PASSPORT");
            e.HasKey(p => p.PassportId);
            e.Property(p => p.PassportId).HasColumnName("PASSPORT_ID").ValueGeneratedOnAdd();
            e.Property(p => p.ClientId).HasColumnName("CLIENT_ID");
            e.Property(p => p.PassportNumber).HasColumnName("PASSPORT_NUMBER").HasMaxLength(20);
            e.Property(p => p.IssueDate).HasColumnName("ISSUE_DATE");
            e.Property(p => p.ExpiryDate).HasColumnName("EXPIRY_DATE");
            e.Property(p => p.IssuingCountry).HasColumnName("ISSUING_COUNTRY").HasMaxLength(50);

            e.HasOne(p => p.Client)
             .WithMany(c => c.Passports)
             .HasForeignKey(p => p.ClientId)
             .OnDelete(DeleteBehavior.Cascade)
             .HasConstraintName("PASSPORT_CLIENTS_FK");
        });

        modelBuilder.Entity<Booking>(e =>
        {
            e.ToTable("BOOKINGS");
            e.HasKey(b => b.BookingId);
            e.Property(b => b.BookingId).HasColumnName("BOOKING_ID").ValueGeneratedOnAdd();
            e.Property(b => b.BookingDate).HasColumnName("BOOKING_DATE");
            e.Property(b => b.ClientId).HasColumnName("CLIENT_ID");
            e.Property(b => b.TourId).HasColumnName("TOUR_ID");
            e.Property(b => b.EmployeeId).HasColumnName("EMPLOYEE_ID");

            e.HasOne(b => b.Client)
             .WithMany(c => c.Bookings)
             .HasForeignKey(b => b.ClientId)
             .OnDelete(DeleteBehavior.Cascade)
             .HasConstraintName("BOOKINGS_CLIENTS_FK");

            e.HasOne(b => b.Employee)
             .WithMany(emp => emp.Bookings)
             .HasForeignKey(b => b.EmployeeId)
             .OnDelete(DeleteBehavior.Cascade)
             .HasConstraintName("BOOKINGS_EMPLOYEES_FK");

            e.HasOne(b => b.Tour)
             .WithMany(t => t.Bookings)
             .HasForeignKey(b => b.TourId)
             .OnDelete(DeleteBehavior.Cascade)
             .HasConstraintName("BOOKINGS_TOURS_FK");
        });

        modelBuilder.Entity<Payment>(e =>
        {
            e.ToTable("PAYMENTS");
            e.HasKey(p => p.PaymentId);
            e.Property(p => p.PaymentId).HasColumnName("PAYMENT_ID").ValueGeneratedOnAdd();
            e.Property(p => p.BookingId).HasColumnName("BOOKING_ID");
            e.Property(p => p.Amount).HasColumnName("AMOUNT").HasColumnType("NUMBER(8, 2)");
            e.Property(p => p.PaymentDate).HasColumnName("PAYMENT_DATE");
            e.Property(p => p.TransactionNumber).HasColumnName("TRANSACTION_NUMBER").HasMaxLength(100);
            e.Property(p => p.PaymentMethod).HasColumnName("PAYMENT_METHOD").HasMaxLength(50);
            e.Property(p => p.EmployeeId).HasColumnName("EMPLOYEE_ID");

            e.HasOne(p => p.Booking)
             .WithMany(b => b.Payments)
             .HasForeignKey(p => p.BookingId)
             .OnDelete(DeleteBehavior.Cascade)
             .HasConstraintName("PAYMENTS_BOOKINGS_FK");

            e.HasOne(p => p.Employee)
             .WithMany(emp => emp.Payments)
             .HasForeignKey(p => p.EmployeeId)
             .HasConstraintName("PAYMENTS_EMPLOYEES_FK");
        });

        modelBuilder.Entity<Transport>(e =>
        {
            e.ToTable("TRANSPORT");
            e.HasKey(t => t.TransportId);
            e.Property(t => t.TransportId).HasColumnName("TRANSPORT_ID").ValueGeneratedOnAdd();
            e.Property(t => t.TransportType).HasColumnName("TRANSPORT_TYPE").HasMaxLength(30);
            e.Property(t => t.RouteNumber).HasColumnName("ROUTE_NUMBER").HasMaxLength(20);
            e.Property(t => t.DepartureDate).HasColumnName("DEPARTURE_DATE");
            e.Property(t => t.DepartureTime).HasColumnName("DEPARTURE_TIME");
            e.Property(t => t.DeparturePlace).HasColumnName("DEPARTURE_PLACE").HasMaxLength(50);
            e.Property(t => t.ArrivalPlace).HasColumnName("ARRIVAL_PLACE").HasMaxLength(50);
            e.Property(t => t.Price).HasColumnName("PRICE").HasColumnType("NUMBER(8, 2)");
            e.Property(t => t.EmployeeId).HasColumnName("EMPLOYEE_ID");
            e.Property(t => t.TourId).HasColumnName("TOUR_ID");

            e.HasOne(t => t.Employee)
             .WithMany(emp => emp.Transports)
             .HasForeignKey(t => t.EmployeeId)
             .HasConstraintName("TRANSPORT_EMPLOYEES_FK");

            e.HasOne(t => t.Tour)
             .WithMany(tour => tour.Transports)
             .HasForeignKey(t => t.TourId)
             .OnDelete(DeleteBehavior.Cascade)
             .HasConstraintName("TRANSPORT_TOURS_FK");
        });
    }
}
