using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;
using Microsoft.EntityFrameworkCore;

namespace NGIPF_BE.DAL.Entities;

[Table("td_emp_opening_balance", Schema = "ingipfund")]
public partial class TdEmpOpeningBalance1
{
    [Key]
    [Column("int_td_emp_open_bal_id")]
    [Precision(22, 0)]
    public decimal IntTdEmpOpenBalId { get; set; }

    [Column("int_tm_emp_open_bal_id")]
    [Precision(22, 0)]
    public decimal? IntTmEmpOpenBalId { get; set; }

    [Column("int_employee_id")]
    [Precision(22, 0)]
    public BigInteger? IntEmployeeId { get; set; }

    [Column("amount")]
    [Precision(22, 2)]
    public decimal? Amount { get; set; }

    [Column("remarks")]
    [StringLength(500)]
    public string? Remarks { get; set; }

    [Column("active_flag")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("dml_ststus_flag")]
    [Precision(22, 0)]
    public decimal? DmlStstusFlag { get; set; }

    [Column("created_user_id")]
    [Precision(22, 0)]
    public decimal? CreatedUserId { get; set; }

    [Column("created_date", TypeName = "timestamp(0) without time zone")]
    public DateTime? CreatedDate { get; set; }

    [Column("modified_user_id")]
    [Precision(22, 0)]
    public decimal? ModifiedUserId { get; set; }

    [Column("modified_date", TypeName = "timestamp(0) without time zone")]
    public DateTime? ModifiedDate { get; set; }

    [Column("status_flag")]
    [StringLength(2)]
    public string? StatusFlag { get; set; }

    [Column("checked_flag")]
    [StringLength(2)]
    public string? CheckedFlag { get; set; }

    [Column("sub_pre_office_type")]
    [StringLength(20)]
    public string? SubPreOfficeType { get; set; }

    [Column("sub_pre_office_id")]
    [Precision(22, 0)]
    public decimal? SubPreOfficeId { get; set; }

    [Column("emp_send_back")]
    [StringLength(5)]
    public string? EmpSendBack { get; set; }

    [Column("section_code")]
    [StringLength(25)]
    public string? SectionCode { get; set; }

    public virtual HrMmEmpBasicDtl? IntEmployee { get; set; }

    [ForeignKey("IntTmEmpOpenBalId")]
    [InverseProperty("TdEmpOpeningBalance1s")]
    public virtual TmEmpIntCalc? IntTmEmpOpenBal { get; set; }
}
