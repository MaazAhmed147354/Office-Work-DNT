using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class TblClearingAgentFreightForwarder
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Type { get; set; }

    public string? EmailAddress { get; set; }

    public string? MobileNo { get; set; }

    public string? TeleNo { get; set; }

    public string? Fax { get; set; }

    public string? Company { get; set; }

    public string? Country { get; set; }

    public string? City { get; set; }

    public string? Street { get; set; }

    public int? Status { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }
}
