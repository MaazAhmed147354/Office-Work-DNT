using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class DiscountUsageHistory
{
    public int Id { get; set; }

    public int DiscountId { get; set; }

    public int OrderId { get; set; }

    public DateTime CreatedOnUtc { get; set; }
}
