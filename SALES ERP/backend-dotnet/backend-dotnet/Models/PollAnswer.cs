using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class PollAnswer
{
    public int Id { get; set; }

    public int PollId { get; set; }

    public string Name { get; set; } = null!;

    public int NumberOfVotes { get; set; }

    public int DisplayOrder { get; set; }
}
