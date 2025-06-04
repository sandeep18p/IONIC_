using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class ErrorLog
{
    public long Id { get; set; }

    public string? ErrorlineNo { get; set; }

    public string? Errormsg { get; set; }

    public string? Extype { get; set; }

    public string? Exurl { get; set; }

    public string? ErrorLocation { get; set; }

    public string? HostIp { get; set; }

    public string? HostAdd { get; set; }

    public string? UserId { get; set; }

    public string? StackTrace { get; set; }

    public string? InnerException { get; set; }

    public DateTime? EntryDate { get; set; }
}
