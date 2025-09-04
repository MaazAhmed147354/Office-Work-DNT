using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class VwVendorLedger
{
    public string Mode { get; set; } = null!;

    public string ModeFull { get; set; } = null!;

    public int Id { get; set; }

    public string? Ponumber { get; set; }

    public string? SupplierInvoiceNo { get; set; }

    public DateOnly? Date { get; set; }

    public string? Vendor { get; set; }

    public string? Comments { get; set; }

    public string? ConfirmationProof { get; set; }

    public string? Poimage { get; set; }

    public string MoneyChanger { get; set; } = null!;

    public int PovendorId { get; set; }

    public decimal Poamount { get; set; }

    public decimal TransferAmount { get; set; }

    public decimal ExchangeRate { get; set; }

    public decimal TransferAmountDollar { get; set; }

    public decimal Expr1 { get; set; }

    public int PaymentVendorId { get; set; }

    public int PaymentMoneyChangerId { get; set; }

    public int? CompanyId { get; set; }

    public string? CompanyName { get; set; }
}
