using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class SdoAndDfoDeptName
{
    public int Id { get; set; }

    public string? UserId { get; set; }

    public string? DeptName { get; set; }

    public DateTime? EntryDate { get; set; }
}
