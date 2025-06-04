using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class Token
{
    public int Id { get; set; }

    public string? AccessToken { get; set; }

    public string? TokenType { get; set; }

    public DateTime? Issuedin { get; set; }

    public DateTime? Expiresin { get; set; }
}
