using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class TblProductDetail
{
    public int Id { get; set; }

    public int? Poid { get; set; }

    public int? ProductId { get; set; }

    public decimal? CostingPrice { get; set; }

    public string? MacAddress { get; set; }

    public int? BranchId { get; set; }

    public int? OrderId { get; set; }

    public string? Replacement { get; set; }

    public int? WarrantyModeId { get; set; }

    public string? WarrantyStartDate { get; set; }

    public int? Active { get; set; }

    public int? CreatedBy { get; set; }

    public string? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public string? UpdatedDate { get; set; }

    public int? ProductDetailIdReplaced { get; set; }

    public string? ReplacedDeviceStatus { get; set; }

    public string? ReplacedDeviceCreated { get; set; }

    public string? ReplacedDeviceSent { get; set; }

    public string? ReplacedDeviceRecieved { get; set; }

    public int? InventoryReqId { get; set; }

    public int? Dcid { get; set; }

    public int? RevertId { get; set; }

    public decimal? ReplacePrice { get; set; }

    public int? MissingItems { get; set; }

    public int? MissingItemsId { get; set; }

    public string? MissingItemsDate { get; set; }
}
