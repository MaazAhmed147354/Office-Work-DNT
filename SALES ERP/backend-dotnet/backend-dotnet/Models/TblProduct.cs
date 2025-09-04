using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class TblProduct
{
    public int Id { get; set; }

    public int? CategoryId { get; set; }

    public string? Name { get; set; }

    public string? ProductCode { get; set; }

    public string? Description { get; set; }

    public decimal? Weight { get; set; }

    public string? Image { get; set; }

    public int? Active { get; set; }

    public int? MacAddRequired { get; set; }

    public decimal? RetailPrice { get; set; }

    public decimal? MiniPrice { get; set; }

    public int? CreatedBy { get; set; }

    public string? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public string? UpdatedDate { get; set; }
}
