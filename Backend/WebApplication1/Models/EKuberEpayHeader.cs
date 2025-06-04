using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class EKuberEpayHeader
{
    public long AppHdrRowId { get; set; }

    public string? AppHdrId { get; set; }

    public string? AppHdrFileNo { get; set; }

    public string? AppHdrFrOrgIdIdOrgIdOthrId { get; set; }

    public string? AppHdrToFiidFinInstnIdClrSysMmbIdMmbId { get; set; }

    public string? AppHdrBizMsgIdr { get; set; }

    public string? AppHdrMsgDefIdr { get; set; }

    public string? AppHdrBizSvc { get; set; }

    public string? AppHdrCreDt { get; set; }

    public string? DocumentCstmrCdtTrfInitnGrpHdrMsgId { get; set; }

    public string? DocumentCstmrCdtTrfInitnGrpHdrCreDtTm { get; set; }

    public string? DocumentCstmrCdtTrfInitnGrpHdrAuthstnPrtry { get; set; }

    public int? DocumentCstmrCdtTrfInitnGrpHdrNbOfTxs { get; set; }

    public decimal? DocumentCstmrCdtTrfInitnGrpHdrCtrlSum { get; set; }

    public string? DocumentCstmrCdtTrfInitnGrpHdrInitgPtyNm { get; set; }

    public string? DocumentCstmrCdtTrfInitnGrpHdrInitgPtyIdOrgIdOthrId { get; set; }

    public string? DocumentCstmrCdtTrfInitnGrpHdrInitgPtyCtctDtlsEmailAdr { get; set; }

    public DateTime? AppHdrEntryDate { get; set; }
}
