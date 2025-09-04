using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class OrderNote
{
    public int Id { get; set; }

    public int OrderId { get; set; }

    public string Note { get; set; } = null!;

    public int DownloadId { get; set; }

    public bool DisplayToCustomer { get; set; }

    public DateTime CreatedOnUtc { get; set; }
}
