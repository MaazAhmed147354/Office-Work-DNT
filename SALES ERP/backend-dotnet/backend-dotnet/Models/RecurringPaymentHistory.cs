using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class RecurringPaymentHistory
{
    public int Id { get; set; }

    public int RecurringPaymentId { get; set; }

    public int OrderId { get; set; }

    public DateTime CreatedOnUtc { get; set; }
}
