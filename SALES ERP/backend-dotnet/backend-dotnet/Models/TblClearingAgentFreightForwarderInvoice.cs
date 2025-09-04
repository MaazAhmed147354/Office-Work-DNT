using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class TblClearingAgentFreightForwarderInvoice
{
    public int Id { get; set; }

    public int? TypeId { get; set; }

    public string? Type { get; set; }

    public DateTime? Date { get; set; }

    public string? Number { get; set; }

    public decimal? Amount { get; set; }

    public string? Image { get; set; }

    public string? Comments { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public int? CompanyId { get; set; }
}
