using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class Poll
{
    public int Id { get; set; }

    public int LanguageId { get; set; }

    public string Name { get; set; } = null!;

    public string? SystemKeyword { get; set; }

    public bool Published { get; set; }

    public bool ShowOnHomePage { get; set; }

    public bool AllowGuestsToVote { get; set; }

    public int DisplayOrder { get; set; }

    public DateTime? StartDateUtc { get; set; }

    public DateTime? EndDateUtc { get; set; }
}
