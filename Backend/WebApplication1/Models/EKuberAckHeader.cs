using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class EKuberAckHeader
{
    public long AppHdrRowId { get; set; }

    public string? AppHdrFileNo { get; set; }

    public string? AppHdrFrFiidFinInstnIdClrSysMmbIdMmbId { get; set; }

    public string? AppHdrToOrgIdIdOrgIdOthrId { get; set; }

    public string? AppHdrBizMsgIdr { get; set; }

    public string? AppHdrMsgDefIdr { get; set; }

    public string? AppHdrBizSvc { get; set; }

    public DateTime? AppHdrCreDt { get; set; }

    public string? DocumentCstmrPmtStsRptGrpHdrMsgId { get; set; }

    public DateTime? DocumentCstmrPmtStsRptGrpHdrCreDtTm { get; set; }

    public string? DocumentCstmrPmtStsRptOrgnlGrpInfAndStsOrgnlMsgId { get; set; }

    public string? DocumentCstmrPmtStsRptOrgnlGrpInfAndStsOrgnlMsgNmId { get; set; }

    public DateTime? DocumentCstmrPmtStsRptOrgnlGrpInfAndStsOrgnlCreDtTm { get; set; }

    public int? DocumentCstmrPmtStsRptOrgnlGrpInfAndStsOrgnlNbOfTxs { get; set; }

    public decimal? DocumentCstmrPmtStsRptOrgnlGrpInfAndStsOrgnlCtrlSum { get; set; }

    public string? DocumentCstmrPmtStsRptOrgnlGrpInfAndStsGrpSts { get; set; }

    public string? DocumentCstmrPmtStsRptOrgnlPmtInfAndStsStsRsnInfRsnPrtry { get; set; }

    public DateTime? EntryDate { get; set; }
}
