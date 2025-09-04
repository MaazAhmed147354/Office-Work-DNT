using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class ProductPictureMapping
{
    public int Id { get; set; }

    public int ProductId { get; set; }

    public int PictureId { get; set; }

    public int DisplayOrder { get; set; }
}
