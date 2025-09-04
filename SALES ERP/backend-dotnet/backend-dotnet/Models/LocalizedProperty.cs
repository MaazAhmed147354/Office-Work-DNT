using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class LocalizedProperty
{
    public int Id { get; set; }

    public int EntityId { get; set; }

    public int LanguageId { get; set; }

    public string LocaleKeyGroup { get; set; } = null!;

    public string LocaleKey { get; set; } = null!;

    public string LocaleValue { get; set; } = null!;
}
