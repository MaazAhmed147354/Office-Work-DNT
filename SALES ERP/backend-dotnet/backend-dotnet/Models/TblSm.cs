using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class TblSm
{
    public int Id { get; set; }

    public string? Number { get; set; }

    public string? Message { get; set; }

    public string? Dated { get; set; }

    public bool? Delivered { get; set; }

    public int? Retries { get; set; }
}
