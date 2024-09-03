using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;
using Microsoft.EntityFrameworkCore;

namespace ngipf_backend.DAL.Entities;

[Table("td_emp_int_calc_err_log", Schema = "ingipfund")]
public partial class TdEmpIntCalcErrLog
{
    [Key]
    [Column("int_td_emp_int_cal_id")]
    [Precision(22, 0)]
    public decimal IntTdEmpIntCalId { get; set; }

    [Column("int_tm_emp_int_cal_id")]
    [Precision(22, 0)]
    public decimal? IntTmEmpIntCalId { get; set; }

    [Column("int_employee_id")]
    [Precision(22, 0)]
    public BigInteger? IntEmployeeId { get; set; }

    [Column("error_no")]
    [Precision(22, 0)]
    public decimal? ErrorNo { get; set; }

    [Column("error_msg")]
    [StringLength(500)]
    public string? ErrorMsg { get; set; }

    [Column("created_user_id")]
    [Precision(22, 0)]
    public decimal? CreatedUserId { get; set; }

    [Column("created_timestamp")]
    public DateOnly? CreatedTimestamp { get; set; }

    [Column("int_td_emp_int_calc_dtls_id")]
    [Precision(22, 0)]
    public decimal? IntTdEmpIntCalcDtlsId { get; set; }

    public virtual HrMmEmpBasicDtl? IntEmployee { get; set; }

    [ForeignKey("IntTmEmpIntCalId")]
    [InverseProperty("TdEmpIntCalcErrLogs")]
    public virtual TmEmpIntCalc? IntTmEmpIntCal { get; set; }
}
