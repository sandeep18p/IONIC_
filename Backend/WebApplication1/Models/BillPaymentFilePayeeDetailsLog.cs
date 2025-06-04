using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class BillPaymentFilePayeeDetailsLog
{
    public long Id { get; set; }

    public int? PayeeId { get; set; }

    public string? Msgtype { get; set; }

    public decimal? MsgId { get; set; }

    public string? PmtInfId { get; set; }

    public decimal? InstrId { get; set; }

    public string? EndToEndId { get; set; }

    public DateTime? CreDt { get; set; }

    public decimal? CtrlSum { get; set; }

    public string? UtrNo { get; set; }

    public string? Status { get; set; }

    public DateTime? EntryDate { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public string? Ustrd { get; set; }

    public string? InAckfileName { get; set; }

    public DateTime? InAckfileReadDatetime { get; set; }

    public string? InNckfileName { get; set; }

    public DateTime? InNckfileReadDatetime { get; set; }

    public string? DnFileName { get; set; }

    public DateTime? DnFileReadDatetime { get; set; }

    public string? RnFileName { get; set; }

    public DateTime? RnFileReadDatetime { get; set; }

    public string? OldEndToEndId { get; set; }

    public DateTime? LogEntryDateTime { get; set; }

    public byte? Isdelete { get; set; }

    public long LogId { get; set; }
}
