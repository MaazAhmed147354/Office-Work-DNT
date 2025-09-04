using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class TblSampleDetail
{
    public int Id { get; set; }

    public int? SampleId { get; set; }

    public int? ProductId { get; set; }

    public string? MacAddress { get; set; }
}
