using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NGIPF_BE.DAL.Entities;

[Table("hr_tm_sanc_strength_post", Schema = "ihrms")]
public partial class HrTmSancStrengthPost
{
    [Key]
    [Column("int_tm_sanction_post")]
    [StringLength(38)]
    public string IntTmSanctionPost { get; set; } = null!;

    [Column("p_int_dept_id")]
    public short PIntDeptId { get; set; }

    [Column("c_int_dept_id")]
    public short CIntDeptId { get; set; }

    [Column("int_hoo")]
    [StringLength(38)]
    public string? IntHoo { get; set; }

    [Column("int_srv_id")]
    [StringLength(38)]
    public string IntSrvId { get; set; } = null!;

    [Column("int_cadre_id")]
    [StringLength(38)]
    public string IntCadreId { get; set; } = null!;

    [Column("int_grp_id")]
    [StringLength(38)]
    public string IntGrpId { get; set; } = null!;

    [Column("int_post_id")]
    [StringLength(38)]
    public string IntPostId { get; set; } = null!;

    [Column("deputation_flag")]
    [StringLength(1)]
    public string DeputationFlag { get; set; } = null!;

    [Column("post_gradation")]
    [StringLength(100)]
    public string? PostGradation { get; set; }

    [Column("created_apt_auth_id")]
    [StringLength(38)]
    public string CreatedAptAuthId { get; set; } = null!;

    [Column("active_flag")]
    [StringLength(1)]
    public string ActiveFlag { get; set; } = null!;

    [Column("dml_status_flag")]
    public short DmlStatusFlag { get; set; }

    [Column("created_user_id")]
    public int CreatedUserId { get; set; }

    [Column("created_timestamp", TypeName = "timestamp(0) without time zone")]
    public DateTime CreatedTimestamp { get; set; }

    [Column("modified_user_id")]
    public int ModifiedUserId { get; set; }

    [Column("modified_timestamp", TypeName = "timestamp(0) without time zone")]
    public DateTime ModifiedTimestamp { get; set; }

    [Column("int_zone_code")]
    [StringLength(38)]
    public string? IntZoneCode { get; set; }
}
