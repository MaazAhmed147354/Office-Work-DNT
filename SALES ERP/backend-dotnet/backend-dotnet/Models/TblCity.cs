using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class TblCity
{
    public int Id { get; set; }

    public int? CountryId { get; set; }

    public string? Name { get; set; }

    public int? DisplayOrder { get; set; }
}
