using System;
using System.Collections.Generic;

namespace Invox.Models;

public partial class GcOnlinePricing
{
    public int SlId { get; set; }

    public int? OpItemId { get; set; }

    public int? OpVentorId { get; set; }

    public decimal? OpPrice { get; set; }

    public string? OpActiveYn { get; set; }

    public string? OpCreatedBy { get; set; }

    public DateTime? OpCreatedOn { get; set; }

    public string? OpUpdatedBy { get; set; }

    public DateTime? OpUpdatedOn { get; set; }
}
