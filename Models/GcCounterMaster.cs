using System;
using System.Collections.Generic;

namespace Invox.Models;

public partial class GcCounterMaster
{
    public long CmId { get; set; }

    public int? CmStore { get; set; }

    public string? CmCounterNo { get; set; }

    public string? CmCounterName { get; set; }

    public string? CmType { get; set; }

    public string? CmActive { get; set; }

    public string? CmPrinterBill { get; set; }

    public string? CmPrinterReceipt { get; set; }

    public string? CmInvoiceNo { get; set; }

    public string? CmPrefix { get; set; }

    public DateTime? CmCreatedOn { get; set; }

    public string? CmCreatedBy { get; set; }

    public DateTime? CmUpdatedOn { get; set; }

    public string? CmUpdatedBy { get; set; }

    public int? CmTransYn { get; set; }
}
