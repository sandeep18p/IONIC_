using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class VendorMasterNew
{
    public long VendorId { get; set; }

    public string? TinNo { get; set; }

    public string? VendorName { get; set; }

    public string? Address { get; set; }

    public long? MobileNo { get; set; }

    public int? StateCode { get; set; }

    public int? DistrictCode { get; set; }

    public string? EmailId { get; set; }

    /// <summary>
    /// 1 for vendor , 2 for labour ,3 for Van Prabandhan Samiti, 4 for Hitgrahi (Malik Makbuja/Anya Yojana ka Anudan), 5 for Pratipurti, 6 for Vibhagiya Karyalaya Fund Transfer
    /// </summary>
    public byte? Usertype { get; set; }

    public byte? Skilled { get; set; }

    public decimal? Wages { get; set; }

    public DateTime? EntryDate { get; set; }

    public byte? Acitve { get; set; }

    /// <summary>
    /// 1 for TIN and 2 for PAN
    /// </summary>
    public byte? IsTinOrPan { get; set; }

    public string? FatherName { get; set; }

    public string? Caste { get; set; }

    /// <summary>
    /// 1 gen, 2 obc, 3 st, 4 sc
    /// </summary>
    public byte? CategoryId { get; set; }

    public string? EntryBy { get; set; }

    public string? SocityRegNo { get; set; }

    public string? Designation { get; set; }

    public string? Empcode { get; set; }

    public string? UpdatedBy { get; set; }
}
