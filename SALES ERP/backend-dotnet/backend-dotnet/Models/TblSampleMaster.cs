using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class TblSampleMaster
{
    public int Id { get; set; }

    public int? BranchId { get; set; }

    public int? CustomerId { get; set; }

    public string? Comments { get; set; }

    public string? SampleDate { get; set; }

    public string? ReturnDate { get; set; }

    public string? CustomerName { get; set; }

    public string? Company { get; set; }

    public string? MobileNo { get; set; }

    public string? TeleNo { get; set; }

    public string? Address { get; set; }
}
