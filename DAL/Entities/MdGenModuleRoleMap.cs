using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_backend.DAL.Entities;

[Table("md_gen_module_role_map", Schema = "ifmsadmin")]
[Index("MdGenModuleRoleMapId", "TargetSubsystemAbbr", "TargetUserTypeAbbr", "TargetRoleAbbr", "ActiveFlag", "DmlStatusFlag", Name = "md_gen_module_role_map_md_gen_module_role_map_id_target_sub_key", IsUnique = true)]
public partial class MdGenModuleRoleMap
{
    [Column("own_flag")]
    [StringLength(4)]
    public string? OwnFlag { get; set; }

    [Column("remarks")]
    [StringLength(1000)]
    public string? Remarks { get; set; }

    [Column("active_flag")]
    [StringLength(2)]
    public string? ActiveFlag { get; set; }

    [Column("created_timestamp")]
    public DateOnly? CreatedTimestamp { get; set; }

    [Column("modify_timestamp")]
    public DateOnly? ModifyTimestamp { get; set; }

    [Column("loggedin_subsystem_abbr")]
    [StringLength(15)]
    public string? LoggedinSubsystemAbbr { get; set; }

    [Column("loggedin_role_abbr")]
    [StringLength(15)]
    public string? LoggedinRoleAbbr { get; set; }

    [Column("target_subsystem_abbr")]
    [StringLength(15)]
    public string? TargetSubsystemAbbr { get; set; }

    [Column("target_user_type_abbr")]
    [StringLength(15)]
    public string? TargetUserTypeAbbr { get; set; }

    [Column("target_role_abbr")]
    [StringLength(15)]
    public string? TargetRoleAbbr { get; set; }

    [Column("loggedin_super_user_flag")]
    [StringLength(15)]
    public string? LoggedinSuperUserFlag { get; set; }

    [Column("loggedin_user_type")]
    [StringLength(15)]
    public string? LoggedinUserType { get; set; }

    [Column("target_admin_superuser_flag")]
    [StringLength(15)]
    public string? TargetAdminSuperuserFlag { get; set; }

    [Column("loggedin_mother_user_flag")]
    [StringLength(15)]
    public string? LoggedinMotherUserFlag { get; set; }

    [Column("super_other_flag")]
    [StringLength(15)]
    public string? SuperOtherFlag { get; set; }

    [Column("loggedin_dept_super_user_flag")]
    [StringLength(15)]
    public string? LoggedinDeptSuperUserFlag { get; set; }

    [Column("default_module_flag")]
    [StringLength(5)]
    public string? DefaultModuleFlag { get; set; }

    [Column("md_gen_module_role_map_id_old")]
    [StringLength(38)]
    public string? MdGenModuleRoleMapIdOld { get; set; }

    [Column("loggedin_subsystem_id_old")]
    [StringLength(38)]
    public string? LoggedinSubsystemIdOld { get; set; }

    [Column("loggedin_subsystem_id")]
    public int? LoggedinSubsystemId { get; set; }

    [Column("loggedin_role_id_old")]
    [StringLength(38)]
    public string? LoggedinRoleIdOld { get; set; }

    [Column("loggedin_role_id")]
    public int? LoggedinRoleId { get; set; }

    [Column("target_subsystem_id_old")]
    [StringLength(38)]
    public string? TargetSubsystemIdOld { get; set; }

    [Column("target_subsystem_id")]
    public int? TargetSubsystemId { get; set; }

    [Column("target_user_type_id_old")]
    [StringLength(38)]
    public string? TargetUserTypeIdOld { get; set; }

    [Column("target_user_type_id")]
    public int? TargetUserTypeId { get; set; }

    [Column("target_role_id_old")]
    [StringLength(38)]
    public string? TargetRoleIdOld { get; set; }

    [Column("target_role_id")]
    public int? TargetRoleId { get; set; }

    [Column("dml_status_flag_old")]
    [StringLength(38)]
    public string? DmlStatusFlagOld { get; set; }

    [Column("dml_status_flag")]
    public int? DmlStatusFlag { get; set; }

    [Key]
    [Column("md_gen_module_role_map_id")]
    public int MdGenModuleRoleMapId { get; set; }
}
