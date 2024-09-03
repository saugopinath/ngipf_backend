using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;
using Microsoft.EntityFrameworkCore;

namespace ngipf_backend.DAL.Entities;

[Table("t_md_gen_remarks", Schema = "ingipfund")]
public partial class TMdGenRemark
{
    [Key]
    [Column("int_md_gen_remarks_id")]
    [Precision(22, 0)]
    public decimal IntMdGenRemarksId { get; set; }

    [Column("recomending_auth_code")]
    [StringLength(100)]
    public string? RecomendingAuthCode { get; set; }

    [Column("ess_int_employee_id")]
    [Precision(38, 0)]
    public BigInteger? EssIntEmployeeId { get; set; }

    [Column("request_id")]
    [StringLength(50)]
    public string? RequestId { get; set; }

    [Column("ng_table_name")]
    [StringLength(40)]
    public string? NgTableName { get; set; }

    [Column("process_name")]
    [StringLength(40)]
    public string? ProcessName { get; set; }

    [Column("int_business_pk")]
    [Precision(22, 0)]
    public decimal? IntBusinessPk { get; set; }

    [Column("remarks")]
    [StringLength(1000)]
    public string? Remarks { get; set; }

    [Column("dml_status_flag")]
    [Precision(22, 0)]
    public decimal? DmlStatusFlag { get; set; }

    [Column("created_user_id")]
    [Precision(22, 0)]
    public decimal? CreatedUserId { get; set; }

    [Column("created_role_id")]
    [Precision(22, 0)]
    public decimal? CreatedRoleId { get; set; }

    [Column("created_timestamp", TypeName = "timestamp(0) without time zone")]
    public DateTime? CreatedTimestamp { get; set; }

    [Column("modified_user_id")]
    [Precision(22, 0)]
    public decimal? ModifiedUserId { get; set; }

    [Column("modified_role_id")]
    [Precision(22, 0)]
    public decimal? ModifiedRoleId { get; set; }

    [Column("modified_timestamp", TypeName = "timestamp(0) without time zone")]
    public DateTime? ModifiedTimestamp { get; set; }

    [Column("sanctioning_auth_code")]
    [StringLength(100)]
    public string? SanctioningAuthCode { get; set; }

    public virtual HrMmEmpBasicDtl? EssIntEmployee { get; set; }
}
