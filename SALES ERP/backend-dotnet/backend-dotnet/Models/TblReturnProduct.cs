using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class TblReturnProduct
{
    public int Id { get; set; }

    public int? BranchId { get; set; }

    public int? OrderId { get; set; }

    public int? ProductId { get; set; }

    public string? MacAddress { get; set; }

    public string? ReturnDate { get; set; }

    public int? ProductDetailId { get; set; }
}
