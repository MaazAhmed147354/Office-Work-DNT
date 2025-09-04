using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class VwPayRoll
{
    public int? CompanyId { get; set; }

    public string? CompanyName { get; set; }

    public string? EmployeeName { get; set; }

    public string? MobileNo { get; set; }

    public int? BranchId { get; set; }

    public string? BranchName { get; set; }

    public string? BranchShortName { get; set; }

    public int Id { get; set; }

    public int? EmployeeId { get; set; }

    public string? Date { get; set; }

    public decimal? Advance { get; set; }

    public decimal? Loan { get; set; }

    public decimal? Deduction { get; set; }

    public decimal? OtherDeduction { get; set; }

    public string? OtherDeductionDescription { get; set; }

    public decimal? Bonus { get; set; }

    public decimal? PaidSalary { get; set; }

    public string? GeneratedDate { get; set; }

    public string? Status { get; set; }

    public string? PayrollNo { get; set; }

    public decimal? ActualSalary { get; set; }

    public decimal? IncomeTax { get; set; }

    public bool? IsIncomeTaxPaid { get; set; }
}
