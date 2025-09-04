using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class ShippingMethod
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public int DisplayOrder { get; set; }
}
