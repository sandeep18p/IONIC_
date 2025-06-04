using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class TaxMaster
{
    public int Id { get; set; }

    public string? TaxName { get; set; }

    public string? Hoa { get; set; }

    public byte? IsTax { get; set; }
}
