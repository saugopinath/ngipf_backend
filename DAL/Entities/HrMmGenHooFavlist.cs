using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NGIPF_BE.DAL.Entities;

[Table("hr_mm_gen_hoo_favlist", Schema = "ihrms")]
public partial class HrMmGenHooFavlist
{
    [Key]
    [Column("int_favlist_id")]
    [StringLength(38)]
    public string IntFavlistId { get; set; } = null!;

    [Column("int_head_of_office_id")]
    [StringLength(38)]
    public string IntHeadOfOfficeId { get; set; } = null!;

    [Column("int_app_authority_id")]
    [StringLength(38)]
    public string IntAppAuthorityId { get; set; } = null!;

    [Column("int_dept_id")]
    public short? IntDeptId { get; set; }

    [Column("level_id")]
    public int? LevelId { get; set; }

    [Column("active_flag")]
    public short? ActiveFlag { get; set; }

    [Column("dml_status_flag")]
    public short DmlStatusFlag { get; set; }

    [Column("created_user_id")]
    public int CreatedUserId { get; set; }

    [Column("modified_user_id")]
    public int ModifiedUserId { get; set; }

    [Column("created_timestamp", TypeName = "timestamp(0) without time zone")]
    public DateTime CreatedTimestamp { get; set; }

    [Column("modified_timestamp", TypeName = "timestamp(0) without time zone")]
    public DateTime ModifiedTimestamp { get; set; }

    [Column("wef", TypeName = "timestamp(0) without time zone")]
    public DateTime? Wef { get; set; }

    [Column("approve_flag")]
    public double? ApproveFlag { get; set; }

    [Column("approve_by")]
    public double? ApproveBy { get; set; }

    [Column("approve_date", TypeName = "timestamp(0) without time zone")]
    public DateTime? ApproveDate { get; set; }

    [Column("demand_no")]
    [StringLength(2)]
    public string? DemandNo { get; set; }
}
