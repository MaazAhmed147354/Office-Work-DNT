using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class VwSampleItem
{
    public int Id { get; set; }

    public int? SampleId { get; set; }

    public string? MacAddress { get; set; }

    public int ProductId { get; set; }

    public string ProductName { get; set; } = null!;

    public string? ProductCode { get; set; }

    public string Image { get; set; } = null!;

    public int? MacAddRequired { get; set; }

    public string? ProductIdString { get; set; }

    public int? Quantity { get; set; }

    public int? BranchId { get; set; }

    public string? ShortName { get; set; }

    public string? BranchName { get; set; }

    public int? CustomerId { get; set; }

    public string? CustomerName { get; set; }

    public string? Company { get; set; }

    public string? MobileNo { get; set; }

    public string? TeleNo { get; set; }

    public string? Address { get; set; }

    public string? Comments { get; set; }

    public string? SampleDate { get; set; }

    public string? ReturnDate { get; set; }
}
