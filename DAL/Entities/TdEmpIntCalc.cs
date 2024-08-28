using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;
using Microsoft.EntityFrameworkCore;

namespace ngipf_frontend.DAL.Entities;

[Table("td_emp_int_calc", Schema = "ingipfund")]
public partial class TdEmpIntCalc
{
    [Key]
    [Column("int_tm_emp_int_cal_id")]
    [Precision(22, 0)]
    public decimal IntTmEmpIntCalId { get; set; }

    [Column("int_employee_id")]
    [Precision(22, 0)]
    public BigInteger? IntEmployeeId { get; set; }

    [Column("voucher_int_year")]
    [Precision(22, 0)]
    public decimal? VoucherIntYear { get; set; }

    [Column("voucher_intr_month")]
    [Precision(22, 0)]
    public decimal? VoucherIntrMonth { get; set; }

    [Column("opening_balance")]
    [Precision(22, 0)]
    public decimal? OpeningBalance { get; set; }

    [Column("amt_bef_intday_unauth")]
    [Precision(22, 0)]
    public decimal? AmtBefIntdayUnauth { get; set; }

    [Column("amt_aft_intday")]
    [Precision(22, 0)]
    public decimal? AmtAftIntday { get; set; }

    [Column("amt_aft_intday_unauth")]
    [Precision(22, 0)]
    public decimal? AmtAftIntdayUnauth { get; set; }

    [Column("withdrawal")]
    [Precision(22, 0)]
    public decimal? Withdrawal { get; set; }

    [Column("interest_rate")]
    [Precision(22, 2)]
    public decimal? InterestRate { get; set; }

    [Column("interest")]
    [Precision(22, 2)]
    public decimal? Interest { get; set; }

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

    [Column("financial_year")]
    [Precision(22, 0)]
    public decimal? FinancialYear { get; set; }

    [Column("int_td_emp_int_cal_id")]
    [Precision(22, 0)]
    public decimal? IntTdEmpIntCalId { get; set; }

    public virtual HrMmEmpBasicDtl? IntEmployee { get; set; }

    [ForeignKey("IntTmEmpIntCalId")]
    [InverseProperty("TdEmpIntCalc")]
    public virtual TmEmpIntCalc IntTmEmpIntCal { get; set; } = null!;

    [InverseProperty("IntTdEmpOpenBal")]
    public virtual ICollection<TdEmpOpeningBalRemark1> TdEmpOpeningBalRemark1s { get; set; } = new List<TdEmpOpeningBalRemark1>();
}
