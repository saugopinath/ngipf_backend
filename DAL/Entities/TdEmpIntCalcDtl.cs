using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;
using Microsoft.EntityFrameworkCore;

namespace ngipf_backend.DAL.Entities;

[Table("td_emp_int_calc_dtls", Schema = "ingipfund")]
public partial class TdEmpIntCalcDtl
{
    [Key]
    [Column("int_td_emp_int_calc_dtls_id")]
    [Precision(22, 0)]
    public decimal IntTdEmpIntCalcDtlsId { get; set; }

    [Column("int_tm_emp_int_cal_id")]
    [Precision(22, 0)]
    public decimal? IntTmEmpIntCalId { get; set; }

    [Column("int_employee_id")]
    [Precision(22, 0)]
    public BigInteger? IntEmployeeId { get; set; }

    [Column("job_id")]
    [Precision(22, 0)]
    public decimal? JobId { get; set; }

    [Column("calc_type")]
    [StringLength(2)]
    public string? CalcType { get; set; }

    [Column("fin_year")]
    [Precision(22, 0)]
    public decimal? FinYear { get; set; }

    [Column("upto_month")]
    [StringLength(3)]
    public string? UptoMonth { get; set; }

    [Column("int_scheme_id")]
    public int? IntSchemeId { get; set; }

    [Column("int_operator_id")]
    public int? IntOperatorId { get; set; }

    [Column("status")]
    [StringLength(2)]
    public string? Status { get; set; }

    [Column("start_time")]
    public DateOnly? StartTime { get; set; }

    [Column("end_time")]
    public DateOnly? EndTime { get; set; }

    [Column("dml_status_flag")]
    [Precision(22, 0)]
    public decimal? DmlStatusFlag { get; set; }

    [Column("emp_source")]
    [StringLength(1)]
    public string? EmpSource { get; set; }

    public virtual HrMmEmpBasicDtl? IntEmployee { get; set; }

    [ForeignKey("IntOperatorId")]
    [InverseProperty("TdEmpIntCalcDtls")]
    public virtual TMmGenPlOperator? IntOperator { get; set; }

    [ForeignKey("IntTmEmpIntCalId")]
    [InverseProperty("TdEmpIntCalcDtls")]
    public virtual TmEmpIntCalc? IntTmEmpIntCal { get; set; }
}
