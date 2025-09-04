using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class TblBankLedger
{
    public int Id { get; set; }

    public string? Type { get; set; }

    public int? TypeId { get; set; }
}
