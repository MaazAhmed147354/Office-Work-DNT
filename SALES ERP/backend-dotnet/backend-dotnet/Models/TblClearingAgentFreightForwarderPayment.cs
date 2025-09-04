using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class TblClearingAgentFreightForwarderPayment
{
    public int Id { get; set; }

    public int? TypeId { get; set; }

    public string? Type { get; set; }

    public string? PaymentType { get; set; }

    public decimal? Amount { get; set; }

    public decimal? OtherAmount { get; set; }

    public string? AmountDescription { get; set; }

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
