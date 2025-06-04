using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class BillPaymentFileDetail
{
    public int Id { get; set; }

    public string? FinYear { get; set; }

    public decimal? BillSerialNo { get; set; }

    public string? Msgtype { get; set; }

    public decimal? MsgId { get; set; }

    /// <summary>
    /// 0 file genarate, 1 ack read, 2 Dn read, 3 Rn read, 4 Account Statement  read
    /// </summary>
    public string? FileStatus { get; set; }

    public DateTime? CreDt { get; set; }

    public int? NbOfTxs { get; set; }

    /// <summary>
    /// totalAmount
    /// </summary>
    public decimal? CtrlSum { get; set; }

    public DateTime? EntryDate { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public string? NtryRef { get; set; }

    public decimal? OldBillSerialNo { get; set; }

    /// <summary>
    /// 0 for accept, 1 is repayment not processed and 2 is for repayment processed
    /// </summary>
    public byte? Repaymentstatus { get; set; }

    /// <summary>
    /// for account correction status
    /// </summary>
    public byte Changebyadmin { get; set; }

    public string? Duplicatfile { get; set; }

    public byte? RepaymentwithoutScheduler { get; set; }

    public byte? Ispushed { get; set; }

    /// <summary>
    /// 1- Duplicate Entry Of File,  2-File Not Found in Treasury, 3-Previous Year Pending After March Closing Cut Off or Previous Year Pending For other Reasons, 4- xmlFileTemp
    /// </summary>
    public byte? Isdelete { get; set; }

    public byte? Tstatus { get; set; }

    public DateOnly? Tacceptdate { get; set; }
}
