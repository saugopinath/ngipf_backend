using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NGIPF_BE.DAL.Entities;

[Table("mm_gen_hrms_role_user_type_map", Schema = "master")]
public partial class MmGenHrmsRoleUserTypeMap
{
    [Key]
    [Column("int_role_user_type_map")]
    public short IntRoleUserTypeMap { get; set; }

    [Column("sub_system_id")]
    public short SubSystemId { get; set; }

    [Column("role_id")]
    public short RoleId { get; set; }

    [Column("int_level_id")]
    public short IntLevelId { get; set; }

    [Column("active_flag")]
    [StringLength(1)]
    public string ActiveFlag { get; set; } = null!;

    [Column("created_user_id")]
    public int CreatedUserId { get; set; }

    [Column("modified_user_id")]
    public int ModifiedUserId { get; set; }

    [Column("created_timestamp", TypeName = "timestamp(0) without time zone")]
    public DateTime CreatedTimestamp { get; set; }

    [Column("modified_timestamp", TypeName = "timestamp(0) without time zone")]
    public DateTime ModifiedTimestamp { get; set; }
}
