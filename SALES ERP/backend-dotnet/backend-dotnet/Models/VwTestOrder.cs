using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class VwTestOrder
{
    public int? Count1 { get; set; }

    public int PaymentId { get; set; }

    public int? CompanyId { get; set; }

    public int? BankAccountId { get; set; }

    public string? PaymentMode { get; set; }

    public int? OrderId { get; set; }

    public string? InvoiceUid { get; set; }

    public int? CustomerId { get; set; }

    public decimal? OrderAmount { get; set; }

    public decimal? PaidAmount { get; set; }

    public string? PaymentType { get; set; }

    public string? ChequeNo { get; set; }

    public string? ClearingDate { get; set; }

    public string? Image { get; set; }

    public string? BankName { get; set; }

    public string? Comments { get; set; }

    public string? SubmitDate { get; set; }

    public int? PaymentIdDeduction { get; set; }

    public string? CreatedDate { get; set; }

    public string? ChequeStatus { get; set; }

    public string? ConfirmDate { get; set; }

    public int? IsDeduction { get; set; }

    public int? IsUpdated { get; set; }
}
