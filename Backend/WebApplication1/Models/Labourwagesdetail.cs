using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class Labourwagesdetail
{
    public int Id { get; set; }

    public int? Labourid { get; set; }

    public string? Accountno { get; set; }

    public string? BankIfsccode { get; set; }

    public int? Worktypeid { get; set; }

    public byte? Skilled { get; set; }

    public decimal? Wages { get; set; }

    public int? Workdays { get; set; }

    public decimal? Totalamount { get; set; }

    public long? Groupid { get; set; }

    public decimal? Billserialnumber { get; set; }

    public DateTime? Date { get; set; }

    public string? EntryBy { get; set; }

    public DateTime? FromDate { get; set; }

    public DateTime? ToDate { get; set; }

    public DateTime? Entrydate { get; set; }

    public byte? Isdelete { get; set; }

    public long? Newgroupid { get; set; }
}
