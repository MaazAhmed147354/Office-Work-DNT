using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class Affiliate
{
    public int Id { get; set; }

    public int AddressId { get; set; }

    public bool Deleted { get; set; }

    public bool Active { get; set; }
}
