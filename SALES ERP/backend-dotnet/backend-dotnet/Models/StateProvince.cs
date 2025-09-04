using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class StateProvince
{
    public int Id { get; set; }

    public int CountryId { get; set; }

    public string Name { get; set; } = null!;

    public string? Abbreviation { get; set; }

    public bool Published { get; set; }

    public int DisplayOrder { get; set; }
}
