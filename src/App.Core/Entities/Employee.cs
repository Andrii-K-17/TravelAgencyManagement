using System;
using System.Collections.Generic;

namespace App.Core.Entities;

public class Employee
{
	public int EmployeeId { get; set; }
	public required string FirstName { get; set; }
	public required string LastName { get; set; }
	public required string Position { get; set; }
	public required string Phone { get; set; }
	public required string Email { get; set; }
	public DateTime HireDate { get; set; }
	public decimal Salary { get; set; }

	public virtual ICollection<Booking> Bookings { get; set; } = [];
	public virtual ICollection<Payment> Payments { get; set; } = [];
	public virtual ICollection<Transport> Transports { get; set; } = [];
}
