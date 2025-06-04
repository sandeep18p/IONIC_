using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class DdoDetail
{
    public int Id { get; set; }

    public string? Userid { get; set; }

    public int? UserTypeId { get; set; }

    public int? CircleId { get; set; }

    public int? RangeId { get; set; }

    public int? DivisionId { get; set; }

    public int? SubDivisionId { get; set; }
}
