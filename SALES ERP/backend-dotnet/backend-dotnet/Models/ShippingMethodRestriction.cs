using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class ShippingMethodRestriction
{
    public int ShippingMethodId { get; set; }

    public int CountryId { get; set; }
}
