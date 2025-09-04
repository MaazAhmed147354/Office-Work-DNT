using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class CustomerAttributeValue
{
    public int Id { get; set; }

    public int CustomerAttributeId { get; set; }

    public string Name { get; set; } = null!;

    public bool IsPreSelected { get; set; }

    public int DisplayOrder { get; set; }
}
