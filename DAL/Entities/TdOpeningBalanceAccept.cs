using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NGIPF_BE.DAL.Entities;

[Table("td_opening_balance_accept", Schema = "ngipf")]
public partial class TdOpeningBalanceAccept
{
    [Key]
    [Column("int_td_opening_balance_accept")]
    [StringLength(38)]
    public string IntTdOpeningBalanceAccept { get; set; } = null!;

    [Column("int_pl_operator_id")]
    [Precision(20, 0)]
    public decimal IntPlOperatorId { get; set; }

    [Column("int_treasury_code")]
    [StringLength(6)]
    public string IntTreasuryCode { get; set; } = null!;

    [Column("int_scheme_id")]
    public long? IntSchemeId { get; set; }

    [Column("financial_year")]
    public short FinancialYear { get; set; }

    /// <summary>
    /// pb= passbook balance, cb= captured balance
    /// </summary>
    [Column("balance_type")]
    [StringLength(2)]
    public string BalanceType { get; set; } = null!;

    [Column("init_opening_balance")]
    [Precision(20, 0)]
    public decimal? InitOpeningBalance { get; set; }

    [Column("init_interest")]
    [Precision(20, 0)]
    public decimal? InitInterest { get; set; }

    [Column("init_final_opening_balance")]
    [Precision(20, 0)]
    public decimal? InitFinalOpeningBalance { get; set; }

    [Column("total_deposit")]
    [Precision(20, 0)]
    public decimal? TotalDeposit { get; set; }

    [Column("total_withdrawal")]
    [Precision(20, 0)]
    public decimal? TotalWithdrawal { get; set; }

    [Column("closing_balance")]
    [Precision(20, 0)]
    public decimal? ClosingBalance { get; set; }

    [Column("final_interest")]
    [Precision(20, 0)]
    public decimal? FinalInterest { get; set; }

    [Column("final_opening_balance")]
    [Precision(20, 0)]
    public decimal? FinalOpeningBalance { get; set; }

    /// <summary>
    /// y/n
    /// </summary>
    [Column("interest_calc_required")]
    [StringLength(1)]
    public string InterestCalcRequired { get; set; } = null!;

    [Column("active_flag")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("dml_status_flag")]
    public short? DmlStatusFlag { get; set; }

    [Column("subscriber_count")]
    [Precision(20, 0)]
    public decimal? SubscriberCount { get; set; }
}
