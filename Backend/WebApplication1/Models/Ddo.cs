using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class Ddo
{
    public string Deptcode { get; set; } = null!;

    public string Ddocode { get; set; } = null!;

    public string Treasurycode { get; set; } = null!;

    public string? Type { get; set; }

    public string? Designation { get; set; }

    public string? Name1 { get; set; }

    public string? Name2 { get; set; }

    public DateTime? Openingdate { get; set; }

    public string? Referenceopen { get; set; }

    public DateTime Closingdate { get; set; }

    public string? Referenceclose { get; set; }

    public string Status { get; set; } = null!;

    public string? Authno { get; set; }

    public string? Pswd { get; set; }

    public string? Ddoregno { get; set; }

    public string? Dtoregno { get; set; }

    public string? Tanno { get; set; }

    public string? Subtreasurycode { get; set; }

    public string? Payrollddo { get; set; }

    public string Ifsccode { get; set; } = null!;

    public string Accountno { get; set; } = null!;

    public string Emailid { get; set; } = null!;

    public string Contactno { get; set; } = null!;

    public string Verifiedbyddo { get; set; } = null!;

    public string? Allow { get; set; }

    public string? DesignationLl { get; set; }

    public string? EduFlag { get; set; }

    public string? OldDdocode { get; set; }

    public string? InchargeDdo { get; set; }

    public string? Userid { get; set; }

    public string? Ipaddress { get; set; }

    public DateTime? Lastupdate { get; set; }

    public string? Verifiedbybank { get; set; }

    public DateTime? Verifieddate { get; set; }
}
