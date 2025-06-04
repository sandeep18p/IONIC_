using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class EKuberEpayDetail
{
    public long AppHdrRowId { get; set; }

    public string? AppHdrId { get; set; }

    public string? AppHdrFileNo { get; set; }

    public string? PmtInfPmtInfId { get; set; }

    public string? PmtInfPmtMtd { get; set; }

    public string? PmtInfBtchBookg { get; set; }

    public int? PmtInfNbOfTxs { get; set; }

    public decimal? PmtInfCtrlSum { get; set; }

    public string? PmtInfPmtTpInfInstrPrty { get; set; }

    public string? PmtInfPmtTpInfSvcLvlPrtry { get; set; }

    public string? PmtInfReqdExctnDt { get; set; }

    public string? PmtInfDbtrNm { get; set; }

    public string? PmtInfDbtrPstlAdrDept { get; set; }

    public string? PmtInfDbtrPstlAdrSubDept { get; set; }

    public string? PmtInfDbtrIdOrgIdOthrId { get; set; }

    public string? PmtInfDbtrAcctIdOthrId { get; set; }

    public string? PmtInfDbtrAgtFinInstnIdClrSysMmbIdMmbId { get; set; }

    public string? PmtInfCdtTrfTxInfPmtIdInstrId { get; set; }

    public string? PmtInfCdtTrfTxInfPmtIdEndToEndId { get; set; }

    public decimal? PmtInfCdtTrfTxInfAmtInstdAmtAmt { get; set; }

    public string? PmtInfCdtTrfTxInfAmtInstdAmtCcyOfTrf { get; set; }

    public string? PmtInfCdtTrfTxInfCdtrAgtFinInstnIdClrSysMmbIdMmbId { get; set; }

    public string? PmtInfCdtTrfTxInfCdtrNm { get; set; }

    public string? PmtInfCdtTrfTxInfCdtrAcctIdOthrId { get; set; }

    public string? PmtInfCdtTrfTxInfCdtrAcctTpCd { get; set; }

    public string? PmtInfCdtTrfTxInfRmtInfUstrdContractorId { get; set; }

    public string? PmtInfCdtTrfTxInfRmtInfUstrdSerialNo { get; set; }

    public string? PmtInfCdtTrfTxInfRmtInfUstrdInitId { get; set; }

    public DateTime? PmtInfEntryDate { get; set; }
}
