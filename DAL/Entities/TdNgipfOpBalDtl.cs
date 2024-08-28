using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;
using Microsoft.EntityFrameworkCore;

namespace NGIPF_BE.DAL.Entities;

[PrimaryKey("FinYear", "IntTreasuryCode", "IntPlOperatorId", "SchemeId", "SancAuthOfficeId", "IntEmployeeId")]
[Table("td_ngipf_op_bal_dtls", Schema = "ingipfund")]
public partial class TdNgipfOpBalDtl
{
    [Key]
    [Column("fin_year")]
    [Precision(22, 0)]
    public decimal FinYear { get; set; }

    [Key]
    [Column("int_treasury_code")]
    [StringLength(5)]
    public string IntTreasuryCode { get; set; } = null!;

    [Key]
    [Column("int_pl_operator_id")]
    public int IntPlOperatorId { get; set; }

    [Key]
    [Column("scheme_id")]
    public int SchemeId { get; set; }

    [Key]
    [Column("sanc_auth_office_id")]
    [Precision(22, 0)]
    public decimal SancAuthOfficeId { get; set; }

    [Key]
    [Column("int_employee_id")]
    [Precision(22, 0)]
    public BigInteger IntEmployeeId { get; set; }

    [Column("opening_balance")]
    [Precision(22, 2)]
    public decimal? OpeningBalance { get; set; }

    [Column("deposit")]
    [Precision(22, 2)]
    public decimal? Deposit { get; set; }

    [Column("withdrawal")]
    [Precision(22, 2)]
    public decimal? Withdrawal { get; set; }

    [Column("interest")]
    [Precision(22, 2)]
    public decimal? Interest { get; set; }

    [Column("closing_balance")]
    [Precision(22, 2)]
    public decimal? ClosingBalance { get; set; }

    [Column("other_balance")]
    [Precision(22, 2)]
    public decimal? OtherBalance { get; set; }

    [Column("acceptance_date")]
    public DateOnly? AcceptanceDate { get; set; }

    [Column("active_flag")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("dml_status_flag")]
    [Precision(22, 0)]
    public decimal? DmlStatusFlag { get; set; }

    [Column("status")]
    [StringLength(100)]
    public string? Status { get; set; }

    [Column("subscriber_status")]
    [StringLength(5)]
    public string? SubscriberStatus { get; set; }

    public virtual HrMmEmpBasicDtl IntEmployee { get; set; } = null!;

    public virtual MmGenTreasury IntTreasuryCodeNavigation { get; set; } = null!;

    [ForeignKey("SchemeId")]
    [InverseProperty("TdNgipfOpBalDtls")]
    public virtual MdGenSchemeHead Scheme { get; set; } = null!;
}
