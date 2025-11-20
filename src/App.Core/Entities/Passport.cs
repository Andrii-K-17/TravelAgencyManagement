using System;

namespace App.Core.Entities;

public class Passport
{
    public int PassportId { get; set; }
    public int ClientId { get; set; }
    public required string PassportNumber { get; set; }
    public DateTime IssueDate { get; set; }
    public DateTime ExpiryDate { get; set; }
    public required string IssuingCountry { get; set; }

    public required virtual Client Client { get; set; }
}
