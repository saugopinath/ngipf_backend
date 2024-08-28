using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NGIPF_BE.DAL.Entities;

[Keyless]
[Table("hr_mm_gen_ropa_map", Schema = "ihrms_master")]
public partial class HrMmGenRopaMap
{
    [Column("WEF_DATE")]
    public DateOnly? WefDate { get; set; }

    [Column("ACTIVE_FLAG")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("REMARKS")]
    [StringLength(200)]
    public string? Remarks { get; set; }

    [Column("CREATED_TIMESTAMP")]
    public DateOnly CreatedTimestamp { get; set; }

    [Column("MODIFIED_TIMESTAMP")]
    public DateOnly ModifiedTimestamp { get; set; }

    [Column("INT_ROPA_MAP_ID_old")]
    [StringLength(38)]
    public string? IntRopaMapIdOld { get; set; }

    [Column("INT_ROPA_MAP_ID")]
    public int? IntRopaMapId { get; set; }

    [Column("INT_NEW_SRV_ID_old")]
    [StringLength(38)]
    public string? IntNewSrvIdOld { get; set; }

    [Column("INT_NEW_SRV_ID")]
    public int? IntNewSrvId { get; set; }

    [Column("INT_OLD_SRV_ID_old")]
    [StringLength(38)]
    public string? IntOldSrvIdOld { get; set; }

    [Column("INT_OLD_SRV_ID")]
    public int? IntOldSrvId { get; set; }

    [Column("INT_NEW_ROPA_ID_old")]
    [StringLength(38)]
    public string? IntNewRopaIdOld { get; set; }

    [Column("INT_NEW_ROPA_ID")]
    public int? IntNewRopaId { get; set; }

    [Column("INT_OLD_ROPA_ID_old")]
    [StringLength(38)]
    public string? IntOldRopaIdOld { get; set; }

    [Column("INT_OLD_ROPA_ID")]
    public int? IntOldRopaId { get; set; }

    [Column("DML_STATUS_FLAG_old")]
    [StringLength(38)]
    public string? DmlStatusFlagOld { get; set; }

    [Column("DML_STATUS_FLAG")]
    public int? DmlStatusFlag { get; set; }

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

    [Column("ROLE_ID_old")]
    [StringLength(38)]
    public string? RoleIdOld { get; set; }

    [Column("ROLE_ID")]
    public int? RoleId { get; set; }
}
