using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_frontend.DAL.Entities;

[Keyless]
[Table("hr_mm_gen_component_map", Schema = "ihrms_master")]
public partial class HrMmGenComponentMap
{
    [Column("ACTIVE_FLAG")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("CREATED_TIMESTAMP")]
    public DateOnly CreatedTimestamp { get; set; }

    [Column("MODIFIED_TIMESTAMP")]
    public DateOnly ModifiedTimestamp { get; set; }

    [Column("INT_COMP_MAP_ID_old")]
    [StringLength(38)]
    public string? IntCompMapIdOld { get; set; }

    [Column("INT_COMP_MAP_ID")]
    public int? IntCompMapId { get; set; }

    [Column("INT_COMP_ID_old")]
    [StringLength(38)]
    public string? IntCompIdOld { get; set; }

    [Column("INT_COMP_ID")]
    public int? IntCompId { get; set; }

    [Column("INT_COMP_ID_MAPP_WITH_old")]
    [StringLength(38)]
    public string? IntCompIdMappWithOld { get; set; }

    [Column("INT_COMP_ID_MAPP_WITH")]
    public int? IntCompIdMappWith { get; set; }

    [Column("CREATED_USER_ID_old")]
    [StringLength(38)]
    public string? CreatedUserIdOld { get; set; }

    [Column("CREATED_USER_ID")]
    public int? CreatedUserId { get; set; }

    [Column("CREATED_ROLL_ID_old")]
    [StringLength(38)]
    public string? CreatedRollIdOld { get; set; }

    [Column("CREATED_ROLL_ID")]
    public int? CreatedRollId { get; set; }

    [Column("MODIFIED_USER_ID_old")]
    [StringLength(38)]
    public string? ModifiedUserIdOld { get; set; }

    [Column("MODIFIED_USER_ID")]
    public int? ModifiedUserId { get; set; }

    [Column("MODIFIED_ROLL_ID_old")]
    [StringLength(38)]
    public string? ModifiedRollIdOld { get; set; }

    [Column("MODIFIED_ROLL_ID")]
    public int? ModifiedRollId { get; set; }

    [Column("INT_DDO_ID_old")]
    [StringLength(38)]
    public string? IntDdoIdOld { get; set; }

    [Column("INT_DDO_ID")]
    public int? IntDdoId { get; set; }
}
