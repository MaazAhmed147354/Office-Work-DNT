using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class TblManufacturer
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? Active { get; set; }

    public int? CreatedBy { get; set; }

    public string? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public string? UpdatedDate { get; set; }
}
