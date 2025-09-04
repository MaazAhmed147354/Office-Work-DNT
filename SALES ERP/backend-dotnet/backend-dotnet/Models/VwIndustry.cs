using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class VwIndustry
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? ShortName { get; set; }

    public string? EmailAddress { get; set; }

    public string? MobileNo { get; set; }

    public string? TeleNo { get; set; }

    public string? Address { get; set; }
}
