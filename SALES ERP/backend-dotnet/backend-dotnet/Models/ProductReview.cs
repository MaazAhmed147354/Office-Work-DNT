using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class ProductReview
{
    public int Id { get; set; }

    public int CustomerId { get; set; }

    public int ProductId { get; set; }

    public bool IsApproved { get; set; }

    public string? Title { get; set; }

    public string? ReviewText { get; set; }

    public int Rating { get; set; }

    public int HelpfulYesTotal { get; set; }

    public int HelpfulNoTotal { get; set; }

    public DateTime CreatedOnUtc { get; set; }
}
