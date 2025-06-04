using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class EKuberRnVoucherReIssue
{
    public long Id { get; set; }

    public string? Ddocode { get; set; }

    public int? VoucherNo { get; set; }

    public DateOnly? VoucherDate { get; set; }

    public string? RnInitializationId { get; set; }

    public string? RnSerialNo { get; set; }

    public string RnFinYear { get; set; } = null!;

    public string? RendToEndId { get; set; }

    public string? RfileNo { get; set; }

    public string? RfileName { get; set; }

    public string? FileName { get; set; }

    public string? FinYear { get; set; }

    public string SerialNo { get; set; } = null!;

    public string? InitializationId { get; set; }

    public decimal? GrossAmount { get; set; }

    public decimal? NetAmount { get; set; }

    public string? Head { get; set; }

    public DateTime? EntryDate { get; set; }

    public string? Ip { get; set; }

    public string? Fileno { get; set; }

    public string? FilenoApproveBy { get; set; }

    public DateTime? Approvedate { get; set; }

    public string? EndToEndId { get; set; }

    public string? EKuberReturnReasn { get; set; }

    public decimal? TotalDeduction { get; set; }

    public string? AcntHolderName { get; set; }

    public string? AcntNo { get; set; }

    public string? BankName { get; set; }

    public string? BranchName { get; set; }

    public string? Micrcode { get; set; }

    public string? Ifsc { get; set; }
}
