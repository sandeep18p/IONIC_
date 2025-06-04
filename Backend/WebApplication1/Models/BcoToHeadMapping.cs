using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class BcoToHeadMapping
{
    public int Id { get; set; }

    public long BcoCode { get; set; }

    public string Hoa { get; set; } = null!;
}
