using System;
using System.Collections.Generic;

namespace Invox.Models;

public partial class GcDeliveryboyMaster
{
    public long DmId { get; set; }

    public int? DmStore { get; set; }

    public string? DmCode { get; set; }

    public string? DmName { get; set; }

    public string? DmMobile { get; set; }

    public string? DmActiveYn { get; set; }

    public DateTime? DmCreatedOn { get; set; }

    public string? DmCreatedBy { get; set; }

    public DateTime? DmUpdatedOn { get; set; }

    public string? DmUpdatedBy { get; set; }
}
