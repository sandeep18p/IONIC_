using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class EKuberAcstHeader
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

    public DateTime? DocCreDtTm { get; set; }

    public string? DocStmtId { get; set; }

    public string? DocPgNb { get; set; }

    public string? DocLastPgInd { get; set; }

    public DateTime? DocStmtCreDtTm { get; set; }

    public DateTime? DocFrDtTm { get; set; }

    public DateTime? DocToDtTm { get; set; }

    public string? DocOthrId { get; set; }

    public string? DocBalTpCdOrPrtryCdOpbd { get; set; }

    public decimal? DocBalAmtCcyInrOpbd { get; set; }

    public string? DocBalCdtDbtIndOpbd { get; set; }

    public DateTime? DocBalDtDtTmOpbd { get; set; }

    public string? DocBalTpCdOrPrtryCdClbd { get; set; }

    public decimal? DocBalAmtCcyInrClbd { get; set; }

    public string? DocBalCdtDbtIndClbd { get; set; }

    public DateTime? DocBalDtDtTmClbd { get; set; }

    public int? DocTtlCdtNtriesNbOfNtries { get; set; }

    public decimal? DocTtlCdtNtriesSum { get; set; }

    public int? DocTtlDbtNtriesNbOfNtries { get; set; }

    public decimal? DocTtlDbtNtriesSum { get; set; }

    public DateTime? EntryDate { get; set; }
}
