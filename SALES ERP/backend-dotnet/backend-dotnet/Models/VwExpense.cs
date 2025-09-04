using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class VwExpense
{
    public int? CompanyId { get; set; }

    public string? CompanyName { get; set; }

    public int Id { get; set; }

    public DateTime? Date { get; set; }

    public string? Date2 { get; set; }

    public string? OfficeWareHouse { get; set; }

    public string? DailyMonthly { get; set; }

    public int TypeId { get; set; }

    public string? DailyMonthlyTypesOld { get; set; }

    public string? Types { get; set; }

    public string? TypesView { get; set; }

    public decimal? Amount { get; set; }

    public int BankAccountId { get; set; }

    public string? PaymentType { get; set; }

    public string? ChequeNo { get; set; }

    public DateTime? ClearingDate { get; set; }

    public string? SubmitProof { get; set; }

    public string? Comments { get; set; }

    public int? BranchId { get; set; }

    public string? BranchName { get; set; }

    public string? DailyMonthlyOther { get; set; }

    public string? BranchShortName { get; set; }

    public string? BankName { get; set; }

    public string? AccountTitle { get; set; }

    public int? BankId { get; set; }

    public int? OrderBy { get; set; }

    public bool? Approved { get; set; }

    public DateTime? ApprovedOn { get; set; }

    public int? ApprovedBy { get; set; }
}
