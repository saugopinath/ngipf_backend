using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NGIPF_BE.DAL.Entities;

[Table("ngipf_opbal_per_negative", Schema = "ingipfund")]
public partial class NgipfOpbalPerNegative
{
    [Key]
    [Column("int_bal_id")]
    [Precision(22, 0)]
    public decimal IntBalId { get; set; }

    [Column("int_op_code")]
    public int? IntOpCode { get; set; }

    [Column("activity_date")]
    public DateOnly? ActivityDate { get; set; }

    [Column("activity_done_by_user_id")]
    [Precision(22, 0)]
    public decimal? ActivityDoneByUserId { get; set; }

    [Column("remarks")]
    [StringLength(1000)]
    public string? Remarks { get; set; }

    [Column("unsettled_amount")]
    [Precision(22, 0)]
    public decimal? UnsettledAmount { get; set; }

    [Column("dml_status_flag")]
    [Precision(22, 0)]
    public decimal? DmlStatusFlag { get; set; }

    [Column("user_id")]
    [Precision(22, 0)]
    public decimal? UserId { get; set; }

    [Column("created_timestamp")]
    public DateOnly? CreatedTimestamp { get; set; }

    [Column("modified_user_id")]
    [Precision(22, 0)]
    public decimal? ModifiedUserId { get; set; }

    [Column("modified_timestamp")]
    public DateOnly? ModifiedTimestamp { get; set; }

    [Column("scheme_code")]
    public int? SchemeCode { get; set; }

    [Column("int_treasury_code")]
    [StringLength(5)]
    public string? IntTreasuryCode { get; set; }

    [ForeignKey("IntOpCode")]
    [InverseProperty("NgipfOpbalPerNegatives")]
    public virtual TMmGenPlOperator? IntOpCodeNavigation { get; set; }

    public virtual MmGenTreasury? IntTreasuryCodeNavigation { get; set; }

    [ForeignKey("SchemeCode")]
    [InverseProperty("NgipfOpbalPerNegatives")]
    public virtual MdGenSchemeHead? SchemeCodeNavigation { get; set; }
}
