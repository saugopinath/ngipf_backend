using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_backend.DAL.Entities;

[Table("mm_pf_interest_bill_type", Schema = "ingipfund")]
public partial class MmPfInterestBillType
{
    [Key]
    [Column("interest_bill_type_id")]
    [Precision(22, 0)]
    public decimal InterestBillTypeId { get; set; }

    [Column("fin_year")]
    [Precision(22, 0)]
    public decimal? FinYear { get; set; }

    [Column("int_scheme_id")]
    public int? IntSchemeId { get; set; }

    [Column("int_treasury_code")]
    [StringLength(5)]
    public string? IntTreasuryCode { get; set; }

    [Column("int_pl_operator_id")]
    public int? IntPlOperatorId { get; set; }

    [Column("go_number")]
    [StringLength(100)]
    public string? GoNumber { get; set; }

    [Column("go_date")]
    public DateOnly? GoDate { get; set; }

    [Column("interest_bill_tye")]
    [StringLength(5)]
    public string? InterestBillTye { get; set; }

    [Column("active_flag")]
    [MaxLength(1)]
    public char? ActiveFlag { get; set; }

    [Column("dml_status_flag")]
    [Precision(22, 0)]
    public decimal? DmlStatusFlag { get; set; }

    [Column("created_user_id")]
    [Precision(22, 0)]
    public decimal? CreatedUserId { get; set; }

    [Column("created_date")]
    public DateOnly? CreatedDate { get; set; }

    [Column("modified_user_id")]
    [Precision(22, 0)]
    public decimal? ModifiedUserId { get; set; }

    [Column("modified_date")]
    public DateOnly? ModifiedDate { get; set; }

    [ForeignKey("IntPlOperatorId")]
    [InverseProperty("MmPfInterestBillTypes")]
    public virtual TMmGenPlOperator? IntPlOperator { get; set; }

    [ForeignKey("IntSchemeId")]
    [InverseProperty("MmPfInterestBillTypes")]
    public virtual MdGenSchemeHead? IntScheme { get; set; }

    public virtual MmGenTreasury? IntTreasuryCodeNavigation { get; set; }
}
