using System;
using System.Collections.Generic;

namespace Invox.Models;

public partial class GcDeliverySettlement
{
    public long DsId { get; set; }

    public int? DsStore { get; set; }

    public string? DsDeliveryId { get; set; }

    public decimal? DsCash { get; set; }

    public decimal? DsCard { get; set; }

    public DateTime? DsCreatedOn { get; set; }

    public string? DsCreatedBy { get; set; }

    public DateTime? DsUpdatedOn { get; set; }

    public string? DsUpdatedBy { get; set; }
}
