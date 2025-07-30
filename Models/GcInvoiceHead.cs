using System;
using System.Collections.Generic;

namespace Invox.Models;

public partial class GcInvoiceHead
{
    public long IhId { get; set; }

    public int? CmStore { get; set; }

    public string? IhInvNo { get; set; }

    public DateTime? IhInvDate { get; set; }

    public string? IhTableNo { get; set; }

    public long? IhStaff { get; set; }

    public long? IhCustomer { get; set; }

    public long? IhCustomerAddress { get; set; }

    public string? IhType { get; set; }

    public long? IhDeliveryId { get; set; }

    public int? IhItemCount { get; set; }

    public decimal? IhTotalAmt { get; set; }

    public decimal? IhTaxAmt { get; set; }

    public decimal? IhDiscAmt { get; set; }

    public decimal? IhNetAmt { get; set; }

    public string? IhPostYn { get; set; }

    public string? IhHoldYn { get; set; }

    public string? IhTransYn { get; set; }

    public int? IhKotCount { get; set; }

    public int? IhBillPrintCount { get; set; }

    public int? IhReprintCount { get; set; }

    public DateTime? IhInvoicedOn { get; set; }

    public string? IhInvoiceBy { get; set; }

    public string? IhRemarks { get; set; }

    public string? IhInfo { get; set; }

    public DateTime? IhCreatedOn { get; set; }

    public string? IhCreatedBy { get; set; }

    public DateTime? IhUpdatedOn { get; set; }

    public string? IhUpdatedBy { get; set; }

    public string? IhReturnYn { get; set; }

    public string? IhCurCode { get; set; }

    public int? IhOnlineVendor { get; set; }

    public string? IhOnlineRef { get; set; }
}
