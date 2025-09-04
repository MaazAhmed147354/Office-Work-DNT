using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class GenericAttribute
{
    public int Id { get; set; }

    public int EntityId { get; set; }

    public string KeyGroup { get; set; } = null!;

    public string Key { get; set; } = null!;

    public string Value { get; set; } = null!;

    public int StoreId { get; set; }
}
