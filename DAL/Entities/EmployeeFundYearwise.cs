using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NGIPF_BE.DAL.Entities;

[Keyless]
[Table("employee_fund_yearwise", Schema = "ngipf")]
public partial class EmployeeFundYearwise
{
    [Column("fin_year_from")]
    public double? FinYearFrom { get; set; }

    [Column("employee_no")]
    [StringLength(20)]
    public string? EmployeeNo { get; set; }

    [Column("int_employee_id")]
    [StringLength(38)]
    public string? IntEmployeeId { get; set; }

    [Column("opening_bal")]
    public double? OpeningBal { get; set; }

    [Column("total_subscription")]
    public double? TotalSubscription { get; set; }

    [Column("total_subscription_001_head")]
    public double? TotalSubscription001Head { get; set; }

    [Column("total_withdrawal")]
    public double? TotalWithdrawal { get; set; }

    [Column("total_interest")]
    public double? TotalInterest { get; set; }

    [Column("closing_bal")]
    public double? ClosingBal { get; set; }

    [Column("fp_withdrawal")]
    public double? FpWithdrawal { get; set; }

    [Column("sanction_id")]
    [StringLength(50)]
    public string? SanctionId { get; set; }

    [Column("sanction_date", TypeName = "timestamp(0) without time zone")]
    public DateTime? SanctionDate { get; set; }

    [Column("payment_authority_id")]
    [StringLength(50)]
    public string? PaymentAuthorityId { get; set; }

    [Column("payment_authority_date", TypeName = "timestamp(0) without time zone")]
    public DateTime? PaymentAuthorityDate { get; set; }

    [Column("ref_no")]
    public double? RefNo { get; set; }

    [Column("group_promotion_closing_bal")]
    public double? GroupPromotionClosingBal { get; set; }

    [Column("group_promotion_date", TypeName = "timestamp(0) without time zone")]
    public DateTime? GroupPromotionDate { get; set; }

    [Column("unauthorized_balance")]
    public double? UnauthorizedBalance { get; set; }
}
