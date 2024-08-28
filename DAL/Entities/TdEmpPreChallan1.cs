using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;
using Microsoft.EntityFrameworkCore;

namespace ngipf_frontend.DAL.Entities;

[Table("td_emp_pre_challan", Schema = "ingipfund")]
public partial class TdEmpPreChallan1
{
    [Key]
    [Column("int_td_emp_pre_challan_id")]
    [Precision(22, 0)]
    public decimal IntTdEmpPreChallanId { get; set; }

    [Column("int_tm_pre_challan_id")]
    [Precision(22, 0)]
    public decimal? IntTmPreChallanId { get; set; }

    [Column("int_employee_id")]
    [Precision(22, 0)]
    public BigInteger? IntEmployeeId { get; set; }

    [Column("request_id")]
    [Precision(22, 0)]
    public decimal? RequestId { get; set; }

    [Column("debit_credit_flag")]
    [StringLength(6)]
    public string? DebitCreditFlag { get; set; }

    [Column("amount")]
    [Precision(22, 2)]
    public decimal? Amount { get; set; }

    [Column("salary_month")]
    [Precision(22, 0)]
    public decimal? SalaryMonth { get; set; }

    [Column("salary_year")]
    [Precision(22, 0)]
    public decimal? SalaryYear { get; set; }

    [Column("basic")]
    [Precision(22, 2)]
    public decimal? Basic { get; set; }

    [Column("voucher_number")]
    [StringLength(8)]
    public string? VoucherNumber { get; set; }

    [Column("voucher_date")]
    public DateOnly? VoucherDate { get; set; }

    [Column("challan_number")]
    [StringLength(8)]
    public string? ChallanNumber { get; set; }

    [Column("challan_date")]
    public DateOnly? ChallanDate { get; set; }

    [Column("arrear_from")]
    public DateOnly? ArrearFrom { get; set; }

    [Column("arrear_to")]
    public DateOnly? ArrearTo { get; set; }

    [Column("current_installment")]
    [Precision(22, 0)]
    public decimal? CurrentInstallment { get; set; }

    [Column("total_installment")]
    [Precision(22, 0)]
    public decimal? TotalInstallment { get; set; }

    [Column("active_flag")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("dml_status_flag")]
    [Precision(22, 0)]
    public decimal? DmlStatusFlag { get; set; }

    [Column("created_user")]
    [Precision(22, 0)]
    public decimal? CreatedUser { get; set; }

    [Column("created_timestamp", TypeName = "timestamp(0) without time zone")]
    public DateTime? CreatedTimestamp { get; set; }

    [Column("modified_user")]
    [Precision(22, 0)]
    public decimal? ModifiedUser { get; set; }

    [Column("modified_timestamp", TypeName = "timestamp(0) without time zone")]
    public DateTime? ModifiedTimestamp { get; set; }

    [Column("financial_year")]
    [Precision(22, 0)]
    public decimal? FinancialYear { get; set; }

    [Column("transaction_date")]
    public DateOnly? TransactionDate { get; set; }

    [Column("grade_pay")]
    [Precision(22, 2)]
    public decimal? GradePay { get; set; }

    [Column("transaction_type")]
    [StringLength(20)]
    public string? TransactionType { get; set; }

    public virtual HrMmEmpBasicDtl? IntEmployee { get; set; }

    [ForeignKey("IntTmPreChallanId")]
    [InverseProperty("TdEmpPreChallan1s")]
    public virtual TmPreChallan1? IntTmPreChallan { get; set; }
}
