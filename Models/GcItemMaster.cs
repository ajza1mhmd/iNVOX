using System;
using System.Collections.Generic;

namespace Invox.Models;

public partial class GcItemMaster
{
    public int ImSlId { get; set; }

    public int? ImItemCode { get; set; }

    public string? ImBarcode { get; set; }

    public string? ImCatId { get; set; }

    public string? ImSubcatId { get; set; }

    public string? ImBrandId { get; set; }

    public string? ImName { get; set; }

    public string? ImShortName { get; set; }

    public string? ImArabicName { get; set; }

    public string? ImArabicShortName { get; set; }

    public string? ImActive { get; set; }

    public int? ImParent { get; set; }

    public string? ImBaseUnit { get; set; }

    public string? ImMakingTime { get; set; }

    public string? ImImage { get; set; }

    public string? ImItemType { get; set; }

    public string? ImFlagActive { get; set; }

    public string? ImFlagFastMk { get; set; }

    public string? ImFlagSellable { get; set; }

    public string? ImFlagBarcodeItm { get; set; }

    public string? ImFlagSpclPrd { get; set; }

    public string? ImFlagSeasonal { get; set; }

    public string? ImParentYn { get; set; }

    public string? ImNormalPrice { get; set; }

    public string? ImDeliveryPrice { get; set; }

    public string? ImTakeawayPrice { get; set; }

    public string? ImFamilyPrice { get; set; }

    public string? ImOnlinePrice { get; set; }

    public string? ImTaxYn { get; set; }

    public decimal? ImTaxPerc { get; set; }

    public string? ImKotYn { get; set; }

    public int? ImKotCode { get; set; }

    public string? ImOldCode { get; set; }

    public DateTime? ImCreatedOn { get; set; }

    public string? ImCreatedBy { get; set; }

    public DateTime? ImUpdatedOn { get; set; }

    public string? ImUpdatedBy { get; set; }

    public int? ImTransYn { get; set; }

    public string? TmOldCode { get; set; }
}
