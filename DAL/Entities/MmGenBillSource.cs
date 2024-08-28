using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NGIPF_BE.DAL.Entities;

[Table("mm_gen_bill_source", Schema = "ngipf_master")]
public partial class MmGenBillSource
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("name")]
    [StringLength(50)]
    public string? Name { get; set; }

    [Column("status")]
    public short? Status { get; set; }

    [InverseProperty("IntBillSourceNavigation")]
    public virtual ICollection<LfPlInterestCreditedBillDetail> LfPlInterestCreditedBillDetails { get; set; } = new List<LfPlInterestCreditedBillDetail>();
}
