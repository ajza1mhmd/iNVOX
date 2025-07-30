using System;
using System.Collections.Generic;

namespace Invox.Models;

public partial class GcKitchenMessage
{
    public long KmId { get; set; }

    public string? KmMessage { get; set; }

    public string? KmActive { get; set; }

    public string? KmCreatedBy { get; set; }

    public DateTime? KmCreatedOn { get; set; }

    public string? KmUpdatedBy { get; set; }

    public DateTime? KmUpdatedOn { get; set; }
}
