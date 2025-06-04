using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class VouchertDetail
{
    public string InitializationId { get; set; } = null!;

    public long SerialNo { get; set; }

    public decimal ReportOrderNo { get; set; }

    public DateTime? ReportOrderDt { get; set; }

    public DateTime? EntryDt { get; set; }

    public string FinYear { get; set; } = null!;

    public string Ddocode { get; set; } = null!;

    public string FlagTable { get; set; } = null!;

    public long SrNo { get; set; }

    public string? BpbillPaymentType { get; set; }

    public string? BpagreementedType { get; set; }

    public string? VoucherNo { get; set; }

    public DateTime? VoucherDt { get; set; }

    public string? BpnameOfWork { get; set; }

    public string? PaidTo { get; set; }

    public string? BpagrBillStatus { get; set; }

    public string? BpbillNo { get; set; }

    public DateTime? BpbillDate { get; set; }

    public decimal? GrossAmount { get; set; }

    public decimal? IncomeTax { get; set; }

    public decimal? SecurityDeposit { get; set; }

    public decimal? Vattax0040 { get; set; }

    public decimal? Vattax8443 { get; set; }

    public decimal? PerformanceGuarantee { get; set; }

    public decimal? Royalty0853 { get; set; }

    public decimal? Royalty8443 { get; set; }

    public decimal? SerivceTax { get; set; }

    public decimal? TimeExtention { get; set; }

    public decimal? KarmkarTax { get; set; }

    public decimal? RevenueRecovery { get; set; }

    public decimal? MiscRecovery { get; set; }

    public decimal? Testing { get; set; }

    public string? RevenueRecoveryAgainst { get; set; }

    public string? MiscRecoveryAgainst { get; set; }

    public decimal? TotalDeduction { get; set; }

    public decimal? TotalContractorDeposit { get; set; }

    public decimal? BpamountPaidByCash { get; set; }

    public decimal? BpamountPaidByCheque { get; set; }

    public string? ChequeBookNo { get; set; }

    public string? ChequeNo { get; set; }

    public DateTime? ChequeDt { get; set; }

    public string? HronAccountOf { get; set; }

    public string? PaymentMode { get; set; }

    public long? MrbookNo { get; set; }

    public long? MrNo { get; set; }

    public string? MrdepositorName { get; set; }

    public DateTime? MrmissueDt { get; set; }

    public string? MusterRollNo { get; set; }

    public DateTime? MperiodFrom { get; set; }

    public DateTime? MperiodTo { get; set; }

    public string? MpaymentBy { get; set; }

    public DateTime? MpaymentDt { get; set; }

    public string? Mallocation { get; set; }

    public decimal? MtotalCashPaid { get; set; }

    public string? MgrainPaid { get; set; }

    public decimal? MrateOfGrain { get; set; }

    public decimal? MamountPaidByGrain { get; set; }

    public string? MworkName { get; set; }

    public int? BagreementNo { get; set; }

    public string? BcontractorId { get; set; }

    public int? NoOfBpwork { get; set; }

    public int? WcnoOfReceiptAllocation { get; set; }

    public string? YearOfAgreement { get; set; }

    public string? ChequeStatus { get; set; }

    public decimal? AmountWork { get; set; }

    public decimal? Escalation { get; set; }

    public decimal? Bonus { get; set; }

    public decimal? BadPdSecuredAdvance { get; set; }

    public decimal? BadPmobilisationAdvance { get; set; }

    public decimal? BadPplantMachinaryAdvance { get; set; }

    public decimal? BarfbsecuredAdvance { get; set; }

    public decimal? BarfbmobilisationAdvance { get; set; }

    public decimal? BarfbplantandMachinaryAdvance { get; set; }

    public string? BponAccountOf { get; set; }

    public DateTime? ChallanDt { get; set; }

    public long? ChallanNo { get; set; }

    public string? BagreementOrSharared { get; set; }

    public string? BagreementedBy { get; set; }

    public string? Todflag { get; set; }

    public string? MronAccountOf { get; set; }

    public string? MrworkCategory { get; set; }

    public decimal? Mramount { get; set; }

    public string? MrschemeName { get; set; }

    public string? MrworkCode { get; set; }

    public string? Mryear { get; set; }

    public string? MrallocationId { get; set; }

    public string? NameOfPieceWork { get; set; }

    public string? PieceWorkNo { get; set; }

    public string? IsCancel { get; set; }

    public string? IsPrepare { get; set; }

    public string? IsCancelOnly { get; set; }

    public string? IsPrint { get; set; }

    public string? IsApproved { get; set; }

    public string? DivisionId { get; set; }

    public string? CircleId { get; set; }

    public string? ZoneId { get; set; }

    public string? IpAddress { get; set; }

    public string? AgmtStatus { get; set; }

    public string? WorkStatus { get; set; }

    public string? PassedBy { get; set; }

    public decimal? AmountPaidInAgmt { get; set; }

    public decimal? TotalValueOfContract { get; set; }

    public decimal? CreditToMiscAdvance { get; set; }

    public DateTime? DtComplitionClosingOfAgreement { get; set; }

    public string? BlankField { get; set; }

    public string? CancelOnly { get; set; }

    public string? AgreementStatusNew { get; set; }

    public string? DepMonth { get; set; }

    public string? ApproveBy { get; set; }

    public string? CancelRemark { get; set; }

    public DateTime? ApproveDate { get; set; }

    public string? ReasonReject { get; set; }

    public string? RevenueRecoveryHead { get; set; }

    public string? Pan { get; set; }

    public string? Tin { get; set; }

    public string? RefNo { get; set; }

    public DateOnly? RefDate { get; set; }

    public string? IsRelaxation { get; set; }

    public string? NonAgrType { get; set; }

    public string? NonAgrItem { get; set; }

    public string? Gsttype { get; set; }

    public string? Gstno { get; set; }

    public string? PaNo { get; set; }

    public string? HeadFlag { get; set; }

    public int? NoofSolarPump { get; set; }

    public string? BeneficiaryType { get; set; }

    public string? AcntHolderName { get; set; }

    public string? AcntNo { get; set; }

    public string? BankName { get; set; }

    public string? BranchName { get; set; }

    public string? Micrcode { get; set; }

    public string? Ifsc { get; set; }

    public string? FileNo { get; set; }

    public string? FileName { get; set; }

    public string? EndToEndId { get; set; }

    public string? IsRnReissued { get; set; }

    public string? RnReissuedByEnc { get; set; }

    public DateTime? RnReissuedByEncDate { get; set; }

    public string? RnReissuedSerialNo { get; set; }

    public string? EKuberReturnReasn { get; set; }
}
