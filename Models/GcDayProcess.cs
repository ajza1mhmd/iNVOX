using System;
using System.Collections.Generic;

namespace Invox.Models;

public partial class GcDayProcess
{
    public int DpSlNo { get; set; }

    public int? DpStore { get; set; }

    public DateTime? DpDate { get; set; }

    public string? DpOpenedUser { get; set; }

    public DateTime? DpOpeningTime { get; set; }

    public string? DpOpenStatus { get; set; }

    public string? DpClosedUser { get; set; }

    public DateTime? DpClosingTime { get; set; }

    public int? DpTransYn { get; set; }
}
