using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class TblCustomersNtn
{
    public int Id { get; set; }

    public int? CustomerId { get; set; }

    public string? Number { get; set; }

    public string? Type { get; set; }

    public int? CreatedBy { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }
}
