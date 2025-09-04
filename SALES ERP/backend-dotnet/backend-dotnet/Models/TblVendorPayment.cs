using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class TblVendorPayment
{
    public int Id { get; set; }

    public int? VendorId { get; set; }

    public int? MoneyChangerId { get; set; }

    public int? CurrencyId { get; set; }

    public decimal? ExchangeRate { get; set; }

    public decimal? TransferAmount { get; set; }

    public decimal? BankCharges { get; set; }

    public DateTime? TransferDate { get; set; }

    public DateTime? ConfirmationDate { get; set; }

    public string? ConfirmationProof { get; set; }

    public string? Comments { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public int? CompanyId { get; set; }
}
