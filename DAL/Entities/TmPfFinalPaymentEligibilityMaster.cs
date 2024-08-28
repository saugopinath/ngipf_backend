using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NGIPF_BE.DAL.Entities;

[Table("tm_pf_final_payment_eligibility_master", Schema = "ingipfund")]
public partial class TmPfFinalPaymentEligibilityMaster
{
    [Key]
    [Column("id")]
    [StringLength(38)]
    public string Id { get; set; } = null!;

    [Column("eligibility_month")]
    [StringLength(3)]
    public string? EligibilityMonth { get; set; }

    [Column("active_flag")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("dml_status_flag")]
    [StringLength(1)]
    public string? DmlStatusFlag { get; set; }

    [Column("created_timestamp")]
    public DateOnly? CreatedTimestamp { get; set; }

    [Column("created_userid")]
    [StringLength(10)]
    public string? CreatedUserid { get; set; }

    [Column("modified_timestamp")]
    public DateOnly? ModifiedTimestamp { get; set; }

    [Column("modified_userid")]
    [StringLength(10)]
    public string? ModifiedUserid { get; set; }

    [Column("hoa")]
    [StringLength(100)]
    public string? Hoa { get; set; }

    [Column("hoa_id")]
    public int? HoaId { get; set; }

    [Column("int_treasury_code")]
    [StringLength(20)]
    public string? IntTreasuryCode { get; set; }

    [Column("int_pl_op_id")]
    public int? IntPlOpId { get; set; }

    [ForeignKey("HoaId")]
    [InverseProperty("TmPfFinalPaymentEligibilityMasters")]
    public virtual MmGenHoa? HoaNavigation { get; set; }

    [ForeignKey("IntPlOpId")]
    [InverseProperty("TmPfFinalPaymentEligibilityMasters")]
    public virtual TMmGenPlOperator? IntPlOp { get; set; }

    public virtual MmGenTreasury? IntTreasuryCodeNavigation { get; set; }
}
