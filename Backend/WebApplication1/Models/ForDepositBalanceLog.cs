using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class ForDepositBalanceLog
{
    public string Ddocode { get; set; } = null!;

    public string FinYear { get; set; } = null!;

    public decimal? Totaldeposited { get; set; }

    public decimal? Expenditure { get; set; }

    public string Hoa { get; set; } = null!;

    public string? Verified { get; set; }

    public string Workcode { get; set; } = null!;

    public string Deptcode { get; set; } = null!;

    public long Logid { get; set; }

    public long? IdDeptBalance { get; set; }

    public DateTime? EntryDate { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public DateTime? LogEntryDateTime { get; set; }
}
