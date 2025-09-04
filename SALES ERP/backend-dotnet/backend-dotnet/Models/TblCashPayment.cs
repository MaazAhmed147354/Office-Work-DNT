using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class TblCashPayment
{
    public int Id { get; set; }

    public int? BranchId { get; set; }

    public string? BankName { get; set; }

    public decimal? Amount { get; set; }

    public DateTime? SubmitDate { get; set; }

    public string? Image { get; set; }

    public string? Comments { get; set; }

    public string? Status { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public int? BankAccountId { get; set; }

    public int? CompanyId { get; set; }
}
