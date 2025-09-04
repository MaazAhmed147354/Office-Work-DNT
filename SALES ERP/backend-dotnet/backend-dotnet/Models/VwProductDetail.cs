using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class VwProductDetail
{
    public int Id { get; set; }

    public int? ProductId { get; set; }

    public string ProductName { get; set; } = null!;

    public int CategoryId { get; set; }

    public int ManufacturerId { get; set; }

    public string Manufacturer { get; set; } = null!;

    public string? BranchName { get; set; }

    public string? BranchNameShort { get; set; }

    public decimal CostingPrice { get; set; }

    public string? MacAddress { get; set; }

    public int? BranchId { get; set; }

    public int? OrderId { get; set; }

    public int CustomerId { get; set; }

    public DateOnly? OrderAcceptedDate { get; set; }

    public string? Replacement { get; set; }

    public int MissingItems { get; set; }

    public int? WarrantyModeId { get; set; }

    public DateOnly? WarrantyStartDate2 { get; set; }

    public string? WarrantyStartDate { get; set; }

    public int? Active { get; set; }

    public int? CreatedBy { get; set; }

    public string? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateOnly? UpdatedDate { get; set; }

    public string? ReplacedDeviceStatus { get; set; }

    public string? ReplacedDeviceCreated { get; set; }

    public string? ReplacedDeviceSent { get; set; }

    public string? ReplacedDeviceRecieved { get; set; }

    public int? ProductDetailIdReplaced { get; set; }

    public int? InventoryReqId { get; set; }

    public int? Dcid { get; set; }

    public int? RevertId { get; set; }

    public int? Poid { get; set; }
}
