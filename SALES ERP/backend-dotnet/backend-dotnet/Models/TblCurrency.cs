using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class TblCurrency
{
    public int Id { get; set; }

    public string? Symbol { get; set; }

    public string? Title { get; set; }
}
