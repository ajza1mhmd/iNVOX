using System;
using System.Collections.Generic;

namespace Invox.Models;

public partial class GcStaffMaster
{
    public long SmId { get; set; }

    public int? SmStore { get; set; }

    public string? SmStaffId { get; set; }

    public string? SmStaffName { get; set; }

    public string? SmActiveYn { get; set; }

    public DateTime? SmCreatedOn { get; set; }

    public string? SmCreatedBy { get; set; }

    public DateTime? SmUpdatedOn { get; set; }

    public string? SmUpdatedBy { get; set; }
}
