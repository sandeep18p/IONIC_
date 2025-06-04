using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class SuspenseAccountDetail
{
    public int Id { get; set; }

    public string? AcName { get; set; }

    public string? Head { get; set; }

    public decimal? DebitAmt { get; set; }

    public decimal? CreditAmt { get; set; }

    public DateTime? EntryDate { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public string? EndToEndId { get; set; }

    public byte? IsPaymentStatus { get; set; }
}
