using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NGIPF_BE.DAL.Entities;

[Table("td_emp_opening_bal_remarks", Schema = "ingipfund")]
public partial class TdEmpOpeningBalRemark1
{
    [Column("created_date", TypeName = "timestamp(0) without time zone")]
    public DateTime? CreatedDate { get; set; }

    [Key]
    [Column("int_td_emp_open_bal_rem_id")]
    [Precision(22, 0)]
    public decimal IntTdEmpOpenBalRemId { get; set; }

    [Column("int_td_emp_open_bal_id")]
    [Precision(22, 0)]
    public decimal? IntTdEmpOpenBalId { get; set; }

    [Column("remarks")]
    [StringLength(500)]
    public string? Remarks { get; set; }

    [Column("dml_ststus_flag")]
    [Precision(22, 0)]
    public decimal? DmlStstusFlag { get; set; }

    [Column("created_user_id")]
    [Precision(22, 0)]
    public decimal? CreatedUserId { get; set; }

    [Column("created_role_id")]
    [Precision(22, 0)]
    public decimal? CreatedRoleId { get; set; }

    [ForeignKey("IntTdEmpOpenBalId")]
    [InverseProperty("TdEmpOpeningBalRemark1s")]
    public virtual TdEmpIntCalc? IntTdEmpOpenBal { get; set; }
}
