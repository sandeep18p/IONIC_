using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class VendorMasterLog
{
    public long? VendorId { get; set; }

    public string? TinNo { get; set; }

    public string? VendorName { get; set; }

    public string? Address { get; set; }

    public long? MobileNo { get; set; }

    public int? StateCode { get; set; }

    public int? DistrictCode { get; set; }

    public string? EmailId { get; set; }

    public byte? Usertype { get; set; }

    public byte? Skilled { get; set; }

    public decimal? Wages { get; set; }

    public DateTime? EntryDate { get; set; }

    public byte? Acitve { get; set; }

    public byte? IsTinOrPan { get; set; }

    public string? FatherName { get; set; }

    public string? Caste { get; set; }

    public byte? CategoryId { get; set; }

    public string? Designation { get; set; }

    public string? Empcode { get; set; }

    public string? Updatedby { get; set; }

    public long Logid { get; set; }

    public DateTime? LogEntryDateTime { get; set; }
}
