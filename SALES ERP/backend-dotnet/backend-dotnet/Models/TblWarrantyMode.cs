using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class TblWarrantyMode
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? Days { get; set; }

    public int? Active { get; set; }
}
