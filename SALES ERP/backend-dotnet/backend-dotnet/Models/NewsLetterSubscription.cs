using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class NewsLetterSubscription
{
    public int Id { get; set; }

    public Guid NewsLetterSubscriptionGuid { get; set; }

    public string Email { get; set; } = null!;

    public bool Active { get; set; }

    public int StoreId { get; set; }

    public DateTime CreatedOnUtc { get; set; }
}
