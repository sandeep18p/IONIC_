using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class EKuberDnRnDetail
{
    public long HdrRowId { get; set; }

    public string? HdrFileNo { get; set; }

    public string? HdrBizMsgIdr { get; set; }

    public string? DocRefsMsgId { get; set; }

    public string? DocRefsAcctSvcrRef { get; set; }

    public string? DocRefsPmtInfId { get; set; }

    public string? DocRefsInstrId { get; set; }

    public string? DocRefsEndToEndId { get; set; }

    public string? DocRefsTxId { get; set; }

    public decimal? DocTxDtlsAmt { get; set; }

    public string? DocTxDtlsCdtDbtInd { get; set; }

    public string? DocNtryPrtryCd { get; set; }

    public string? DocTxDtlsRmtInfUstrd1 { get; set; }

    public string? DocTxDtlsRmtInfUstrd2 { get; set; }

    public string? DocTxDtlsRmtInfUstrd3 { get; set; }

    public string? DocTxDtlsRmtInfUstrd4 { get; set; }

    public DateTime? DocTxDtlsRltdDtsAccptncDtTm { get; set; }

    public int? DocTxDtlsAddtlTxInf { get; set; }

    public DateTime? EntryDate { get; set; }
}
