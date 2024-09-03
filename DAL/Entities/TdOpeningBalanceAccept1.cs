using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_backend.DAL.Entities;

[Table("td_opening_balance_accept", Schema = "ingipfund")]
public partial class TdOpeningBalanceAccept1
{
    [Column("init_interest")]
    [Precision(22, 0)]
    public decimal? InitInterest { get; set; }

    [Key]
    [Column("int_td_opening_balance_accept")]
    [Precision(22, 0)]
    public decimal IntTdOpeningBalanceAccept { get; set; }

    [Column("int_pl_operator_id")]
    public int? IntPlOperatorId { get; set; }

    [Column("int_treasury_code")]
    [StringLength(6)]
    public string? IntTreasuryCode { get; set; }

    [Column("int_scheme_id")]
    public int? IntSchemeId { get; set; }

    [Column("financial_year")]
    [Precision(22, 0)]
    public decimal? FinancialYear { get; set; }

    [Column("balance_type")]
    [StringLength(2)]
    public string? BalanceType { get; set; }

    [Column("init_opening_balance")]
    [Precision(22, 0)]
    public decimal? InitOpeningBalance { get; set; }

    [Column("init_final_opening_balance")]
    [Precision(22, 0)]
    public decimal? InitFinalOpeningBalance { get; set; }

    [Column("total_deposit")]
    [Precision(22, 0)]
    public decimal? TotalDeposit { get; set; }

    [Column("total_withdrawal")]
    [Precision(22, 0)]
    public decimal? TotalWithdrawal { get; set; }

    [Column("closing_balance")]
    [Precision(22, 0)]
    public decimal? ClosingBalance { get; set; }

    [Column("final_interest")]
    [Precision(22, 0)]
    public decimal? FinalInterest { get; set; }

    [Column("final_opening_balance")]
    [Precision(22, 0)]
    public decimal? FinalOpeningBalance { get; set; }

    [Column("interest_calc_required")]
    [StringLength(1)]
    public string? InterestCalcRequired { get; set; }

    [Column("active_flag")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("dml_status_flag")]
    [Precision(22, 0)]
    public decimal? DmlStatusFlag { get; set; }

    [Column("subscriber_count")]
    [Precision(22, 0)]
    public decimal? SubscriberCount { get; set; }

    [ForeignKey("IntPlOperatorId")]
    [InverseProperty("TdOpeningBalanceAccept1s")]
    public virtual TMmGenPlOperator? IntPlOperator { get; set; }

    public virtual MmGenTreasury? IntTreasuryCodeNavigation { get; set; }
}
