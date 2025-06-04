using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class WingMaster
{
    public int Id { get; set; }

    public int? WingId { get; set; }

    public string? WingName { get; set; }
}
