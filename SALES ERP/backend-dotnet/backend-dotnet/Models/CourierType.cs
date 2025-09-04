using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class CourierType
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public string? ContactNo { get; set; }
}
