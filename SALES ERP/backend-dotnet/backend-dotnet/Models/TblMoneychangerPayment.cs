using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class TblMoneychangerPayment
{
    public int Id { get; set; }

    public int? MoneyChangerId { get; set; }

    public string? PaymentType { get; set; }

    public decimal? Amount { get; set; }

    public string? OtherAmountText { get; set; }

    public decimal? OtherAmount { get; set; }

    public string? AmountDescriptionText { get; set; }

    public string? AmountDescription { get; set; }

    public decimal? ExchangeRate { get; set; }

    public int? CurrencyId { get; set; }

    public string? ChequeNo { get; set; }

    public DateTime? ClearingDate { get; set; }

    public string? BankName { get; set; }

    public DateTime? SubmitDate { get; set; }

    public string? SubmitProof { get; set; }

    public string? Comments { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public int? BankAccountId { get; set; }

    public int? CompanyId { get; set; }
}
