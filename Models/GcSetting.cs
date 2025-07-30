using System;
using System.Collections.Generic;

namespace Invox.Models;

public partial class GcSetting
{
    public long SiId { get; set; }

    public string? SiKey { get; set; }

    public string? SiName { get; set; }

    public string? SiValue { get; set; }

    public DateTime? SiCreatedOn { get; set; }

    public string? SiCreatedBy { get; set; }

    public DateTime? SiUpdatedOn { get; set; }

    public string? SiUpdatedBy { get; set; }
}
