using System;
using System.Collections.Generic;

namespace Invox.Models;

public partial class GcPosUser
{
    public long PuId { get; set; }

    public string PuUserId { get; set; } = null!;

    public string PuName { get; set; } = null!;

    public string? PuEmail { get; set; }

    public string? PuMobile { get; set; }

    public string PuPassword { get; set; } = null!;

    public int? PuLevel { get; set; }

    public DateTime? PuLastLogin { get; set; }

    public DateTime? PuCreatedOn { get; set; }

    public string? PuCreatedBy { get; set; }

    public DateTime? PuUpdatedOn { get; set; }

    public string? PuUpdatedBy { get; set; }

    public int? PuTransYn { get; set; }
}
