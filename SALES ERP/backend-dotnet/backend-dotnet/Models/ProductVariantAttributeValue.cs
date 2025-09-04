using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class ProductVariantAttributeValue
{
    public int Id { get; set; }

    public int ProductVariantAttributeId { get; set; }

    public int AttributeValueTypeId { get; set; }

    public int AssociatedProductId { get; set; }

    public string Name { get; set; } = null!;

    public string? ColorSquaresRgb { get; set; }

    public decimal PriceAdjustment { get; set; }

    public decimal WeightAdjustment { get; set; }

    public decimal Cost { get; set; }

    public int Quantity { get; set; }

    public bool IsPreSelected { get; set; }

    public int DisplayOrder { get; set; }

    public int PictureId { get; set; }
}
