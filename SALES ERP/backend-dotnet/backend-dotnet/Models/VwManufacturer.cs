using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class VwManufacturer
{
    public int Id { get; set; }

    public int ManufacturerId { get; set; }

    public string Manufacturer { get; set; } = null!;

    public string? Description { get; set; }

    public string? MetaKeywords { get; set; }

    public string? MetaDescription { get; set; }

    public string? MetaTitle { get; set; }

    public int PictureId { get; set; }

    public string? PriceRanges { get; set; }

    public bool? Active { get; set; }

    public bool Published { get; set; }

    public int DisplayOrder { get; set; }

    public string? Slug { get; set; }

    public string? Image { get; set; }
}
