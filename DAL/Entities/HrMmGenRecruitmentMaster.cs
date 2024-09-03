using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_backend.DAL.Entities;

[Keyless]
[Table("hr_mm_gen_recruitment_master", Schema = "ihrms_master")]
public partial class HrMmGenRecruitmentMaster
{
    [Column("MASTER_ABBR")]
    [StringLength(10)]
    public string? MasterAbbr { get; set; }

    [Column("MASTER_DESCR")]
    [StringLength(50)]
    public string? MasterDescr { get; set; }

    [Column("MASTER_TYPE")]
    [StringLength(6)]
    public string? MasterType { get; set; }

    [Column("ACTIVE_FLAG")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("CREATED_TIMESTAMP")]
    public DateOnly CreatedTimestamp { get; set; }

    [Column("MODIFIED_TIMESTAMP")]
    public DateOnly ModifiedTimestamp { get; set; }

    [Column("INT_OTHER_MASTER_ID_old")]
    [StringLength(38)]
    public string? IntOtherMasterIdOld { get; set; }

    [Column("INT_OTHER_MASTER_ID")]
    public int? IntOtherMasterId { get; set; }

    [Column("CREATED_USER_ID_old")]
    [StringLength(38)]
    public string? CreatedUserIdOld { get; set; }

    [Column("CREATED_USER_ID")]
    public int? CreatedUserId { get; set; }

    [Column("MODIFIED_USER_ID_old")]
    [StringLength(38)]
    public string? ModifiedUserIdOld { get; set; }

    [Column("MODIFIED_USER_ID")]
    public int? ModifiedUserId { get; set; }
}
