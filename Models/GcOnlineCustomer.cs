using System;
using System.Collections.Generic;

namespace Invox.Models;

public partial class GcOnlineCustomer
{
    public long OcId { get; set; }

    public int? OcCustomerCode { get; set; }

    public string? OcCustomerName { get; set; }

    public string? OcActiveYn { get; set; }

    public DateTime? OcCreatedOn { get; set; }

    public string? OcCreatedBy { get; set; }

    public DateTime? OcUpdatedOn { get; set; }

    public string? OcUpdatedBy { get; set; }
}
