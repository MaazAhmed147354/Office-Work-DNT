using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class TblClearingAgentFreightForwarderLedger
{
    public int Id { get; set; }

    public int? PaymentId { get; set; }

    public int? InvoiceId { get; set; }
}
