using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class CourierDetail
{
    public int Id { get; set; }

    public int? OrderId { get; set; }

    public int? CourierTypeId { get; set; }

    public string? CourierNumber { get; set; }

    public string? Date { get; set; }
}
