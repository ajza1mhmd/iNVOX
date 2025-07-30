using System;
using System.Collections.Generic;

namespace Invox.Models;

public partial class GcCustomerMaster
{
    public long CmId { get; set; }

    public string? CmCustCode { get; set; }

    public string? CmCustName { get; set; }

    public string? CmMobile { get; set; }

    public string? CmSecMobile { get; set; }

    public string? CmEmail { get; set; }

    public long? CmPrimaryAddress { get; set; }

    public string? CmActiveYn { get; set; }

    public string? CmBlackListYn { get; set; }

    public DateTime? CmCreatedOn { get; set; }

    public string? CmCreatedBy { get; set; }

    public DateTime? CmUpdatedOn { get; set; }

    public string? CmUpdatedBy { get; set; }

    public int? CmTransYn { get; set; }
}
