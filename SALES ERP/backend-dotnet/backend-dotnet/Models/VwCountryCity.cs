using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class VwCountryCity
{
    public int CountryId { get; set; }

    public string Country { get; set; } = null!;

    public int CityId { get; set; }

    public string City { get; set; } = null!;

    public bool PublishedCountry { get; set; }

    public int DisplayOrderCountry { get; set; }

    public bool PublishedCity { get; set; }

    public int DisplayOrderCity { get; set; }
}
