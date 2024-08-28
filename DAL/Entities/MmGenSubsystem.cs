using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_frontend.DAL.Entities;

[Keyless]
[Table("mm_gen_subsystem", Schema = "ifmsadmin")]
public partial class MmGenSubsystem
{
    [Column("subsystem_desc")]
    [StringLength(200)]
    public string? SubsystemDesc { get; set; }

    [Column("active_flag")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("created_timestamp")]
    public DateOnly CreatedTimestamp { get; set; }

    [Column("modified_timestamp")]
    public DateOnly ModifiedTimestamp { get; set; }

    [Column("sub_system_url")]
    [StringLength(200)]
    public string? SubSystemUrl { get; set; }

    [Column("sub_system_initial")]
    [StringLength(2)]
    public string? SubSystemInitial { get; set; }

    [Column("sub_system_abbr")]
    [StringLength(15)]
    public string? SubSystemAbbr { get; set; }

    [Column("sub_system_description")]
    [StringLength(4000)]
    public string? SubSystemDescription { get; set; }

    [Column("sub_system_icon_id")]
    [StringLength(50)]
    public string? SubSystemIconId { get; set; }

    [Column("additional_data")]
    [StringLength(4000)]
    public string? AdditionalData { get; set; }

    [Column("dsc_flag")]
    [StringLength(2)]
    public string? DscFlag { get; set; }

    [Column("sub_system_id_old")]
    [StringLength(38)]
    public string? SubSystemIdOld { get; set; }

    [Column("sub_system_id")]
    public int? SubSystemId { get; set; }

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
