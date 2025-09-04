using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class VwProduct
{
    public int ManufacturerId { get; set; }

    public string Manufacturer { get; set; } = null!;

    public int CategoryId { get; set; }

    public string Category { get; set; } = null!;

    public int ProductId { get; set; }

    public string ProductName { get; set; } = null!;

    public string? ProductCode { get; set; }

    public bool Published { get; set; }

    public bool? Active { get; set; }

    public int? MacAddRequired { get; set; }

    public bool? MacAddRequired2 { get; set; }

    public bool ShowOnHomePage { get; set; }

    public bool AllowCustomerReviews { get; set; }

    public bool DisableBuyButton { get; set; }

    public bool DisableWishlistButton { get; set; }

    public decimal Price { get; set; }

    public decimal OldPrice { get; set; }

    public decimal ProductCost { get; set; }

    public decimal? SpecialPrice { get; set; }

    public DateTime? SpecialPriceStartDateTime { get; set; }

    public DateTime? SpecialPriceEndDateTime { get; set; }

    public string? MetaKeywords { get; set; }

    public string? MetaDescription { get; set; }

    public string? MetaTitle { get; set; }

    public decimal Weight { get; set; }

    public decimal Length { get; set; }

    public decimal Width { get; set; }

    public decimal Height { get; set; }

    public string? ShortDescription { get; set; }

    public string? Description { get; set; }

    public string? FullDescription { get; set; }

    public string? DownloadTab { get; set; }

    public string? ApplicationTab { get; set; }

    public string? VideoUrl { get; set; }

    public bool? IsCustomUrl { get; set; }

    public bool HasSampleDownload { get; set; }

    public int SampleDownloadId { get; set; }

    public bool? UseDownloadUrl { get; set; }

    public string? DownloadUrl { get; set; }

    public string? ContentType { get; set; }

    public string? Filename { get; set; }

    public string? Extension { get; set; }

    public string? SampleFile { get; set; }

    public int ProductCategoryMappingId { get; set; }

    public int DisplayOrder { get; set; }

    public bool IsFeaturedProduct { get; set; }

    public string? Slug { get; set; }

    public int? UrlRecordId { get; set; }

    public string Image { get; set; } = null!;
}
