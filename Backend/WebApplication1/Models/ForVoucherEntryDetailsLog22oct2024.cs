using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class ForVoucherEntryDetailsLog22oct2024
{
    public long? Id { get; set; }

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

    public long LogId { get; set; }

    public DateTime? LogEntryDate { get; set; }
}
