using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class Smsconfig
{
    public int Id { get; set; }

    public string? Type { get; set; }

    public bool? Active { get; set; }

    public string? UrlWebApi { get; set; }

    public string? UrlGlobalPk { get; set; }

    public string? Username { get; set; }

    public string? Password { get; set; }

    public string? GsmDeviceName { get; set; }
}
