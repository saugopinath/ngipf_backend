using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_backend.DAL.Entities;

[PrimaryKey("UserId", "RoleId", "SubSystemId")]
[Table("md_gen_user_role", Schema = "ifmsadmin")]
public partial class MdGenUserRole
{
    [Column("active_flag")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("created_timestamp")]
    public DateOnly CreatedTimestamp { get; set; }

    [Column("modified_timestamp")]
    public DateOnly ModifiedTimestamp { get; set; }

    [Column("bco_code")]
    [StringLength(20)]
    public string? BcoCode { get; set; }

    [Column("office_code")]
    [StringLength(10)]
    public string? OfficeCode { get; set; }

    [Column("user_id_old")]
    [StringLength(38)]
    public string? UserIdOld { get; set; }

    [Key]
    [Column("user_id")]
    public int UserId { get; set; }

    [Column("role_id_old")]
    [StringLength(38)]
    public string? RoleIdOld { get; set; }

    [Key]
    [Column("role_id")]
    public int RoleId { get; set; }

    [Column("sub_system_id_old")]
    [StringLength(38)]
    public string? SubSystemIdOld { get; set; }

    [Key]
    [Column("sub_system_id")]
    public int SubSystemId { get; set; }

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

    [Column("int_level_id_old")]
    [StringLength(38)]
    public string? IntLevelIdOld { get; set; }

    [Column("int_level_id")]
    public int? IntLevelId { get; set; }
}
