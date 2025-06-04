using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class AllocationDetail
{
    public string InitializationId { get; set; } = null!;

    public long SerialNo { get; set; }

    public decimal ReportOrderNo { get; set; }

    public DateTime? ReportOrderDt { get; set; }

    public DateTime? EntryDt { get; set; }

    public string FinYear { get; set; } = null!;

    public string Ddocode { get; set; } = null!;

    public string FlagTable { get; set; } = null!;

    public long SrNo { get; set; }

    public long? BillDetailSrNo { get; set; }

    public string? VoucherNo { get; set; }

    public string? BpbillNo { get; set; }

    public decimal? Amount { get; set; }

    public string BillAllocation { get; set; } = null!;

    public string? AllocationId { get; set; }

    public string? WorkName { get; set; }

    public string? WorkCode { get; set; }

    public string? Workyear { get; set; }

    public long? MrbookNo { get; set; }

    public long? Mrno { get; set; }

    public DateTime? MrissueDt { get; set; }

    public string? Mrscheme { get; set; }

    public int? BagreementNo { get; set; }

    public string? WorkCat { get; set; }

    public string? Worktype { get; set; }

    public string? RoadId { get; set; }

    public string? Pbflag { get; set; }

    public decimal? BlankField { get; set; }

    public string? IsAti { get; set; }

    public string? WorkCodeNew { get; set; }

    public string? DivisionId { get; set; }

    public decimal? Ecamount { get; set; }

    public decimal? Tpamount { get; set; }

    public string? CircleId { get; set; }

    public string? ZoneId { get; set; }

    public string? IpAddress { get; set; }

    public string? EworkName { get; set; }

    public string? CancelOnly { get; set; }

    public string? BridgeType { get; set; }

    public string? BridgeName { get; set; }

    public string? BridgeId { get; set; }

    public string? RoadDivisionId { get; set; }

    public string? DocketNo { get; set; }

    public string? Updateflag { get; set; }

    public string? MatPay { get; set; }

    public decimal? PerRecoveryAmount { get; set; }

    public string? Itemcat { get; set; }

    public string? HeadFlag { get; set; }

    public string? BillSerialNo { get; set; }
}
