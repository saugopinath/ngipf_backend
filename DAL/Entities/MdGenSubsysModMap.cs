using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NGIPF_BE.DAL.Entities;

[PrimaryKey("IntRfpSubsysId", "IntSubsystemId")]
[Table("md_gen_subsys_mod_map", Schema = "ifmsadmin")]
public partial class MdGenSubsysModMap
{
    [Column("rfp_subsys_desc")]
    [StringLength(100)]
    public string? RfpSubsysDesc { get; set; }

    [Column("active_flag")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("created_timestamp")]
    public DateOnly CreatedTimestamp { get; set; }

    [Column("modified_timestamp")]
    public DateOnly ModifiedTimestamp { get; set; }

    [Column("int_rfp_subsys_id_old")]
    [StringLength(38)]
    public string? IntRfpSubsysIdOld { get; set; }

    [Key]
    [Column("int_rfp_subsys_id")]
    public int IntRfpSubsysId { get; set; }

    [Column("int_subsystem_id_old")]
    [StringLength(38)]
    public string? IntSubsystemIdOld { get; set; }

    [Key]
    [Column("int_subsystem_id")]
    public int IntSubsystemId { get; set; }

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
