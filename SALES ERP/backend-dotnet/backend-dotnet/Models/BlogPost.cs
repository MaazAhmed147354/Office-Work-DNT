using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class BlogPost
{
    public int Id { get; set; }

    public int LanguageId { get; set; }

    public string Title { get; set; } = null!;

    public string Body { get; set; } = null!;

    public bool AllowComments { get; set; }

    public int CommentCount { get; set; }

    public string? Tags { get; set; }

    public DateTime? StartDateUtc { get; set; }

    public DateTime? EndDateUtc { get; set; }

    public string? MetaKeywords { get; set; }

    public string? MetaDescription { get; set; }

    public string? MetaTitle { get; set; }

    public bool LimitedToStores { get; set; }

    public DateTime CreatedOnUtc { get; set; }
}
