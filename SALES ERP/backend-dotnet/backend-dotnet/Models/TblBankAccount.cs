using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class TblBankAccount
{
    public int Id { get; set; }

    public int? CompanyId { get; set; }

    public int? BankId { get; set; }

    public string? AccountTitle { get; set; }

    public string? AccountNumber { get; set; }

    public string? BranchCode { get; set; }

    public decimal? OpeningBalance { get; set; }
}
