using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NGIPF_BE.DAL.Entities;

[Keyless]
[Table("mm_gen_level_code", Schema = "ifmsadmin")]
public partial class MmGenLevelCode
{
    [Column("bco_code")]
    [StringLength(15)]
    public string? BcoCode { get; set; }

    [Column("next_level_bco_code")]
    [StringLength(15)]
    public string? NextLevelBcoCode { get; set; }

    [Column("description")]
    [StringLength(100)]
    public string? Description { get; set; }

    [Column("active_flag")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("created_timestamp")]
    public DateOnly CreatedTimestamp { get; set; }

    [Column("modified_timestamp")]
    public DateOnly ModifiedTimestamp { get; set; }

    [Column("tier_2")]
    [StringLength(1)]
    public string? Tier2 { get; set; }

    [Column("tier_3")]
    [StringLength(1)]
    public string? Tier3 { get; set; }

    [Column("tier_4")]
    [StringLength(1)]
    public string? Tier4 { get; set; }

    [Column("district_code")]
    [StringLength(8)]
    public string? DistrictCode { get; set; }

    [Column("int_level_id_old")]
    [StringLength(38)]
    public string? IntLevelIdOld { get; set; }

    [Column("int_level_id")]
    public int? IntLevelId { get; set; }

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

    [Column("dml_status_flag_old")]
    [StringLength(38)]
    public string? DmlStatusFlagOld { get; set; }

    [Column("dml_status_flag")]
    public int? DmlStatusFlag { get; set; }
}
