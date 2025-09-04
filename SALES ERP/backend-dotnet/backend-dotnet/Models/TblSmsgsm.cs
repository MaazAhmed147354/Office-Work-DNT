using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class TblSmsgsm
{
    public long Id { get; set; }

    public string? OriginatingAddress { get; set; }

    public string? Sctimestamp { get; set; }

    public string? UserDataText { get; set; }

    public int? IsValid { get; set; }
}
