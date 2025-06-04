using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class LoginMappingTable
{
    public int Id { get; set; }

    public int? DivisionId { get; set; }

    public string? DivisonName { get; set; }

    public int? SubdivisionId { get; set; }

    public string? Subdivisionname { get; set; }

    public int? RangeId { get; set; }

    public string? RangeName { get; set; }

    public string? Ddocode { get; set; }

    public string? Sdo { get; set; }

    public string? Ro { get; set; }
}
