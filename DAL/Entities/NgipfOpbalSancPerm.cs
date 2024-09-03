using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_backend.DAL.Entities;

[Table("ngipf_opbal_sanc_perm", Schema = "ingipfund")]
public partial class NgipfOpbalSancPerm
{
    [Key]
    [Column("int_perm_id")]
    [Precision(22, 0)]
    public decimal IntPermId { get; set; }

    [Column("int_op_code")]
    public int? IntOpCode { get; set; }

    [Column("remarks")]
    [StringLength(1000)]
    public string? Remarks { get; set; }

    [Column("dml_status_flag")]
    [Precision(22, 0)]
    public decimal? DmlStatusFlag { get; set; }

    [Column("created_user_id")]
    [Precision(22, 0)]
    public decimal? CreatedUserId { get; set; }

    [Column("created_timestamp")]
    public DateOnly? CreatedTimestamp { get; set; }

    [Column("modified_user_id")]
    [Precision(22, 0)]
    public decimal? ModifiedUserId { get; set; }

    [Column("modified_timestamp")]
    public DateOnly? ModifiedTimestamp { get; set; }

    [Column("scheme_code")]
    [Precision(22, 0)]
    public decimal? SchemeCode { get; set; }

    [Column("int_treasury_code")]
    [StringLength(5)]
    public string? IntTreasuryCode { get; set; }

    [Column("created_role_id")]
    [Precision(22, 0)]
    public decimal? CreatedRoleId { get; set; }

    [Column("financial_year")]
    [Precision(22, 0)]
    public decimal? FinancialYear { get; set; }

    [Column("sanc_auth_id")]
    [StringLength(38)]
    public string? SancAuthId { get; set; }

    [Column("request_id")]
    [Precision(22, 0)]
    public decimal? RequestId { get; set; }

    [ForeignKey("IntOpCode")]
    [InverseProperty("NgipfOpbalSancPerms")]
    public virtual TMmGenPlOperator? IntOpCodeNavigation { get; set; }
}
