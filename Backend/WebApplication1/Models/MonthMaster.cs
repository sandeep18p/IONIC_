using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class MonthMaster
{
    public int Id { get; set; }

    public string? MonthName { get; set; }

    public string? MonthCode { get; set; }
}
