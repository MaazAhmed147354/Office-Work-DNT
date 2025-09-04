using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class VwSm
{
    public int Id { get; set; }

    public string? Number { get; set; }

    public string? Message { get; set; }

    public bool? Delivered { get; set; }

    public bool? Api { get; set; }

    public bool? Globalpk { get; set; }

    public bool? Gsm { get; set; }

    public string? UrlWebApi { get; set; }

    public string? UrlGlobalPk { get; set; }

    public string? Username { get; set; }

    public string? Password { get; set; }

    public string? GsmDeviceName { get; set; }
}
