using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class TblMoneychangerLedger
{
    public int Id { get; set; }

    public int? MoneyChangerPaymentId { get; set; }

    public int? VendorPaymentId { get; set; }
}
