using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;
using Microsoft.EntityFrameworkCore;

namespace ngipf_backend.DAL.Entities;

[Table("td_emp_wise_remarks_dtls", Schema = "ingipfund")]
public partial class TdEmpWiseRemarksDtl
{
    [Key]
    [Column("int_td_emp_wise_remarks_dtls")]
    [Precision(22, 0)]
    public decimal IntTdEmpWiseRemarksDtls { get; set; }

    [Column("int_emp_primary_id")]
    [Precision(22, 0)]
    public decimal? IntEmpPrimaryId { get; set; }

    [Column("int_employee_id")]
    [Precision(22, 0)]
    public BigInteger? IntEmployeeId { get; set; }

    [Column("sequence_no")]
    [Precision(22, 0)]
    public decimal? SequenceNo { get; set; }

    [Column("functionality_abbr")]
    [StringLength(20)]
    public string? FunctionalityAbbr { get; set; }

    [Column("remarks")]
    [StringLength(400)]
    public string? Remarks { get; set; }

    [Column("created_user")]
    [Precision(22, 0)]
    public decimal? CreatedUser { get; set; }

    [Column("created_role")]
    [Precision(22, 0)]
    public decimal? CreatedRole { get; set; }

    [Column("created_date")]
    public DateOnly? CreatedDate { get; set; }

    [Column("dml_status_flag")]
    [Precision(22, 0)]
    public decimal? DmlStatusFlag { get; set; }

    public virtual HrMmEmpBasicDtl? IntEmployee { get; set; }
}
