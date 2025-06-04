using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class ForChequeDeliveryLog
{
    public string? Ddocode { get; set; }

    public string? FinYear { get; set; }

    public string? Month { get; set; }

    public string Chequeno { get; set; } = null!;

    public DateTime? Chequedate { get; set; }

    public decimal? Chequeamount { get; set; }

    public string? Chequeinfavour { get; set; }

    public string? Wamount { get; set; }

    public string? Wamount1 { get; set; }

    public string? Chequestatus { get; set; }

    public DateTime? Encashmentdate { get; set; }

    public string? Ipaddress { get; set; }

    public DateTime? Lastupdate { get; set; }

    public long Logid { get; set; }

    public DateTime? LogEntryDateTime { get; set; }

    public long CkhDelvId { get; set; }
}
