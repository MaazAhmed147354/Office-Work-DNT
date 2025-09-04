using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class ForumsTopic
{
    public int Id { get; set; }

    public int ForumId { get; set; }

    public int CustomerId { get; set; }

    public int TopicTypeId { get; set; }

    public string Subject { get; set; } = null!;

    public int NumPosts { get; set; }

    public int Views { get; set; }

    public int LastPostId { get; set; }

    public int LastPostCustomerId { get; set; }

    public DateTime? LastPostTime { get; set; }

    public DateTime CreatedOnUtc { get; set; }

    public DateTime UpdatedOnUtc { get; set; }
}
