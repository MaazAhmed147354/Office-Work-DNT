using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class UrlRecord
{
    public int Id { get; set; }

    public int EntityId { get; set; }

    public string EntityName { get; set; } = null!;

    public string Slug { get; set; } = null!;

    public bool IsActive { get; set; }

    public int LanguageId { get; set; }
}
