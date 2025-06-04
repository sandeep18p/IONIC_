using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class ForMismathPaymentReference
{
    public int Id { get; set; }

    public long Referenceno { get; set; }

    public long OldReferenceno { get; set; }

    public int NoOfPayee { get; set; }

    public decimal NetAmount { get; set; }

    public DateTime? EntryDate { get; set; }

    public string? EntryBy { get; set; }
}
