using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class TblPerforma
{
    public int Id { get; set; }

    public int? OrderId { get; set; }

    public int? CompanyId { get; set; }

    public string? GenderTitle { get; set; }

    public string? InvoiceTitle1 { get; set; }

    public string? InvoiceTitle2 { get; set; }

    public string? SubjectTitle { get; set; }

    public string? Subject { get; set; }

    public string? Para01 { get; set; }

    public string? Para02 { get; set; }

    public string? EquipmentWarrantyTitle { get; set; }

    public string? EquipmentWarranty { get; set; }

    public string? ValidityTitle { get; set; }

    public string? Validity { get; set; }

    public string? TaxesTitle { get; set; }

    public string? Taxes { get; set; }

    public string? CommissioningOfServiceTitle { get; set; }

    public string? CommissioningOfService { get; set; }

    public string? ForceMajeureTitle { get; set; }

    public string? ForceMajeure { get; set; }

    public string? ModeOfPaymentTitle { get; set; }

    public string? ModeOfPayment { get; set; }

    public string? ModeOfDeliveryTitle { get; set; }

    public string? ModeOfDelivery { get; set; }

    public string? Signature { get; set; }

    public int? Status { get; set; }

    public string? CreatedDate { get; set; }
}
