using System;
using System.Collections.Generic;

namespace Invox.Models;

public partial class GcInvoiceDetl
{
    public long IdId { get; set; }

    public int? IdStore { get; set; }

    public string? IdInvNo { get; set; }

    public int? IdIdx { get; set; }

    public long? IdItemCode { get; set; }

    public string? IdBarcode { get; set; }

    public string? IdName { get; set; }

    public string? IdKitchenMessage { get; set; }

    public string? IdArabicName { get; set; }

    public decimal? IdQuantity { get; set; }

    public decimal? IdPrice { get; set; }

    public decimal? IdTaxAmt { get; set; }

    public decimal? IdDiscAmt { get; set; }

    public decimal? IdNetTotal { get; set; }

    public string? IdKotYn { get; set; }

    public DateTime? IdCreatedOn { get; set; }

    public string? IdCreatedBy { get; set; }

    public DateTime? IdUpdatedOn { get; set; }

    public string? IdUpdatedBy { get; set; }

    public string? IdReturnYn { get; set; }
}
