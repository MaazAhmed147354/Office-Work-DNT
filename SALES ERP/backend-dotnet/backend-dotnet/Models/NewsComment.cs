using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class NewsComment
{
    public int Id { get; set; }

    public string? CommentTitle { get; set; }

    public string? CommentText { get; set; }

    public int NewsItemId { get; set; }

    public int CustomerId { get; set; }

    public DateTime CreatedOnUtc { get; set; }

    public int? IsViewed { get; set; }
}
