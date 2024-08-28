using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NGIPF_BE.DAL.Entities;

[Table("emp_monthly_salary", Schema = "ngipf")]
[Index("NgipfId", Name = "ngipf_id_unique", IsUnique = true)]
public partial class EmpMonthlySalary
{
    [Column("drn_no")]
    [StringLength(15)]
    public string DrnNo { get; set; } = null!;

    [Column("treasury_code")]
    [StringLength(3)]
    public string TreasuryCode { get; set; } = null!;

    [Column("ddo_code")]
    [StringLength(9)]
    public string DdoCode { get; set; } = null!;

    [Column("op_treasury_code")]
    [StringLength(3)]
    public string OpTreasuryCode { get; set; } = null!;

    [Column("op_code")]
    [Precision(5, 0)]
    public decimal OpCode { get; set; }

    [Column("total_amount")]
    [Precision(18, 2)]
    public decimal TotalAmount { get; set; }

    [Column("iosms_id")]
    [StringLength(2)]
    public string IosmsId { get; set; } = null!;

    [Column("ngipf_id")]
    [StringLength(12)]
    public string NgipfId { get; set; } = null!;

    [Column("salary_month")]
    [Precision(2, 0)]
    public decimal? SalaryMonth { get; set; }

    [Column("salary_year")]
    [Precision(4, 0)]
    public decimal? SalaryYear { get; set; }

    [Column("basic_pay")]
    [Precision(14, 2)]
    public decimal? BasicPay { get; set; }

    [Column("grade_pay")]
    [Precision(14, 2)]
    public decimal? GradePay { get; set; }

    [Column("ropa")]
    [StringLength(50)]
    public string? Ropa { get; set; }

    [Column("employer_subscription")]
    [Precision(14, 2)]
    public decimal? EmployerSubscription { get; set; }

    [Column("regular_amount")]
    [Precision(14, 2)]
    public decimal RegularAmount { get; set; }

    [Column("total_installment")]
    [Precision(3, 0)]
    public decimal? TotalInstallment { get; set; }

    [Column("current_installment")]
    [Precision(3, 0)]
    public decimal? CurrentInstallment { get; set; }

    [Column("period_from")]
    public DateOnly? PeriodFrom { get; set; }

    [Column("period_to")]
    public DateOnly? PeriodTo { get; set; }

    [Column("arrear_amount")]
    [Precision(14, 2)]
    public decimal? ArrearAmount { get; set; }

    [Column("refund_amount")]
    [Precision(14, 2)]
    public decimal? RefundAmount { get; set; }

    [Column("emp_source")]
    public int? EmpSource { get; set; }

    [Key]
    [Column("id")]
    public long Id { get; set; }

    public virtual HrMmEmpBasicDtl? HrMmEmpBasicDtl { get; set; }
}
