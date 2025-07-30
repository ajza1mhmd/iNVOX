using System;
using System.Collections.Generic;

namespace Invox.Models;

public partial class GcCategoryMaster
{
    public long CmId { get; set; }

    public int? CmCatgId { get; set; }

    public string? CmCatgName { get; set; }

    public string? CmShortName { get; set; }

    public int? CmParentId { get; set; }

    public string? CmActive { get; set; }

    public int? CmIdx { get; set; }

    public DateTime? CmCreatedOn { get; set; }

    public string? CmCreatedBy { get; set; }

    public DateTime? CmUpdatedOn { get; set; }

    public string? CmUpdatedBy { get; set; }

    public int? CmTransYn { get; set; }
}
