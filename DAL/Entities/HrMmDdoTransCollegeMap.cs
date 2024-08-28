using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NGIPF_BE.DAL.Entities;

[Keyless]
[Table("hr_mm_ddo_trans_college_map", Schema = "ihrms_master")]
public partial class HrMmDdoTransCollegeMap
{
    [Column("ACTIVE_FLAG")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("CREATED_TIMESTAMP")]
    public DateOnly CreatedTimestamp { get; set; }

    [Column("MODIFIED_TIMESTAMP")]
    public DateOnly ModifiedTimestamp { get; set; }

    [Column("INT_DDO_TRANS_COLLEGE_MAP_ID_old")]
    [StringLength(38)]
    public string? IntDdoTransCollegeMapIdOld { get; set; }

    [Column("INT_DDO_TRANS_COLLEGE_MAP_ID")]
    public int? IntDdoTransCollegeMapId { get; set; }

    [Column("INT_DDO_TRANSFER_MAPPING_ID_old")]
    [StringLength(38)]
    public string? IntDdoTransferMappingIdOld { get; set; }

    [Column("INT_DDO_TRANSFER_MAPPING_ID")]
    public int? IntDdoTransferMappingId { get; set; }

    [Column("INT_PL_PF_DDO_MAP_FROM_old")]
    [StringLength(38)]
    public string? IntPlPfDdoMapFromOld { get; set; }

    [Column("INT_PL_PF_DDO_MAP_FROM")]
    public int? IntPlPfDdoMapFrom { get; set; }

    [Column("INT_PL_PF_DDO_MAP_TO_old")]
    [StringLength(38)]
    public string? IntPlPfDdoMapToOld { get; set; }

    [Column("INT_PL_PF_DDO_MAP_TO")]
    public int? IntPlPfDdoMapTo { get; set; }

    [Column("CREATED_USER_ID_old")]
    [StringLength(38)]
    public string? CreatedUserIdOld { get; set; }

    [Column("CREATED_USER_ID")]
    public int? CreatedUserId { get; set; }

    [Column("CREATED_ROLE_ID_old")]
    [StringLength(38)]
    public string? CreatedRoleIdOld { get; set; }

    [Column("CREATED_ROLE_ID")]
    public int? CreatedRoleId { get; set; }

    [Column("MODIFIED_USER_ID_old")]
    [StringLength(38)]
    public string? ModifiedUserIdOld { get; set; }

    [Column("MODIFIED_USER_ID")]
    public int? ModifiedUserId { get; set; }

    [Column("MODIFIED_ROLE_ID_old")]
    [StringLength(38)]
    public string? ModifiedRoleIdOld { get; set; }

    [Column("MODIFIED_ROLE_ID")]
    public int? ModifiedRoleId { get; set; }
}
