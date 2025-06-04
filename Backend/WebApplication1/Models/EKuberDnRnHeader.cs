using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class EKuberDnRnHeader
{
    public long HdrRowId { get; set; }

    public string? HdrFileNo { get; set; }

    public string? HdrMmbId { get; set; }

    public string? HdrOthrId { get; set; }

    public string? HdrBizMsgIdr { get; set; }

    public string? HdrMsgDefIdr { get; set; }

    public string? HdrBizSvc { get; set; }

    public DateTime? HdrCreDt { get; set; }

    public string? DocMsgId { get; set; }

    public string? DocCreDtTm { get; set; }

    public string? DocNtfctnId { get; set; }

    public int? DocPgNb { get; set; }

    public string? DocLastPgInd { get; set; }

    public string? DocOthrId { get; set; }

    public int? DocNbOfNtries { get; set; }

    public decimal? DocSum { get; set; }

    public string? DocNtryNtryRef { get; set; }

    public decimal? DocNtryAmt { get; set; }

    public string? DocNtryCdtDbtInd { get; set; }

    public string? DocNtryRvslInd { get; set; }

    public string? DocNtrySts { get; set; }

    public DateOnly? DocNtryBookgDtDt { get; set; }

    public DateOnly? DocNtryValDtDt { get; set; }

    public int? DocNtryNbOfTxs { get; set; }

    public DateTime? EntryDate { get; set; }
}
