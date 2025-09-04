using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class VwProductDetailAll
{
    public int? ProductId { get; set; }

    public string ProductName { get; set; } = null!;

    public string BranchName { get; set; } = null!;

    public string BranchShortName { get; set; } = null!;

    public int Id { get; set; }

    public int? Poid { get; set; }

    public string? Ponumber { get; set; }

    public decimal CostingPrice { get; set; }

    public string? MacAddress { get; set; }

    public int? BranchId { get; set; }

    public int? OrderId { get; set; }

    public string? Replacement { get; set; }

    public int MissingItems { get; set; }

    public int? WarrantyModeId { get; set; }

    public DateOnly? WarrantyStartDate { get; set; }

    public int? Active { get; set; }

    public int? CreatedBy { get; set; }

    public string? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateOnly? UpdatedDate { get; set; }

    public string? ReplacedDeviceStatus { get; set; }

    public string? ReplacedDeviceCreated { get; set; }

    public string? ReplacedDeviceSent { get; set; }

    public string? ReplacedDeviceRecieved { get; set; }

    public int? InventoryReqId { get; set; }

    public int? Dcid { get; set; }

    public int? RevertId { get; set; }

    public string? InvoiceId { get; set; }

    public string? InvoiceUid { get; set; }

    public DateOnly? OrderAcceptedDate { get; set; }

    public int? CustomerId { get; set; }
}
