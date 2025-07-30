using System;
using System.Collections.Generic;

namespace Invox.Models;

public partial class GcCompanyMaster
{
    public int LmId { get; set; }

    public string? LmStoreId { get; set; }

    public string? LmStoreName { get; set; }

    public string? LmArabicName { get; set; }

    public string? LmShortName { get; set; }

    public string? LmArabicShortName { get; set; }

    public string? LmActiveYn { get; set; }

    public string? LmAddressLine1 { get; set; }

    public string? LmAddressLine2 { get; set; }

    public string? LmMobile { get; set; }

    public string? LmMailId { get; set; }

    public string? LmPhone { get; set; }

    public string? LmTaxNo { get; set; }

    public string? LmFooter1 { get; set; }

    public string? LmFooter2 { get; set; }

    public string? LmFooter3 { get; set; }

    public string? LmFooter4 { get; set; }

    public string? ImFooter5 { get; set; }

    public string? ImLogo { get; set; }

    public string? ImBillName { get; set; }

    public DateTime? LmCreatedOn { get; set; }

    public string? LmCreatedBy { get; set; }

    public DateTime? LmUpdatedOn { get; set; }

    public string? LmUpdatedBy { get; set; }
}
