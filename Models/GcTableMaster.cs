using System;
using System.Collections.Generic;

namespace Invox.Models;

public partial class GcTableMaster
{
    public long TmId { get; set; }

    public int? TmStore { get; set; }

    public string TmNumber { get; set; } = null!;

    public string TmType { get; set; } = null!;

    public string? TmStatus { get; set; }

    public DateTime? TmStartTime { get; set; }

    public string? TmInvocieNo { get; set; }

    public string? TmActive { get; set; }

    public string? TmParentYn { get; set; }

    public string? TmTempYn { get; set; }

    public int? TmTransYn { get; set; }

    public string? TmChildId { get; set; }

    public DateTime? TmCreatedOn { get; set; }

    public string? TmCreatedBy { get; set; }

    public DateTime? TmUpdatedOn { get; set; }

    public string? TmUpdatedBy { get; set; }
}
