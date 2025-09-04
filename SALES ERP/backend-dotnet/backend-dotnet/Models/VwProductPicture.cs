using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class VwProductPicture
{
    public int Id { get; set; }

    public int ProductId { get; set; }

    public int PictureId { get; set; }

    public int DisplayOrder { get; set; }

    public string MimeType { get; set; } = null!;

    public string? SeoFilename { get; set; }

    public string? Image { get; set; }
}
