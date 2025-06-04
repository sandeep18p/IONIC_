using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models;

public partial class FdsMayContext : DbContext
{
    public FdsMayContext()
    {
    }

    public FdsMayContext(DbContextOptions<FdsMayContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Ackfailedfiledetail> Ackfailedfiledetails { get; set; }

    public virtual DbSet<AllocationDetail> AllocationDetails { get; set; }

    public virtual DbSet<BankMaster> BankMasters { get; set; }

    public virtual DbSet<BcoToHeadMapping> BcoToHeadMappings { get; set; }

    public virtual DbSet<BillEntryStatus> BillEntryStatuses { get; set; }

    public virtual DbSet<BillPaymentAccountStatement> BillPaymentAccountStatements { get; set; }

    public virtual DbSet<BillPaymentFailedFilePayeeDetail> BillPaymentFailedFilePayeeDetails { get; set; }

    public virtual DbSet<BillPaymentFileDetail> BillPaymentFileDetails { get; set; }

    public virtual DbSet<BillPaymentFileDetailsLog> BillPaymentFileDetailsLogs { get; set; }

    public virtual DbSet<BillPaymentFileDetailsLogOld200924> BillPaymentFileDetailsLogOld200924s { get; set; }

    public virtual DbSet<BillPaymentFileDetailsOld200924> BillPaymentFileDetailsOld200924s { get; set; }

    public virtual DbSet<BillPaymentFilePayeeDetail> BillPaymentFilePayeeDetails { get; set; }

    public virtual DbSet<BillPaymentFilePayeeDetailLog> BillPaymentFilePayeeDetailLogs { get; set; }

    public virtual DbSet<BillPaymentFilePayeeDetailsLog> BillPaymentFilePayeeDetailsLogs { get; set; }

    public virtual DbSet<BillPaymentFilePayeeDetailsOld200924> BillPaymentFilePayeeDetailsOld200924s { get; set; }

    public virtual DbSet<BillTaxDetail> BillTaxDetails { get; set; }

    public virtual DbSet<BillTaxDetailsLog> BillTaxDetailsLogs { get; set; }

    public virtual DbSet<ChangeTrackingHistory> ChangeTrackingHistories { get; set; }

    public virtual DbSet<CircleMaster> CircleMasters { get; set; }

    public virtual DbSet<Ddo> Ddos { get; set; }

    public virtual DbSet<DdoDetail> DdoDetails { get; set; }

    public virtual DbSet<DemandnoMaster> DemandnoMasters { get; set; }

    public virtual DbSet<DetailheadMaster> DetailheadMasters { get; set; }

    public virtual DbSet<DistrictMaster> DistrictMasters { get; set; }

    public virtual DbSet<DivisonMaster> DivisonMasters { get; set; }

    public virtual DbSet<DscTokenDetail> DscTokenDetails { get; set; }

    public virtual DbSet<DuplicateFile> DuplicateFiles { get; set; }

    public virtual DbSet<EKuberAckDetail> EKuberAckDetails { get; set; }

    public virtual DbSet<EKuberAckHeader> EKuberAckHeaders { get; set; }

    public virtual DbSet<EKuberAcstDetail> EKuberAcstDetails { get; set; }

    public virtual DbSet<EKuberAcstHeader> EKuberAcstHeaders { get; set; }

    public virtual DbSet<EKuberActivityLog> EKuberActivityLogs { get; set; }

    public virtual DbSet<EKuberDnRnDetail> EKuberDnRnDetails { get; set; }

    public virtual DbSet<EKuberDnRnHeader> EKuberDnRnHeaders { get; set; }

    public virtual DbSet<EKuberEkoshAck> EKuberEkoshAcks { get; set; }

    public virtual DbSet<EKuberEpayDetail> EKuberEpayDetails { get; set; }

    public virtual DbSet<EKuberEpayHeader> EKuberEpayHeaders { get; set; }

    public virtual DbSet<EKuberErrorLog> EKuberErrorLogs { get; set; }

    public virtual DbSet<EKuberInackInnckDetail> EKuberInackInnckDetails { get; set; }

    public virtual DbSet<EKuberInackInnckHeader> EKuberInackInnckHeaders { get; set; }

    public virtual DbSet<EKuberRnVoucherReIssue> EKuberRnVoucherReIssues { get; set; }

    public virtual DbSet<EKuberServiceCallLog> EKuberServiceCallLogs { get; set; }

    public virtual DbSet<ErrorLog> ErrorLogs { get; set; }

    public virtual DbSet<ErrorMessageMaster> ErrorMessageMasters { get; set; }

    public virtual DbSet<ForAuthority1> ForAuthority1s { get; set; }

    public virtual DbSet<ForChequeDelivery> ForChequeDeliveries { get; set; }

    public virtual DbSet<ForChequeDeliveryLog> ForChequeDeliveryLogs { get; set; }

    public virtual DbSet<ForChequeEncashment> ForChequeEncashments { get; set; }

    public virtual DbSet<ForChequeMaster> ForChequeMasters { get; set; }

    public virtual DbSet<ForChequePreparation> ForChequePreparations { get; set; }

    public virtual DbSet<ForDepositBalance> ForDepositBalances { get; set; }

    public virtual DbSet<ForDepositBalanceLog> ForDepositBalanceLogs { get; set; }

    public virtual DbSet<ForDepositEntry> ForDepositEntries { get; set; }

    public virtual DbSet<ForDepositEntryLog> ForDepositEntryLogs { get; set; }

    public virtual DbSet<ForDepositWork> ForDepositWorks { get; set; }

    public virtual DbSet<ForDepositWorkOld> ForDepositWorkOlds { get; set; }

    public virtual DbSet<ForDeptmast> ForDeptmasts { get; set; }

    public virtual DbSet<ForDeptmastOld> ForDeptmastOlds { get; set; }

    public virtual DbSet<ForMismathPaymentReference> ForMismathPaymentReferences { get; set; }

    public virtual DbSet<ForVoucherEntry> ForVoucherEntries { get; set; }

    public virtual DbSet<ForVoucherEntryDetail> ForVoucherEntryDetails { get; set; }

    public virtual DbSet<ForVoucherEntryDetailsLog> ForVoucherEntryDetailsLogs { get; set; }

    public virtual DbSet<ForVoucherEntryDetailsLog22oct2024> ForVoucherEntryDetailsLog22oct2024s { get; set; }

    public virtual DbSet<ForVoucherEntryLog> ForVoucherEntryLogs { get; set; }

    public virtual DbSet<ForVoucherEntryLog22oct2024> ForVoucherEntryLog22oct2024s { get; set; }

    public virtual DbSet<Ifscmaster> Ifscmasters { get; set; }

    public virtual DbSet<Labourwagesdetail> Labourwagesdetails { get; set; }

    public virtual DbSet<LabourwagesdetailsLog> LabourwagesdetailsLogs { get; set; }

    public virtual DbSet<Labourworkdetail> Labourworkdetails { get; set; }

    public virtual DbSet<Labourworktype> Labourworktypes { get; set; }

    public virtual DbSet<LocLogin> LocLogins { get; set; }

    public virtual DbSet<LoginMappingTable> LoginMappingTables { get; set; }

    public virtual DbSet<MajorheadMaster> MajorheadMasters { get; set; }

    public virtual DbSet<Mergedbillfiledetail> Mergedbillfiledetails { get; set; }

    public virtual DbSet<MergedbillfiledetailsLog> MergedbillfiledetailsLogs { get; set; }

    public virtual DbSet<MinorheadMaster> MinorheadMasters { get; set; }

    public virtual DbSet<MonthMaster> MonthMasters { get; set; }

    public virtual DbSet<NotificationNotReceived> NotificationNotReceiveds { get; set; }

    public virtual DbSet<ObjectheadMaster> ObjectheadMasters { get; set; }

    public virtual DbSet<RangeMaster> RangeMasters { get; set; }

    public virtual DbSet<SchemecodeMaster> SchemecodeMasters { get; set; }

    public virtual DbSet<SdoAndDfoDeptName> SdoAndDfoDeptNames { get; set; }

    public virtual DbSet<SegmentCodeMaster> SegmentCodeMasters { get; set; }

    public virtual DbSet<StateMaster> StateMasters { get; set; }

    public virtual DbSet<StatusCodeMaster> StatusCodeMasters { get; set; }

    public virtual DbSet<SubDivisionMasterNew> SubDivisionMasterNews { get; set; }

    public virtual DbSet<Subdivisionmaster> Subdivisionmasters { get; set; }

    public virtual DbSet<SubmajorheadMaster> SubmajorheadMasters { get; set; }

    public virtual DbSet<SuspenseAccountDetail> SuspenseAccountDetails { get; set; }

    public virtual DbSet<TaxBillReferenceDetail> TaxBillReferenceDetails { get; set; }

    public virtual DbSet<TaxMaster> TaxMasters { get; set; }

    public virtual DbSet<TblRbiMissingFile> TblRbiMissingFiles { get; set; }

    public virtual DbSet<TempLabourRepaymentDetail> TempLabourRepaymentDetails { get; set; }

    public virtual DbSet<Token> Tokens { get; set; }

    public virtual DbSet<TreasuryResponseLog> TreasuryResponseLogs { get; set; }

    public virtual DbSet<Tstatusmaster> Tstatusmasters { get; set; }

    public virtual DbSet<UserActivityLog> UserActivityLogs { get; set; }

    public virtual DbSet<UserTypeMaster> UserTypeMasters { get; set; }

    public virtual DbSet<Userrepaymentupdate> Userrepaymentupdates { get; set; }

    public virtual DbSet<VendorBankDetail> VendorBankDetails { get; set; }

    public virtual DbSet<VendorBankDetailsLog> VendorBankDetailsLogs { get; set; }

    public virtual DbSet<VendorBankDetailscopy> VendorBankDetailscopies { get; set; }

    public virtual DbSet<VendorMaster> VendorMasters { get; set; }

    public virtual DbSet<VendorMasterLog> VendorMasterLogs { get; set; }

    public virtual DbSet<VendorMasterNew> VendorMasterNews { get; set; }

    public virtual DbSet<VendorMasterOld> VendorMasterOlds { get; set; }

    public virtual DbSet<Voucher> Vouchers { get; set; }

    public virtual DbSet<VouchertDetail> VouchertDetails { get; set; }

    public virtual DbSet<Vw> Vws { get; set; }

    public virtual DbSet<VwLabourwage> VwLabourwages { get; set; }

    public virtual DbSet<WingMaster> WingMasters { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-CC429DC\\SQLEXPRESS; Database=FDS_MAY; Integrated Security=True; TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Latin1_General_CI_AI");

        modelBuilder.Entity<Ackfailedfiledetail>(entity =>
        {
            entity.ToTable("ackfailedfiledetails");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BillSerialNo).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreDt).HasColumnType("datetime");
            entity.Property(e => e.CtrlSum).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.EndToEndId)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EntryDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("entryDate");
            entity.Property(e => e.InAckfileName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("inACKFileName");
            entity.Property(e => e.InAckfileReadDatetime)
                .HasColumnType("datetime")
                .HasColumnName("inACKFileReadDatetime");
            entity.Property(e => e.InNckfileName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("inNCKFileName");
            entity.Property(e => e.InNckfileReadDatetime)
                .HasColumnType("datetime")
                .HasColumnName("inNCKFileReadDatetime");
            entity.Property(e => e.InstrId).HasColumnType("numeric(38, 0)");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("lastUpdateDate");
            entity.Property(e => e.MsgId).HasColumnType("numeric(38, 0)");
            entity.Property(e => e.Msgtype)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.PayeeId).HasColumnName("payeeId");
            entity.Property(e => e.PmtInfId)
                .HasMaxLength(35)
                .IsUnicode(false);
            entity.Property(e => e.Reason)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.Ustrd)
                .HasMaxLength(35)
                .IsUnicode(false);
            entity.Property(e => e.UtrNo)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AllocationDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AllocationDetail");

            entity.Property(e => e.AllocationId)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("AllocationID");
            entity.Property(e => e.Amount).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.BagreementNo).HasColumnName("BAgreementNo");
            entity.Property(e => e.BillAllocation)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.BillDetailSrNo).HasColumnName("BillDetailSrNO");
            entity.Property(e => e.BillSerialNo).HasMaxLength(10);
            entity.Property(e => e.BlankField).HasColumnType("decimal(12, 3)");
            entity.Property(e => e.BpbillNo)
                .HasMaxLength(30)
                .HasColumnName("BPBillNo");
            entity.Property(e => e.BridgeId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BridgeID");
            entity.Property(e => e.BridgeName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BridgeType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CancelOnly)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CircleId)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("CircleID");
            entity.Property(e => e.Ddocode)
                .HasMaxLength(30)
                .IsFixedLength()
                .HasColumnName("ddocode");
            entity.Property(e => e.DivisionId)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("DivisionID");
            entity.Property(e => e.DocketNo)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Ecamount)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("ECAmount");
            entity.Property(e => e.EntryDt)
                .HasColumnType("datetime")
                .HasColumnName("EntryDT");
            entity.Property(e => e.EworkName)
                .HasMaxLength(400)
                .HasColumnName("EWorkName");
            entity.Property(e => e.FinYear)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.FlagTable)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.HeadFlag).HasMaxLength(10);
            entity.Property(e => e.InitializationId)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("InitializationID");
            entity.Property(e => e.IpAddress)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IsAti)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("IsATI");
            entity.Property(e => e.Itemcat)
                .HasMaxLength(2)
                .HasColumnName("itemcat");
            entity.Property(e => e.MatPay)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("mat_pay");
            entity.Property(e => e.MrbookNo).HasColumnName("MRBookNo");
            entity.Property(e => e.MrissueDt)
                .HasColumnType("datetime")
                .HasColumnName("MRIssueDT");
            entity.Property(e => e.Mrno).HasColumnName("MRNo");
            entity.Property(e => e.Mrscheme)
                .HasMaxLength(4)
                .IsFixedLength()
                .HasColumnName("MRScheme");
            entity.Property(e => e.Pbflag)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasColumnName("PBFlag");
            entity.Property(e => e.PerRecoveryAmount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("perRecoveryAmount");
            entity.Property(e => e.ReportOrderDt)
                .HasColumnType("datetime")
                .HasColumnName("ReportOrderDT");
            entity.Property(e => e.ReportOrderNo).HasColumnType("decimal(10, 3)");
            entity.Property(e => e.RoadDivisionId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("RoadDivisionID");
            entity.Property(e => e.RoadId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Road_ID");
            entity.Property(e => e.Tpamount)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("TPAmount");
            entity.Property(e => e.Updateflag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("updateflag");
            entity.Property(e => e.VoucherNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.WorkCat)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.WorkCode).HasMaxLength(20);
            entity.Property(e => e.WorkCodeNew)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Worktype)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Workyear)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("workyear");
            entity.Property(e => e.ZoneId)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("ZoneID");
        });

        modelBuilder.Entity<BankMaster>(entity =>
        {
            entity.HasKey(e => e.BankCode);

            entity.ToTable("BankMaster");

            entity.Property(e => e.BankCode).ValueGeneratedNever();
            entity.Property(e => e.BankName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TypeOfBank)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<BcoToHeadMapping>(entity =>
        {
            entity.ToTable("BcoToHeadMapping");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Hoa)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("HOA");
        });

        modelBuilder.Entity<BillEntryStatus>(entity =>
        {
            entity.ToTable("BillEntryStatus");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.EntryDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FinYear)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("FIN_YEAR");
            entity.Property(e => e.MessageCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("message_code");
            entity.Property(e => e.MessageDescription)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("message_description");
        });

        modelBuilder.Entity<BillPaymentAccountStatement>(entity =>
        {
            entity.ToTable("BillPaymentAccountStatement");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ActualFileName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BillSerialNo).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.ClosingAmount).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.CreDt).HasColumnType("datetime");
            entity.Property(e => e.CreditAmount).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.DebitAmount).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.DnrnfileName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DNRNFileName");
            entity.Property(e => e.EntryDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.NtryRef)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OpeningAmount).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Status)
                .HasDefaultValue(0)
                .HasColumnName("status");
        });

        modelBuilder.Entity<BillPaymentFailedFilePayeeDetail>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Ammount)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("ammount");
            entity.Property(e => e.PayeeId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("payeeId");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("status");
        });

        modelBuilder.Entity<BillPaymentFileDetail>(entity =>
        {
            entity.ToTable(tb => tb.HasTrigger("BillPaymentFileDetailsLog"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BillSerialNo).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Changebyadmin)
                .HasComment("for account correction status")
                .HasColumnName("changebyadmin");
            entity.Property(e => e.CreDt).HasColumnType("datetime");
            entity.Property(e => e.CtrlSum)
                .HasComment("totalAmount")
                .HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Duplicatfile)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("duplicatfile");
            entity.Property(e => e.EntryDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("entryDate");
            entity.Property(e => e.FileStatus)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .HasComment("0 file genarate, 1 ack read, 2 Dn read, 3 Rn read, 4 Account Statement  read");
            entity.Property(e => e.FinYear)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("FIN_YEAR");
            entity.Property(e => e.Isdelete)
                .HasComment("1- Duplicate Entry Of File,  2-File Not Found in Treasury, 3-Previous Year Pending After March Closing Cut Off or Previous Year Pending For other Reasons, 4- xmlFileTemp")
                .HasColumnName("isdelete");
            entity.Property(e => e.Ispushed).HasDefaultValue((byte)0);
            entity.Property(e => e.LastUpdateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("lastUpdateDate");
            entity.Property(e => e.MsgId).HasColumnType("numeric(38, 0)");
            entity.Property(e => e.Msgtype)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.NtryRef)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OldBillSerialNo)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("oldBillSerialNo");
            entity.Property(e => e.Repaymentstatus)
                .HasDefaultValue((byte)0)
                .HasComment("0 for accept, 1 is repayment not processed and 2 is for repayment processed")
                .HasColumnName("repaymentstatus");
            entity.Property(e => e.RepaymentwithoutScheduler)
                .HasDefaultValue((byte)0)
                .HasColumnName("repaymentwithoutScheduler");
            entity.Property(e => e.Tacceptdate).HasColumnName("tacceptdate");
            entity.Property(e => e.Tstatus).HasColumnName("tstatus");
        });

        modelBuilder.Entity<BillPaymentFileDetailsLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BillPaymentFileDetails_log");

            entity.Property(e => e.BillSerialNo).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreDt).HasColumnType("datetime");
            entity.Property(e => e.CtrlSum).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.EntryDate)
                .HasColumnType("datetime")
                .HasColumnName("entryDate");
            entity.Property(e => e.FileStatus)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.FinYear)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("FIN_YEAR");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Isdelete).HasColumnName("isdelete");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("lastUpdateDate");
            entity.Property(e => e.LogEntryDateTime).HasColumnType("datetime");
            entity.Property(e => e.Logid).ValueGeneratedOnAdd();
            entity.Property(e => e.MsgId).HasColumnType("numeric(38, 0)");
            entity.Property(e => e.Msgtype)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.NtryRef)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OldBillSerialNo)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("oldBillSerialNo");
            entity.Property(e => e.Repaymentstatus).HasColumnName("repaymentstatus");
            entity.Property(e => e.Tacceptdate).HasColumnName("tacceptdate");
            entity.Property(e => e.Tstatus).HasColumnName("tstatus");
        });

        modelBuilder.Entity<BillPaymentFileDetailsLogOld200924>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BillPaymentFileDetails_log_old200924");

            entity.Property(e => e.BillSerialNo).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CreDt).HasColumnType("datetime");
            entity.Property(e => e.CtrlSum).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.EntryDate)
                .HasColumnType("datetime")
                .HasColumnName("entryDate");
            entity.Property(e => e.FileStatus)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.FinYear)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("FIN_YEAR");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("lastUpdateDate");
            entity.Property(e => e.MsgId).HasColumnType("numeric(38, 0)");
            entity.Property(e => e.Msgtype)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.NtryRef)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OldBillSerialNo)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("oldBillSerialNo");
            entity.Property(e => e.Repaymentstatus).HasColumnName("repaymentstatus");
        });

        modelBuilder.Entity<BillPaymentFileDetailsOld200924>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BillPaymentFileDetails_old200924");

            entity.Property(e => e.BillSerialNo).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Changebyadmin).HasColumnName("changebyadmin");
            entity.Property(e => e.CreDt).HasColumnType("datetime");
            entity.Property(e => e.CtrlSum).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Duplicatfile)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("duplicatfile");
            entity.Property(e => e.EntryDate)
                .HasColumnType("datetime")
                .HasColumnName("entryDate");
            entity.Property(e => e.FileStatus)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.FinYear)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("FIN_YEAR");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("lastUpdateDate");
            entity.Property(e => e.MsgId).HasColumnType("numeric(38, 0)");
            entity.Property(e => e.Msgtype)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.NtryRef)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OldBillSerialNo)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("oldBillSerialNo");
            entity.Property(e => e.Repaymentstatus).HasColumnName("repaymentstatus");
        });

        modelBuilder.Entity<BillPaymentFilePayeeDetail>(entity =>
        {
            entity.ToTable(tb => tb.HasTrigger("BillPaymentFilePayeeDetailsLog"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreDt).HasColumnType("datetime");
            entity.Property(e => e.CtrlSum).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.DnFileName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("dnFileName");
            entity.Property(e => e.DnFileReadDatetime)
                .HasColumnType("datetime")
                .HasColumnName("dnFileReadDatetime");
            entity.Property(e => e.EndToEndId)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EntryDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("entryDate");
            entity.Property(e => e.InAckfileName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("inACKFileName");
            entity.Property(e => e.InAckfileReadDatetime)
                .HasColumnType("datetime")
                .HasColumnName("inACKFileReadDatetime");
            entity.Property(e => e.InNckfileName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("inNCKFileName");
            entity.Property(e => e.InNckfileReadDatetime)
                .HasColumnType("datetime")
                .HasColumnName("inNCKFileReadDatetime");
            entity.Property(e => e.InstrId).HasColumnType("numeric(38, 0)");
            entity.Property(e => e.Isdelete).HasColumnName("isdelete");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("lastUpdateDate");
            entity.Property(e => e.MsgId).HasColumnType("numeric(38, 0)");
            entity.Property(e => e.Msgtype)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.OldEndToEndId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("oldEndToEndId");
            entity.Property(e => e.PayeeId)
                .HasComment("Used for Parent Table  VendorID")
                .HasColumnName("payeeId");
            entity.Property(e => e.PmtInfId)
                .HasMaxLength(35)
                .IsUnicode(false);
            entity.Property(e => e.RnFileName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("rnFileName");
            entity.Property(e => e.RnFileReadDatetime)
                .HasColumnType("datetime")
                .HasColumnName("rnFileReadDatetime");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.Ustrd)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasComment("Remark");
            entity.Property(e => e.UtrNo)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<BillPaymentFilePayeeDetailLog>(entity =>
        {
            entity.HasKey(e => e.Logid).HasName("PK__BillPaym__5E55825010898442");

            entity.ToTable("BillPaymentFilePayeeDetail_log");

            entity.Property(e => e.CreDt).HasColumnType("datetime");
            entity.Property(e => e.CtrlSum).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.DnFileName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("dnFileName");
            entity.Property(e => e.DnFileReadDatetime)
                .HasColumnType("datetime")
                .HasColumnName("dnFileReadDatetime");
            entity.Property(e => e.EndToEndId)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EntryDate)
                .HasColumnType("datetime")
                .HasColumnName("entryDate");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.InAckfileName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("inACKFileName");
            entity.Property(e => e.InAckfileReadDatetime)
                .HasColumnType("datetime")
                .HasColumnName("inACKFileReadDatetime");
            entity.Property(e => e.InNckfileName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("inNCKFileName");
            entity.Property(e => e.InNckfileReadDatetime)
                .HasColumnType("datetime")
                .HasColumnName("inNCKFileReadDatetime");
            entity.Property(e => e.InstrId).HasColumnType("numeric(38, 0)");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("lastUpdateDate");
            entity.Property(e => e.LogEntryDateTime).HasColumnType("datetime");
            entity.Property(e => e.MsgId).HasColumnType("numeric(38, 0)");
            entity.Property(e => e.Msgtype)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.OldEndToEndId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("oldEndToEndId");
            entity.Property(e => e.PayeeId).HasColumnName("payeeId");
            entity.Property(e => e.PmtInfId)
                .HasMaxLength(35)
                .IsUnicode(false);
            entity.Property(e => e.RnFileName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("rnFileName");
            entity.Property(e => e.RnFileReadDatetime)
                .HasColumnType("datetime")
                .HasColumnName("rnFileReadDatetime");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.Ustrd)
                .HasMaxLength(35)
                .IsUnicode(false);
            entity.Property(e => e.UtrNo)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<BillPaymentFilePayeeDetailsLog>(entity =>
        {
            entity.HasKey(e => e.LogId).IsClustered(false);

            entity.ToTable("BillPaymentFilePayeeDetails_log");

            entity.Property(e => e.CreDt).HasColumnType("datetime");
            entity.Property(e => e.CtrlSum).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.DnFileName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("dnFileName");
            entity.Property(e => e.DnFileReadDatetime)
                .HasColumnType("datetime")
                .HasColumnName("dnFileReadDatetime");
            entity.Property(e => e.EndToEndId)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EntryDate)
                .HasColumnType("datetime")
                .HasColumnName("entryDate");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.InAckfileName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("inACKFileName");
            entity.Property(e => e.InAckfileReadDatetime)
                .HasColumnType("datetime")
                .HasColumnName("inACKFileReadDatetime");
            entity.Property(e => e.InNckfileName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("inNCKFileName");
            entity.Property(e => e.InNckfileReadDatetime)
                .HasColumnType("datetime")
                .HasColumnName("inNCKFileReadDatetime");
            entity.Property(e => e.InstrId).HasColumnType("numeric(38, 0)");
            entity.Property(e => e.Isdelete).HasColumnName("isdelete");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("lastUpdateDate");
            entity.Property(e => e.LogEntryDateTime).HasColumnType("datetime");
            entity.Property(e => e.MsgId).HasColumnType("numeric(38, 0)");
            entity.Property(e => e.Msgtype)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.OldEndToEndId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("oldEndToEndId");
            entity.Property(e => e.PayeeId).HasColumnName("payeeId");
            entity.Property(e => e.PmtInfId)
                .HasMaxLength(35)
                .IsUnicode(false);
            entity.Property(e => e.RnFileName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("rnFileName");
            entity.Property(e => e.RnFileReadDatetime)
                .HasColumnType("datetime")
                .HasColumnName("rnFileReadDatetime");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.Ustrd)
                .HasMaxLength(35)
                .IsUnicode(false);
            entity.Property(e => e.UtrNo)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<BillPaymentFilePayeeDetailsOld200924>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BillPaymentFilePayeeDetails_old200924");

            entity.Property(e => e.CreDt).HasColumnType("datetime");
            entity.Property(e => e.CtrlSum).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.DnFileName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("dnFileName");
            entity.Property(e => e.DnFileReadDatetime)
                .HasColumnType("datetime")
                .HasColumnName("dnFileReadDatetime");
            entity.Property(e => e.EndToEndId)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EntryDate)
                .HasColumnType("datetime")
                .HasColumnName("entryDate");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.InAckfileName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("inACKFileName");
            entity.Property(e => e.InAckfileReadDatetime)
                .HasColumnType("datetime")
                .HasColumnName("inACKFileReadDatetime");
            entity.Property(e => e.InNckfileName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("inNCKFileName");
            entity.Property(e => e.InNckfileReadDatetime)
                .HasColumnType("datetime")
                .HasColumnName("inNCKFileReadDatetime");
            entity.Property(e => e.InstrId).HasColumnType("numeric(38, 0)");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("lastUpdateDate");
            entity.Property(e => e.MsgId).HasColumnType("numeric(38, 0)");
            entity.Property(e => e.Msgtype)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.OldEndToEndId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("oldEndToEndId");
            entity.Property(e => e.PayeeId).HasColumnName("payeeId");
            entity.Property(e => e.PmtInfId)
                .HasMaxLength(35)
                .IsUnicode(false);
            entity.Property(e => e.RnFileName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("rnFileName");
            entity.Property(e => e.RnFileReadDatetime)
                .HasColumnType("datetime")
                .HasColumnName("rnFileReadDatetime");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.Ustrd)
                .HasMaxLength(35)
                .IsUnicode(false);
            entity.Property(e => e.UtrNo)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<BillTaxDetail>(entity =>
        {
            entity.ToTable(tb => tb.HasTrigger("BillTaxDetailsLog"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Amount).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.BillSerialNo).HasColumnType("numeric(10, 0)");
            entity.Property(e => e.EntryDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsTaxPaid)
                .HasDefaultValue(false)
                .HasColumnName("isTaxPaid");
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.TaxId).HasColumnName("taxId");
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<BillTaxDetailsLog>(entity =>
        {
            entity.HasKey(e => e.Logid).HasName("PK__BillTaxD__7838F265294B3394");

            entity.ToTable("BillTaxDetails_Log");

            entity.Property(e => e.Logid).HasColumnName("logid");
            entity.Property(e => e.Amount).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.BillSerialNo).HasColumnType("numeric(10, 0)");
            entity.Property(e => e.EntryDate).HasColumnType("datetime");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsTaxPaid).HasColumnName("isTaxPaid");
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.LogEntryDateTime).HasColumnType("datetime");
            entity.Property(e => e.TaxId).HasColumnName("taxId");
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ChangeTrackingHistory>(entity =>
        {
            entity.ToTable("ChangeTrackingHistory");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("userId");
        });

        modelBuilder.Entity<CircleMaster>(entity =>
        {
            entity.ToTable("CircleMaster");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CircleName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("circleName");
            entity.Property(e => e.Ddocode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ddocode");
            entity.Property(e => e.Emailid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("emailid");
            entity.Property(e => e.IsFirstLogin).HasColumnName("isFirstLogin");
            entity.Property(e => e.Mobileno).HasColumnName("mobileno");
            entity.Property(e => e.PersonName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Pwd)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("pwd");
            entity.Property(e => e.Userid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("userid");
            entity.Property(e => e.WingType).HasColumnName("wingType");
        });

        modelBuilder.Entity<Ddo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DDO");

            entity.HasIndex(e => e.Ddocode, "DDO_UK").IsUnique();

            entity.Property(e => e.Accountno)
                .HasMaxLength(17)
                .IsUnicode(false)
                .HasColumnName("ACCOUNTNO");
            entity.Property(e => e.Allow)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ALLOW");
            entity.Property(e => e.Authno)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasColumnName("AUTHNO");
            entity.Property(e => e.Closingdate)
                .HasColumnType("datetime")
                .HasColumnName("CLOSINGDATE");
            entity.Property(e => e.Contactno)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("CONTACTNO");
            entity.Property(e => e.Ddocode)
                .HasMaxLength(7)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DDOCODE");
            entity.Property(e => e.Ddoregno)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DDOREGNO");
            entity.Property(e => e.Deptcode)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DEPTCODE");
            entity.Property(e => e.Designation)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DESIGNATION");
            entity.Property(e => e.DesignationLl)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("DESIGNATION_LL");
            entity.Property(e => e.Dtoregno)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DTOREGNO");
            entity.Property(e => e.EduFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EDU_FLAG");
            entity.Property(e => e.Emailid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMAILID");
            entity.Property(e => e.Ifsccode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IFSCCODE");
            entity.Property(e => e.InchargeDdo)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("INCHARGE_DDO");
            entity.Property(e => e.Ipaddress)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("IPADDRESS");
            entity.Property(e => e.Lastupdate)
                .HasPrecision(6)
                .HasColumnName("LASTUPDATE");
            entity.Property(e => e.Name1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("NAME1");
            entity.Property(e => e.Name2)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("NAME2");
            entity.Property(e => e.OldDdocode)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("OLD_DDOCODE");
            entity.Property(e => e.Openingdate)
                .HasColumnType("datetime")
                .HasColumnName("OPENINGDATE");
            entity.Property(e => e.Payrollddo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("PAYROLLDDO");
            entity.Property(e => e.Pswd)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("PSWD");
            entity.Property(e => e.Referenceclose)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("REFERENCECLOSE");
            entity.Property(e => e.Referenceopen)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("REFERENCEOPEN");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("STATUS");
            entity.Property(e => e.Subtreasurycode)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SUBTREASURYCODE");
            entity.Property(e => e.Tanno)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TANNO");
            entity.Property(e => e.Treasurycode)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TREASURYCODE");
            entity.Property(e => e.Type)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TYPE");
            entity.Property(e => e.Userid)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("USERID");
            entity.Property(e => e.Verifiedbybank)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("N")
                .IsFixedLength()
                .HasColumnName("VERIFIEDBYBANK");
            entity.Property(e => e.Verifiedbyddo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("VERIFIEDBYDDO");
            entity.Property(e => e.Verifieddate)
                .HasColumnType("datetime")
                .HasColumnName("VERIFIEDDATE");
        });

        modelBuilder.Entity<DdoDetail>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CircleId).HasColumnName("circleId");
            entity.Property(e => e.DivisionId).HasColumnName("divisionId");
            entity.Property(e => e.RangeId).HasColumnName("rangeId");
            entity.Property(e => e.SubDivisionId).HasColumnName("subDivisionId");
            entity.Property(e => e.UserTypeId).HasColumnName("userTypeId");
            entity.Property(e => e.Userid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("userid");
        });

        modelBuilder.Entity<DemandnoMaster>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("demandno_master");

            entity.Property(e => e.Demandno)
                .HasMaxLength(255)
                .HasColumnName("DEMANDNO");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.Description1)
                .HasMaxLength(255)
                .HasColumnName("DESCRIPTION1");
        });

        modelBuilder.Entity<DetailheadMaster>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("detailhead_master");

            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.Detailhead)
                .HasMaxLength(255)
                .HasColumnName("DETAILHEAD");
            entity.Property(e => e.Detailheadname)
                .HasMaxLength(255)
                .HasColumnName("DETAILHEADNAME");
            entity.Property(e => e.FinYear)
                .HasMaxLength(255)
                .HasColumnName("FIN_YEAR");
            entity.Property(e => e.Formno)
                .HasMaxLength(255)
                .HasColumnName("FORMNO");
            entity.Property(e => e.Objecthead)
                .HasMaxLength(255)
                .HasColumnName("OBJECTHEAD");
        });

        modelBuilder.Entity<DistrictMaster>(entity =>
        {
            entity.HasKey(e => e.DistrictId);

            entity.ToTable("DistrictMaster");

            entity.Property(e => e.DistrictId).ValueGeneratedNever();
            entity.Property(e => e.DistrictName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DivisonMaster>(entity =>
        {
            entity.ToTable("DivisonMaster");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CircleId).HasColumnName("circleId");
            entity.Property(e => e.Ddocode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ddocode");
            entity.Property(e => e.DivisonName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("divisonName");
            entity.Property(e => e.Emailid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("emailid");
            entity.Property(e => e.IsFirstLogin).HasColumnName("isFirstLogin");
            entity.Property(e => e.Mobileno).HasColumnName("mobileno");
            entity.Property(e => e.PersonName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Pwd)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("pwd");
            entity.Property(e => e.WingType).HasColumnName("wingType");
        });

        modelBuilder.Entity<DscTokenDetail>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CertificatePem)
                .IsUnicode(false)
                .HasColumnName("certificatePEM");
            entity.Property(e => e.DeactivateDate)
                .HasColumnType("datetime")
                .HasColumnName("deactivateDate");
            entity.Property(e => e.HasPrivateKey).HasColumnName("hasPrivateKey");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.IsVerified).HasColumnName("isVerified");
            entity.Property(e => e.IssuedBy)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("issuedBy");
            entity.Property(e => e.PublicKey)
                .IsUnicode(false)
                .HasColumnName("publicKey");
            entity.Property(e => e.PublicKeyString)
                .IsUnicode(false)
                .HasColumnName("publicKeyString");
            entity.Property(e => e.RegDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("regDate");
            entity.Property(e => e.Role)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.SerialNumber)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("serialNumber");
            entity.Property(e => e.Subject).IsUnicode(false);
            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ValidForDigitalSign).HasColumnName("validForDigitalSign");
            entity.Property(e => e.ValidFrom)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("validFrom");
            entity.Property(e => e.ValidTo)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("validTo");
        });

        modelBuilder.Entity<DuplicateFile>(entity =>
        {
            entity.ToTable("duplicateFile");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BillserialNo).HasColumnName("billserialNo");
        });

        modelBuilder.Entity<EKuberAckDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("e_Kuber_ACK_Detail");

            entity.Property(e => e.DocumentCstmrPmtStsRptOrgnlPmtInfAndStsOrgnlPmtInfId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Document_CstmrPmtStsRpt_OrgnlPmtInfAndSts_OrgnlPmtInfId");
            entity.Property(e => e.DocumentCstmrPmtStsRptOrgnlPmtInfAndStsPmtInfSts)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Document_CstmrPmtStsRpt_OrgnlPmtInfAndSts_PmtInfSts");
            entity.Property(e => e.DocumentCstmrPmtStsRptOrgnlPmtInfAndStsTxInfAndStsAccptncDtTm)
                .HasColumnType("datetime")
                .HasColumnName("Document_CstmrPmtStsRpt_OrgnlPmtInfAndSts_TxInfAndSts_AccptncDtTm");
            entity.Property(e => e.DocumentCstmrPmtStsRptOrgnlPmtInfAndStsTxInfAndStsOrgnlEndToEndId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Document_CstmrPmtStsRpt_OrgnlPmtInfAndSts_TxInfAndSts_OrgnlEndToEndId");
            entity.Property(e => e.DocumentCstmrPmtStsRptOrgnlPmtInfAndStsTxInfAndStsOrgnlInstrId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Document_CstmrPmtStsRpt_OrgnlPmtInfAndSts_TxInfAndSts_OrgnlInstrId");
            entity.Property(e => e.DocumentCstmrPmtStsRptOrgnlPmtInfAndStsTxInfAndStsStsRsnInfRsnPrtry)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Document_CstmrPmtStsRpt_OrgnlPmtInfAndSts_TxInfAndSts_StsRsnInf_Rsn_Prtry");
            entity.Property(e => e.DocumentCstmrPmtStsRptOrgnlPmtInfAndStsTxInfAndStsTxSts)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Document_CstmrPmtStsRpt_OrgnlPmtInfAndSts_TxInfAndSts_TxSts");
            entity.Property(e => e.DocumentFileNo)
                .HasMaxLength(45)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Document_File_No");
            entity.Property(e => e.DocumentRowId)
                .ValueGeneratedOnAdd()
                .HasColumnName("Document_RowId");
            entity.Property(e => e.EntryDate)
                .HasColumnType("datetime")
                .HasColumnName("Entry_Date");
        });

        modelBuilder.Entity<EKuberAckHeader>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("e_Kuber_ACK_Header");

            entity.Property(e => e.AppHdrBizMsgIdr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("AppHdr_BizMsgIdr");
            entity.Property(e => e.AppHdrBizSvc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("AppHdr_BizSvc");
            entity.Property(e => e.AppHdrCreDt)
                .HasColumnType("datetime")
                .HasColumnName("AppHdr_CreDt");
            entity.Property(e => e.AppHdrFileNo)
                .HasMaxLength(45)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("AppHdr_File_No");
            entity.Property(e => e.AppHdrFrFiidFinInstnIdClrSysMmbIdMmbId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("AppHdr_Fr_FIId_FinInstnId_ClrSysMmbId_MmbId");
            entity.Property(e => e.AppHdrMsgDefIdr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("AppHdr_MsgDefIdr");
            entity.Property(e => e.AppHdrRowId)
                .ValueGeneratedOnAdd()
                .HasColumnName("AppHdr_RowId");
            entity.Property(e => e.AppHdrToOrgIdIdOrgIdOthrId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("AppHdr_To_OrgId_Id_OrgId_Othr_Id");
            entity.Property(e => e.DocumentCstmrPmtStsRptGrpHdrCreDtTm)
                .HasColumnType("datetime")
                .HasColumnName("Document_CstmrPmtStsRpt_GrpHdr_CreDtTm");
            entity.Property(e => e.DocumentCstmrPmtStsRptGrpHdrMsgId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Document_CstmrPmtStsRpt_GrpHdr_MsgId");
            entity.Property(e => e.DocumentCstmrPmtStsRptOrgnlGrpInfAndStsGrpSts)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Document_CstmrPmtStsRpt_OrgnlGrpInfAndSts_GrpSts");
            entity.Property(e => e.DocumentCstmrPmtStsRptOrgnlGrpInfAndStsOrgnlCreDtTm)
                .HasColumnType("datetime")
                .HasColumnName("Document_CstmrPmtStsRpt_OrgnlGrpInfAndSts_OrgnlCreDtTm");
            entity.Property(e => e.DocumentCstmrPmtStsRptOrgnlGrpInfAndStsOrgnlCtrlSum)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Document_CstmrPmtStsRpt_OrgnlGrpInfAndSts_OrgnlCtrlSum");
            entity.Property(e => e.DocumentCstmrPmtStsRptOrgnlGrpInfAndStsOrgnlMsgId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Document_CstmrPmtStsRpt_OrgnlGrpInfAndSts_OrgnlMsgId");
            entity.Property(e => e.DocumentCstmrPmtStsRptOrgnlGrpInfAndStsOrgnlMsgNmId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Document_CstmrPmtStsRpt_OrgnlGrpInfAndSts_OrgnlMsgNmId");
            entity.Property(e => e.DocumentCstmrPmtStsRptOrgnlGrpInfAndStsOrgnlNbOfTxs).HasColumnName("Document_CstmrPmtStsRpt_OrgnlGrpInfAndSts_OrgnlNbOfTxs");
            entity.Property(e => e.DocumentCstmrPmtStsRptOrgnlPmtInfAndStsStsRsnInfRsnPrtry)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Document_CstmrPmtStsRpt_OrgnlPmtInfAndSts_StsRsnInf_Rsn_Prtry");
            entity.Property(e => e.EntryDate)
                .HasColumnType("datetime")
                .HasColumnName("Entry_Date");
        });

        modelBuilder.Entity<EKuberAcstDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("e_Kuber_ACST_Detail");

            entity.Property(e => e.DocAmtCcy)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Doc_AmtCcy");
            entity.Property(e => e.DocBookgDtDt).HasColumnName("Doc_BookgDt_Dt");
            entity.Property(e => e.DocCdtDbtInd)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Doc_CdtDbtInd");
            entity.Property(e => e.DocNtryRef)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Doc_NtryRef");
            entity.Property(e => e.DocPrtryCd)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Doc_Prtry_Cd");
            entity.Property(e => e.DocRvslInd)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Doc_RvslInd");
            entity.Property(e => e.DocSts)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Doc_Sts");
            entity.Property(e => e.DocValDtDt).HasColumnName("Doc_ValDt_Dt");
            entity.Property(e => e.EntryDate)
                .HasColumnType("datetime")
                .HasColumnName("Entry_Date");
            entity.Property(e => e.HdrBizMsgIdr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("HDR_BizMsgIdr");
            entity.Property(e => e.HdrFileNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("HDR_File_No");
            entity.Property(e => e.HdrRowId)
                .ValueGeneratedOnAdd()
                .HasColumnName("HDR_RowId");
        });

        modelBuilder.Entity<EKuberAcstHeader>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("e_Kuber_ACST_Header");

            entity.Property(e => e.DocBalAmtCcyInrClbd)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Doc_Bal_AmtCcyInr_CLBD");
            entity.Property(e => e.DocBalAmtCcyInrOpbd)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Doc_Bal_AmtCcyInr_OPBD");
            entity.Property(e => e.DocBalCdtDbtIndClbd)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Doc_Bal_CdtDbtInd_CLBD");
            entity.Property(e => e.DocBalCdtDbtIndOpbd)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Doc_Bal_CdtDbtInd_OPBD");
            entity.Property(e => e.DocBalDtDtTmClbd)
                .HasColumnType("datetime")
                .HasColumnName("Doc_Bal_Dt_DtTm_CLBD");
            entity.Property(e => e.DocBalDtDtTmOpbd)
                .HasColumnType("datetime")
                .HasColumnName("Doc_Bal_Dt_DtTm_OPBD");
            entity.Property(e => e.DocBalTpCdOrPrtryCdClbd)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Doc_Bal_Tp_CdOrPrtry_Cd_CLBD");
            entity.Property(e => e.DocBalTpCdOrPrtryCdOpbd)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Doc_Bal_Tp_CdOrPrtry_Cd_OPBD");
            entity.Property(e => e.DocCreDtTm)
                .HasColumnType("datetime")
                .HasColumnName("Doc_CreDtTm");
            entity.Property(e => e.DocFrDtTm)
                .HasColumnType("datetime")
                .HasColumnName("Doc_FrDtTm");
            entity.Property(e => e.DocLastPgInd)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Doc_LastPgInd");
            entity.Property(e => e.DocMsgId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Doc_MsgId");
            entity.Property(e => e.DocOthrId)
                .HasMaxLength(25)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Doc_Othr_Id");
            entity.Property(e => e.DocPgNb)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Doc_PgNb");
            entity.Property(e => e.DocStmtCreDtTm)
                .HasColumnType("datetime")
                .HasColumnName("Doc_Stmt_CreDtTm");
            entity.Property(e => e.DocStmtId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Doc_Stmt_Id");
            entity.Property(e => e.DocToDtTm)
                .HasColumnType("datetime")
                .HasColumnName("Doc_ToDtTm");
            entity.Property(e => e.DocTtlCdtNtriesNbOfNtries).HasColumnName("Doc_TtlCdtNtries_NbOfNtries");
            entity.Property(e => e.DocTtlCdtNtriesSum)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Doc_TtlCdtNtries_Sum");
            entity.Property(e => e.DocTtlDbtNtriesNbOfNtries).HasColumnName("Doc_TtlDbtNtries_NbOfNtries");
            entity.Property(e => e.DocTtlDbtNtriesSum)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Doc_TtlDbtNtries_Sum");
            entity.Property(e => e.EntryDate)
                .HasColumnType("datetime")
                .HasColumnName("Entry_Date");
            entity.Property(e => e.HdrBizMsgIdr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("HDR_BizMsgIdr");
            entity.Property(e => e.HdrBizSvc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("HDR_BizSvc");
            entity.Property(e => e.HdrCreDt)
                .HasColumnType("datetime")
                .HasColumnName("HDR_CreDt");
            entity.Property(e => e.HdrFileNo)
                .HasMaxLength(45)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("HDR_File_No");
            entity.Property(e => e.HdrMmbId)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("HDR_MmbId");
            entity.Property(e => e.HdrMsgDefIdr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("HDR_MsgDefIdr");
            entity.Property(e => e.HdrOthrId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("HDR_Othr_Id");
            entity.Property(e => e.HdrRowId)
                .ValueGeneratedOnAdd()
                .HasColumnName("HDR_RowId");
        });

        modelBuilder.Entity<EKuberActivityLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("e_Kuber_Activity_Log");

            entity.Property(e => e.EntryDate)
                .HasColumnType("datetime")
                .HasColumnName("Entry_Date");
            entity.Property(e => e.FileContent)
                .IsUnicode(false)
                .HasColumnName("File_Content");
            entity.Property(e => e.FileNo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("File_No");
            entity.Property(e => e.FileType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("File_Type");
            entity.Property(e => e.Folder)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Message).IsUnicode(false);
            entity.Property(e => e.MovedTo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Moved_To");
            entity.Property(e => e.PickedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Picked_By");
            entity.Property(e => e.PlacedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Placed_By");
            entity.Property(e => e.ServiceType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Service_Type");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EKuberDnRnDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("e_Kuber_DN_RN_Detail");

            entity.Property(e => e.DocNtryPrtryCd)
                .HasMaxLength(200)
                .HasColumnName("Doc_Ntry_Prtry_Cd");
            entity.Property(e => e.DocRefsAcctSvcrRef)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Doc_Refs_AcctSvcrRef");
            entity.Property(e => e.DocRefsEndToEndId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Doc_Refs_EndToEndId");
            entity.Property(e => e.DocRefsInstrId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Doc_Refs_InstrId");
            entity.Property(e => e.DocRefsMsgId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Doc_Refs_MsgId");
            entity.Property(e => e.DocRefsPmtInfId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Doc_Refs_PmtInfId");
            entity.Property(e => e.DocRefsTxId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Doc_Refs_TxId");
            entity.Property(e => e.DocTxDtlsAddtlTxInf).HasColumnName("Doc_TxDtls_AddtlTxInf");
            entity.Property(e => e.DocTxDtlsAmt)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Doc_TxDtls_Amt");
            entity.Property(e => e.DocTxDtlsCdtDbtInd)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Doc_TxDtls_CdtDbtInd");
            entity.Property(e => e.DocTxDtlsRltdDtsAccptncDtTm)
                .HasColumnType("datetime")
                .HasColumnName("Doc_TxDtls_RltdDts_AccptncDtTm");
            entity.Property(e => e.DocTxDtlsRmtInfUstrd1)
                .HasMaxLength(200)
                .HasColumnName("Doc_TxDtls_RmtInf_Ustrd1");
            entity.Property(e => e.DocTxDtlsRmtInfUstrd2)
                .HasMaxLength(200)
                .HasColumnName("Doc_TxDtls_RmtInf_Ustrd2");
            entity.Property(e => e.DocTxDtlsRmtInfUstrd3)
                .HasMaxLength(200)
                .HasColumnName("Doc_TxDtls_RmtInf_Ustrd3");
            entity.Property(e => e.DocTxDtlsRmtInfUstrd4)
                .HasMaxLength(200)
                .HasColumnName("Doc_TxDtls_RmtInf_Ustrd4");
            entity.Property(e => e.EntryDate)
                .HasColumnType("datetime")
                .HasColumnName("Entry_Date");
            entity.Property(e => e.HdrBizMsgIdr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("HDR_BizMsgIdr");
            entity.Property(e => e.HdrFileNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("HDR_File_No");
            entity.Property(e => e.HdrRowId)
                .ValueGeneratedOnAdd()
                .HasColumnName("HDR_RowId");
        });

        modelBuilder.Entity<EKuberDnRnHeader>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("e_Kuber_DN_RN_Header");

            entity.Property(e => e.DocCreDtTm)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Doc_CreDtTm");
            entity.Property(e => e.DocLastPgInd)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Doc_LastPgInd");
            entity.Property(e => e.DocMsgId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Doc_MsgId");
            entity.Property(e => e.DocNbOfNtries).HasColumnName("Doc_NbOfNtries");
            entity.Property(e => e.DocNtfctnId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Doc_Ntfctn_Id");
            entity.Property(e => e.DocNtryAmt)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Doc_Ntry_Amt");
            entity.Property(e => e.DocNtryBookgDtDt).HasColumnName("Doc_Ntry_BookgDt_Dt");
            entity.Property(e => e.DocNtryCdtDbtInd)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Doc_Ntry_CdtDbtInd");
            entity.Property(e => e.DocNtryNbOfTxs).HasColumnName("Doc_Ntry_NbOfTxs");
            entity.Property(e => e.DocNtryNtryRef)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Doc_Ntry_NtryRef");
            entity.Property(e => e.DocNtryRvslInd)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Doc_Ntry_RvslInd");
            entity.Property(e => e.DocNtrySts)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Doc_Ntry_Sts");
            entity.Property(e => e.DocNtryValDtDt).HasColumnName("Doc_Ntry_ValDt_Dt");
            entity.Property(e => e.DocOthrId)
                .HasMaxLength(25)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Doc_Othr_Id");
            entity.Property(e => e.DocPgNb).HasColumnName("Doc_PgNb");
            entity.Property(e => e.DocSum)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Doc_Sum");
            entity.Property(e => e.EntryDate)
                .HasColumnType("datetime")
                .HasColumnName("Entry_Date");
            entity.Property(e => e.HdrBizMsgIdr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("HDR_BizMsgIdr");
            entity.Property(e => e.HdrBizSvc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("HDR_BizSvc");
            entity.Property(e => e.HdrCreDt)
                .HasColumnType("datetime")
                .HasColumnName("HDR_CreDt");
            entity.Property(e => e.HdrFileNo)
                .HasMaxLength(45)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("HDR_File_No");
            entity.Property(e => e.HdrMmbId)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("HDR_MmbId");
            entity.Property(e => e.HdrMsgDefIdr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("HDR_MsgDefIdr");
            entity.Property(e => e.HdrOthrId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("HDR_Othr_Id");
            entity.Property(e => e.HdrRowId)
                .ValueGeneratedOnAdd()
                .HasColumnName("HDR_RowId");
        });

        modelBuilder.Entity<EKuberEkoshAck>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("e_Kuber_EKOSH_ACK");

            entity.Property(e => e.DocEvtCd)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("Doc_EvtCd");
            entity.Property(e => e.DocEvtTm)
                .HasColumnType("datetime")
                .HasColumnName("Doc_EvtTm");
            entity.Property(e => e.EntryDate)
                .HasColumnType("datetime")
                .HasColumnName("Entry_Date");
            entity.Property(e => e.HdrBizMsgIdr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("HDR_BizMsgIdr");
            entity.Property(e => e.HdrBizSvc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("HDR_BizSvc");
            entity.Property(e => e.HdrCreDt)
                .HasColumnType("datetime")
                .HasColumnName("HDR_CreDt");
            entity.Property(e => e.HdrFileNo)
                .HasMaxLength(45)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("HDR_File_No");
            entity.Property(e => e.HdrMmbId)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("HDR_MmbId");
            entity.Property(e => e.HdrMsgDefIdr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("HDR_MsgDefIdr");
            entity.Property(e => e.HdrOthrId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("HDR_Othr_Id");
            entity.Property(e => e.HdrRowId)
                .ValueGeneratedOnAdd()
                .HasColumnName("HDR_RowId");
        });

        modelBuilder.Entity<EKuberEpayDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("e_Kuber_EPAY_Detail");

            entity.Property(e => e.AppHdrFileNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("AppHdr_File_No");
            entity.Property(e => e.AppHdrId)
                .HasMaxLength(11)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("AppHdr_Id");
            entity.Property(e => e.AppHdrRowId)
                .ValueGeneratedOnAdd()
                .HasColumnName("AppHdr_RowId");
            entity.Property(e => e.PmtInfBtchBookg)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PmtInf_BtchBookg");
            entity.Property(e => e.PmtInfCdtTrfTxInfAmtInstdAmtAmt)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("PmtInf_CdtTrfTxInf_Amt_InstdAmt_Amt");
            entity.Property(e => e.PmtInfCdtTrfTxInfAmtInstdAmtCcyOfTrf)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PmtInf_CdtTrfTxInf_Amt_InstdAmt_CcyOfTrf");
            entity.Property(e => e.PmtInfCdtTrfTxInfCdtrAcctIdOthrId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PmtInf_CdtTrfTxInf_CdtrAcct_Id_Othr_Id");
            entity.Property(e => e.PmtInfCdtTrfTxInfCdtrAcctTpCd)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PmtInf_CdtTrfTxInf_CdtrAcct_Tp_Cd");
            entity.Property(e => e.PmtInfCdtTrfTxInfCdtrAgtFinInstnIdClrSysMmbIdMmbId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PmtInf_CdtTrfTxInf_CdtrAgt_FinInstnId_ClrSysMmbId_MmbId");
            entity.Property(e => e.PmtInfCdtTrfTxInfCdtrNm)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("PmtInf_CdtTrfTxInf_Cdtr_Nm");
            entity.Property(e => e.PmtInfCdtTrfTxInfPmtIdEndToEndId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PmtInf_CdtTrfTxInf_PmtId_EndToEndId");
            entity.Property(e => e.PmtInfCdtTrfTxInfPmtIdInstrId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PmtInf_CdtTrfTxInf_PmtId_InstrId");
            entity.Property(e => e.PmtInfCdtTrfTxInfRmtInfUstrdContractorId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PmtInf_CdtTrfTxInf_RmtInf_Ustrd_ContractorId");
            entity.Property(e => e.PmtInfCdtTrfTxInfRmtInfUstrdInitId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PmtInf_CdtTrfTxInf_RmtInf_Ustrd_InitId");
            entity.Property(e => e.PmtInfCdtTrfTxInfRmtInfUstrdSerialNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PmtInf_CdtTrfTxInf_RmtInf_Ustrd_SerialNo");
            entity.Property(e => e.PmtInfCtrlSum)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("PmtInf_CtrlSum");
            entity.Property(e => e.PmtInfDbtrAcctIdOthrId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PmtInf_DbtrAcct_Id_Othr_Id");
            entity.Property(e => e.PmtInfDbtrAgtFinInstnIdClrSysMmbIdMmbId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PmtInf_DbtrAgt_FinInstnId_ClrSysMmbId_MmbId");
            entity.Property(e => e.PmtInfDbtrIdOrgIdOthrId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PmtInf_Dbtr_Id_OrgId_Othr_Id");
            entity.Property(e => e.PmtInfDbtrNm)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PmtInf_Dbtr_Nm");
            entity.Property(e => e.PmtInfDbtrPstlAdrDept)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PmtInf_Dbtr_PstlAdr_Dept");
            entity.Property(e => e.PmtInfDbtrPstlAdrSubDept)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PmtInf_Dbtr_PstlAdr_SubDept");
            entity.Property(e => e.PmtInfEntryDate)
                .HasColumnType("datetime")
                .HasColumnName("PmtInf_Entry_Date");
            entity.Property(e => e.PmtInfNbOfTxs).HasColumnName("PmtInf_NbOfTxs");
            entity.Property(e => e.PmtInfPmtInfId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PmtInf_PmtInfId");
            entity.Property(e => e.PmtInfPmtMtd)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PmtInf_PmtMtd");
            entity.Property(e => e.PmtInfPmtTpInfInstrPrty)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PmtInf_PmtTpInf_InstrPrty");
            entity.Property(e => e.PmtInfPmtTpInfSvcLvlPrtry)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PmtInf_PmtTpInf_SvcLvl_Prtry");
            entity.Property(e => e.PmtInfReqdExctnDt)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PmtInf_ReqdExctnDt");
        });

        modelBuilder.Entity<EKuberEpayHeader>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("e_Kuber_EPAY_Header");

            entity.Property(e => e.AppHdrBizMsgIdr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("AppHdr_BizMsgIdr");
            entity.Property(e => e.AppHdrBizSvc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("AppHdr_BizSvc");
            entity.Property(e => e.AppHdrCreDt)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("AppHdr_CreDt");
            entity.Property(e => e.AppHdrEntryDate)
                .HasColumnType("datetime")
                .HasColumnName("AppHdr_Entry_Date");
            entity.Property(e => e.AppHdrFileNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("AppHdr_File_No");
            entity.Property(e => e.AppHdrFrOrgIdIdOrgIdOthrId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("AppHdr_Fr_OrgId_Id_OrgId_Othr_Id");
            entity.Property(e => e.AppHdrId)
                .HasMaxLength(11)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("AppHdr_Id");
            entity.Property(e => e.AppHdrMsgDefIdr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("AppHdr_MsgDefIdr");
            entity.Property(e => e.AppHdrRowId)
                .ValueGeneratedOnAdd()
                .HasColumnName("AppHdr_RowId");
            entity.Property(e => e.AppHdrToFiidFinInstnIdClrSysMmbIdMmbId)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("AppHdr_To_FIId_FinInstnId_ClrSysMmbId_MmbId");
            entity.Property(e => e.DocumentCstmrCdtTrfInitnGrpHdrAuthstnPrtry)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Document_CstmrCdtTrfInitn_GrpHdr_Authstn_Prtry");
            entity.Property(e => e.DocumentCstmrCdtTrfInitnGrpHdrCreDtTm)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Document_CstmrCdtTrfInitn_GrpHdr_CreDtTm");
            entity.Property(e => e.DocumentCstmrCdtTrfInitnGrpHdrCtrlSum)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Document_CstmrCdtTrfInitn_GrpHdr_CtrlSum");
            entity.Property(e => e.DocumentCstmrCdtTrfInitnGrpHdrInitgPtyCtctDtlsEmailAdr)
                .HasMaxLength(320)
                .IsUnicode(false)
                .HasColumnName("Document_CstmrCdtTrfInitn_GrpHdr_InitgPty_CtctDtls_EmailAdr");
            entity.Property(e => e.DocumentCstmrCdtTrfInitnGrpHdrInitgPtyIdOrgIdOthrId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Document_CstmrCdtTrfInitn_GrpHdr_InitgPty_Id_OrgId_Othr_Id");
            entity.Property(e => e.DocumentCstmrCdtTrfInitnGrpHdrInitgPtyNm)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Document_CstmrCdtTrfInitn_GrpHdr_InitgPty_Nm");
            entity.Property(e => e.DocumentCstmrCdtTrfInitnGrpHdrMsgId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Document_CstmrCdtTrfInitn_GrpHdr_MsgId");
            entity.Property(e => e.DocumentCstmrCdtTrfInitnGrpHdrNbOfTxs).HasColumnName("Document_CstmrCdtTrfInitn_GrpHdr_NbOfTxs");
        });

        modelBuilder.Entity<EKuberErrorLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("e_Kuber_Error_Logs");

            entity.Property(e => e.EntryDate)
                .HasColumnType("datetime")
                .HasColumnName("entryDate");
            entity.Property(e => e.ErrorLineNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("error_line_no");
            entity.Property(e => e.ErrorName)
                .HasColumnType("text")
                .HasColumnName("error_name");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Ip)
                .HasMaxLength(50)
                .HasColumnName("ip");
            entity.Property(e => e.MethodName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("method_name");
            entity.Property(e => e.PageName)
                .HasMaxLength(50)
                .HasColumnName("page_name");
            entity.Property(e => e.Userid)
                .HasMaxLength(50)
                .HasColumnName("userid");
        });

        modelBuilder.Entity<EKuberInackInnckDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("e_Kuber_INACK_INNCK_Detail");

            entity.Property(e => e.DocAccptncDtTm)
                .HasColumnType("datetime")
                .HasColumnName("Doc_AccptncDtTm");
            entity.Property(e => e.DocOrgnlEndToEndId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Doc_OrgnlEndToEndId");
            entity.Property(e => e.DocOrgnlInstrId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Doc_OrgnlInstrId");
            entity.Property(e => e.DocOrgnlPmtInfId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Doc_OrgnlPmtInfId");
            entity.Property(e => e.DocPmtInfSts)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Doc_PmtInfSts");
            entity.Property(e => e.DocPrtry)
                .HasMaxLength(10)
                .HasColumnName("Doc_Prtry");
            entity.Property(e => e.DocTxSts)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Doc_TxSts");
            entity.Property(e => e.EntryDate)
                .HasColumnType("datetime")
                .HasColumnName("Entry_Date");
            entity.Property(e => e.HdrBizMsgIdr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("HDR_BizMsgIdr");
            entity.Property(e => e.HdrFileNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("HDR_File_No");
            entity.Property(e => e.HdrRowId)
                .ValueGeneratedOnAdd()
                .HasColumnName("HDR_RowId");
        });

        modelBuilder.Entity<EKuberInackInnckHeader>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("e_Kuber_INACK_INNCK_Header");

            entity.Property(e => e.DocCreDtTm)
                .HasColumnType("datetime")
                .HasColumnName("Doc_CreDtTm");
            entity.Property(e => e.DocGrpSts)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Doc_GrpSts");
            entity.Property(e => e.DocMsgId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Doc_MsgId");
            entity.Property(e => e.DocOrgnlCreDtTm)
                .HasColumnType("datetime")
                .HasColumnName("Doc_OrgnlCreDtTm");
            entity.Property(e => e.DocOrgnlCtrlSum)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Doc_OrgnlCtrlSum");
            entity.Property(e => e.DocOrgnlMsgId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Doc_OrgnlMsgId");
            entity.Property(e => e.DocOrgnlMsgNmId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Doc_OrgnlMsgNmId");
            entity.Property(e => e.DocOrgnlNbOfTxs).HasColumnName("Doc_OrgnlNbOfTxs");
            entity.Property(e => e.EntryDate)
                .HasColumnType("datetime")
                .HasColumnName("Entry_Date");
            entity.Property(e => e.HdrBizMsgIdr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("HDR_BizMsgIdr");
            entity.Property(e => e.HdrBizSvc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("HDR_BizSvc");
            entity.Property(e => e.HdrCreDt)
                .HasColumnType("datetime")
                .HasColumnName("HDR_CreDt");
            entity.Property(e => e.HdrFileNo)
                .HasMaxLength(45)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("HDR_File_No");
            entity.Property(e => e.HdrMmbId)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("HDR_MmbId");
            entity.Property(e => e.HdrMsgDefIdr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("HDR_MsgDefIdr");
            entity.Property(e => e.HdrOthrId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("HDR_Othr_Id");
            entity.Property(e => e.HdrRowId)
                .ValueGeneratedOnAdd()
                .HasColumnName("HDR_RowId");
        });

        modelBuilder.Entity<EKuberRnVoucherReIssue>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("e_Kuber_RnVoucherReIssue");

            entity.Property(e => e.AcntHolderName).HasMaxLength(100);
            entity.Property(e => e.AcntNo)
                .HasMaxLength(20)
                .HasColumnName("AcntNO");
            entity.Property(e => e.Approvedate).HasColumnType("datetime");
            entity.Property(e => e.BankName).HasMaxLength(200);
            entity.Property(e => e.BranchName).HasMaxLength(200);
            entity.Property(e => e.Ddocode)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ddocode");
            entity.Property(e => e.EKuberReturnReasn)
                .HasMaxLength(2)
                .HasColumnName("eKuberReturnReasn");
            entity.Property(e => e.EndToEndId).HasMaxLength(50);
            entity.Property(e => e.EntryDate).HasColumnType("datetime");
            entity.Property(e => e.FileName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Fileno)
                .HasMaxLength(20)
                .IsFixedLength()
                .HasColumnName("fileno");
            entity.Property(e => e.FilenoApproveBy)
                .HasMaxLength(50)
                .HasColumnName("filenoApproveBy");
            entity.Property(e => e.FinYear)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.GrossAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Head)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Ifsc)
                .HasMaxLength(12)
                .HasColumnName("IFSC");
            entity.Property(e => e.InitializationId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("InitializationID");
            entity.Property(e => e.Ip)
                .HasMaxLength(45)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("IP");
            entity.Property(e => e.Micrcode)
                .HasMaxLength(10)
                .HasColumnName("MICRCode");
            entity.Property(e => e.NetAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.RendToEndId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REndToEndId");
            entity.Property(e => e.RfileName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RFileName");
            entity.Property(e => e.RfileNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RFileNo");
            entity.Property(e => e.RnFinYear)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("RnFInYear");
            entity.Property(e => e.RnInitializationId)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("RnInitializationID");
            entity.Property(e => e.RnSerialNo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.SerialNo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TotalDeduction).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<EKuberServiceCallLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("e_Kuber_Service_Call_Log");

            entity.Property(e => e.FunctionName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Function_Name");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.ServiceCalledAt)
                .HasColumnType("datetime")
                .HasColumnName("Service_Called_At");
            entity.Property(e => e.ServiceType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Service_Type");
            entity.Property(e => e.TotalAcst).HasColumnName("Total_ACST");
            entity.Property(e => e.TotalDn).HasColumnName("Total_DN");
            entity.Property(e => e.TotalEkoshAck).HasColumnName("Total_EKOSH_ACK");
            entity.Property(e => e.TotalFailed).HasColumnName("Total_Failed");
            entity.Property(e => e.TotalFileFound).HasColumnName("Total_File_Found");
            entity.Property(e => e.TotalInack).HasColumnName("Total_INACK");
            entity.Property(e => e.TotalInnck).HasColumnName("Total_INNCK");
            entity.Property(e => e.TotalReceived).HasColumnName("Total_Received");
            entity.Property(e => e.TotalRn).HasColumnName("Total_RN");
            entity.Property(e => e.TotalSent).HasColumnName("Total_Sent");
        });

        modelBuilder.Entity<ErrorLog>(entity =>
        {
            entity.ToTable("ErrorLog");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.EntryDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ErrorLocation)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.ErrorlineNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Errormsg)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.Extype)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("extype");
            entity.Property(e => e.Exurl)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("exurl");
            entity.Property(e => e.HostAdd)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.HostIp)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("hostIp");
            entity.Property(e => e.InnerException)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("innerException");
            entity.Property(e => e.StackTrace)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("stackTrace");
            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ErrorMessageMaster>(entity =>
        {
            entity.ToTable("ErrorMessageMaster");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Message)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ForAuthority1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FOR_AUTHORITY1");

            entity.Property(e => e.Authority)
                .HasMaxLength(7)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("AUTHORITY");
            entity.Property(e => e.Authorityname)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("AUTHORITYNAME");
            entity.Property(e => e.Rptddo)
                .HasMaxLength(7)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("RPTDDO");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("STATUS");
        });

        modelBuilder.Entity<ForChequeDelivery>(entity =>
        {
            entity.HasKey(e => e.CkhDelvId);

            entity.ToTable("FOR_CHEQUE_DELIVERY", tb => tb.HasTrigger("FOR_CHEQUE_DELIVERYLogNew"));

            entity.Property(e => e.CkhDelvId).HasColumnName("ckh_delv_id");
            entity.Property(e => e.Chequeamount)
                .HasColumnType("decimal(14, 2)")
                .HasColumnName("CHEQUEAMOUNT");
            entity.Property(e => e.Chequedate)
                .HasColumnType("datetime")
                .HasColumnName("CHEQUEDATE");
            entity.Property(e => e.Chequeinfavour)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("CHEQUEINFAVOUR");
            entity.Property(e => e.Chequeno)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("CHEQUENO");
            entity.Property(e => e.Chequestatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CHEQUESTATUS");
            entity.Property(e => e.Ddocode)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("DDOCODE");
            entity.Property(e => e.Encashmentdate)
                .HasColumnType("datetime")
                .HasColumnName("ENCASHMENTDATE");
            entity.Property(e => e.FinYear)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("FIN_YEAR");
            entity.Property(e => e.Ipaddress)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("IPADDRESS");
            entity.Property(e => e.Lastupdate)
                .HasColumnType("datetime")
                .HasColumnName("LASTUPDATE");
            entity.Property(e => e.Month)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("MONTH");
            entity.Property(e => e.Wamount)
                .HasMaxLength(500)
                .HasColumnName("WAMOUNT");
            entity.Property(e => e.Wamount1)
                .HasMaxLength(500)
                .HasColumnName("WAMOUNT1");
        });

        modelBuilder.Entity<ForChequeDeliveryLog>(entity =>
        {
            entity.HasKey(e => e.Logid);

            entity.ToTable("FOR_CHEQUE_DELIVERY_log");

            entity.Property(e => e.Chequeamount)
                .HasColumnType("decimal(14, 2)")
                .HasColumnName("CHEQUEAMOUNT");
            entity.Property(e => e.Chequedate)
                .HasColumnType("datetime")
                .HasColumnName("CHEQUEDATE");
            entity.Property(e => e.Chequeinfavour)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("CHEQUEINFAVOUR");
            entity.Property(e => e.Chequeno)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("CHEQUENO");
            entity.Property(e => e.Chequestatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CHEQUESTATUS");
            entity.Property(e => e.CkhDelvId).HasColumnName("ckh_delv_id");
            entity.Property(e => e.Ddocode)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("DDOCODE");
            entity.Property(e => e.Encashmentdate)
                .HasColumnType("datetime")
                .HasColumnName("ENCASHMENTDATE");
            entity.Property(e => e.FinYear)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("FIN_YEAR");
            entity.Property(e => e.Ipaddress)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("IPADDRESS");
            entity.Property(e => e.Lastupdate)
                .HasColumnType("datetime")
                .HasColumnName("LASTUPDATE");
            entity.Property(e => e.LogEntryDateTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Month)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("MONTH");
            entity.Property(e => e.Wamount)
                .HasMaxLength(500)
                .HasColumnName("WAMOUNT");
            entity.Property(e => e.Wamount1)
                .HasMaxLength(500)
                .HasColumnName("WAMOUNT1");
        });

        modelBuilder.Entity<ForChequeEncashment>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FOR_CHEQUE_ENCASHMENT");

            entity.Property(e => e.Chequeamount)
                .HasColumnType("decimal(14, 2)")
                .HasColumnName("CHEQUEAMOUNT");
            entity.Property(e => e.Chequedate)
                .HasColumnType("datetime")
                .HasColumnName("CHEQUEDATE");
            entity.Property(e => e.Chequeno)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CHEQUENO");
            entity.Property(e => e.Ddocode)
                .HasMaxLength(7)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DDOCODE");
            entity.Property(e => e.FinYear)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("FIN_YEAR");
            entity.Property(e => e.Lastupdate)
                .HasColumnType("datetime")
                .HasColumnName("LASTUPDATE");
            entity.Property(e => e.Majorhead)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MAJORHEAD");
            entity.Property(e => e.Minorhead)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MINORHEAD");
            entity.Property(e => e.Paymentdate)
                .HasColumnType("datetime")
                .HasColumnName("PAYMENTDATE");
            entity.Property(e => e.Serialno)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SERIALNO");
            entity.Property(e => e.Series)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SERIES");
            entity.Property(e => e.Submajorhead)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SUBMAJORHEAD");
            entity.Property(e => e.Treasurycode)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("TREASURYCODE");
            entity.Property(e => e.Usercode)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("USERCODE");
            entity.Property(e => e.Workcode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("WORKCODE");
            entity.Property(e => e.Worktype)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("WORKTYPE");
        });

        modelBuilder.Entity<ForChequeMaster>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FOR_CHEQUE_MASTER");

            entity.Property(e => e.Chequeexhaust)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CHEQUEEXHAUST");
            entity.Property(e => e.Chequenofrom)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("CHEQUENOFROM");
            entity.Property(e => e.Chequenoto)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("CHEQUENOTO");
            entity.Property(e => e.Currentchequeno)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("CURRENTCHEQUENO");
            entity.Property(e => e.Ddocode)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("DDOCODE");
        });

        modelBuilder.Entity<ForChequePreparation>(entity =>
        {
            entity.HasKey(e => e.ChkPreId);

            entity.ToTable("FOR_CHEQUE_PREPARATION");

            entity.Property(e => e.ChkPreId).HasColumnName("chk_Pre_id");
            entity.Property(e => e.Chequeamount)
                .HasColumnType("decimal(14, 2)")
                .HasColumnName("CHEQUEAMOUNT");
            entity.Property(e => e.Chequedate)
                .HasColumnType("datetime")
                .HasColumnName("CHEQUEDATE");
            entity.Property(e => e.Chequeno)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("CHEQUENO");
            entity.Property(e => e.Ddocode)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("DDOCODE");
            entity.Property(e => e.FinYear)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("FIN_YEAR");
            entity.Property(e => e.Month)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("MONTH");
            entity.Property(e => e.Paymenttype)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PAYMENTTYPE");
            entity.Property(e => e.Referenceno).HasColumnName("REFERENCENO");
        });

        modelBuilder.Entity<ForDepositBalance>(entity =>
        {
            entity.HasKey(e => e.IdDeptBalance).HasName("FOR_DEPOSIT_BALANCE_PK1");

            entity.ToTable("FOR_DEPOSIT_BALANCE", tb => tb.HasTrigger("FOR_DEPOSIT_BALANCE_logNew"));

            entity.Property(e => e.IdDeptBalance).HasColumnName("id_dept_balance");
            entity.Property(e => e.Ddocode)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("DDOCODE");
            entity.Property(e => e.Deptcode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("DEPTCODE");
            entity.Property(e => e.Entrydate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("entrydate");
            entity.Property(e => e.Expenditure)
                .HasColumnType("decimal(14, 2)")
                .HasColumnName("EXPENDITURE");
            entity.Property(e => e.FinYear)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("FIN_YEAR");
            entity.Property(e => e.Hoa)
                .HasMaxLength(33)
                .IsUnicode(false)
                .HasColumnName("HOA");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("lastUpdateDate");
            entity.Property(e => e.Totaldeposited)
                .HasColumnType("decimal(14, 2)")
                .HasColumnName("TOTALDEPOSITED");
            entity.Property(e => e.Verified)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("VERIFIED");
            entity.Property(e => e.Workcode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("WORKCODE");
        });

        modelBuilder.Entity<ForDepositBalanceLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FOR_DEPOSIT_BALANCE_log");

            entity.Property(e => e.Ddocode)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("DDOCODE");
            entity.Property(e => e.Deptcode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("DEPTCODE");
            entity.Property(e => e.EntryDate)
                .HasColumnType("datetime")
                .HasColumnName("entryDate");
            entity.Property(e => e.Expenditure)
                .HasColumnType("decimal(14, 2)")
                .HasColumnName("EXPENDITURE");
            entity.Property(e => e.FinYear)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("FIN_YEAR");
            entity.Property(e => e.Hoa)
                .HasMaxLength(33)
                .IsUnicode(false)
                .HasColumnName("HOA");
            entity.Property(e => e.IdDeptBalance).HasColumnName("id_dept_balance");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("lastUpdateDate");
            entity.Property(e => e.LogEntryDateTime).HasColumnType("datetime");
            entity.Property(e => e.Logid)
                .ValueGeneratedOnAdd()
                .HasColumnName("logid");
            entity.Property(e => e.Totaldeposited)
                .HasColumnType("decimal(14, 2)")
                .HasColumnName("TOTALDEPOSITED");
            entity.Property(e => e.Verified)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("VERIFIED");
            entity.Property(e => e.Workcode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("WORKCODE");
        });

        modelBuilder.Entity<ForDepositEntry>(entity =>
        {
            entity.HasKey(e => new { e.Challanno, e.Challandate, e.Ddocode }).HasName("FOR_DEPOSIT_ENTRY_PK");

            entity.ToTable("FOR_DEPOSIT_ENTRY", tb => tb.HasTrigger("FOR_DEPOSIT_ENTRY_logNew"));

            entity.Property(e => e.Challanno)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CHALLANNO");
            entity.Property(e => e.Challandate)
                .HasColumnType("datetime")
                .HasColumnName("CHALLANDATE");
            entity.Property(e => e.Ddocode)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("DDOCODE");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(14, 2)")
                .HasColumnName("AMOUNT");
            entity.Property(e => e.DepostEntId)
                .ValueGeneratedOnAdd()
                .HasColumnName("depost_ent_id");
            entity.Property(e => e.Deptcode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("DEPTCODE");
            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.EntryDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FinYear)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("FIN_YEAR");
            entity.Property(e => e.Hoa)
                .HasMaxLength(33)
                .IsUnicode(false)
                .HasColumnName("HOA");
            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Verified)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("VERIFIED");
            entity.Property(e => e.Workcode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("WORKCODE");
        });

        modelBuilder.Entity<ForDepositEntryLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FOR_DEPOSIT_ENTRY_log");

            entity.Property(e => e.Amount)
                .HasColumnType("decimal(14, 2)")
                .HasColumnName("AMOUNT");
            entity.Property(e => e.Challandate)
                .HasColumnType("datetime")
                .HasColumnName("CHALLANDATE");
            entity.Property(e => e.Challanno)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CHALLANNO");
            entity.Property(e => e.Ddocode)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("DDOCODE");
            entity.Property(e => e.DepostEntIdLog).HasColumnName("depost_ent_id_log");
            entity.Property(e => e.Deptcode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("DEPTCODE");
            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.EntryDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FinYear)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("FIN_YEAR");
            entity.Property(e => e.Hoa)
                .HasMaxLength(33)
                .IsUnicode(false)
                .HasColumnName("HOA");
            entity.Property(e => e.LogEntryDateTime).HasColumnType("datetime");
            entity.Property(e => e.Logid).ValueGeneratedOnAdd();
            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Verified)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("VERIFIED");
            entity.Property(e => e.Workcode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("WORKCODE");
        });

        modelBuilder.Entity<ForDepositWork>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FOR_DEPOSIT_WORK");

            entity.Property(e => e.Ddocode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("DDOCODE");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("STATUS");
            entity.Property(e => e.Workcode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("WORKCODE");
            entity.Property(e => e.Workname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("WORKNAME");
        });

        modelBuilder.Entity<ForDepositWorkOld>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FOR_DEPOSIT_WORK_old");

            entity.Property(e => e.Ddocode)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("DDOCODE");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("STATUS");
            entity.Property(e => e.Workcode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("WORKCODE");
            entity.Property(e => e.Workname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("WORKNAME");
        });

        modelBuilder.Entity<ForDeptmast>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FOR_DEPTMAST");

            entity.Property(e => e.Ddocode)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("DDOCODE");
            entity.Property(e => e.Deptcode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("DEPTCODE");
            entity.Property(e => e.Deptname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DEPTNAME");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("STATUS");
        });

        modelBuilder.Entity<ForDeptmastOld>(entity =>
        {
            entity.HasKey(e => e.Deptcode).HasName("FOR_DEPTMAST_PK");

            entity.ToTable("FOR_DEPTMAST_old");

            entity.Property(e => e.Deptcode)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("DEPTCODE");
            entity.Property(e => e.Ddocode)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("DDOCODE");
            entity.Property(e => e.Deptname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DEPTNAME");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("STATUS");
        });

        modelBuilder.Entity<ForMismathPaymentReference>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("For_MismathPayment_Reference");

            entity.Property(e => e.EntryBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EntryDate).HasColumnType("datetime");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.NetAmount).HasColumnType("decimal(14, 2)");
            entity.Property(e => e.OldReferenceno).HasColumnName("OldREFERENCENO");
            entity.Property(e => e.Referenceno).HasColumnName("REFERENCENO");
        });

        modelBuilder.Entity<ForVoucherEntry>(entity =>
        {
            entity.HasKey(e => e.VoucherId);

            entity.ToTable("FOR_VOUCHER_ENTRY", tb => tb.HasTrigger("FOR_VOUCHER_ENTRY_logNew"));

            entity.HasIndex(e => e.Referenceno, "FOR_VOUCHER_ENTRY_uniqueKeyRef").IsUnique();

            entity.Property(e => e.VoucherId).HasColumnName("Voucher_id");
            entity.Property(e => e.Billdate)
                .HasColumnType("datetime")
                .HasColumnName("BILLDATE");
            entity.Property(e => e.Billno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BILLNO");
            entity.Property(e => e.Billstatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("BILLSTATUS");
            entity.Property(e => e.Chequeprepared)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CHEQUEPREPARED");
            entity.Property(e => e.Ddocode)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("DDOCODE");
            entity.Property(e => e.Deduction)
                .HasColumnType("decimal(14, 2)")
                .HasColumnName("DEDUCTION");
            entity.Property(e => e.Deductiondetail)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("DEDUCTIONDETAIL");
            entity.Property(e => e.Deptcode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("DEPTCODE");
            entity.Property(e => e.Descriptione)
                .HasMaxLength(500)
                .HasColumnName("DESCRIPTIONE");
            entity.Property(e => e.Descriptionh)
                .HasMaxLength(1000)
                .HasColumnName("DESCRIPTIONH");
            entity.Property(e => e.DfoApDate)
                .HasColumnType("datetime")
                .HasColumnName("dfo_ap_date");
            entity.Property(e => e.DfoApSysDate)
                .HasColumnType("datetime")
                .HasColumnName("dfo_ap_sys_date");
            entity.Property(e => e.Dmf)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DMF");
            entity.Property(e => e.EntryDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Expenditure)
                .HasColumnType("decimal(14, 2)")
                .HasColumnName("EXPENDITURE");
            entity.Property(e => e.FinYear)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("FIN_YEAR");
            entity.Property(e => e.Groupid).HasColumnName("groupid");
            entity.Property(e => e.Gst)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("GST");
            entity.Property(e => e.Hoa)
                .HasMaxLength(33)
                .IsUnicode(false)
                .HasColumnName("HOA");
            entity.Property(e => e.InconeTax).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.IsApprovedBySdo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("isApprovedBySdo");
            entity.Property(e => e.IsDsc).HasColumnName("isDSC");
            entity.Property(e => e.IsReturn)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("isReturn");
            entity.Property(e => e.IsTaxBill)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("isTaxBill");
            entity.Property(e => e.Lastupdate).HasColumnName("LASTUPDATE");
            entity.Property(e => e.MmOrderNumber)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("mm_orderNumber");
            entity.Property(e => e.Month)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("MONTH");
            entity.Property(e => e.Netamount)
                .HasColumnType("decimal(14, 2)")
                .HasColumnName("NETAMOUNT");
            entity.Property(e => e.OldReferencenoforTax).HasColumnName("OldREFERENCENOForTax");
            entity.Property(e => e.Orderdate)
                .HasColumnType("datetime")
                .HasColumnName("ORDERDATE");
            entity.Property(e => e.Orderno)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ORDERNO");
            entity.Property(e => e.Paymenttype)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PAYMENTTYPE");
            entity.Property(e => e.Referenceno).HasColumnName("REFERENCENO");
            entity.Property(e => e.ReturnRemark)
                .HasMaxLength(2000)
                .HasColumnName("returnRemark");
            entity.Property(e => e.Royalty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.SdoApDate)
                .HasColumnType("datetime")
                .HasColumnName("sdo_ap_date");
            entity.Property(e => e.SdoApSysDate)
                .HasColumnType("datetime")
                .HasColumnName("sdo_ap_sys_date");
            entity.Property(e => e.Subdivisioncode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SUBDIVISIONCODE");
            entity.Property(e => e.Subvoucherno).HasColumnName("SUBVOUCHERNO");
            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Voucherno).HasColumnName("VOUCHERNO");
            entity.Property(e => e.Workcode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("WORKCODE");
        });

        modelBuilder.Entity<ForVoucherEntryDetail>(entity =>
        {
            entity.ToTable("FOR_VOUCHER_ENTRY_Details", tb => tb.HasTrigger("FOR_VOUCHER_ENTRY_Details_logNew"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AccountNo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("accountNo");
            entity.Property(e => e.Ammount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ammount");
            entity.Property(e => e.BankIfscCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EntryDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FinYear)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("FIN_YEAR");
            entity.Property(e => e.Lastupdate)
                .HasColumnType("datetime")
                .HasColumnName("LASTUPDATE");
            entity.Property(e => e.PayeeId).HasColumnName("payeeID");
            entity.Property(e => e.PaymentTo)
                .HasDefaultValue(1)
                .HasComment("1 for DFO, 2 For RO ")
                .HasColumnName("paymentTo");
            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WorkOrderNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("workOrderNo");
        });

        modelBuilder.Entity<ForVoucherEntryDetailsLog>(entity =>
        {
            entity.HasKey(e => e.Logid).HasName("PK__FOR_VOUC__5E558250FF85C9C4");

            entity.ToTable("FOR_VOUCHER_ENTRY_Details_Log");

            entity.Property(e => e.AccountNo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("accountNo");
            entity.Property(e => e.Ammount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ammount");
            entity.Property(e => e.BankIfscCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EntryDate).HasColumnType("datetime");
            entity.Property(e => e.FinYear)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("FIN_YEAR");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Lastupdate)
                .HasColumnType("datetime")
                .HasColumnName("LASTUPDATE");
            entity.Property(e => e.LogEntryDateTime).HasColumnType("datetime");
            entity.Property(e => e.PayeeId).HasColumnName("payeeID");
            entity.Property(e => e.PaymentTo).HasColumnName("paymentTo");
            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WorkOrderNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("workOrderNo");
        });

        modelBuilder.Entity<ForVoucherEntryDetailsLog22oct2024>(entity =>
        {
            entity.HasKey(e => e.LogId).HasName("PK_FOR_VOUCHER_ENTRY_Details_log");

            entity.ToTable("FOR_VOUCHER_ENTRY_Details_log_22Oct2024");

            entity.Property(e => e.LogId).HasColumnName("log_id");
            entity.Property(e => e.AccountNo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("accountNo");
            entity.Property(e => e.Ammount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ammount");
            entity.Property(e => e.BankIfscCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EntryDate).HasColumnType("datetime");
            entity.Property(e => e.FinYear)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("FIN_YEAR");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Lastupdate)
                .HasColumnType("datetime")
                .HasColumnName("LASTUPDATE");
            entity.Property(e => e.LogEntryDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("log_EntryDate");
            entity.Property(e => e.PayeeId).HasColumnName("payeeID");
            entity.Property(e => e.PaymentTo).HasColumnName("paymentTo");
            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WorkOrderNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("workOrderNo");
        });

        modelBuilder.Entity<ForVoucherEntryLog>(entity =>
        {
            entity.HasKey(e => e.Logid).HasName("PK__FOR_VOUC__5E55825051053DE7");

            entity.ToTable("FOR_VOUCHER_ENTRY_Log");

            entity.Property(e => e.Billdate)
                .HasColumnType("datetime")
                .HasColumnName("BILLDATE");
            entity.Property(e => e.Billno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BILLNO");
            entity.Property(e => e.Billstatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("BILLSTATUS");
            entity.Property(e => e.Chequeprepared)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CHEQUEPREPARED");
            entity.Property(e => e.Ddocode)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("DDOCODE");
            entity.Property(e => e.Deduction)
                .HasColumnType("decimal(14, 2)")
                .HasColumnName("DEDUCTION");
            entity.Property(e => e.Deductiondetail)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("DEDUCTIONDETAIL");
            entity.Property(e => e.Deptcode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("DEPTCODE");
            entity.Property(e => e.Descriptione)
                .HasMaxLength(500)
                .HasColumnName("DESCRIPTIONE");
            entity.Property(e => e.Descriptionh)
                .HasMaxLength(1000)
                .HasColumnName("DESCRIPTIONH");
            entity.Property(e => e.DfoApDate)
                .HasColumnType("datetime")
                .HasColumnName("dfo_ap_date");
            entity.Property(e => e.DfoApSysDate)
                .HasColumnType("datetime")
                .HasColumnName("dfo_ap_sys_date");
            entity.Property(e => e.Dmf)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DMF");
            entity.Property(e => e.EntryDate).HasColumnType("datetime");
            entity.Property(e => e.Expenditure)
                .HasColumnType("decimal(14, 2)")
                .HasColumnName("EXPENDITURE");
            entity.Property(e => e.FinYear)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("FIN_YEAR");
            entity.Property(e => e.Groupid).HasColumnName("groupid");
            entity.Property(e => e.Gst)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("GST");
            entity.Property(e => e.Hoa)
                .HasMaxLength(33)
                .IsUnicode(false)
                .HasColumnName("HOA");
            entity.Property(e => e.InconeTax).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.IsApprovedBySdo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("isApprovedBySdo");
            entity.Property(e => e.IsDsc).HasColumnName("isDSC");
            entity.Property(e => e.IsReturn)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("isReturn");
            entity.Property(e => e.IsTaxBill)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("isTaxBill");
            entity.Property(e => e.Lastupdate).HasColumnName("LASTUPDATE");
            entity.Property(e => e.LogEntryDateTime).HasColumnType("datetime");
            entity.Property(e => e.MmOrderNumber)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("mm_orderNumber");
            entity.Property(e => e.Month)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("MONTH");
            entity.Property(e => e.Netamount)
                .HasColumnType("decimal(14, 2)")
                .HasColumnName("NETAMOUNT");
            entity.Property(e => e.OldReferencenoforTax).HasColumnName("OldREFERENCENOForTax");
            entity.Property(e => e.Orderdate)
                .HasColumnType("datetime")
                .HasColumnName("ORDERDATE");
            entity.Property(e => e.Orderno)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ORDERNO");
            entity.Property(e => e.Paymenttype)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PAYMENTTYPE");
            entity.Property(e => e.Referenceno).HasColumnName("REFERENCENO");
            entity.Property(e => e.ReturnRemark)
                .HasMaxLength(2000)
                .HasColumnName("returnRemark");
            entity.Property(e => e.Royalty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.SdoApDate)
                .HasColumnType("datetime")
                .HasColumnName("sdo_ap_date");
            entity.Property(e => e.SdoApSysDate)
                .HasColumnType("datetime")
                .HasColumnName("sdo_ap_sys_date");
            entity.Property(e => e.Subdivisioncode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SUBDIVISIONCODE");
            entity.Property(e => e.Subvoucherno).HasColumnName("SUBVOUCHERNO");
            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.VoucherId).HasColumnName("Voucher_id");
            entity.Property(e => e.Voucherno).HasColumnName("VOUCHERNO");
            entity.Property(e => e.Workcode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("WORKCODE");
        });

        modelBuilder.Entity<ForVoucherEntryLog22oct2024>(entity =>
        {
            entity.HasKey(e => e.VoucherIdLog).HasName("PK_FOR_VOUCHER_ENTRY_log");

            entity.ToTable("FOR_VOUCHER_ENTRY_log_22Oct2024");

            entity.Property(e => e.VoucherIdLog).HasColumnName("Voucher_id_log");
            entity.Property(e => e.Billdate)
                .HasColumnType("datetime")
                .HasColumnName("BILLDATE");
            entity.Property(e => e.Billno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BILLNO");
            entity.Property(e => e.Billstatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("BILLSTATUS");
            entity.Property(e => e.Chequeprepared)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CHEQUEPREPARED");
            entity.Property(e => e.Ddocode)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("DDOCODE");
            entity.Property(e => e.Deduction)
                .HasColumnType("decimal(14, 2)")
                .HasColumnName("DEDUCTION");
            entity.Property(e => e.Deductiondetail)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("DEDUCTIONDETAIL");
            entity.Property(e => e.Deptcode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("DEPTCODE");
            entity.Property(e => e.Descriptione)
                .HasMaxLength(500)
                .HasColumnName("DESCRIPTIONE");
            entity.Property(e => e.Descriptionh)
                .HasMaxLength(1000)
                .HasColumnName("DESCRIPTIONH");
            entity.Property(e => e.Dmf)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DMF");
            entity.Property(e => e.EntryDate).HasColumnType("datetime");
            entity.Property(e => e.EntryDateLog)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("EntryDate_log");
            entity.Property(e => e.Expenditure)
                .HasColumnType("decimal(14, 2)")
                .HasColumnName("EXPENDITURE");
            entity.Property(e => e.FinYear)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("FIN_YEAR");
            entity.Property(e => e.Groupid).HasColumnName("groupid");
            entity.Property(e => e.Gst)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("GST");
            entity.Property(e => e.Hoa)
                .HasMaxLength(33)
                .IsUnicode(false)
                .HasColumnName("HOA");
            entity.Property(e => e.InconeTax).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.IsApprovedBySdo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("isApprovedBySdo");
            entity.Property(e => e.IsReturn)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("isReturn");
            entity.Property(e => e.IsTaxBill)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("isTaxBill");
            entity.Property(e => e.Lastupdate).HasColumnName("LASTUPDATE");
            entity.Property(e => e.MmOrderNumber)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("mm_orderNumber");
            entity.Property(e => e.Month)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("MONTH");
            entity.Property(e => e.Netamount)
                .HasColumnType("decimal(14, 2)")
                .HasColumnName("NETAMOUNT");
            entity.Property(e => e.OldReferencenoforTax).HasColumnName("OldREFERENCENOForTax");
            entity.Property(e => e.Orderdate)
                .HasColumnType("datetime")
                .HasColumnName("ORDERDATE");
            entity.Property(e => e.Orderno)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ORDERNO");
            entity.Property(e => e.Paymenttype)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PAYMENTTYPE");
            entity.Property(e => e.Referenceno).HasColumnName("REFERENCENO");
            entity.Property(e => e.ReturnRemark)
                .HasMaxLength(2000)
                .HasColumnName("returnRemark");
            entity.Property(e => e.Royalty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Subdivisioncode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SUBDIVISIONCODE");
            entity.Property(e => e.Subvoucherno).HasColumnName("SUBVOUCHERNO");
            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.VoucherId).HasColumnName("Voucher_id");
            entity.Property(e => e.Voucherno).HasColumnName("VOUCHERNO");
            entity.Property(e => e.Workcode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("WORKCODE");
        });

        modelBuilder.Entity<Ifscmaster>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_IFSCMaster_1");

            entity.ToTable("IFSCMaster");

            entity.HasIndex(e => e.Ifsc, "UQ__IFSCMast__B93B3FB95FD814DD").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BranchName)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.Ifsc)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("IFSC");

            entity.HasOne(d => d.BankCodeNavigation).WithMany(p => p.Ifscmasters)
                .HasForeignKey(d => d.BankCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IFSCMaster_BankMaster");
        });

        modelBuilder.Entity<Labourwagesdetail>(entity =>
        {
            entity.ToTable("labourwagesdetails", tb => tb.HasTrigger("labourwagesdetails_logNew"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Accountno)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("accountno");
            entity.Property(e => e.BankIfsccode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("bankIfsccode");
            entity.Property(e => e.Billserialnumber)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("billserialnumber");
            entity.Property(e => e.Date)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.EntryBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Entrydate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("entrydate");
            entity.Property(e => e.FromDate).HasColumnType("datetime");
            entity.Property(e => e.Groupid).HasColumnName("groupid");
            entity.Property(e => e.Isdelete).HasColumnName("isdelete");
            entity.Property(e => e.Labourid).HasColumnName("labourid");
            entity.Property(e => e.Newgroupid).HasColumnName("newgroupid");
            entity.Property(e => e.Skilled).HasColumnName("skilled");
            entity.Property(e => e.ToDate).HasColumnType("datetime");
            entity.Property(e => e.Totalamount)
                .HasColumnType("decimal(15, 3)")
                .HasColumnName("totalamount");
            entity.Property(e => e.Wages)
                .HasColumnType("decimal(7, 3)")
                .HasColumnName("wages");
            entity.Property(e => e.Workdays).HasColumnName("workdays");
            entity.Property(e => e.Worktypeid).HasColumnName("worktypeid");
        });

        modelBuilder.Entity<LabourwagesdetailsLog>(entity =>
        {
            entity.HasKey(e => e.LogId).HasName("PK__labourwa__9E2397E0BC3B2CD3");

            entity.ToTable("labourwagesdetails_Log");

            entity.Property(e => e.LogId).HasColumnName("log_id");
            entity.Property(e => e.Accountno)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("accountno");
            entity.Property(e => e.BankIfsccode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("bankIfsccode");
            entity.Property(e => e.Billserialnumber)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("billserialnumber");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.EntryBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Entrydate)
                .HasColumnType("datetime")
                .HasColumnName("entrydate");
            entity.Property(e => e.FromDate).HasColumnType("datetime");
            entity.Property(e => e.Groupid).HasColumnName("groupid");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Isdelete).HasColumnName("isdelete");
            entity.Property(e => e.Labourid).HasColumnName("labourid");
            entity.Property(e => e.LogEntryDateTime).HasColumnType("datetime");
            entity.Property(e => e.Skilled).HasColumnName("skilled");
            entity.Property(e => e.ToDate).HasColumnType("datetime");
            entity.Property(e => e.Totalamount)
                .HasColumnType("decimal(15, 3)")
                .HasColumnName("totalamount");
            entity.Property(e => e.Wages)
                .HasColumnType("decimal(7, 3)")
                .HasColumnName("wages");
            entity.Property(e => e.Workdays).HasColumnName("workdays");
            entity.Property(e => e.Worktypeid).HasColumnName("worktypeid");
        });

        modelBuilder.Entity<Labourworkdetail>(entity =>
        {
            entity.ToTable("labourworkdetails");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Date)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.Labourid)
                .HasComment("correlated with vendor master table column vendorid")
                .HasColumnName("labourid");
            entity.Property(e => e.Workid).HasColumnName("workid");
        });

        modelBuilder.Entity<Labourworktype>(entity =>
        {
            entity.ToTable("labourworktypes");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Skilled).HasColumnName("skilled");
        });

        modelBuilder.Entity<LocLogin>(entity =>
        {
            entity.ToTable("LOC_LOGIN");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Authority)
                .HasMaxLength(15)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("AUTHORITY");
            entity.Property(e => e.AuthorityName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("AUTHORITY_Name");
            entity.Property(e => e.Ddocode)
                .HasMaxLength(15)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DDOCODE");
            entity.Property(e => e.Deptcode)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DEPTCODE");
            entity.Property(e => e.EncPswd)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ENC_PSWD");
            entity.Property(e => e.Pswd)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PSWD");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("STATUS");
            entity.Property(e => e.UserType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("1 for DFO , 2 for RO")
                .HasColumnName("USER_TYPE");
        });

        modelBuilder.Entity<LoginMappingTable>(entity =>
        {
            entity.ToTable("LoginMappingTable");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Ddocode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ddocode");
            entity.Property(e => e.DivisionId).HasColumnName("divisionId");
            entity.Property(e => e.DivisonName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("divisonName");
            entity.Property(e => e.RangeId).HasColumnName("rangeId");
            entity.Property(e => e.RangeName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("rangeName");
            entity.Property(e => e.Ro)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RO");
            entity.Property(e => e.Sdo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SDO");
            entity.Property(e => e.SubdivisionId).HasColumnName("subdivisionId");
            entity.Property(e => e.Subdivisionname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("subdivisionname");
        });

        modelBuilder.Entity<MajorheadMaster>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("majorhead_master");

            entity.Property(e => e.Allow)
                .HasMaxLength(255)
                .HasColumnName("ALLOW");
            entity.Property(e => e.Category)
                .HasMaxLength(255)
                .HasColumnName("CATEGORY");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.Majorhead)
                .HasMaxLength(255)
                .HasColumnName("MAJORHEAD");
            entity.Property(e => e.Majorheadname)
                .HasMaxLength(255)
                .HasColumnName("MAJORHEADNAME");
            entity.Property(e => e.Majorheadtype)
                .HasMaxLength(255)
                .HasColumnName("MAJORHEADTYPE");
        });

        modelBuilder.Entity<Mergedbillfiledetail>(entity =>
        {
            entity.ToTable("mergedbillfiledetails", tb => tb.HasTrigger("mergedbillfiledetails_logNew"));

            entity.HasIndex(e => e.BillSerialNoDetail, "Ukey_BillSerialNo").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BillSerialNo).HasColumnType("numeric(10, 0)");
            entity.Property(e => e.BillSerialNoDetail).HasColumnType("numeric(10, 0)");
            entity.Property(e => e.EntryBy)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("entryBy");
            entity.Property(e => e.EntrydDate)
                .HasColumnType("datetime")
                .HasColumnName("entrydDate");
            entity.Property(e => e.FileStatus)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("fileStatus");
            entity.Property(e => e.FinYear)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("FIN_YEAR");
            entity.Property(e => e.LastUpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("lastUpdatedDate");
            entity.Property(e => e.MsgId).HasColumnType("numeric(38, 0)");
            entity.Property(e => e.Msgtype)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Status).HasColumnName("status");
        });

        modelBuilder.Entity<MergedbillfiledetailsLog>(entity =>
        {
            entity.HasKey(e => e.Logid).HasName("PK__mergedbi__5E558250E3C154C7");

            entity.ToTable("mergedbillfiledetails_log");

            entity.Property(e => e.BillSerialNo).HasColumnType("numeric(10, 0)");
            entity.Property(e => e.BillSerialNoDetail).HasColumnType("numeric(10, 0)");
            entity.Property(e => e.EntryBy)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("entryBy");
            entity.Property(e => e.EntrydDate)
                .HasColumnType("datetime")
                .HasColumnName("entrydDate");
            entity.Property(e => e.FileStatus)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("fileStatus");
            entity.Property(e => e.FinYear)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("FIN_YEAR");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.LastUpdatedDate)
                .HasColumnType("datetime")
                .HasColumnName("lastUpdatedDate");
            entity.Property(e => e.LogEntryDateTime).HasColumnType("datetime");
            entity.Property(e => e.MsgId).HasColumnType("numeric(38, 0)");
            entity.Property(e => e.Msgtype)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Status).HasColumnName("status");
        });

        modelBuilder.Entity<MinorheadMaster>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("minorhead_master");

            entity.Property(e => e.Allow)
                .HasMaxLength(255)
                .HasColumnName("ALLOW");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.Majorhead)
                .HasMaxLength(255)
                .HasColumnName("MAJORHEAD");
            entity.Property(e => e.Minorhead)
                .HasMaxLength(255)
                .HasColumnName("MINORHEAD");
            entity.Property(e => e.Minorheadname)
                .HasMaxLength(255)
                .HasColumnName("MINORHEADNAME");
            entity.Property(e => e.Submajorhead)
                .HasMaxLength(255)
                .HasColumnName("SUBMAJORHEAD");
        });

        modelBuilder.Entity<MonthMaster>(entity =>
        {
            entity.ToTable("MonthMaster");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.MonthCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("monthCode");
            entity.Property(e => e.MonthName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("monthName");
        });

        modelBuilder.Entity<NotificationNotReceived>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("NotificationNotReceived");

            entity.Property(e => e.AckFileName)
                .HasMaxLength(255)
                .HasColumnName("ACK_FILE_NAME");
            entity.Property(e => e.DnFilename)
                .HasMaxLength(255)
                .HasColumnName("DN_FILENAME");
            entity.Property(e => e.File)
                .HasMaxLength(255)
                .HasColumnName("FILE");
        });

        modelBuilder.Entity<ObjectheadMaster>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("objecthead_master");

            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.FinYear)
                .HasMaxLength(255)
                .HasColumnName("FIN_YEAR");
            entity.Property(e => e.Objecthead)
                .HasMaxLength(255)
                .HasColumnName("OBJECTHEAD");
            entity.Property(e => e.Objectheadname)
                .HasMaxLength(255)
                .HasColumnName("OBJECTHEADNAME");
        });

        modelBuilder.Entity<RangeMaster>(entity =>
        {
            entity.ToTable("RangeMaster");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Circleid).HasColumnName("circleid");
            entity.Property(e => e.DivisonId).HasColumnName("divisonId");
            entity.Property(e => e.Emailid)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("emailid");
            entity.Property(e => e.IsDepo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("isDepo");
            entity.Property(e => e.IsFirstLogin).HasColumnName("isFirstLogin");
            entity.Property(e => e.Mobileno).HasColumnName("mobileno");
            entity.Property(e => e.PersonName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Pwd)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("pwd");
            entity.Property(e => e.RangeName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("rangeName");
            entity.Property(e => e.SubdivisionId).HasColumnName("subdivisionId");
            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("userId");
            entity.Property(e => e.WingType).HasColumnName("wingType");
        });

        modelBuilder.Entity<SchemecodeMaster>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("schemecode_master");

            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.FinYear)
                .HasMaxLength(255)
                .HasColumnName("FIN_YEAR");
            entity.Property(e => e.Schemecode)
                .HasMaxLength(255)
                .HasColumnName("SCHEMECODE");
            entity.Property(e => e.Schemename)
                .HasMaxLength(255)
                .HasColumnName("SCHEMENAME");
        });

        modelBuilder.Entity<SdoAndDfoDeptName>(entity =>
        {
            entity.ToTable("SdoAndDfoDeptName");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DeptName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EntryDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SegmentCodeMaster>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SegmentCode_master");

            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.Description1)
                .HasMaxLength(255)
                .HasColumnName("DESCRIPTION1");
            entity.Property(e => e.FinYear)
                .HasMaxLength(255)
                .HasColumnName("FIN_YEAR");
            entity.Property(e => e.Segmentcode)
                .HasMaxLength(255)
                .HasColumnName("SEGMENTCODE");
        });

        modelBuilder.Entity<StateMaster>(entity =>
        {
            entity.HasKey(e => e.StateId);

            entity.ToTable("StateMaster");

            entity.Property(e => e.StateId).ValueGeneratedNever();
            entity.Property(e => e.StateCapital)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StateName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<StatusCodeMaster>(entity =>
        {
            entity.ToTable("StatusCodeMaster");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("name");
        });

        modelBuilder.Entity<SubDivisionMasterNew>(entity =>
        {
            entity.ToTable("SubDivisionMasterNew");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Cricleid).HasColumnName("cricleid");
            entity.Property(e => e.DivisionId).HasColumnName("divisionId");
            entity.Property(e => e.Emailid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("emailid");
            entity.Property(e => e.IsFirstLogin).HasColumnName("isFirstLogin");
            entity.Property(e => e.Mobileno).HasColumnName("mobileno");
            entity.Property(e => e.PersonName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Pwd)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("pwd");
            entity.Property(e => e.SubDivisionName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("userId");
            entity.Property(e => e.WingType).HasColumnName("wingType");
        });

        modelBuilder.Entity<Subdivisionmaster>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SUBDIVISIONMASTER");

            entity.Property(e => e.Ddocode)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("DDOCODE");
            entity.Property(e => e.Pswd)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PSWD");
            entity.Property(e => e.Subdivisioncode)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("SUBDIVISIONCODE");
            entity.Property(e => e.Subdivisionname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("SUBDIVISIONNAME");
        });

        modelBuilder.Entity<SubmajorheadMaster>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("submajorhead_master");

            entity.Property(e => e.Allow)
                .HasMaxLength(255)
                .HasColumnName("ALLOW");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.Majorhead)
                .HasMaxLength(255)
                .HasColumnName("MAJORHEAD");
            entity.Property(e => e.Submajorhead)
                .HasMaxLength(255)
                .HasColumnName("SUBMAJORHEAD");
            entity.Property(e => e.Submajorheadname)
                .HasMaxLength(255)
                .HasColumnName("SUBMAJORHEADNAME");
        });

        modelBuilder.Entity<SuspenseAccountDetail>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AcName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("SuspenseAc");
            entity.Property(e => e.CreditAmt)
                .HasDefaultValue(0.000m)
                .HasColumnType("decimal(18, 3)");
            entity.Property(e => e.DebitAmt)
                .HasDefaultValue(0.000m)
                .HasColumnType("decimal(18, 3)");
            entity.Property(e => e.EndToEndId)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EntryDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Head)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(((((8658)-(0))-(102))-(0))-(0))");
            entity.Property(e => e.IsPaymentStatus).HasDefaultValue((byte)0);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TaxBillReferenceDetail>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BillserialNo)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("billserialNo");
            entity.Property(e => e.Entrydate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("entrydate");
            entity.Property(e => e.OldbillserialNo)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("oldbillserialNo");
            entity.Property(e => e.Taxid).HasColumnName("taxid");
        });

        modelBuilder.Entity<TaxMaster>(entity =>
        {
            entity.ToTable("TaxMaster");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Hoa)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("HOA");
            entity.Property(e => e.IsTax).HasColumnName("isTax");
            entity.Property(e => e.TaxName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("taxName");
        });

        modelBuilder.Entity<TblRbiMissingFile>(entity =>
        {
            entity.ToTable("tbl_RBI_MissingFile");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AckFileName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DnFileName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.RnFileName)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TempLabourRepaymentDetail>(entity =>
        {
            entity.ToTable("temp_labourRepaymentDetails");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Bcocode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("bcocode");
            entity.Property(e => e.Billserialnumber)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("billserialnumber");
            entity.Property(e => e.Date)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.Endtoendid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("endtoendid");
            entity.Property(e => e.Filename)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("filename");
            entity.Property(e => e.Finyear)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("finyear");
            entity.Property(e => e.Oldbillserialnumber)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("oldbillserialnumber");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("remark");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<Token>(entity =>
        {
            entity.ToTable("token");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AccessToken)
                .IsUnicode(false)
                .HasColumnName("access_token");
            entity.Property(e => e.Expiresin)
                .HasColumnType("datetime")
                .HasColumnName("expiresin");
            entity.Property(e => e.Issuedin)
                .HasColumnType("datetime")
                .HasColumnName("issuedin");
            entity.Property(e => e.TokenType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("token_type");
        });

        modelBuilder.Entity<TreasuryResponseLog>(entity =>
        {
            entity.ToTable("Treasury_Response_log");

            entity.Property(e => e.Ddocode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ddocode");
            entity.Property(e => e.EntryDate)
                .HasColumnType("datetime")
                .HasColumnName("Entry_Date");
            entity.Property(e => e.Method)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("method");
            entity.Property(e => e.Response).HasColumnType("text");
        });

        modelBuilder.Entity<Tstatusmaster>(entity =>
        {
            entity.HasKey(e => e.StatusId).HasName("PK__tstatusm__C8EE2063B85C4AFC");

            entity.ToTable("tstatusmaster");

            entity.Property(e => e.StatusName).HasMaxLength(100);
        });

        modelBuilder.Entity<UserActivityLog>(entity =>
        {
            entity.HasKey(e => e.LogId).HasName("PK__UserActi__5E54864894437A31");

            entity.ToTable("UserActivityLog");

            entity.Property(e => e.ActionType).HasMaxLength(20);
            entity.Property(e => e.AdditionalInfo).HasMaxLength(500);
            entity.Property(e => e.Ipaddress)
                .HasMaxLength(45)
                .HasColumnName("IPAddress");
            entity.Property(e => e.LogTimestamp)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.SessionId).HasMaxLength(100);
            entity.Property(e => e.Username).HasMaxLength(50);
        });

        modelBuilder.Entity<UserTypeMaster>(entity =>
        {
            entity.ToTable("UserTypeMaster");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.UserTypeName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("userTypeName");
        });

        modelBuilder.Entity<Userrepaymentupdate>(entity =>
        {
            entity.ToTable("userrepaymentupdates");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Date)
                .HasComment("getdate()")
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.FinYear)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("FIN_YEAR");
            entity.Property(e => e.Lastupdateddate)
                .HasComment("getdate()")
                .HasColumnType("datetime")
                .HasColumnName("lastupdateddate");
            entity.Property(e => e.Requestuserid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("requestuserid");
            entity.Property(e => e.Status)
                .HasComment("0 for pending, and 1 for approve and changed, 2 for denied")
                .HasColumnName("status");
            entity.Property(e => e.Userid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("userid");
        });

        modelBuilder.Entity<VendorBankDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_VendorBankDetails_1");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AccountHolderName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.BankAccountNo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.BankIfscCode)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.BranchName)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("updatedBy");
        });

        modelBuilder.Entity<VendorBankDetailsLog>(entity =>
        {
            entity.HasKey(e => e.Logid).HasName("PK_VendorBankDetails_log_1");

            entity.ToTable("VendorBankDetails_log");

            entity.Property(e => e.AccountHolderName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.BankAccountNo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.BankIfscCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.LogEntryDateTime).HasColumnType("datetime");
            entity.Property(e => e.Updatedby)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("updatedby");
        });

        modelBuilder.Entity<VendorBankDetailscopy>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_VendorBankDetails");

            entity.ToTable("VendorBankDetailscopy");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AccountHolderName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.BankAccountNo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.BankIfscCode)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.BranchName)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("updatedBy");
        });

        modelBuilder.Entity<VendorMaster>(entity =>
        {
            entity.HasKey(e => e.VendorId).HasName("PK_VendorMaster_1");

            entity.ToTable("VendorMaster", tb => tb.HasTrigger("VendorMaster_logNew"));

            entity.Property(e => e.VendorId).HasColumnName("vendorID");
            entity.Property(e => e.Acitve)
                .HasDefaultValue((byte)1)
                .HasColumnName("acitve");
            entity.Property(e => e.Address)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Caste)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("caste");
            entity.Property(e => e.CategoryId).HasComment("1 gen, 2 obc, 3 st, 4 sc");
            entity.Property(e => e.Designation)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("designation");
            entity.Property(e => e.EmailId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Empcode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("empcode");
            entity.Property(e => e.EntryBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("entryBy");
            entity.Property(e => e.EntryDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("entryDate");
            entity.Property(e => e.FatherName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("fatherName");
            entity.Property(e => e.IsTinOrPan)
                .HasDefaultValue((byte)0)
                .HasComment("1 for TIN and 2 for PAN");
            entity.Property(e => e.Skilled).HasColumnName("skilled");
            entity.Property(e => e.SocityRegNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("socityRegNo");
            entity.Property(e => e.TinNo)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("tinNo");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("updatedBy");
            entity.Property(e => e.Usertype)
                .HasDefaultValue((byte)1)
                .HasComment("1 for vendor , 2 for labour ,3 for Van Prabandhan Samiti, 4 for Hitgrahi (Malik Makbuja/Anya Yojana ka Anudan), 5 for Pratipurti, 6 for Vibhagiya Karyalaya Fund Transfer, 7 for Hitgrahi - Anya Yojana ka Anudan")
                .HasColumnName("usertype");
            entity.Property(e => e.VendorName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("vendorName");
            entity.Property(e => e.Wages)
                .HasColumnType("decimal(7, 3)")
                .HasColumnName("wages");
        });

        modelBuilder.Entity<VendorMasterLog>(entity =>
        {
            entity.HasKey(e => e.Logid);

            entity.ToTable("VendorMaster_log");

            entity.Property(e => e.Acitve).HasColumnName("acitve");
            entity.Property(e => e.Address)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Caste)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("caste");
            entity.Property(e => e.Designation)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("designation");
            entity.Property(e => e.EmailId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Empcode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("empcode");
            entity.Property(e => e.EntryDate)
                .HasColumnType("datetime")
                .HasColumnName("entryDate");
            entity.Property(e => e.FatherName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("fatherName");
            entity.Property(e => e.LogEntryDateTime).HasColumnType("datetime");
            entity.Property(e => e.Skilled).HasColumnName("skilled");
            entity.Property(e => e.TinNo)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("tinNo");
            entity.Property(e => e.Updatedby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("updatedby");
            entity.Property(e => e.Usertype).HasColumnName("usertype");
            entity.Property(e => e.VendorId).HasColumnName("vendorID");
            entity.Property(e => e.VendorName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("vendorName");
            entity.Property(e => e.Wages)
                .HasColumnType("decimal(7, 3)")
                .HasColumnName("wages");
        });

        modelBuilder.Entity<VendorMasterNew>(entity =>
        {
            entity.HasKey(e => e.VendorId);

            entity.ToTable("VendorMasterNew");

            entity.Property(e => e.VendorId).HasColumnName("vendorID");
            entity.Property(e => e.Acitve)
                .HasDefaultValue((byte)1)
                .HasColumnName("acitve");
            entity.Property(e => e.Address)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Caste)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("caste");
            entity.Property(e => e.CategoryId).HasComment("1 gen, 2 obc, 3 st, 4 sc");
            entity.Property(e => e.Designation)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("designation");
            entity.Property(e => e.EmailId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Empcode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("empcode");
            entity.Property(e => e.EntryBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("entryBy");
            entity.Property(e => e.EntryDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("entryDate");
            entity.Property(e => e.FatherName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("fatherName");
            entity.Property(e => e.IsTinOrPan)
                .HasDefaultValue((byte)0)
                .HasComment("1 for TIN and 2 for PAN");
            entity.Property(e => e.Skilled).HasColumnName("skilled");
            entity.Property(e => e.SocityRegNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("socityRegNo");
            entity.Property(e => e.TinNo)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("tinNo");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("updatedBy");
            entity.Property(e => e.Usertype)
                .HasDefaultValue((byte)1)
                .HasComment("1 for vendor , 2 for labour ,3 for Van Prabandhan Samiti, 4 for Hitgrahi (Malik Makbuja/Anya Yojana ka Anudan), 5 for Pratipurti, 6 for Vibhagiya Karyalaya Fund Transfer")
                .HasColumnName("usertype");
            entity.Property(e => e.VendorName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("vendorName");
            entity.Property(e => e.Wages)
                .HasColumnType("decimal(7, 3)")
                .HasColumnName("wages");
        });

        modelBuilder.Entity<VendorMasterOld>(entity =>
        {
            entity.HasKey(e => e.VendorId).HasName("PK_VendorMaster");

            entity.ToTable("VendorMaster_old");

            entity.Property(e => e.VendorId).HasColumnName("vendorID");
            entity.Property(e => e.Acitve)
                .HasDefaultValue((byte)1)
                .HasColumnName("acitve");
            entity.Property(e => e.Address)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Caste)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("caste");
            entity.Property(e => e.CategoryId).HasComment("1 gen, 2 obc, 3 st, 4 sc");
            entity.Property(e => e.Designation)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("designation");
            entity.Property(e => e.EmailId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Empcode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("empcode");
            entity.Property(e => e.EntryBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("entryBy");
            entity.Property(e => e.EntryDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("entryDate");
            entity.Property(e => e.FatherName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("fatherName");
            entity.Property(e => e.IsTinOrPan)
                .HasDefaultValue((byte)0)
                .HasComment("1 for TIN and 2 for PAN");
            entity.Property(e => e.Skilled).HasColumnName("skilled");
            entity.Property(e => e.SocityRegNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("socityRegNo");
            entity.Property(e => e.TinNo)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("tinNo");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("updatedBy");
            entity.Property(e => e.Usertype)
                .HasDefaultValue((byte)1)
                .HasComment("1 for vendor and 2 for labour")
                .HasColumnName("usertype");
            entity.Property(e => e.VendorName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("vendorName");
            entity.Property(e => e.Wages)
                .HasColumnType("decimal(7, 3)")
                .HasColumnName("wages");
        });

        modelBuilder.Entity<Voucher>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("vouchers");

            entity.Property(e => e.AgvCode)
                .HasMaxLength(255)
                .HasColumnName("AGV_CODE");
            entity.Property(e => e.Billamount).HasColumnName("BILLAMOUNT");
            entity.Property(e => e.Billdate)
                .HasColumnType("datetime")
                .HasColumnName("BILLDATE");
            entity.Property(e => e.Billhead)
                .HasMaxLength(255)
                .HasColumnName("BILLHEAD");
            entity.Property(e => e.Billno)
                .HasMaxLength(255)
                .HasColumnName("BILLNO");
            entity.Property(e => e.Billtype)
                .HasMaxLength(255)
                .HasColumnName("BILLTYPE");
            entity.Property(e => e.Btrno)
                .HasMaxLength(255)
                .HasColumnName("BTRNO");
            entity.Property(e => e.BudgetNonbudget)
                .HasMaxLength(255)
                .HasColumnName("BUDGET_NONBUDGET");
            entity.Property(e => e.Budgetddo)
                .HasMaxLength(255)
                .HasColumnName("BUDGETDDO");
            entity.Property(e => e.Chequeamount).HasColumnName("CHEQUEAMOUNT");
            entity.Property(e => e.Chequedate)
                .HasColumnType("datetime")
                .HasColumnName("CHEQUEDATE");
            entity.Property(e => e.Chequenumber)
                .HasMaxLength(255)
                .HasColumnName("CHEQUENUMBER");
            entity.Property(e => e.Ddocode)
                .HasMaxLength(255)
                .HasColumnName("DDOCODE");
            entity.Property(e => e.Deptcode)
                .HasMaxLength(255)
                .HasColumnName("DEPTCODE");
            entity.Property(e => e.Deptddocode)
                .HasMaxLength(255)
                .HasColumnName("DEPTDDOCODE");
            entity.Property(e => e.FinYear)
                .HasMaxLength(255)
                .HasColumnName("FIN_YEAR");
            entity.Property(e => e.Formno)
                .HasMaxLength(255)
                .HasColumnName("FORMNO");
            entity.Property(e => e.Initialisationid)
                .HasMaxLength(255)
                .HasColumnName("INITIALISATIONID");
            entity.Property(e => e.Lastupdate)
                .HasMaxLength(255)
                .HasColumnName("LASTUPDATE");
            entity.Property(e => e.Netamount).HasColumnName("NETAMOUNT");
            entity.Property(e => e.PassBy)
                .HasMaxLength(255)
                .HasColumnName("PASS_BY");
            entity.Property(e => e.Rddocode)
                .HasMaxLength(255)
                .HasColumnName("RDDOCODE");
            entity.Property(e => e.Req)
                .HasMaxLength(255)
                .HasColumnName("REQ");
            entity.Property(e => e.Selfddo)
                .HasMaxLength(255)
                .HasColumnName("SELFDDO");
            entity.Property(e => e.Serialno)
                .HasMaxLength(255)
                .HasColumnName("SERIALNO");
            entity.Property(e => e.Treasurycode)
                .HasMaxLength(255)
                .HasColumnName("TREASURYCODE");
            entity.Property(e => e.Ventrydate)
                .HasMaxLength(255)
                .HasColumnName("VENTRYDATE");
            entity.Property(e => e.Voucherdate)
                .HasMaxLength(255)
                .HasColumnName("VOUCHERDATE");
            entity.Property(e => e.Vrno).HasColumnName("VRNO");
        });

        modelBuilder.Entity<VouchertDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("VouchertDetail");

            entity.Property(e => e.AcntHolderName).HasMaxLength(100);
            entity.Property(e => e.AcntNo)
                .HasMaxLength(20)
                .HasColumnName("AcntNO");
            entity.Property(e => e.AgmtStatus)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.AgreementStatusNew).HasMaxLength(100);
            entity.Property(e => e.AmountPaidInAgmt).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.AmountWork).HasColumnType("decimal(10, 0)");
            entity.Property(e => e.ApproveBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("approveBy");
            entity.Property(e => e.ApproveDate).HasColumnType("datetime");
            entity.Property(e => e.BadPdSecuredAdvance)
                .HasColumnType("decimal(10, 0)")
                .HasColumnName("BAdPdSecuredAdvance");
            entity.Property(e => e.BadPmobilisationAdvance)
                .HasColumnType("decimal(10, 0)")
                .HasColumnName("BAdPMobilisationAdvance");
            entity.Property(e => e.BadPplantMachinaryAdvance)
                .HasColumnType("decimal(10, 0)")
                .HasColumnName("BAdPPlantMachinaryAdvance");
            entity.Property(e => e.BagreementNo).HasColumnName("BAgreementNo");
            entity.Property(e => e.BagreementOrSharared)
                .HasMaxLength(15)
                .IsFixedLength()
                .HasColumnName("BAGreementOrSharared");
            entity.Property(e => e.BagreementedBy)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("BAgreementedBy");
            entity.Property(e => e.BankName).HasMaxLength(200);
            entity.Property(e => e.BarfbmobilisationAdvance)
                .HasColumnType("decimal(10, 0)")
                .HasColumnName("BARFBMobilisationAdvance");
            entity.Property(e => e.BarfbplantandMachinaryAdvance)
                .HasColumnType("decimal(10, 0)")
                .HasColumnName("BARFBPlantandMachinaryAdvance");
            entity.Property(e => e.BarfbsecuredAdvance)
                .HasColumnType("decimal(10, 0)")
                .HasColumnName("BARFBSecuredAdvance");
            entity.Property(e => e.BcontractorId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("BContractorId");
            entity.Property(e => e.BeneficiaryType).HasMaxLength(10);
            entity.Property(e => e.BlankField)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Bonus).HasColumnType("decimal(10, 0)");
            entity.Property(e => e.BpagrBillStatus)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("BPAgrBillStatus");
            entity.Property(e => e.BpagreementedType)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("BPAgreementedType");
            entity.Property(e => e.BpamountPaidByCash)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("BPAmountPaidByCash");
            entity.Property(e => e.BpamountPaidByCheque)
                .HasColumnType("decimal(12, 0)")
                .HasColumnName("BPAmountPaidByCheque");
            entity.Property(e => e.BpbillDate)
                .HasColumnType("datetime")
                .HasColumnName("BPBillDate");
            entity.Property(e => e.BpbillNo)
                .HasMaxLength(30)
                .HasColumnName("BPBillNo");
            entity.Property(e => e.BpbillPaymentType)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("BPBillPaymentType");
            entity.Property(e => e.BpnameOfWork).HasColumnName("BPNameOfWork");
            entity.Property(e => e.BponAccountOf)
                .HasMaxLength(200)
                .HasColumnName("BPOnAccountOf");
            entity.Property(e => e.BranchName).HasMaxLength(200);
            entity.Property(e => e.CancelOnly)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CancelRemark)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("cancel_remark");
            entity.Property(e => e.ChallanDt).HasColumnType("datetime");
            entity.Property(e => e.ChequeBookNo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.ChequeDt)
                .HasColumnType("datetime")
                .HasColumnName("ChequeDT");
            entity.Property(e => e.ChequeNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ChequeStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("chequeStatus");
            entity.Property(e => e.CircleId)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("CircleID");
            entity.Property(e => e.CreditToMiscAdvance).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Ddocode)
                .HasMaxLength(30)
                .IsFixedLength()
                .HasColumnName("ddocode");
            entity.Property(e => e.DepMonth)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("depMonth");
            entity.Property(e => e.DivisionId)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("DivisionID");
            entity.Property(e => e.DtComplitionClosingOfAgreement).HasColumnType("datetime");
            entity.Property(e => e.EKuberReturnReasn)
                .HasMaxLength(2)
                .HasColumnName("eKuberReturnReasn");
            entity.Property(e => e.EndToEndId).HasMaxLength(50);
            entity.Property(e => e.EntryDt)
                .HasColumnType("datetime")
                .HasColumnName("EntryDT");
            entity.Property(e => e.Escalation).HasColumnType("decimal(10, 0)");
            entity.Property(e => e.FileName)
                .HasMaxLength(50)
                .HasColumnName("file_name");
            entity.Property(e => e.FileNo)
                .HasMaxLength(50)
                .HasColumnName("file_no");
            entity.Property(e => e.FinYear)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FlagTable)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.GrossAmount).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Gstno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("gstno");
            entity.Property(e => e.Gsttype)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("gsttype");
            entity.Property(e => e.HeadFlag).HasMaxLength(10);
            entity.Property(e => e.HronAccountOf)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("HROnAccountOf");
            entity.Property(e => e.Ifsc)
                .HasMaxLength(12)
                .HasColumnName("IFSC");
            entity.Property(e => e.IncomeTax).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.InitializationId)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("InitializationID");
            entity.Property(e => e.IpAddress)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IsApproved)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.IsCancel)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.IsCancelOnly)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.IsPrepare)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.IsPrint)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.IsRelaxation)
                .HasMaxLength(1)
                .HasColumnName("isRelaxation");
            entity.Property(e => e.IsRnReissued).HasMaxLength(1);
            entity.Property(e => e.KarmkarTax).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Mallocation)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("MAllocation");
            entity.Property(e => e.MamountPaidByGrain)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("MAmountPaidByGrain");
            entity.Property(e => e.MgrainPaid)
                .HasMaxLength(20)
                .IsFixedLength()
                .HasColumnName("MGrainPaid");
            entity.Property(e => e.Micrcode)
                .HasMaxLength(10)
                .HasColumnName("MICRCode");
            entity.Property(e => e.MiscRecovery).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.MiscRecoveryAgainst)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.MpaymentBy)
                .HasMaxLength(15)
                .IsFixedLength()
                .HasColumnName("MPaymentBy");
            entity.Property(e => e.MpaymentDt)
                .HasColumnType("datetime")
                .HasColumnName("MPaymentDT");
            entity.Property(e => e.MperiodFrom)
                .HasColumnType("datetime")
                .HasColumnName("MPeriodFrom");
            entity.Property(e => e.MperiodTo)
                .HasColumnType("datetime")
                .HasColumnName("MPeriodTo");
            entity.Property(e => e.MrallocationId)
                .HasMaxLength(20)
                .HasColumnName("MRAllocationId");
            entity.Property(e => e.Mramount)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("MRAmount");
            entity.Property(e => e.MrateOfGrain)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("MRateOfGrain");
            entity.Property(e => e.MrbookNo).HasColumnName("MRBookNo");
            entity.Property(e => e.MrdepositorName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("MRDepositorName");
            entity.Property(e => e.MrmissueDt)
                .HasColumnType("datetime")
                .HasColumnName("MRMIssueDT");
            entity.Property(e => e.MronAccountOf)
                .HasMaxLength(100)
                .HasColumnName("MROnAccountOf");
            entity.Property(e => e.MrschemeName)
                .HasMaxLength(100)
                .HasColumnName("MRSchemeName");
            entity.Property(e => e.MrworkCategory)
                .HasMaxLength(100)
                .HasColumnName("MRWorkCategory");
            entity.Property(e => e.MrworkCode)
                .HasMaxLength(20)
                .HasColumnName("MRWorkCode");
            entity.Property(e => e.Mryear)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("MRyear");
            entity.Property(e => e.MtotalCashPaid)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("MTotalCashPaid");
            entity.Property(e => e.MusterRollNo)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.MworkName)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("MWorkName");
            entity.Property(e => e.NoOfBpwork).HasColumnName("NoOfBPWork");
            entity.Property(e => e.NonAgrItem)
                .HasMaxLength(50)
                .HasColumnName("non_agr_item");
            entity.Property(e => e.NonAgrType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("non_agr_type");
            entity.Property(e => e.PaNo)
                .HasMaxLength(15)
                .IsFixedLength()
                .HasColumnName("pa_no");
            entity.Property(e => e.PaidTo).HasMaxLength(100);
            entity.Property(e => e.Pan)
                .HasMaxLength(10)
                .HasColumnName("pan");
            entity.Property(e => e.PassedBy)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.PaymentMode)
                .HasMaxLength(6)
                .IsFixedLength();
            entity.Property(e => e.PerformanceGuarantee).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.PieceWorkNo)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.RefDate).HasColumnName("ref_date");
            entity.Property(e => e.RefNo)
                .HasMaxLength(50)
                .HasColumnName("ref_no");
            entity.Property(e => e.ReportOrderDt)
                .HasColumnType("datetime")
                .HasColumnName("ReportOrderDT");
            entity.Property(e => e.ReportOrderNo).HasColumnType("decimal(10, 3)");
            entity.Property(e => e.RevenueRecovery).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.RevenueRecoveryAgainst)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.RevenueRecoveryHead)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RnReissuedByEnc).HasMaxLength(1);
            entity.Property(e => e.RnReissuedByEncDate).HasColumnType("datetime");
            entity.Property(e => e.RnReissuedSerialNo).HasMaxLength(10);
            entity.Property(e => e.Royalty0853).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Royalty8443).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.SecurityDeposit).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.SerivceTax).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Testing).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TimeExtention).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Tin)
                .HasMaxLength(50)
                .HasColumnName("tin");
            entity.Property(e => e.Todflag)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasColumnName("TODFlag");
            entity.Property(e => e.TotalContractorDeposit).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TotalDeduction).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TotalValueOfContract).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Vattax0040)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("VATTax0040");
            entity.Property(e => e.Vattax8443)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("VATTax8443");
            entity.Property(e => e.VoucherDt)
                .HasColumnType("datetime")
                .HasColumnName("VoucherDT");
            entity.Property(e => e.VoucherNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.WcnoOfReceiptAllocation).HasColumnName("WCNoOfReceiptAllocation");
            entity.Property(e => e.WorkStatus)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.YearOfAgreement)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("year_of_agreement");
            entity.Property(e => e.ZoneId)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("ZoneID");
        });

        modelBuilder.Entity<Vw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw");

            entity.Property(e => e.Accountno)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("accountno");
            entity.Property(e => e.BankIfsccode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("bankIfsccode");
            entity.Property(e => e.Billserialnumber)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("billserialnumber");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.EntryBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Entrydate)
                .HasColumnType("datetime")
                .HasColumnName("entrydate");
            entity.Property(e => e.FromDate).HasColumnType("datetime");
            entity.Property(e => e.Groupid).HasColumnName("groupid");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Isdelete).HasColumnName("isdelete");
            entity.Property(e => e.Labourid).HasColumnName("labourid");
            entity.Property(e => e.Skilled).HasColumnName("skilled");
            entity.Property(e => e.ToDate).HasColumnType("datetime");
            entity.Property(e => e.Totalamount)
                .HasColumnType("decimal(15, 3)")
                .HasColumnName("totalamount");
            entity.Property(e => e.Wages)
                .HasColumnType("decimal(7, 3)")
                .HasColumnName("wages");
            entity.Property(e => e.Workdays).HasColumnName("workdays");
            entity.Property(e => e.Worktypeid).HasColumnName("worktypeid");
        });

        modelBuilder.Entity<VwLabourwage>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_labourwages");

            entity.Property(e => e.Accountno)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("accountno");
            entity.Property(e => e.BankIfsccode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("bankIfsccode");
            entity.Property(e => e.Billserialnumber)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("billserialnumber");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.EntryBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Entrydate)
                .HasColumnType("datetime")
                .HasColumnName("entrydate");
            entity.Property(e => e.FromDate).HasColumnType("datetime");
            entity.Property(e => e.Groupid).HasColumnName("groupid");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Isdelete).HasColumnName("isdelete");
            entity.Property(e => e.Labourid).HasColumnName("labourid");
            entity.Property(e => e.Skilled).HasColumnName("skilled");
            entity.Property(e => e.ToDate).HasColumnType("datetime");
            entity.Property(e => e.Totalamount)
                .HasColumnType("decimal(15, 3)")
                .HasColumnName("totalamount");
            entity.Property(e => e.Wages)
                .HasColumnType("decimal(7, 3)")
                .HasColumnName("wages");
            entity.Property(e => e.Workdays).HasColumnName("workdays");
            entity.Property(e => e.Worktypeid).HasColumnName("worktypeid");
        });

        modelBuilder.Entity<WingMaster>(entity =>
        {
            entity.ToTable("WingMaster");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.WingId).HasColumnName("wingId");
            entity.Property(e => e.WingName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("wingName");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
