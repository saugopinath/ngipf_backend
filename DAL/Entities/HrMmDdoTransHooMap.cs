using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_frontend.DAL.Entities;

[Keyless]
[Table("hr_mm_ddo_trans_hoo_map", Schema = "ihrms_master")]
public partial class HrMmDdoTransHooMap
{
    [Column("ACTIVE_FLAG")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("CREATED_TIMESTAMP")]
    public DateOnly CreatedTimestamp { get; set; }

    [Column("MODIFIED_TIMESTAMP")]
    public DateOnly ModifiedTimestamp { get; set; }

    [Column("INT_DDO_TRANS_HOO_MAP_ID_old")]
    [StringLength(38)]
    public string? IntDdoTransHooMapIdOld { get; set; }

    [Column("INT_DDO_TRANS_HOO_MAP_ID")]
    public int? IntDdoTransHooMapId { get; set; }

    [Column("INT_DDO_TRANSFER_MAPPING_ID_old")]
    [StringLength(38)]
    public string? IntDdoTransferMappingIdOld { get; set; }

    [Column("INT_DDO_TRANSFER_MAPPING_ID")]
    public int? IntDdoTransferMappingId { get; set; }

    [Column("INT_HEAD_OF_OFFICE_ID_FROM_old")]
    [StringLength(38)]
    public string? IntHeadOfOfficeIdFromOld { get; set; }

    [Column("INT_HEAD_OF_OFFICE_ID_FROM")]
    public int? IntHeadOfOfficeIdFrom { get; set; }

    [Column("INT_HEAD_OF_OFFICE_ID_TO_CONT_old")]
    [StringLength(38)]
    public string? IntHeadOfOfficeIdToContOld { get; set; }

    [Column("INT_HEAD_OF_OFFICE_ID_TO_CONT")]
    public int? IntHeadOfOfficeIdToCont { get; set; }

    [Column("INT_TM_SANCTION_POST_old")]
    [StringLength(38)]
    public string? IntTmSanctionPostOld { get; set; }

    [Column("INT_TM_SANCTION_POST")]
    public int? IntTmSanctionPost { get; set; }

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

    [Column("INT_TM_SANCTION_POST_TO_old")]
    [StringLength(38)]
    public string? IntTmSanctionPostToOld { get; set; }

    [Column("INT_TM_SANCTION_POST_TO")]
    public int? IntTmSanctionPostTo { get; set; }
}
