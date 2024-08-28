using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NGIPF_BE.DAL.Entities;

[Keyless]
[Table("md_gen_user_subsystem_menu", Schema = "ifmsadmin")]
public partial class MdGenUserSubsystemMenu
{
    [Column("active_flag")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("created_timestamp")]
    public DateOnly CreatedTimestamp { get; set; }

    [Column("modified_timestamp")]
    public DateOnly ModifiedTimestamp { get; set; }

    [Column("app_url_flag")]
    [StringLength(1)]
    public string? AppUrlFlag { get; set; }

    [Column("user_id_old")]
    [StringLength(38)]
    public string? UserIdOld { get; set; }

    [Column("user_id")]
    public int? UserId { get; set; }

    [Column("sub_system_id_old")]
    [StringLength(38)]
    public string? SubSystemIdOld { get; set; }

    [Column("sub_system_id")]
    public int? SubSystemId { get; set; }

    [Column("menu_id_old")]
    [StringLength(38)]
    public string? MenuIdOld { get; set; }

    [Column("menu_id")]
    public int? MenuId { get; set; }

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

    [Column("role_id_old")]
    [StringLength(38)]
    public string? RoleIdOld { get; set; }

    [Column("role_id")]
    public int? RoleId { get; set; }
}
