using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class ForVoucherEntryLog
{
    public string? Ddocode { get; set; }

    public string? FinYear { get; set; }

    public string? Month { get; set; }

    public string? Paymenttype { get; set; }

    public decimal? Expenditure { get; set; }

    public decimal? Deduction { get; set; }

    public string? Deductiondetail { get; set; }

    public decimal? Netamount { get; set; }

    public string? Hoa { get; set; }

    public string? Descriptionh { get; set; }

    public string? Descriptione { get; set; }

    public int? Voucherno { get; set; }

    public int? Subvoucherno { get; set; }

    public string? Chequeprepared { get; set; }

    public string? Billno { get; set; }

    public string? Subdivisioncode { get; set; }

    public long? Referenceno { get; set; }

    public string? Billstatus { get; set; }

    public DateTime? Billdate { get; set; }

    public string? Deptcode { get; set; }

    public string? Workcode { get; set; }

    public DateTime? Orderdate { get; set; }

    public string? Orderno { get; set; }

    public DateTime? Lastupdate { get; set; }

    public string? UserId { get; set; }

    public DateTime? EntryDate { get; set; }

    public string? ReturnRemark { get; set; }

    public string? IsApprovedBySdo { get; set; }

    public string? IsReturn { get; set; }

    public decimal? Gst { get; set; }

    public decimal? Dmf { get; set; }

    public decimal? InconeTax { get; set; }

    public decimal? Royalty { get; set; }

    public long? OldReferencenoforTax { get; set; }

    public int? TaxId { get; set; }

    public string? IsTaxBill { get; set; }

    public long? VoucherId { get; set; }

    public long? Groupid { get; set; }

    public string? MmOrderNumber { get; set; }

    public DateTime? SdoApDate { get; set; }

    public DateTime? SdoApSysDate { get; set; }

    public DateTime? DfoApDate { get; set; }

    public DateTime? DfoApSysDate { get; set; }

    public byte? IsDsc { get; set; }

    public long Logid { get; set; }

    public DateTime? LogEntryDateTime { get; set; }
}
