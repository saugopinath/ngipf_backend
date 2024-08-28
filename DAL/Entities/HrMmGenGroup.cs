using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NGIPF_BE.DAL.Entities;

[Keyless]
[Table("hr_mm_gen_group", Schema = "ihrms_master")]
public partial class HrMmGenGroup
{
    [Column("GROUP_CODE")]
    [StringLength(5)]
    public string? GroupCode { get; set; }

    [Column("GROUP_NAME")]
    [StringLength(50)]
    public string? GroupName { get; set; }

    [Column("WEF_DATE", TypeName = "timestamp without time zone")]
    public DateTime? WefDate { get; set; }

    [Column("ACTIVE_FLAG")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("CREATED_TIMESTAMP")]
    public DateOnly CreatedTimestamp { get; set; }

    [Column("MODIFIED_TIMESTAMP")]
    public DateOnly ModifiedTimestamp { get; set; }

    [Column("INT_GRP_ID_old")]
    [StringLength(38)]
    public string? IntGrpIdOld { get; set; }

    [Column("INT_GRP_ID")]
    public int? IntGrpId { get; set; }

    [Column("GRP_ID_old")]
    [StringLength(38)]
    public string? GrpIdOld { get; set; }

    [Column("GRP_ID")]
    public int? GrpId { get; set; }

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
