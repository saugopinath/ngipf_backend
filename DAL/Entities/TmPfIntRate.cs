using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_backend.DAL.Entities;

[Keyless]
[Table("tm_pf_int_rate", Schema = "ngipf")]
[Index("VoucherMonth", "VoucherYear", Name = "uk_tm_gpf_int_rate", IsUnique = true)]
public partial class TmPfIntRate
{
    [Column("voucher_month")]
    public short? VoucherMonth { get; set; }

    [Column("voucher_year")]
    public short? VoucherYear { get; set; }

    [Column("int_rate")]
    [Precision(4, 2)]
    public decimal? IntRate { get; set; }
}
