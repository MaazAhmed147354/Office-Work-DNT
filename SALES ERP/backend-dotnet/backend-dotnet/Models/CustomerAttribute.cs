using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class CustomerAttribute
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public bool IsRequired { get; set; }

    public int AttributeControlTypeId { get; set; }

    public int DisplayOrder { get; set; }
}
