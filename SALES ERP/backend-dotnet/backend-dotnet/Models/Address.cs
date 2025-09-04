using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class Address
{
    public int Id { get; set; }

    public int? UserRole { get; set; }

    public string? Username { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Email { get; set; }

    public string? Company { get; set; }

    public int? CountryId { get; set; }

    public int? StateProvinceId { get; set; }

    public string? Country { get; set; }

    public string? Province { get; set; }

    public string? City { get; set; }

    public string? Address1 { get; set; }

    public string? Address2 { get; set; }

    public string? ZipPostalCode { get; set; }

    public string? PhoneNumber { get; set; }

    public string? FaxNumber { get; set; }

    public DateTime CreatedOnUtc { get; set; }
}
