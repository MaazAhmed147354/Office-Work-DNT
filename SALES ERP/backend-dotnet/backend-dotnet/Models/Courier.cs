using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class Courier
{
    public string CourierName { get; set; } = null!;

    public string Tag { get; set; } = null!;

    public int Orderid { get; set; }

    public DateOnly Date { get; set; }
}
