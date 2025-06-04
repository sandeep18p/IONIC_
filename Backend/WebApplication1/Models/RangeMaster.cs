using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class RangeMaster
{
    public int Id { get; set; }

    public string? RangeName { get; set; }

    public int? DivisonId { get; set; }

    public int? Circleid { get; set; }

    public int? SubdivisionId { get; set; }

    public string? IsDepo { get; set; }

    public string? UserId { get; set; }

    public string? Pwd { get; set; }

    public string? PersonName { get; set; }

    public long? Mobileno { get; set; }

    public string? Emailid { get; set; }

    public bool IsFirstLogin { get; set; }

    public int? WingType { get; set; }
}
