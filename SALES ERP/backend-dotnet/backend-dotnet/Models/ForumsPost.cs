using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class ForumsPost
{
    public int Id { get; set; }

    public int TopicId { get; set; }

    public int CustomerId { get; set; }

    public string Text { get; set; } = null!;

    public string? Ipaddress { get; set; }

    public DateTime CreatedOnUtc { get; set; }

    public DateTime UpdatedOnUtc { get; set; }
}
