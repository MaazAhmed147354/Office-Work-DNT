using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class TblIndustry
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? ShortName { get; set; }

    public string? EmailAddress { get; set; }

    public string? MobileNo { get; set; }

    public string? TeleNo { get; set; }

    public string? Address { get; set; }

    public int? Active { get; set; }

    public int? CreatedBy { get; set; }

    public string? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public string? UpdatedDate { get; set; }
}
