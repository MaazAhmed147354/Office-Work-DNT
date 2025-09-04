using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class Language
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string LanguageCulture { get; set; } = null!;

    public string? UniqueSeoCode { get; set; }

    public string? FlagImageFileName { get; set; }

    public bool Rtl { get; set; }

    public bool LimitedToStores { get; set; }

    public int DefaultCurrencyId { get; set; }

    public bool Published { get; set; }

    public int DisplayOrder { get; set; }
}
