using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_backend.DAL.Entities;

[Keyless]
[Table("tm_state_pf_balance", Schema = "ngipf")]
public partial class TmStatePfBalance
{
    [Column("fin_year")]
    public short? FinYear { get; set; }

    [Column("hoa_id")]
    [StringLength(25)]
    public string? HoaId { get; set; }

    [Column("number_of_subs")]
    public long? NumberOfSubs { get; set; }

    [Column("opening_balance")]
    [Precision(20, 0)]
    public decimal? OpeningBalance { get; set; }

    [Column("deposit")]
    [Precision(20, 0)]
    public decimal? Deposit { get; set; }

    [Column("withdrawal")]
    [Precision(20, 0)]
    public decimal? Withdrawal { get; set; }

    [Column("last_year_deposit")]
    [Precision(20, 0)]
    public decimal? LastYearDeposit { get; set; }

    [Column("last_year_withdrawal")]
    [Precision(20, 0)]
    public decimal? LastYearWithdrawal { get; set; }

    [Column("total_bal_curr_year")]
    [Precision(20, 0)]
    public decimal? TotalBalCurrYear { get; set; }

    [Column("total_bal_prev_year")]
    [Precision(20, 0)]
    public decimal? TotalBalPrevYear { get; set; }

    [Column("current_year_int")]
    public long? CurrentYearInt { get; set; }

    [Column("prev_year_int")]
    public long? PrevYearInt { get; set; }

    [Column("deposit_subs_no")]
    public long? DepositSubsNo { get; set; }

    [Column("withd_subs_no")]
    public long? WithdSubsNo { get; set; }

    [Column("int_subs_no")]
    public long? IntSubsNo { get; set; }
}
