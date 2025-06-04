using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class NotificationNotReceived
{
    public string? File { get; set; }

    public string? AckFileName { get; set; }

    public string? DnFilename { get; set; }
}
