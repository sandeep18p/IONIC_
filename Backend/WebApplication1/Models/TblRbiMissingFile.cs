using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class TblRbiMissingFile
{
    public long Id { get; set; }

    public string? DnFileName { get; set; }

    public string? RnFileName { get; set; }

    public string? AckFileName { get; set; }

    public long? BillserialNo { get; set; }
}
