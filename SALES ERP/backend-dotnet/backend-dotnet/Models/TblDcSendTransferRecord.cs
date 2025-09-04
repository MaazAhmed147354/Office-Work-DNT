using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class TblDcSendTransferRecord
{
    public int Id { get; set; }

    public int? ProductId { get; set; }

    public int? DcSent { get; set; }

    public int? DcRecieved { get; set; }

    public int? Quantity { get; set; }
}
