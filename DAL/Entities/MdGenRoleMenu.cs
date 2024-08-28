using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NGIPF_BE.DAL.Entities;

[PrimaryKey("RoleId", "MenuId")]
[Table("md_gen_role_menu", Schema = "ifmsadmin")]
public partial class MdGenRoleMenu
{
    [Column("active_flag")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("created_timestamp")]
    public DateOnly CreatedTimestamp { get; set; }

    [Column("modifed_timestamp")]
    public DateOnly ModifedTimestamp { get; set; }

    [Column("activity_status")]
    [StringLength(1)]
    public string? ActivityStatus { get; set; }

    [Column("role_id_old")]
    [StringLength(38)]
    public string? RoleIdOld { get; set; }

    [Key]
    [Column("role_id")]
    public int RoleId { get; set; }

    [Column("menu_id_old")]
    [StringLength(38)]
    public string? MenuIdOld { get; set; }

    [Key]
    [Column("menu_id")]
    public int MenuId { get; set; }

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
