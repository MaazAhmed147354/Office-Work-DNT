using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class NewsLetterTemplate
{
    public int Id { get; set; }

    public string? Subject { get; set; }

    public string? Template { get; set; }

    public string? Attachment { get; set; }

    public DateTime? CreatedOnUtc { get; set; }
}
