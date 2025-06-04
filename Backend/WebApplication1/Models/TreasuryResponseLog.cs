using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class TreasuryResponseLog
{
    public long Id { get; set; }

    public string? Response { get; set; }

    public DateTime? EntryDate { get; set; }

    public string? Method { get; set; }

    public string? Ddocode { get; set; }
}
