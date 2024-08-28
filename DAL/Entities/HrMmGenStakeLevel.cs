using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_frontend.DAL.Entities;

[Keyless]
[Table("hr_mm_gen_stake_level", Schema = "ihrms_master")]
public partial class HrMmGenStakeLevel
{
    [Column("DESCRIPTION")]
    [StringLength(200)]
    public string? Description { get; set; }

    [Column("ACTIVE_FLAG")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("CREATED_TIMESTAMP")]
    public DateOnly? CreatedTimestamp { get; set; }

    [Column("MODIFY_TIMESTAMP")]
    public DateOnly? ModifyTimestamp { get; set; }

    [Column("LEVEL_ABBR")]
    [StringLength(5)]
    public string? LevelAbbr { get; set; }

    [Column("INT_LEVEL_ID_old")]
    [StringLength(38)]
    public string? IntLevelIdOld { get; set; }

    [Column("INT_LEVEL_ID")]
    public int? IntLevelId { get; set; }

    [Column("CURRENT_LEVEL_ID_old")]
    [StringLength(38)]
    public string? CurrentLevelIdOld { get; set; }

    [Column("CURRENT_LEVEL_ID")]
    public int? CurrentLevelId { get; set; }

    [Column("NEXT_LEVEL_ID_old")]
    [StringLength(38)]
    public string? NextLevelIdOld { get; set; }

    [Column("NEXT_LEVEL_ID")]
    public int? NextLevelId { get; set; }

    [Column("DML_STATUS_FLAG_old")]
    [StringLength(38)]
    public string? DmlStatusFlagOld { get; set; }

    [Column("DML_STATUS_FLAG")]
    public int? DmlStatusFlag { get; set; }

    [Column("CREATED_USERID_old")]
    [StringLength(38)]
    public string? CreatedUseridOld { get; set; }

    [Column("CREATED_USERID")]
    public int? CreatedUserid { get; set; }

    [Column("MODIFY_USERID_old")]
    [StringLength(38)]
    public string? ModifyUseridOld { get; set; }

    [Column("MODIFY_USERID")]
    public int? ModifyUserid { get; set; }
}
