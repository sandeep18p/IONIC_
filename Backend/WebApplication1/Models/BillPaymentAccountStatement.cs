using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class BillPaymentAccountStatement
{
    public long Id { get; set; }

    public string? ActualFileName { get; set; }

    public decimal? BillSerialNo { get; set; }

    public string? NtryRef { get; set; }

    public string? DnrnfileName { get; set; }

    public decimal? DebitAmount { get; set; }

    public decimal? CreditAmount { get; set; }

    public DateTime? EntryDate { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public decimal? OpeningAmount { get; set; }

    public decimal? ClosingAmount { get; set; }

    public int? TotalDebitCount { get; set; }

    public int? TotalCreditCount { get; set; }

    public int? TotalCount { get; set; }

    public int? Status { get; set; }

    public DateTime? CreDt { get; set; }
}
