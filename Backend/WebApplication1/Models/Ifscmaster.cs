using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class Ifscmaster
{
    public int Id { get; set; }

    public int BankCode { get; set; }

    public string? Ifsc { get; set; }

    public string? BranchName { get; set; }

    public virtual BankMaster BankCodeNavigation { get; set; } = null!;
}
