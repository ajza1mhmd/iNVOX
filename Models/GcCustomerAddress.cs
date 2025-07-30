using System;
using System.Collections.Generic;

namespace Invox.Models;

public partial class GcCustomerAddress
{
    public long CaId { get; set; }

    public long? CaCustId { get; set; }

    public long? CaCode { get; set; }

    public string? CaPhone { get; set; }

    public string? CaAddress { get; set; }

    public string? CaStreetName { get; set; }

    public string? CaBuildingName { get; set; }

    public string? CaArea { get; set; }

    public string? CaLandMark { get; set; }

    public string? CaActiveYn { get; set; }

    public DateTime? CaCreatedOn { get; set; }

    public string? CaCreatedBy { get; set; }

    public DateTime? CaUpdatedOn { get; set; }

    public string? CaUpdatedBy { get; set; }
}
