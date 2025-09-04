using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class TblRma
{
    public int Id { get; set; }

    public int? CustomerId { get; set; }

    public int? ProductId { get; set; }

    public string? MacAddress { get; set; }

    public string? Status { get; set; }

    public string? Comments { get; set; }

    public string? BranchComments { get; set; }

    public decimal? Charges { get; set; }

    public string? SubmitDate { get; set; }

    public string? RepairedDate { get; set; }
}
