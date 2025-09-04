using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class TblOtherPayment
{
    public int Id { get; set; }

    public int? CompanyId { get; set; }

    public int? BranchId { get; set; }

    public int? FromBankAccountId { get; set; }

    public int? ToBankAccountId { get; set; }

    public string? Type { get; set; }

    public string? TypeDescription { get; set; }

    public decimal? Credit { get; set; }

    public decimal? Debit { get; set; }

    public string? PaymentType { get; set; }

    public string? ChequeNo { get; set; }

    public string? ClearingDate { get; set; }

    public string? Image { get; set; }

    public string? Comments { get; set; }

    public string? SubmitDate { get; set; }

    public string? CreatedDate { get; set; }

    public int? OtherPaymentId { get; set; }

    public DateTime? ApprovedOn { get; set; }

    public int? ApprovedBy { get; set; }

    public bool? Approved { get; set; }

    public string? PayrollNo { get; set; }

    public long? EmployeeId { get; set; }
}
