using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class Picture
{
    public int Id { get; set; }

    public byte[]? PictureBinary { get; set; }

    public string MimeType { get; set; } = null!;

    public string? SeoFilename { get; set; }

    public bool IsNew { get; set; }
}
