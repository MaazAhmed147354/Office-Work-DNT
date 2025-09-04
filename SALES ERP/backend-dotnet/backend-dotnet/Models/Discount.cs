using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class Discount
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int DiscountTypeId { get; set; }

    public bool UsePercentage { get; set; }

    public decimal DiscountPercentage { get; set; }

    public decimal DiscountAmount { get; set; }

    public DateTime? StartDateUtc { get; set; }

    public DateTime? EndDateUtc { get; set; }

    public bool RequiresCouponCode { get; set; }

    public string? CouponCode { get; set; }

    public int DiscountLimitationId { get; set; }

    public int LimitationTimes { get; set; }
}
