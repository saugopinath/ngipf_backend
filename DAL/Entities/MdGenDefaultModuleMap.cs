using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NGIPF_BE.DAL.Entities;

[Table("md_gen_default_module_map", Schema = "master")]
[Index("MdGenModuleRoleMapId", "TargetSubsystemAbbr", "TargetUserTypeAbbr", "TargetRoleAbbr", "ActiveFlag", "DmlStatusFlag", Name = "uk_default_module_map_id_1", IsUnique = true)]
public partial class MdGenDefaultModuleMap
{
    [Key]
    [Column("md_gen_default_mod_map_id")]
    public short MdGenDefaultModMapId { get; set; }

    [Column("md_gen_module_role_map_id")]
    public short MdGenModuleRoleMapId { get; set; }

    [Column("target_subsystem_id")]
    public short? TargetSubsystemId { get; set; }

    [Column("target_user_type_id")]
    public short? TargetUserTypeId { get; set; }

    [Column("target_role_id")]
    public short? TargetRoleId { get; set; }

    [Column("remarks")]
    [StringLength(1000)]
    public string? Remarks { get; set; }

    [Column("active_flag")]
    [StringLength(2)]
    public string? ActiveFlag { get; set; }

    [Column("dml_status_flag")]
    public short? DmlStatusFlag { get; set; }

    [Column("created_timestamp", TypeName = "timestamp(0) without time zone")]
    public DateTime? CreatedTimestamp { get; set; }

    [Column("modify_timestamp", TypeName = "timestamp(0) without time zone")]
    public DateTime? ModifyTimestamp { get; set; }

    [Column("target_subsystem_abbr")]
    [StringLength(15)]
    public string? TargetSubsystemAbbr { get; set; }

    [Column("target_user_type_abbr")]
    [StringLength(15)]
    public string? TargetUserTypeAbbr { get; set; }

    [Column("target_role_abbr")]
    [StringLength(15)]
    public string? TargetRoleAbbr { get; set; }

    [ForeignKey("TargetSubsystemId")]
    [InverseProperty("MdGenDefaultModuleMaps")]
    public virtual MmGenSubsystem? TargetSubsystem { get; set; }
}
