using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class Category
{
    public int Id { get; set; }

    public int? ManufacturerId { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public int CategoryTemplateId { get; set; }

    public string? MetaKeywords { get; set; }

    public string? MetaDescription { get; set; }

    public string? MetaTitle { get; set; }

    public int ParentCategoryId { get; set; }

    public int PictureId { get; set; }

    public int PageSize { get; set; }

    public bool AllowCustomersToSelectPageSize { get; set; }

    public string? PageSizeOptions { get; set; }

    public string? PriceRanges { get; set; }

    public bool ShowOnHomePage { get; set; }

    public bool IncludeInTopMenu { get; set; }

    public bool HasDiscountsApplied { get; set; }

    public bool SubjectToAcl { get; set; }

    public bool LimitedToStores { get; set; }

    public bool Published { get; set; }

    public bool? Active { get; set; }

    public bool Deleted { get; set; }

    public int DisplayOrder { get; set; }

    public DateTime CreatedOnUtc { get; set; }

    public DateTime UpdatedOnUtc { get; set; }
}
