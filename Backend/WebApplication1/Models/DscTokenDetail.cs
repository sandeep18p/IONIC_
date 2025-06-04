using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class DscTokenDetail
{
    public int Id { get; set; }

    public string? UserId { get; set; }

    public bool? HasPrivateKey { get; set; }

    public string? Subject { get; set; }

    public string? IssuedBy { get; set; }

    public string? PublicKey { get; set; }

    public string? PublicKeyString { get; set; }

    public string? ValidFrom { get; set; }

    public string? ValidTo { get; set; }

    public string? SerialNumber { get; set; }

    public bool? IsVerified { get; set; }

    public bool? ValidForDigitalSign { get; set; }

    public string? CertificatePem { get; set; }

    public string? Role { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? DeactivateDate { get; set; }

    public DateTime? RegDate { get; set; }
}
