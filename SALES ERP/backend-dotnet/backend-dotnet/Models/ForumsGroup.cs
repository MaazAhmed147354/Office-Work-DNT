using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class ForumsGroup
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int DisplayOrder { get; set; }

    public DateTime CreatedOnUtc { get; set; }

    public DateTime UpdatedOnUtc { get; set; }
}
