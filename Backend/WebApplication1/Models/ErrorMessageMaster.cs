using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class ErrorMessageMaster
{
    public int Id { get; set; }

    public int? Code { get; set; }

    public string? Message { get; set; }
}
