using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class VwCustomer
{
    public int Id { get; set; }

    public int CustomerId { get; set; }

    public int CompanyId { get; set; }

    public string CompanyName { get; set; } = null!;

    public string? InvoiceTypeCompany { get; set; }

    public int? BranchId { get; set; }

    public string? ShortName { get; set; }

    public string? BranchName { get; set; }

    public int? UserRole { get; set; }

    public string? UserRoleText { get; set; }

    public string? EmailAddress { get; set; }

    public string? Username { get; set; }

    public string? Password { get; set; }

    public string? Name { get; set; }

    public string? CustomerName { get; set; }

    public string? CustomerFullName { get; set; }

    public string? CustomerNameCompany { get; set; }

    public string? CustomerNameBranch { get; set; }

    public string Company { get; set; } = null!;

    public string MobileNo { get; set; } = null!;

    public string TeleNo { get; set; } = null!;

    public string? Fax { get; set; }

    public string? Zipcode { get; set; }

    public string? Address { get; set; }

    public int? CountryId { get; set; }

    public int? CityId { get; set; }

    public string? Country { get; set; }

    public string? City { get; set; }

    public string? Province { get; set; }

    public int? Active { get; set; }

    public bool? Active2 { get; set; }

    public bool? IsApproved { get; set; }

    public DateTime? CreatedOnUtc { get; set; }

    public int? BillingAddressId { get; set; }

    public int? AddressId { get; set; }

    public DateTime? CreatedDateFull { get; set; }

    public string? CreatedDateTime { get; set; }

    public string? CreatedDate { get; set; }

    public int Designation { get; set; }

    public string DesignationView { get; set; } = null!;
}
