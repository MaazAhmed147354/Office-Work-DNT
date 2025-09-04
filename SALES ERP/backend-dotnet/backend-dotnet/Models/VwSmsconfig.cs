using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class VwSmsconfig
{
    public int Id { get; set; }

    public bool? Active { get; set; }

    public bool? Api { get; set; }

    public bool? Globalpk { get; set; }

    public bool? Gsm { get; set; }

    public string? UrlWebApi { get; set; }

    public string? UrlGlobalPk { get; set; }

    public string? Username { get; set; }

    public string? Password { get; set; }

    public string? GsmDeviceName { get; set; }
}
