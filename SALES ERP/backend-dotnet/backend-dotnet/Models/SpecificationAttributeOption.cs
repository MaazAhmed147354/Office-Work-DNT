using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class SpecificationAttributeOption
{
    public int Id { get; set; }

    public int SpecificationAttributeId { get; set; }

    public string Name { get; set; } = null!;

    public int DisplayOrder { get; set; }
}
