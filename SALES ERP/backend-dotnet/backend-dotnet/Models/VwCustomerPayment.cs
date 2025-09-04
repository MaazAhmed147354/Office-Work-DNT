using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class VwCustomerPayment
{
    public int PaymentId { get; set; }

    public string? PaymentMode { get; set; }

    public int? OrderId { get; set; }

    public string? InvoiceUid { get; set; }

    public int? CustomerId { get; set; }

    public decimal? OrderAmount { get; set; }

    public decimal? PaidAmount { get; set; }

    public string? PaymentType { get; set; }

    public string ChequeNo { get; set; } = null!;

    public string ClearingDate { get; set; } = null!;

    public string? Image { get; set; }

    public int CompanyId { get; set; }

    public int BankAccountId { get; set; }

    public string? BankName { get; set; }

    public string? BankNameOld { get; set; }

    public string? Comments { get; set; }

    public string? SubmitDate { get; set; }

    public int PaymentIdDeduction { get; set; }

    public string? CreatedDate { get; set; }

    public string ChequeStatus { get; set; } = null!;

    public string ConfirmDate { get; set; } = null!;

    public string CompanyName { get; set; } = null!;

    public string? InvoiceTypeCompany { get; set; }

    public string? CustomerName { get; set; }

    public string? CustomerFullName { get; set; }

    public string? Username { get; set; }

    public string? EmailAddress { get; set; }

    public string Company { get; set; } = null!;

    public string MobileNo { get; set; } = null!;

    public string TeleNo { get; set; } = null!;

    public string? City { get; set; }

    public int? Active { get; set; }

    public int? BranchId { get; set; }

    public string? ShortName { get; set; }

    public string? BranchShortName { get; set; }

    public string? BranchName { get; set; }

    public decimal? TotalOrderAmount { get; set; }

    public decimal? TotalPaidAmount { get; set; }

    public bool IsPartialPayment { get; set; }

    public bool IsAdvancePayment { get; set; }

    public decimal RemainingBalance { get; set; }
}
