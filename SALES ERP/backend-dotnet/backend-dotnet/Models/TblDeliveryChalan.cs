using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class TblDeliveryChalan
{
    public int Id { get; set; }

    public int? BranchId { get; set; }

    public int? BranchIdTo { get; set; }

    public string? CommentsApp { get; set; }

    public string? CommentsReq { get; set; }

    public int? Status { get; set; }

    public int? CreatedBy { get; set; }

    public string? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public string? UpdatedDate { get; set; }
}
