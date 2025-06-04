using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class BillPaymentFailedFilePayeeDetail
{
    public long Id { get; set; }

    public long? EndToEndId { get; set; }

    public string? PayeeId { get; set; }

    public string? Status { get; set; }

    public decimal? Ammount { get; set; }

    public long? NewEndToEndId { get; set; }

    public long? NewBillSerialNo { get; set; }
}
