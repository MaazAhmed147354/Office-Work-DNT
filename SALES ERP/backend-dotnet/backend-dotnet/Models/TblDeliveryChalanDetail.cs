using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class TblDeliveryChalanDetail
{
    public int Id { get; set; }

    public int? Dcid { get; set; }

    public int? ProductId { get; set; }

    public int? RequestQty { get; set; }

    public int? IssuedQty { get; set; }
}
