using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class EKuberErrorLog
{
    public long Id { get; set; }

    public string PageName { get; set; } = null!;

    public string? MethodName { get; set; }

    public string? ErrorLineNo { get; set; }

    public string ErrorName { get; set; } = null!;

    public string? Userid { get; set; }

    public string? Ip { get; set; }

    public DateTime? EntryDate { get; set; }
}
