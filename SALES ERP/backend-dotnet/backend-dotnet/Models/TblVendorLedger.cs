using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class TblVendorLedger
{
    public int Id { get; set; }

    public int? VendorPaymentId { get; set; }

    public int? Poid { get; set; }
}
