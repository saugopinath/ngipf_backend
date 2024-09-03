using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_backend.DAL.Entities;

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

    [Column("created_by")]
    public int? CreatedBy { get; set; }

    [Column("last_updated_by")]
    public int? LastUpdatedBy { get; set; }

    [Column("deleted_by")]
    public int? DeletedBy { get; set; }

    [Column("created_at", TypeName = "timestamp without time zone")]
    public DateTime? CreatedAt { get; set; }

    [Column("last_updated_at", TypeName = "timestamp without time zone")]
    public DateTime? LastUpdatedAt { get; set; }

    [Column("deleted_at", TypeName = "timestamp without time zone")]
    public DateTime? DeletedAt { get; set; }

    [Column("active_flag")]
    [MaxLength(1)]
    public char? ActiveFlag { get; set; }

    [ForeignKey("IntBillSource")]
    [InverseProperty("LfPlInterestCreditedBillDetails")]
    public virtual BillSourceMst? IntBillSourceNavigation { get; set; }

    [InverseProperty("IntBillNoNavigation")]
    public virtual ICollection<LfPlOpInterestCreditedStatus> LfPlOpInterestCreditedStatuses { get; set; } = new List<LfPlOpInterestCreditedStatus>();
}
