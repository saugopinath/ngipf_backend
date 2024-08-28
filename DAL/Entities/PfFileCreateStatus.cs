using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_frontend.DAL.Entities;

[Table("pf_file_create_status", Schema = "ingipfund")]
public partial class PfFileCreateStatus
{
    [Key]
    [Column("ucm_ref_id")]
    [StringLength(50)]
    public string UcmRefId { get; set; } = null!;

    [Column("ucm_doc_id")]
    [Precision(38, 0)]
    public decimal? UcmDocId { get; set; }

    [Column("ucm_file_type")]
    [StringLength(10)]
    public string? UcmFileType { get; set; }

    [Column("ucm_file_name")]
    [StringLength(500)]
    public string? UcmFileName { get; set; }

    [Column("filesize")]
    [Precision(38, 0)]
    public decimal? Filesize { get; set; }

    [Column("active_flag")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("user_id")]
    [StringLength(20)]
    public string? UserId { get; set; }

    [Column("created_timestamp")]
    public DateOnly? CreatedTimestamp { get; set; }

    [Column("request_id")]
    [StringLength(38)]
    public string? RequestId { get; set; }

    [Column("request_type")]
    [StringLength(38)]
    public string? RequestType { get; set; }

    [Column("pf_file_create_status_id")]
    [StringLength(38)]
    public string? PfFileCreateStatusId { get; set; }

    [Column("dml_status_flag")]
    [StringLength(1)]
    public string? DmlStatusFlag { get; set; }

    [Column("gen_uploaded_time")]
    [StringLength(50)]
    public string? GenUploadedTime { get; set; }
}
