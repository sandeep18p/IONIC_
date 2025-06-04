using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class EKuberActivityLog
{
    public long Id { get; set; }

    public string? ServiceType { get; set; }

    public string? FileNo { get; set; }

    public string? FileType { get; set; }

    public string? PlacedBy { get; set; }

    public string? Folder { get; set; }

    public string? PickedBy { get; set; }

    public string? MovedTo { get; set; }

    public string? Message { get; set; }

    public string? Status { get; set; }

    public DateTime? EntryDate { get; set; }

    public string? FileContent { get; set; }
}
