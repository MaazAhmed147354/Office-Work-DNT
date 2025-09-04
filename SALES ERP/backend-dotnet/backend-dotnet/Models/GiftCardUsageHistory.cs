using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class GiftCardUsageHistory
{
    public int Id { get; set; }

    public int GiftCardId { get; set; }

    public int UsedWithOrderId { get; set; }

    public decimal UsedValue { get; set; }

    public DateTime CreatedOnUtc { get; set; }
}
