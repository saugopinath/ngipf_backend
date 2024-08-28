using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;
using Microsoft.EntityFrameworkCore;

namespace ngipf_frontend.DAL.Entities;

[Table("mm_gen_ngipf_user", Schema = "ingipfund")]
public partial class MmGenNgipfUser
{
    [Key]
    [Column("int_gen_ngipf_user_id")]
    [Precision(38, 0)]
    public decimal IntGenNgipfUserId { get; set; }

    [Column("int_employee_id")]
    [Precision(38, 0)]
    public BigInteger? IntEmployeeId { get; set; }

    [Column("login_id")]
    [StringLength(100)]
    public string? LoginId { get; set; }

    [Column("role_id")]
    public short? RoleId { get; set; }

    [Column("request_id")]
    public long? RequestId { get; set; }

    [Column("workflow_status_flag")]
    [StringLength(2)]
    public string? WorkflowStatusFlag { get; set; }

    [Column("dml_status_flag")]
    public short? DmlStatusFlag { get; set; }

    [Column("created_user_id")]
    public short? CreatedUserId { get; set; }

    [Column("created_timestamp", TypeName = "timestamp(0) without time zone")]
    public DateTime? CreatedTimestamp { get; set; }

    [Column("modified_user_id")]
    public short? ModifiedUserId { get; set; }

    [Column("modified_timestamp", TypeName = "timestamp(0) without time zone")]
    public DateTime? ModifiedTimestamp { get; set; }

    [Column("pf_no")]
    [StringLength(100)]
    public string? PfNo { get; set; }

    [Column("sanc_code")]
    [Precision(38, 0)]
    public decimal? SancCode { get; set; }

    [Column("bco_code")]
    [StringLength(20)]
    public string? BcoCode { get; set; }

    public virtual HrMmEmpBasicDtl? IntEmployee { get; set; }
}
