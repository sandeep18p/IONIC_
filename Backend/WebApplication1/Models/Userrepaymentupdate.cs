using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class Userrepaymentupdate
{
    public int Id { get; set; }

    public long? BillSerialNo { get; set; }

    public string? FinYear { get; set; }

    /// <summary>
    /// 0 for pending, and 1 for approve and changed, 2 for denied
    /// </summary>
    public byte? Status { get; set; }

    public string? Requestuserid { get; set; }

    public string? Userid { get; set; }

    /// <summary>
    /// getdate()
    /// </summary>
    public DateTime? Date { get; set; }

    /// <summary>
    /// getdate()
    /// </summary>
    public DateTime? Lastupdateddate { get; set; }
}
