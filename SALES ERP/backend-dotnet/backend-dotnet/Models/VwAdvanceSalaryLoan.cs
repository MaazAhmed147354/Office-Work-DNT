using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class VwAdvanceSalaryLoan
{
    public int CompanyId { get; set; }

    public string CompanyName { get; set; } = null!;

    public string? EmployeeName { get; set; }

    public string MobileNo { get; set; } = null!;

    public int BranchId { get; set; }

    public string? BranchName { get; set; }

    public string? BranchShortName { get; set; }

    public string? Type { get; set; }

    public int Id { get; set; }

    public int? EmployeeId { get; set; }

    public decimal AdvanceAmount { get; set; }

    public decimal ReturnAmount { get; set; }

    public string? AdvanceDate { get; set; }

    public string? ReturnDate { get; set; }

    public int BankAccountId { get; set; }

    public string? PaymentType { get; set; }

    public string? ChequeNo { get; set; }

    public DateTime? ClearingDate { get; set; }

    public string? SubmitProof { get; set; }

    public string? Date { get; set; }

    public string? Comments { get; set; }

    public int PayRollId { get; set; }

    public bool? Approved { get; set; }

    public DateTime? ApprovedOn { get; set; }

    public int? ApprovedBy { get; set; }

    public string? VoucherProof { get; set; }
}
