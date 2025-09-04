using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class VwOtherPayment
{
    public int Id { get; set; }

    public int? CompanyId { get; set; }

    public string? Type { get; set; }

    public string? TypeView { get; set; }

    public string? TypeDescription { get; set; }

    public decimal? Credit { get; set; }

    public decimal? Debit { get; set; }

    public decimal BankCharges { get; set; }

    public string? PaymentType { get; set; }

    public string? ChequeNo { get; set; }

    public int? FromBankAccountId { get; set; }

    public int FromBankId { get; set; }

    public string FromBankName { get; set; } = null!;

    public string FromBankAccount { get; set; } = null!;

    public string FromBankAccountTitle { get; set; } = null!;

    public int? ToBankAccountId { get; set; }

    public int ToBankId { get; set; }

    public string ToBankName { get; set; } = null!;

    public string ToBankAccount { get; set; } = null!;

    public string ToBankAccountTitle { get; set; } = null!;

    public string? ClearingDate { get; set; }

    public string? Image { get; set; }

    public string? Comments { get; set; }

    public string? SubmitDate { get; set; }

    public string? CreatedDate { get; set; }

    public int? OtherPaymentId { get; set; }

    public int? BranchId { get; set; }

    public string? ShortName { get; set; }

    public string? BranchName { get; set; }

    public string? CompanyName { get; set; }

    public bool? Approved { get; set; }

    public DateTime? ApprovedOn { get; set; }

    public int? ApprovedBy { get; set; }
}
