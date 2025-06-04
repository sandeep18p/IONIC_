using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class SubDivisionMasterNew
{
    public int Id { get; set; }

    public string? SubDivisionName { get; set; }

    public int? Cricleid { get; set; }

    public int? DivisionId { get; set; }

    public string? UserId { get; set; }

    public string? Pwd { get; set; }

    public string? PersonName { get; set; }

    public long? Mobileno { get; set; }

    public string? Emailid { get; set; }

    public bool IsFirstLogin { get; set; }

    public int? WingType { get; set; }
}
