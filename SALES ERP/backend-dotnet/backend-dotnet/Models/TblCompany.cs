using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class TblCompany
{
    public int Id { get; set; }

    public string? CompanyName { get; set; }

    public int? CountryId { get; set; }

    public int? CityId { get; set; }

    public string? Address { get; set; }

    public string? Ntn { get; set; }

    public string? Srtn { get; set; }

    public string? FybeginingYear { get; set; }

    public string? TeleNo { get; set; }

    public string? FaxNo { get; set; }

    public string? EmailAddress { get; set; }

    public string? Website { get; set; }

    public string? InvoiceType { get; set; }

    public string? Image { get; set; }

    public int? DisplayOrder { get; set; }
}
