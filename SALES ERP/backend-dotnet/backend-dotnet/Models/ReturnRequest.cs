using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class ReturnRequest
{
    public int Id { get; set; }

    public int StoreId { get; set; }

    public int OrderItemId { get; set; }

    public int CustomerId { get; set; }

    public int Quantity { get; set; }

    public string ReasonForReturn { get; set; } = null!;

    public string RequestedAction { get; set; } = null!;

    public string? CustomerComments { get; set; }

    public string? StaffNotes { get; set; }

    public int ReturnRequestStatusId { get; set; }

    public DateTime CreatedOnUtc { get; set; }

    public DateTime UpdatedOnUtc { get; set; }
}
