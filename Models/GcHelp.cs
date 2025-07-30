using System;
using System.Collections.Generic;

namespace Invox.Models;

public partial class GcHelp
{
    public long HpId { get; set; }

    public string? HpCompany { get; set; }

    public string? HpContactPerson1 { get; set; }

    public string? HpContactPerson2 { get; set; }

    public string? HpContactMobile1 { get; set; }

    public string? HpContactMobile2 { get; set; }

    public string? HpContactEmail1 { get; set; }

    public string? HpContactEmail2 { get; set; }

    public string? HpWebsite { get; set; }

    public string? HpCopyright { get; set; }

    public string? HpMoreInfo { get; set; }

    public DateTime? HpCreatedOn { get; set; }

    public string? HpCreatedBy { get; set; }

    public DateTime? HpUpdatedOn { get; set; }

    public string? HpUpdatedBy { get; set; }

    public int? HpTransYn { get; set; }
}
