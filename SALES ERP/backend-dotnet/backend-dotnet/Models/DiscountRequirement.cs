using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class DiscountRequirement
{
    public int Id { get; set; }

    public int DiscountId { get; set; }

    public string? DiscountRequirementRuleSystemName { get; set; }
}
