using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class EKuberServiceCallLog
{
    public long Id { get; set; }

    public string? ServiceType { get; set; }

    public string? FunctionName { get; set; }

    public DateTime? ServiceCalledAt { get; set; }

    public int? TotalFileFound { get; set; }

    public int? TotalSent { get; set; }

    public int? TotalReceived { get; set; }

    public int? TotalFailed { get; set; }

    public string? Message { get; set; }

    public int? TotalDn { get; set; }

    public int? TotalRn { get; set; }

    public int? TotalAcst { get; set; }

    public int? TotalInack { get; set; }

    public int? TotalInnck { get; set; }

    public int? TotalEkoshAck { get; set; }
}
