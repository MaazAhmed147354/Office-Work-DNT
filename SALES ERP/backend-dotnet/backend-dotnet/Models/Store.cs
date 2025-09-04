using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class Store
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Url { get; set; } = null!;

    public bool SslEnabled { get; set; }

    public string? SecureUrl { get; set; }

    public string? Hosts { get; set; }

    public int DisplayOrder { get; set; }

    public string? CompanyName { get; set; }

    public string? CompanyAddress { get; set; }

    public string? CompanyPhoneNumber { get; set; }

    public string? CompanyVat { get; set; }
}
