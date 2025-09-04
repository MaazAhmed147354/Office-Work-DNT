using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class Campaign
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Subject { get; set; } = null!;

    public string Body { get; set; } = null!;

    public DateTime CreatedOnUtc { get; set; }
}
