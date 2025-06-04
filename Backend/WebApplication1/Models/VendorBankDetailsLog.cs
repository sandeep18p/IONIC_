using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class VendorBankDetailsLog
{
    public long? Id { get; set; }

    public string? AccountHolderName { get; set; }

    public int? BankCode { get; set; }

    public string? BranchName { get; set; }

    public string? BankAccountNo { get; set; }

    public string? BankIfscCode { get; set; }

    public long? VendorId { get; set; }

    public byte? Active { get; set; }

    public long Logid { get; set; }

    public string? Updatedby { get; set; }

    public DateTime? LogEntryDateTime { get; set; }
}
