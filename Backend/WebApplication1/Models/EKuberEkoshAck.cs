using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class EKuberEkoshAck
{
    public long HdrRowId { get; set; }

    public string? HdrFileNo { get; set; }

    public string? HdrMmbId { get; set; }

    public string? HdrOthrId { get; set; }

    public string? HdrBizMsgIdr { get; set; }

    public string? HdrMsgDefIdr { get; set; }

    public string? HdrBizSvc { get; set; }

    public DateTime? HdrCreDt { get; set; }

    public string? DocEvtCd { get; set; }

    public DateTime? DocEvtTm { get; set; }

    public DateTime? EntryDate { get; set; }
}
