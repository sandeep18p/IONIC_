using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class VendorBankDetail
{
    public long Id { get; set; }

    public string? AccountHolderName { get; set; }

    public int? BankCode { get; set; }

    public string? BranchName { get; set; }

    public string? BankAccountNo { get; set; }

    public string? BankIfscCode { get; set; }

    public long? VendorId { get; set; }

    public byte? Active { get; set; }

    public string? UpdatedBy { get; set; }
}
