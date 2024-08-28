using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NGIPF_BE.DAL.Entities;

[Table("tm_pf_sbscrbrs_op_bal_dtls", Schema = "ngipf")]
[Index("PrevIntRequestId", Name = "uk_tm_gpf_sbscrbrs_op_bal_dtls", IsUnique = true)]
public partial class TmPfSbscrbrsOpBalDtl
{
    [Key]
    [Column("int_request_id")]
    [StringLength(38)]
    public string IntRequestId { get; set; } = null!;

    [Column("int_employee_id")]
    [StringLength(38)]
    public string? IntEmployeeId { get; set; }

    [Column("int_treasury_code")]
    [StringLength(5)]
    public string? IntTreasuryCode { get; set; }

    [Column("int_ddo_id")]
    public int? IntDdoId { get; set; }

    [Column("fin_year_from")]
    public short? FinYearFrom { get; set; }

    [Column("balance_month")]
    public short? BalanceMonth { get; set; }

    [Column("op_balance")]
    [Precision(14, 2)]
    public decimal? OpBalance { get; set; }

    [Column("interest_amt")]
    [Precision(14, 2)]
    public decimal? InterestAmt { get; set; }

    [Column("non_interest_amt")]
    [Precision(14, 2)]
    public decimal? NonInterestAmt { get; set; }

    [Column("cl_balance")]
    [Precision(14, 2)]
    public decimal? ClBalance { get; set; }

    [Column("approve_reject_flag")]
    [MaxLength(1)]
    public char? ApproveRejectFlag { get; set; }

    [Column("remarks")]
    [StringLength(200)]
    public string? Remarks { get; set; }

    [Column("int_balance_id")]
    [StringLength(38)]
    public string? IntBalanceId { get; set; }

    [Column("prev_int_request_id")]
    [StringLength(38)]
    public string? PrevIntRequestId { get; set; }

    [Column("bco_code")]
    [StringLength(20)]
    public string? BcoCode { get; set; }

    [Column("declare_flag")]
    [MaxLength(1)]
    public char? DeclareFlag { get; set; }

    [Column("dml_status_flag")]
    public short? DmlStatusFlag { get; set; }

    [Column("user_id")]
    public int? UserId { get; set; }

    [Column("created_timestamp", TypeName = "timestamp(0) without time zone")]
    public DateTime? CreatedTimestamp { get; set; }

    [Column("modified_user_id")]
    public int? ModifiedUserId { get; set; }

    [Column("modified_timestamp", TypeName = "timestamp(0) without time zone")]
    public DateTime? ModifiedTimestamp { get; set; }
}
