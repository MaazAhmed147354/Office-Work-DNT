using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class BlogComment
{
    public int Id { get; set; }

    public int CustomerId { get; set; }

    public string? CommentText { get; set; }

    public int BlogPostId { get; set; }

    public DateTime CreatedOnUtc { get; set; }
}
