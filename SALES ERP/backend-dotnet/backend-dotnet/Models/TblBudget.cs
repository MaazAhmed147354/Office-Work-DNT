using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class TblBudget
{
    public int Id { get; set; }

    public int? BranchId { get; set; }

    public decimal? Amount { get; set; }

    public DateTime? Date { get; set; }

    public string? Comments { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public int? BankAccountId { get; set; }

    public int? CompanyId { get; set; }
}
