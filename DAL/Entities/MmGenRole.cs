using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NGIPF_BE.DAL.Entities;

[Keyless]
[Table("mm_gen_role", Schema = "ifmsadmin")]
public partial class MmGenRole
{
    [Column("role_desc")]
    [StringLength(100)]
    public string? RoleDesc { get; set; }

    [Column("active_flag")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("created_timestamp")]
    public DateOnly CreatedTimestamp { get; set; }

    [Column("modified_timestamp")]
    public DateOnly ModifiedTimestamp { get; set; }

    [Column("role_abbr")]
    [StringLength(10)]
    public string? RoleAbbr { get; set; }

    [Column("role_id_old")]
    [StringLength(38)]
    public string? RoleIdOld { get; set; }

    [Column("role_id")]
    public int? RoleId { get; set; }

    [Column("subsystem_id_old")]
    [StringLength(38)]
    public string? SubsystemIdOld { get; set; }

    [Column("subsystem_id")]
    public int? SubsystemId { get; set; }

    [Column("created_user_id_old")]
    [StringLength(38)]
    public string? CreatedUserIdOld { get; set; }

    [Column("created_user_id")]
    public int? CreatedUserId { get; set; }

    [Column("modified_user_id_old")]
    [StringLength(38)]
    public string? ModifiedUserIdOld { get; set; }

    [Column("modified_user_id")]
    public int? ModifiedUserId { get; set; }
}
