using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class TblCustomer
{
    public int Id { get; set; }

    public int? BranchId { get; set; }

    public int? UserRole { get; set; }

    public string? UserRoleText { get; set; }

    public string? Username { get; set; }

    public string? Password { get; set; }

    public string? Name { get; set; }

    public string? EmailAddress { get; set; }

    public string? Company { get; set; }

    public string? Country { get; set; }

    public string? Province { get; set; }

    public string? City { get; set; }

    public string? Zipcode { get; set; }

    public string? Address { get; set; }

    public string? TeleNo { get; set; }

    public string? MobileNo { get; set; }

    public string? Fax { get; set; }

    public int? Active { get; set; }

    public int? CreatedBy { get; set; }

    public string? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public string? UpdatedDate { get; set; }

    public int? CountryId { get; set; }

    public int? CityId { get; set; }
}
