using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class InvoicePaymentDetail
{
    public long Id { get; set; }

    public long OrderId { get; set; }

    public long InvoiceSerial { get; set; }

    public string InvoiceNumber { get; set; } = null!;

    public long PaymentId { get; set; }

    public long CustomerId { get; set; }

    public decimal InvoiceAmount { get; set; }

    public decimal ActualAmountPaid { get; set; }

    public decimal AmountUsedForInvoice { get; set; }

    public decimal BalanceInvoiceAmount { get; set; }

    public bool? IsTemproryRecord { get; set; }

    public DateTime? EntryDate { get; set; }

    public bool IsActive { get; set; }

    public bool? IsDeleted { get; set; }
}
