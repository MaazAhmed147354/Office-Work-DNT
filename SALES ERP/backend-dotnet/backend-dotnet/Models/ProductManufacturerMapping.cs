using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class ProductManufacturerMapping
{
    public int Id { get; set; }

    public int ProductId { get; set; }

    public int ManufacturerId { get; set; }

    public bool IsFeaturedProduct { get; set; }

    public int DisplayOrder { get; set; }
}
