using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class BankMaster
{
    public int BankCode { get; set; }

    public string? BankName { get; set; }

    public string? TypeOfBank { get; set; }

    public virtual ICollection<Ifscmaster> Ifscmasters { get; set; } = new List<Ifscmaster>();
}
