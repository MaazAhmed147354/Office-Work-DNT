using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class VwProductTag
{
    public int TagId { get; set; }

    public string Name { get; set; } = null!;

    public int ProductId { get; set; }

    public int ProductTagId { get; set; }
}
