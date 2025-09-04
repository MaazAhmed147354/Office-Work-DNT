using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class LocaleStringResource
{
    public int Id { get; set; }

    public int LanguageId { get; set; }

    public string ResourceName { get; set; } = null!;

    public string ResourceValue { get; set; } = null!;
}
