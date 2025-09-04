using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class PollVotingRecord
{
    public int Id { get; set; }

    public int PollAnswerId { get; set; }

    public int CustomerId { get; set; }

    public DateTime CreatedOnUtc { get; set; }
}
