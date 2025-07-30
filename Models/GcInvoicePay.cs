using System;
using System.Collections.Generic;

namespace Invox.Models;

public partial class GcInvoicePay
{
    public long IpId { get; set; }

    public int? IpStore { get; set; }

    public string? IpInvNo { get; set; }

    public string? IpPayMode { get; set; }

    public decimal? IpRecAmt { get; set; }

    public decimal? IpBalAmt { get; set; }

    public int? IpCustomerCode { get; set; }

    public string? IpCustomerName { get; set; }

    public DateTime? IpCreatedOn { get; set; }

    public string? IpCreatedBy { get; set; }

    public DateTime? IpUpdatedOn { get; set; }

    public string? IpUpdatedBy { get; set; }
}
