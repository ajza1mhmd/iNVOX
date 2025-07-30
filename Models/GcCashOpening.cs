using System;
using System.Collections.Generic;

namespace Invox.Models;

public partial class GcCashOpening
{
    public long CoId { get; set; }

    public int? CoStore { get; set; }

    public DateTime? CoInvDate { get; set; }

    public decimal? CoOpenAmt { get; set; }

    public decimal? CoSales { get; set; }

    public decimal? CoCloseAmt { get; set; }

    public decimal? CoDiffAmt { get; set; }

    public string? CoCloseYn { get; set; }

    public DateTime? CoCreatedOn { get; set; }

    public string? CoCreatedBy { get; set; }

    public DateTime? CoUpdatedOn { get; set; }

    public string? CoUpdatedBy { get; set; }

    public int? CoTransYn { get; set; }
}
