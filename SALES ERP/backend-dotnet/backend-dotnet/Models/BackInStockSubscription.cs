using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class BackInStockSubscription
{
    public int Id { get; set; }

    public int StoreId { get; set; }

    public int ProductId { get; set; }

    public int CustomerId { get; set; }

    public DateTime CreatedOnUtc { get; set; }
}
