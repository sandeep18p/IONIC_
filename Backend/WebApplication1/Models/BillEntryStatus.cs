using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class BillEntryStatus
{
    public long BillSeriesNo { get; set; }

    public long ReferenceNo { get; set; }

    public byte StatusCode { get; set; }

    public DateTime EntryDate { get; set; }

    public string FinYear { get; set; } = null!;

    public string? MessageCode { get; set; }

    public long Id { get; set; }

    public string? MessageDescription { get; set; }
}
