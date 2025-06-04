using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class TempLabourRepaymentDetail
{
    public int Id { get; set; }

    public string? Bcocode { get; set; }

    public string? Finyear { get; set; }

    public decimal? Billserialnumber { get; set; }

    public decimal? Oldbillserialnumber { get; set; }

    public string? Filename { get; set; }

    public string? Endtoendid { get; set; }

    public int? Userid { get; set; }

    public byte? Status { get; set; }

    public string? Remark { get; set; }

    public DateTime? Date { get; set; }
}
