using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class VwOrder
{
    public int CompanyId { get; set; }

    public int? BranchId { get; set; }

    public int CustomerId { get; set; }

    public int Id { get; set; }

    public int OrderId { get; set; }

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

    public string InvoiceType { get; set; } = null!;

    public int? DueDays { get; set; }

    public int? IsDueDaysSmsSent { get; set; }

    public int? RemainingDueDays { get; set; }

    public int? AcceptedBy { get; set; }

    public string? Comments { get; set; }

    public string? OtherAmountDescription { get; set; }

    public string? ProformaUid { get; set; }

    public string? ProformaUidsalesTax { get; set; }

    public int? InvoiceSerial { get; set; }

    public string Note { get; set; } = null!;

    public string NoteHeading { get; set; } = null!;

    public string? InvoiceId { get; set; }

    public string? InvoiceUid { get; set; }

    public string? AcceptedDate { get; set; }

    public string? AcceptedDate1 { get; set; }

    public DateOnly? AcceptedDate2 { get; set; }

    public string? AcceptedDate3 { get; set; }

    public string? OrderDate { get; set; }

    public string? OrderDate1 { get; set; }

    public DateOnly? OrderDate2 { get; set; }

    public string? OrderDate3 { get; set; }

    public int? Status { get; set; }

    public string? StatusName { get; set; }

    public string? Name { get; set; }

    public string? CustomerName { get; set; }

    public string? CustomerFullName { get; set; }

    public string? CustomerNameCompany { get; set; }

    public string? EmailAddress { get; set; }

    public string MobileNo { get; set; } = null!;

    public string CompanyName { get; set; } = null!;

    public string? InvoiceTypeCompany { get; set; }

    public string? BranchName { get; set; }

    public string? ShortName { get; set; }

    public string? BranchShortName { get; set; }

    public string? PurchaseOrderRef { get; set; }

    public string? PurchaseOrderImageRef { get; set; }

    public string? SignedDeliveryNoteImageRef { get; set; }

    public string? SystemGeneratedInoviceNo { get; set; }

    public string? ReturnFileMonth { get; set; }

    public string? ReturnFileImgRef { get; set; }

    public string? BillingMonth { get; set; }

    public int? ProvinceId { get; set; }

    public string? ProvinceName { get; set; }

    public int? DepartmentId { get; set; }

    public string? DepartmentName { get; set; }

    public DateTime? OrderCreatedDate { get; set; }

    public DateTime CreatedOnUtc { get; set; }
}
