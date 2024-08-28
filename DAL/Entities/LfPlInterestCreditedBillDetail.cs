using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NGIPF_BE.DAL.Entities;

[Table("lf_pl_interest_credited_bill_details", Schema = "ngipf")]
public partial class LfPlInterestCreditedBillDetail
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("bill_no")]
    [StringLength(100)]
    public string? BillNo { get; set; }

    [Column("bill_amount")]
    public double? BillAmount { get; set; }

    [Column("amount_credited")]
    public double? AmountCredited { get; set; }

    [Column("voucher_number")]
    [StringLength(100)]
    public string? VoucherNumber { get; set; }

    [Column("voucher_date")]
    public DateOnly? VoucherDate { get; set; }

    [Column("int_bill_source")]
    public int? IntBillSource { get; set; }

    [ForeignKey("IntBillSource")]
    [InverseProperty("LfPlInterestCreditedBillDetails")]
    public virtual MmGenBillSource? IntBillSourceNavigation { get; set; }

    [InverseProperty("IntBillNoNavigation")]
    public virtual ICollection<LfPlOpInterestCreditedStatus> LfPlOpInterestCreditedStatuses { get; set; } = new List<LfPlOpInterestCreditedStatus>();
}
