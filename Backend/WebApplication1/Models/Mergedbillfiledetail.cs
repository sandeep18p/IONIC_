using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class Mergedbillfiledetail
{
    public int Id { get; set; }

    public string? Msgtype { get; set; }

    public decimal? MsgId { get; set; }

    public string? FinYear { get; set; }

    public decimal? BillSerialNo { get; set; }

    public decimal? BillSerialNoDetail { get; set; }

    public string? FileStatus { get; set; }

    public string? EntryBy { get; set; }

    public DateTime? EntrydDate { get; set; }

    public byte? Status { get; set; }

    public DateTime? LastUpdatedDate { get; set; }
}
