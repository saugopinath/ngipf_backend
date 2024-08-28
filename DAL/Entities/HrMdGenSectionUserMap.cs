using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_frontend.DAL.Entities;

[Keyless]
[Table("hr_md_gen_section_user_map", Schema = "ihrms_master")]
public partial class HrMdGenSectionUserMap
{
    [Column("ACTIVE_FLAG")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("LAST_UPDATED_ON", TypeName = "timestamp without time zone")]
    public DateTime LastUpdatedOn { get; set; }

    [Column("INT_SECTION_USER_MAP_ID_old")]
    [StringLength(38)]
    public string? IntSectionUserMapIdOld { get; set; }

    [Column("INT_SECTION_USER_MAP_ID")]
    public int? IntSectionUserMapId { get; set; }

    [Column("INT_SECTION_ID_old")]
    [StringLength(38)]
    public string? IntSectionIdOld { get; set; }

    [Column("INT_SECTION_ID")]
    public int? IntSectionId { get; set; }

    [Column("USER_ID_old")]
    [StringLength(38)]
    public string? UserIdOld { get; set; }

    [Column("USER_ID")]
    public int? UserId { get; set; }

    [Column("DML_STATUS_FLAG_old")]
    [StringLength(38)]
    public string? DmlStatusFlagOld { get; set; }

    [Column("DML_STATUS_FLAG")]
    public int? DmlStatusFlag { get; set; }

    [Column("LAST_UPDATED_BY_old")]
    [StringLength(38)]
    public string? LastUpdatedByOld { get; set; }

    [Column("LAST_UPDATED_BY")]
    public int? LastUpdatedBy { get; set; }
}
