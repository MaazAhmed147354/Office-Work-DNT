using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class VwClearingAgentFreightForwarderLedger
{
    public string Mode { get; set; } = null!;

    public int Id { get; set; }

    public DateOnly? Date { get; set; }

    public decimal InvoiceAmount { get; set; }

    public decimal Amount { get; set; }

    public string? Type { get; set; }

    public int? TypeId { get; set; }

    public string? TypeName { get; set; }

    public string? Image { get; set; }

    public string? InvoiceNumber { get; set; }

    public string? Comments { get; set; }

    public int? CompanyId { get; set; }
}
