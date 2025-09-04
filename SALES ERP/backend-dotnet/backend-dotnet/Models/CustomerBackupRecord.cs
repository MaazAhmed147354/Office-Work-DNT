using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class CustomerBackupRecord
{
    public int Id { get; set; }

    public int? BranchId { get; set; }

    public int? UserRole { get; set; }

    public string? UserRoleText { get; set; }

    public string? Username { get; set; }

    public string? Email { get; set; }

    public string? Password { get; set; }

    public int PasswordFormatId { get; set; }

    public string? PasswordSalt { get; set; }

    public string? AdminComment { get; set; }

    public bool? IsTaxExempt { get; set; }

    public int? AffiliateId { get; set; }

    public int? VendorId { get; set; }

    public bool HasShoppingCartItems { get; set; }

    public bool? Active { get; set; }

    public bool? IsApproved { get; set; }

    public bool? Deleted { get; set; }

    public bool IsSystemAccount { get; set; }

    public string? SystemName { get; set; }

    public string? LastIpAddress { get; set; }

    public DateTime? CreatedOnUtc { get; set; }

    public DateTime? LastLoginDateUtc { get; set; }

    public DateTime? LastActivityDateUtc { get; set; }

    public int? BillingAddressId { get; set; }

    public int? ShippingAddressId { get; set; }

    public Guid CustomerGuid { get; set; }

    public int? CompanyId { get; set; }
}
