using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class ForChequeEncashment
{
    public string Treasurycode { get; set; } = null!;

    public string Worktype { get; set; } = null!;

    public string? Workcode { get; set; }

    public string Ddocode { get; set; } = null!;

    public string Serialno { get; set; } = null!;

    public DateTime Paymentdate { get; set; }

    public string Series { get; set; } = null!;

    public string Chequeno { get; set; } = null!;

    public DateTime Chequedate { get; set; }

    public decimal Chequeamount { get; set; }

    public string Usercode { get; set; } = null!;

    public string Majorhead { get; set; } = null!;

    public string Submajorhead { get; set; } = null!;

    public string Minorhead { get; set; } = null!;

    public string FinYear { get; set; } = null!;

    public DateTime? Lastupdate { get; set; }
}
