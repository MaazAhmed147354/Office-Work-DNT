using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class ViewOrderReturn
{
    public int Id { get; set; }

    public int? CompanyId { get; set; }

    public int CustomerId { get; set; }

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

    public Guid OrderGuid { get; set; }

    public int StoreId { get; set; }

    public int OrderStatusId { get; set; }

    public int BillingAddressId { get; set; }

    public int? ShippingAddressId { get; set; }

    public bool PickUpInStore { get; set; }

    public int ShippingStatusId { get; set; }

    public int PaymentStatusId { get; set; }

    public string? PaymentMethodSystemName { get; set; }

    public string? CustomerCurrencyCode { get; set; }

    public decimal CurrencyRate { get; set; }

    public int CustomerTaxDisplayTypeId { get; set; }

    public string? VatNumber { get; set; }

    public decimal OrderSubtotalInclTax { get; set; }

    public decimal OrderSubtotalExclTax { get; set; }

    public decimal OrderSubTotalDiscountInclTax { get; set; }

    public decimal OrderSubTotalDiscountExclTax { get; set; }

    public decimal OrderShippingInclTax { get; set; }

    public decimal OrderShippingExclTax { get; set; }

    public decimal PaymentMethodAdditionalFeeInclTax { get; set; }

    public decimal PaymentMethodAdditionalFeeExclTax { get; set; }

    public string? TaxRates { get; set; }

    public decimal OrderTax { get; set; }

    public decimal OrderDiscount { get; set; }

    public decimal OrderTotal { get; set; }

    public decimal RefundedAmount { get; set; }

    public bool RewardPointsWereAdded { get; set; }

    public string? CheckoutAttributeDescription { get; set; }

    public string? CheckoutAttributesXml { get; set; }

    public int CustomerLanguageId { get; set; }

    public int AffiliateId { get; set; }

    public string? CustomerIp { get; set; }

    public bool AllowStoringCreditCardNumber { get; set; }

    public string? CardType { get; set; }

    public string? CardName { get; set; }

    public string? CardNumber { get; set; }

    public string? MaskedCreditCardNumber { get; set; }

    public string? CardCvv2 { get; set; }

    public string? CardExpirationMonth { get; set; }

    public string? CardExpirationYear { get; set; }

    public string? AuthorizationTransactionId { get; set; }

    public string? AuthorizationTransactionCode { get; set; }

    public string? AuthorizationTransactionResult { get; set; }

    public string? CaptureTransactionId { get; set; }

    public string? CaptureTransactionResult { get; set; }

    public string? SubscriptionTransactionId { get; set; }

    public string? PurchaseOrderNumber { get; set; }

    public DateTime? PaidDateUtc { get; set; }

    public string? ShippingMethod { get; set; }

    public string? ShippingRateComputationMethodSystemName { get; set; }

    public string? CustomValuesXml { get; set; }

    public bool Deleted { get; set; }

    public DateTime CreatedOnUtc { get; set; }

    public int? OrderId { get; set; }

    public int? ProductId { get; set; }

    public string? MacAddress { get; set; }

    public string? ReturnDate { get; set; }

    public int? ProductDetailId { get; set; }

    public int? BranchId { get; set; }
}
