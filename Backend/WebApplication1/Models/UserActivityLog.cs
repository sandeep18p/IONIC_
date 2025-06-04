using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class UserActivityLog
{
    public int LogId { get; set; }

    public string Username { get; set; } = null!;

    public string ActionType { get; set; } = null!;

    public DateTime LogTimestamp { get; set; }

    public string? SessionId { get; set; }

    public string? Ipaddress { get; set; }

    public string? AdditionalInfo { get; set; }
}
