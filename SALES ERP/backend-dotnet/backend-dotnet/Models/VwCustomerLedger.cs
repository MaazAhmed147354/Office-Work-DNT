using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class VwCustomerLedger
{
    public int CompanyId { get; set; }

    public string? InvoiceTypeCompany { get; set; }

    public string CompanyName { get; set; } = null!;

    public int PaymentId { get; set; }

    public string? PaymentMode { get; set; }

    public int? BranchId { get; set; }

    public string? BranchName { get; set; }

    public int? CustomerId { get; set; }

    public string? CustomerFullName { get; set; }

    public DateOnly? SubmitDate { get; set; }

    public int? OrderId { get; set; }

    public string? InvoiceUid { get; set; }

    public string InvoiceType { get; set; } = null!;

    public string? InvoiceId { get; set; }

    public string? PaymentType { get; set; }

    public string? PaymentTypeOrignal { get; set; }

    public string ChequeNo { get; set; } = null!;

    public string? ClearingDate { get; set; }

    public string? BankName { get; set; }

    public string? BankNameOld { get; set; }

    public decimal OrderAmount { get; set; }

    public decimal PaidAmount { get; set; }

    public decimal Courier { get; set; }

    public decimal OtherAmount { get; set; }

    public string ChequeStatus { get; set; } = null!;

    public string? Image { get; set; }

    public string? Comments { get; set; }

    public string ConfirmDate { get; set; } = null!;
}
