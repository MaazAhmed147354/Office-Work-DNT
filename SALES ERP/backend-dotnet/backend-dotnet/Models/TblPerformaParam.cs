using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class TblPerformaParam
{
    public int Id { get; set; }

    public string? InvoiceTitle1 { get; set; }

    public string? InvoiceTitle2 { get; set; }

    public string? Subject { get; set; }

    public string? Para01 { get; set; }

    public string? Para02 { get; set; }

    public string? EquipmentWarranty { get; set; }

    public string? Validity { get; set; }

    public string? Taxes { get; set; }

    public string? CommissioningOfService { get; set; }

    public string? ForceMajeure { get; set; }

    public string? ModeOfPayment { get; set; }

    public string? Signature { get; set; }
}
