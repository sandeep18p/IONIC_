using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class EKuberInackInnckDetail
{
    public long HdrRowId { get; set; }

    public string? HdrFileNo { get; set; }

    public string? HdrBizMsgIdr { get; set; }

    public string? DocOrgnlPmtInfId { get; set; }

    public string? DocPmtInfSts { get; set; }

    public string? DocOrgnlInstrId { get; set; }

    public string? DocOrgnlEndToEndId { get; set; }

    public string? DocTxSts { get; set; }

    public DateTime? DocAccptncDtTm { get; set; }

    public string? DocPrtry { get; set; }

    public DateTime? EntryDate { get; set; }
}
