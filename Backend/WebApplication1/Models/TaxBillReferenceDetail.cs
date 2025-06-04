using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class TaxBillReferenceDetail
{
    public long Id { get; set; }

    public int? Taxid { get; set; }

    public decimal? BillserialNo { get; set; }

    public decimal? OldbillserialNo { get; set; }

    public DateTime? Entrydate { get; set; }
}
