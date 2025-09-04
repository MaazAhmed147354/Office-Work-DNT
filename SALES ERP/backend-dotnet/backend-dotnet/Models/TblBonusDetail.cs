using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class TblBonusDetail
{
    public int Id { get; set; }

    public int? BonusId { get; set; }

    public int? EmployeeId { get; set; }

    public decimal? BonusAmount { get; set; }
}
