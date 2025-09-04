using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class TblLogin
{
    public int Id { get; set; }

    public string? Username { get; set; }

    public string? Password { get; set; }
}
