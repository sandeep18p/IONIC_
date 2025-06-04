using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class LocLogin
{
    public string Deptcode { get; set; } = null!;

    public string Ddocode { get; set; } = null!;

    public string? Pswd { get; set; }

    public string? Status { get; set; }

    public string? EncPswd { get; set; }

    /// <summary>
    /// 1 for DFO , 2 for RO
    /// </summary>
    public string? UserType { get; set; }

    public long Id { get; set; }

    public string? Authority { get; set; }

    public string? AuthorityName { get; set; }
}
