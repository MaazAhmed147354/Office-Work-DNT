using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class TblInvoiceType
{
    public int Id { get; set; }

    public string? InvoiceType { get; set; }

    public string? DisplayTitle { get; set; }

    public int? DisplayOrder { get; set; }
}
