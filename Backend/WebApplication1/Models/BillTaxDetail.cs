using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class BillTaxDetail
{
    public long Id { get; set; }

    public decimal? BillSerialNo { get; set; }

    public int? TaxId { get; set; }

    public decimal? Amount { get; set; }

    public DateTime? EntryDate { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public string? UpdateBy { get; set; }

    public bool? IsTaxPaid { get; set; }
}
