using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class Page
{
    public long PageId { get; set; }

    public string? Name { get; set; }

    public string? Link { get; set; }

    public string? ImagePath { get; set; }

    public long? ParentId { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsPage { get; set; }

    public bool? IsAdhoc { get; set; }
}
