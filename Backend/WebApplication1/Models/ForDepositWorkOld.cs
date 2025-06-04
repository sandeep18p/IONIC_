using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class ForDepositWorkOld
{
    public string? Workname { get; set; }

    public string Workcode { get; set; } = null!;

    public string? Ddocode { get; set; }

    public string? Status { get; set; }
}
