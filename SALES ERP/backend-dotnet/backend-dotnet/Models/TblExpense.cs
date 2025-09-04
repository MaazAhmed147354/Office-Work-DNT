using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class TblExpense
{
    public int Id { get; set; }

    public DateTime? Date { get; set; }

    public int? BranchId { get; set; }

    public string? OfficeWareHouse { get; set; }

    public string? DailyMonthly { get; set; }

    public string? DailyMonthlyTypes { get; set; }

    public int? TypeId { get; set; }

    public string? DailyMonthlyOther { get; set; }

    public decimal? Amount { get; set; }

    public string? Comments { get; set; }

    public int? CreatedBy { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public int? CompanyId { get; set; }

    public int? BankAccountId { get; set; }

    public string? PaymentType { get; set; }

    public string? ChequeNo { get; set; }

    public DateTime? ClearingDate { get; set; }

    public string? SubmitProof { get; set; }

    public DateTime? ApprovedOn { get; set; }

    public int? ApprovedBy { get; set; }

    public bool? Approved { get; set; }
}
