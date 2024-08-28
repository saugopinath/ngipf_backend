using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_frontend.DAL.Entities;

[Keyless]
[Table("pf_td_emp_plus_minus", Schema = "ngipf")]
[Index("IntEmployeeId", Name = "pf_td_emp_plus_minus_indx1")]
public partial class PfTdEmpPlusMinu
{
    [Column("fin_year_from")]
    public short? FinYearFrom { get; set; }

    [Column("int_employee_id")]
    [StringLength(38)]
    public string? IntEmployeeId { get; set; }

    [Column("op_balance")]
    [Precision(14, 2)]
    public decimal? OpBalance { get; set; }

    [Column("interest_amt")]
    [Precision(14, 2)]
    public decimal? InterestAmt { get; set; }

    [Column("cl_balance")]
    [Precision(14, 2)]
    public decimal? ClBalance { get; set; }

    [Column("final_payment_flag")]
    [StringLength(1)]
    public string? FinalPaymentFlag { get; set; }

    [Column("bill_gen_flag")]
    [StringLength(1)]
    public string? BillGenFlag { get; set; }

    [Column("cessation_flag")]
    [StringLength(1)]
    public string? CessationFlag { get; set; }

    [Column("workflow_status_flag")]
    [StringLength(2)]
    public string? WorkflowStatusFlag { get; set; }

    [Column("approve_reject_flag")]
    [StringLength(1)]
    public string? ApproveRejectFlag { get; set; }

    [Column("wages_flag")]
    [StringLength(1)]
    public string? WagesFlag { get; set; }

    [Column("more_then_12_subs")]
    [StringLength(1)]
    public string? MoreThen12Subs { get; set; }

    [Column("arrear_trans_flag")]
    [StringLength(1)]
    public string? ArrearTransFlag { get; set; }

    [Column("pay_rct_head_001")]
    [StringLength(1)]
    public string? PayRctHead001 { get; set; }

    [Column("unauthorised_subs_flag")]
    [StringLength(1)]
    public string? UnauthorisedSubsFlag { get; set; }

    [Column("negative_op_bal_flag")]
    [StringLength(1)]
    public string? NegativeOpBalFlag { get; set; }

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

    [Column("withdrawal_amount")]
    [Precision(14, 2)]
    public decimal? WithdrawalAmount { get; set; }

    [Column("deposit_amount")]
    [Precision(14, 2)]
    public decimal? DepositAmount { get; set; }

    [Column("office_code")]
    [StringLength(20)]
    public string? OfficeCode { get; set; }

    [Column("cessation_date", TypeName = "timestamp(0) without time zone")]
    public DateTime? CessationDate { get; set; }

    [Column("exclude_flag")]
    [StringLength(1)]
    public string? ExcludeFlag { get; set; }

    [Column("recovery")]
    [Precision(14, 2)]
    public decimal? Recovery { get; set; }

    [Column("arrear")]
    [Precision(14, 2)]
    public decimal? Arrear { get; set; }

    [Column("subscription_amt")]
    [Precision(14, 2)]
    public decimal? SubscriptionAmt { get; set; }

    [Column("wd_amt")]
    [Precision(14, 2)]
    public decimal? WdAmt { get; set; }

    [Column("basic")]
    [Precision(14, 2)]
    public decimal? Basic { get; set; }

    [Column("gp")]
    [Precision(14, 2)]
    public decimal? Gp { get; set; }

    [Column("int_amt")]
    [Precision(14, 2)]
    public decimal? IntAmt { get; set; }

    [Column("delay_in_drawal")]
    [StringLength(1)]
    public string? DelayInDrawal { get; set; }

    [Column("bill_gen_req")]
    [StringLength(1)]
    public string? BillGenReq { get; set; }

    [Column("adj_updt_flag")]
    [StringLength(2)]
    public string? AdjUpdtFlag { get; set; }

    [Column("prev_year_adj_amount")]
    public long? PrevYearAdjAmount { get; set; }

    [Column("prev_year_adj_int")]
    public long? PrevYearAdjInt { get; set; }

    [Column("prev_year_trbill_gen_flag")]
    [StringLength(2)]
    public string? PrevYearTrbillGenFlag { get; set; }

    [Column("prev_year_adjt_flag")]
    [StringLength(2)]
    public string? PrevYearAdjtFlag { get; set; }

    [Column("new_subscrb_flag")]
    [StringLength(2)]
    public string? NewSubscrbFlag { get; set; }
}
