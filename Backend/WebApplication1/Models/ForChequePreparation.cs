using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class ForChequePreparation
{
    public string? Ddocode { get; set; }

    public string FinYear { get; set; } = null!;

    public string? Month { get; set; }

    public string? Paymenttype { get; set; }

    public long Referenceno { get; set; }

    public string? Chequeno { get; set; }

    public DateTime? Chequedate { get; set; }

    public decimal? Chequeamount { get; set; }

    public long ChkPreId { get; set; }
}
