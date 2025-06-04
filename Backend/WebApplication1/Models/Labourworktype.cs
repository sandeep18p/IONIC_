using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class Labourworktype
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public byte? Skilled { get; set; }
}
