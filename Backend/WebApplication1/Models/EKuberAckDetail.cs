using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class EKuberAckDetail
{
    public long DocumentRowId { get; set; }

    public string? DocumentFileNo { get; set; }

    public string? DocumentCstmrPmtStsRptOrgnlPmtInfAndStsOrgnlPmtInfId { get; set; }

    public string? DocumentCstmrPmtStsRptOrgnlPmtInfAndStsPmtInfSts { get; set; }

    public string? DocumentCstmrPmtStsRptOrgnlPmtInfAndStsTxInfAndStsOrgnlInstrId { get; set; }

    public string? DocumentCstmrPmtStsRptOrgnlPmtInfAndStsTxInfAndStsOrgnlEndToEndId { get; set; }

    public string? DocumentCstmrPmtStsRptOrgnlPmtInfAndStsTxInfAndStsTxSts { get; set; }

    public DateTime? DocumentCstmrPmtStsRptOrgnlPmtInfAndStsTxInfAndStsAccptncDtTm { get; set; }

    public string? DocumentCstmrPmtStsRptOrgnlPmtInfAndStsTxInfAndStsStsRsnInfRsnPrtry { get; set; }

    public DateTime? EntryDate { get; set; }
}
