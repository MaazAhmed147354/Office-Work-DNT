using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class VwMoneyChangerLedger
{
    public string Mode { get; set; } = null!;

    public int Id { get; set; }

    public DateOnly? Date { get; set; }

    public string? Symbol { get; set; }

    public int CurrencyId { get; set; }

    public decimal SubmitAmount { get; set; }

    public string? SubmitProof { get; set; }

    public decimal TransferAmount { get; set; }

    public DateOnly? ConfirmationDate { get; set; }

    public string? ConfirmationProof { get; set; }

    public int MoneyChangerId { get; set; }

    public string MoneyChanger { get; set; } = null!;

    public int VendorId { get; set; }

    public decimal BankCharges { get; set; }

    public string? Vendor { get; set; }

    public int PaymentVendorId { get; set; }

    public int PaymentMoneyChangerId { get; set; }

    public string? Comments { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? CompanyId { get; set; }

    public string? CompanyName { get; set; }

    public int MoneyChangerPaymentId { get; set; }
}
