using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class ForumsPrivateMessage
{
    public int Id { get; set; }

    public int StoreId { get; set; }

    public int FromCustomerId { get; set; }

    public int ToCustomerId { get; set; }

    public string Subject { get; set; } = null!;

    public string Text { get; set; } = null!;

    public bool IsRead { get; set; }

    public bool IsDeletedByAuthor { get; set; }

    public bool IsDeletedByRecipient { get; set; }

    public DateTime CreatedOnUtc { get; set; }
}
