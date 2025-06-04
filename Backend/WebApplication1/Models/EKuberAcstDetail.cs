using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class EKuberAcstDetail
{
    public long HdrRowId { get; set; }

    public string? HdrFileNo { get; set; }

    public string? HdrBizMsgIdr { get; set; }

    public string? DocNtryRef { get; set; }

    public decimal? DocAmtCcy { get; set; }

    public string? DocCdtDbtInd { get; set; }

    public string? DocRvslInd { get; set; }

    public string? DocSts { get; set; }

    public DateOnly? DocBookgDtDt { get; set; }

    public DateOnly? DocValDtDt { get; set; }

    public string? DocPrtryCd { get; set; }

    public DateTime? EntryDate { get; set; }
}
