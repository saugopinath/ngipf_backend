using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NGIPF_BE.DAL.Entities;

[Table("td_emp_pre_challan", Schema = "ngipf")]
public partial class TdEmpPreChallan
{
    [Key]
    [Column("int_td_emp_pre_challan_id")]
    [StringLength(38)]
    public string IntTdEmpPreChallanId { get; set; } = null!;

    [Column("int_tm_pre_challan_id")]
    [StringLength(38)]
    public string IntTmPreChallanId { get; set; } = null!;

    [Column("int_employee_id")]
    [StringLength(38)]
    public string IntEmployeeId { get; set; } = null!;

    [Column("request_id")]
    public long RequestId { get; set; }

    [Column("debit_credit_flag")]
    [StringLength(6)]
    public string DebitCreditFlag { get; set; } = null!;

    [Column("amount")]
    [Precision(20, 2)]
    public decimal Amount { get; set; }

    [Column("salary_month")]
    public short? SalaryMonth { get; set; }

    [Column("salary_year")]
    public short? SalaryYear { get; set; }

    [Column("basic")]
    [Precision(10, 2)]
    public decimal? Basic { get; set; }

    [Column("voucher_number")]
    [StringLength(8)]
    public string? VoucherNumber { get; set; }

    [Column("voucher_date", TypeName = "timestamp(0) without time zone")]
    public DateTime? VoucherDate { get; set; }

    [Column("challan_number")]
    [StringLength(8)]
    public string? ChallanNumber { get; set; }

    [Column("challan_date", TypeName = "timestamp(0) without time zone")]
    public DateTime? ChallanDate { get; set; }

    [Column("arrear_from", TypeName = "timestamp(0) without time zone")]
    public DateTime? ArrearFrom { get; set; }

    [Column("arrear_to", TypeName = "timestamp(0) without time zone")]
    public DateTime? ArrearTo { get; set; }

    [Column("current_installment")]
    public short? CurrentInstallment { get; set; }

    [Column("total_installment")]
    public short? TotalInstallment { get; set; }

    [Column("active_flag")]
    [StringLength(1)]
    public string ActiveFlag { get; set; } = null!;

    [Column("dml_status_flag")]
    public short DmlStatusFlag { get; set; }

    [Column("created_user")]
    public int CreatedUser { get; set; }

    [Column("created_timestamp", TypeName = "timestamp(6) without time zone")]
    public DateTime CreatedTimestamp { get; set; }

    [Column("modified_user")]
    public int? ModifiedUser { get; set; }

    [Column("modified_timestamp", TypeName = "timestamp(6) without time zone")]
    public DateTime? ModifiedTimestamp { get; set; }

    [Column("financial_year")]
    public short FinancialYear { get; set; }

    [Column("transaction_date", TypeName = "timestamp(0) without time zone")]
    public DateTime TransactionDate { get; set; }

    [Column("grade_pay")]
    [Precision(10, 2)]
    public decimal? GradePay { get; set; }

    [Column("transaction_type")]
    [StringLength(20)]
    public string TransactionType { get; set; } = null!;
}
