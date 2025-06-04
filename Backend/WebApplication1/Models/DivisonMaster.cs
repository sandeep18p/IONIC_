using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class DivisonMaster
{
    public int Id { get; set; }

    public string? DivisonName { get; set; }

    public int? CircleId { get; set; }

    public string? Ddocode { get; set; }

    public string? Pwd { get; set; }

    public string? PersonName { get; set; }

    public long? Mobileno { get; set; }

    public string? Emailid { get; set; }

    public bool IsFirstLogin { get; set; }

    public int? WingType { get; set; }
}
