using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class TblBonu
{
    public int Id { get; set; }

    public string? BonusMonth { get; set; }

    public string? Comments { get; set; }

    public string? Status { get; set; }
}
