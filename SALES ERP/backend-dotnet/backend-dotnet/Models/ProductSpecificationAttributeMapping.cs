using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class ProductSpecificationAttributeMapping
{
    public int Id { get; set; }

    public int ProductId { get; set; }

    public int SpecificationAttributeOptionId { get; set; }

    public string? CustomValue { get; set; }

    public bool AllowFiltering { get; set; }

    public bool ShowOnProductPage { get; set; }

    public int DisplayOrder { get; set; }
}
