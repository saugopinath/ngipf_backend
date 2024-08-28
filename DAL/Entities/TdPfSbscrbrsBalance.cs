using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_frontend.DAL.Entities;

[Table("td_pf_sbscrbrs_balance", Schema = "ngipf")]
[Index("IntFinalPaymentId", Name = "idx_fk_gpf_sbscrbrs_balance2")]
[Index("IntEmployeeId", "CalenderYear", "CalenderMonth", "BalanceMonth", "DmlStatusFlag", Name = "td_pf_sbs_balance_idx1")]
public partial class TdPfSbscrbrsBalance
{
    [Key]
    [Column("int_balance_id")]
    [StringLength(38)]
    public string IntBalanceId { get; set; } = null!;

    [Column("fin_year_from")]
    public short? FinYearFrom { get; set; }

    [Column("int_employee_id")]
    [StringLength(38)]
    public string? IntEmployeeId { get; set; }

    [Column("balance_month")]
    public short? BalanceMonth { get; set; }

    [Column("calender_year")]
    public short? CalenderYear { get; set; }

    [Column("calender_month")]
    public short? CalenderMonth { get; set; }

    [Column("contribution_amount")]
    [Precision(14, 2)]
    public decimal? ContributionAmount { get; set; }

    [Column("interest_amt")]
    [Precision(14, 2)]
    public decimal? InterestAmt { get; set; }

    [Column("non_interest_amt")]
    [Precision(14, 2)]
    public decimal? NonInterestAmt { get; set; }

    [Column("debit_amount")]
    [Precision(14, 2)]
    public decimal? DebitAmount { get; set; }

    [Column("int_calc_amount")]
    [Precision(14, 2)]
    public decimal? IntCalcAmount { get; set; }

    [Column("interest_balance")]
    [Precision(14, 2)]
    public decimal? InterestBalance { get; set; }

    [Column("non_interest_balance")]
    [Precision(14, 2)]
    public decimal? NonInterestBalance { get; set; }

    [Column("balance_gen_source")]
    [MaxLength(1)]
    public char? BalanceGenSource { get; set; }

    [Column("dml_status_flag")]
    public short? DmlStatusFlag { get; set; }

    [Column("user_id")]
    public int? UserId { get; set; }

    [Column("created_timestamp", TypeName = "timestamp without time zone")]
    public DateTime? CreatedTimestamp { get; set; }

    [Column("modified_user_id")]
    public int? ModifiedUserId { get; set; }

    [Column("modified_timestamp", TypeName = "timestamp without time zone")]
    public DateTime? ModifiedTimestamp { get; set; }

    [Column("int_final_payment_id")]
    [StringLength(38)]
    public string? IntFinalPaymentId { get; set; }
}
