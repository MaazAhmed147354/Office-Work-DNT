using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class TblOrder
{
    public int Id { get; set; }

    public int? BranchId { get; set; }

    public int? CustomerId { get; set; }

    public int? NtnNo { get; set; }

    public int? SrtnNo { get; set; }

    public decimal? IncomeTax { get; set; }

    public decimal? SalesTax { get; set; }

    public decimal? ValueAddedTax1per { get; set; }

    public decimal? ValueAddedTax17per { get; set; }

    public decimal? SalesTaxOneFifthDeduction { get; set; }

    public decimal? IncomeTaxForNotImportedItems { get; set; }

    public decimal? Courier { get; set; }

    public decimal? OtherAmount { get; set; }

    public string? InvoiceType { get; set; }

    public string? OrderDate { get; set; }

    public string? AcceptedDate { get; set; }

    public int? DueDays { get; set; }

    public int? IsDueDaysSmsSent { get; set; }

    public int? AcceptedBy { get; set; }

    public string? Comments { get; set; }

    public string? InvoiceUid { get; set; }

    public int? Status { get; set; }

    public string? OtherAmountDescription { get; set; }

    public string? ProformaUid { get; set; }

    public string? ProformaUidsalesTax { get; set; }

    public int? InvoiceSerial { get; set; }

    public string? Note { get; set; }

    public string? NoteHeading { get; set; }
}
