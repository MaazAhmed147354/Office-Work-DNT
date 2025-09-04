using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class VwPurchaseOrder
{
    public int Id { get; set; }

    public int Poid { get; set; }

    public int VendorId { get; set; }

    public string? Vendor { get; set; }

    public string? Ponumber { get; set; }

    public DateTime? Podate { get; set; }

    public string? SupplierInvoiceNo { get; set; }

    public string? OtherVendorChargesText1 { get; set; }

    public string? OtherVendorChargesText2 { get; set; }

    public string? OtherVendorChargesText3 { get; set; }

    public decimal? OtherVendorCharges1 { get; set; }

    public decimal? OtherVendorCharges2 { get; set; }

    public decimal? OtherVendorCharges3 { get; set; }

    public decimal? OtherVendorChargesTotal { get; set; }

    public decimal? ExchangeRate { get; set; }

    public decimal? PenaltyChargesMaster { get; set; }

    public decimal? Cessmaster { get; set; }

    public decimal? CustomMiscMaster { get; set; }

    public decimal? WharfageMaster { get; set; }

    public decimal? DochargesMaster { get; set; }

    public decimal? FreightChargesMaster { get; set; }

    public string? OtherChargesText { get; set; }

    public decimal? ClearingChargesMaster { get; set; }

    public decimal? OtherChargesMaster { get; set; }

    public decimal? LandingChargesMaster { get; set; }

    public decimal? InsuranceChargesMaster { get; set; }

    public decimal? OtherChargesImportValueMaster { get; set; }

    public decimal? SalesTaxMaster { get; set; }

    public decimal? AddSalesTaxMaster { get; set; }

    public decimal? IncomeTaxMaster { get; set; }

    public string? CreatedDate { get; set; }

    public string? Poimage { get; set; }

    public string? Comments { get; set; }

    public decimal Poamount { get; set; }

    public int? CompanyId { get; set; }
}
