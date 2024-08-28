using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NGIPF_BE.DAL.Entities;

[Table("hr_md_gen_hoo_group_aud", Schema = "ihrms")]
public partial class HrMdGenHooGroupAud
{
    [Key]
    [Column("int_hr_md_gen_group_aud")]
    [StringLength(38)]
    public string IntHrMdGenGroupAud { get; set; } = null!;

    [Column("int_hr_md_gen_group")]
    [StringLength(38)]
    public string IntHrMdGenGroup { get; set; } = null!;

    [Column("int_head_of_office_id")]
    [StringLength(38)]
    public string IntHeadOfOfficeId { get; set; } = null!;

    [Column("group_name")]
    [StringLength(200)]
    public string GroupName { get; set; } = null!;

    [Column("group_code")]
    [StringLength(100)]
    public string GroupCode { get; set; } = null!;

    [Column("group_type")]
    [StringLength(38)]
    public string GroupType { get; set; } = null!;

    [Column("request_id")]
    public long RequestId { get; set; }

    [Column("active_flag")]
    [StringLength(1)]
    public string ActiveFlag { get; set; } = null!;

    [Column("wef", TypeName = "timestamp(0) without time zone")]
    public DateTime Wef { get; set; }

    [Column("dml_status_flag")]
    public short DmlStatusFlag { get; set; }

    [Column("last_updated_by")]
    public int LastUpdatedBy { get; set; }

    [Column("last_updated_on", TypeName = "timestamp(0) without time zone")]
    public DateTime LastUpdatedOn { get; set; }

    [Column("last_updated_role")]
    public int LastUpdatedRole { get; set; }

    [Column("approved_flag")]
    [StringLength(1)]
    public string ApprovedFlag { get; set; } = null!;

    [Column("created_time_stamp_aud", TypeName = "timestamp(6) without time zone")]
    public DateTime CreatedTimeStampAud { get; set; }
}
