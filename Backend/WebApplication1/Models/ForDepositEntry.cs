using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class ForDepositEntry
{
    public string Ddocode { get; set; } = null!;

    public string? FinYear { get; set; }

    public decimal? Amount { get; set; }

    public string Challanno { get; set; } = null!;

    public DateTime Challandate { get; set; }

    public string? Description { get; set; }

    public string? Hoa { get; set; }

    public string? Verified { get; set; }

    public string? Deptcode { get; set; }

    public string? Workcode { get; set; }

    public string? UserId { get; set; }

    public DateTime? EntryDate { get; set; }

    public long DepostEntId { get; set; }
}
