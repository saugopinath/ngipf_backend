using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_frontend.DAL.Entities;

/// <summary>
/// table containing ucm upload info the employees santion details
/// </summary>
[Table("pf_td_emp_sanction_upload", Schema = "ngipf")]
public partial class PfTdEmpSanctionUpload
{
    [Key]
    [Column("int_upload_id")]
    [StringLength(38)]
    public string IntUploadId { get; set; } = null!;

    [Column("request_id")]
    [StringLength(38)]
    public string RequestId { get; set; } = null!;

    [Column("int_employee_id")]
    [StringLength(38)]
    public string IntEmployeeId { get; set; } = null!;

    [Column("report_type")]
    [StringLength(20)]
    public string ReportType { get; set; } = null!;

    [Column("ucm_doc_id")]
    [StringLength(38)]
    public string UcmDocId { get; set; } = null!;

    [Column("ucm_content_id")]
    [StringLength(100)]
    public string UcmContentId { get; set; } = null!;

    [Column("doc_name")]
    [StringLength(100)]
    public string DocName { get; set; } = null!;

    [Column("doc_type")]
    [StringLength(20)]
    public string DocType { get; set; } = null!;

    [Column("remarks")]
    [StringLength(500)]
    public string? Remarks { get; set; }

    [Column("dml_status_flag")]
    public short DmlStatusFlag { get; set; }

    [Column("created_user_id")]
    public double CreatedUserId { get; set; }

    [Column("created_timestamp", TypeName = "timestamp(0) without time zone")]
    public DateTime CreatedTimestamp { get; set; }

    [Column("created_role_id")]
    public double CreatedRoleId { get; set; }

    [Column("modified_user_id")]
    public double ModifiedUserId { get; set; }

    [Column("modified_timestamp", TypeName = "timestamp(0) without time zone")]
    public DateTime ModifiedTimestamp { get; set; }

    [Column("modified_role_id")]
    public double ModifiedRoleId { get; set; }
}
