using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class TblDesignation
{
    public int Id { get; set; }

    public string? Designation { get; set; }

    public int? DisplayOrder { get; set; }
}
