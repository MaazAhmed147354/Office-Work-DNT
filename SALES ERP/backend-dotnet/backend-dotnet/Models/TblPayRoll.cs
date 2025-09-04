using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class TblPayRoll
{
    public int Id { get; set; }

    public int? EmployeeId { get; set; }

    public decimal? Bonus { get; set; }

    public decimal? Loan { get; set; }

    public decimal? PaidSalary { get; set; }

    public string? OtherDeductionDescription { get; set; }

    public string? GeneratedDate { get; set; }

    public string? Date { get; set; }

    public decimal? Advance { get; set; }

    public decimal? Deduction { get; set; }

    public decimal? OtherDeduction { get; set; }

    public string? Status { get; set; }

    public decimal? BasicSalary { get; set; }

    public decimal? TotalAllowances { get; set; }

    public decimal? AdvanceSalary { get; set; }

    public decimal? LoanTaken { get; set; }

    public int? BranchId { get; set; }

    public string? PayrollNo { get; set; }

    public bool? IsIncomeTaxPaid { get; set; }

    public decimal? IncomeTax { get; set; }

    public bool? IsSalaryPaid { get; set; }
}
