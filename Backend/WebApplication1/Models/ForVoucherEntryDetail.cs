using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class ForVoucherEntryDetail
{
    public long Id { get; set; }

    /// <summary>
    /// 1 for DFO, 2 For RO 
    /// </summary>
    public int PaymentTo { get; set; }

    public int? PayeeId { get; set; }

    public decimal? Ammount { get; set; }

    public string? WorkOrderNo { get; set; }

    public long ReferenceNo { get; set; }

    public string FinYear { get; set; } = null!;

    public string? AccountNo { get; set; }

    public string? BankIfscCode { get; set; }

    public string? UserId { get; set; }

    public DateTime? EntryDate { get; set; }

    public DateTime? Lastupdate { get; set; }
}
