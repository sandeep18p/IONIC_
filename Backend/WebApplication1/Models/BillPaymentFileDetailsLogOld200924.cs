using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class BillPaymentFileDetailsLogOld200924
{
    public int Id { get; set; }

    public string? FinYear { get; set; }

    public decimal? BillSerialNo { get; set; }

    public string? Msgtype { get; set; }

    public decimal? MsgId { get; set; }

    public string? FileStatus { get; set; }

    public DateTime? CreDt { get; set; }

    public int? NbOfTxs { get; set; }

    public decimal? CtrlSum { get; set; }

    public DateTime? EntryDate { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public string? NtryRef { get; set; }

    public decimal? OldBillSerialNo { get; set; }

    public byte? Repaymentstatus { get; set; }
}
