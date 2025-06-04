using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class Labourworkdetail
{
    public int Id { get; set; }

    /// <summary>
    /// correlated with vendor master table column vendorid
    /// </summary>
    public int? Labourid { get; set; }

    public int? Workid { get; set; }

    public DateTime? Date { get; set; }
}
