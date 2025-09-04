using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class VwBonu
{
    public int? CompanyId { get; set; }

    public string? CompanyName { get; set; }

    public string? EmployeeName { get; set; }

    public string? MobileNo { get; set; }

    public int? BranchId { get; set; }

    public string? BranchName { get; set; }

    public string? BranchShortName { get; set; }

    public int Id { get; set; }

    public string? BonusMonth { get; set; }

    public string? Comments { get; set; }

    public string? Status { get; set; }

    public int? EmployeeId { get; set; }

    public decimal? BonusAmount { get; set; }
}
