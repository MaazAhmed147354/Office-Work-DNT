using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class VwOrderDetail
{
    public int Id { get; set; }

    public int OrderId { get; set; }

    public int ProductId { get; set; }

    public int Quantity { get; set; }

    public decimal? Price { get; set; }
}
