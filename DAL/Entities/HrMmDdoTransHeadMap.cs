using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NGIPF_BE.DAL.Entities;

[Keyless]
[Table("hr_mm_ddo_trans_head_map", Schema = "ihrms_master")]
public partial class HrMmDdoTransHeadMap
{
    [Column("ACTIVE_FLAG")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("CREATED_TIMESTAMP")]
    public DateOnly CreatedTimestamp { get; set; }

    [Column("MODIFIED_TIMESTAMP")]
    public DateOnly ModifiedTimestamp { get; set; }

    [Column("OPERATION_FLAG")]
    [StringLength(20)]
    public string? OperationFlag { get; set; }

    [Column("INT_DDO_TRANSFER_HEAD_MAP_ID_old")]
    [StringLength(38)]
    public string? IntDdoTransferHeadMapIdOld { get; set; }

    [Column("INT_DDO_TRANSFER_HEAD_MAP_ID")]
    public int? IntDdoTransferHeadMapId { get; set; }

    [Column("INT_DDO_TRANSFER_MAPPING_ID_old")]
    [StringLength(38)]
    public string? IntDdoTransferMappingIdOld { get; set; }

    [Column("INT_DDO_TRANSFER_MAPPING_ID")]
    public int? IntDdoTransferMappingId { get; set; }

    [Column("INT_DDO_SALARY_HEAD_MAP_ID_FRM_old")]
    [StringLength(38)]
    public string? IntDdoSalaryHeadMapIdFrmOld { get; set; }

    [Column("INT_DDO_SALARY_HEAD_MAP_ID_FRM")]
    public int? IntDdoSalaryHeadMapIdFrm { get; set; }

    [Column("INT_DDO_SALARY_HEAD_MAP_ID_TO_old")]
    [StringLength(38)]
    public string? IntDdoSalaryHeadMapIdToOld { get; set; }

    [Column("INT_DDO_SALARY_HEAD_MAP_ID_TO")]
    public int? IntDdoSalaryHeadMapIdTo { get; set; }

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

    [Column("DML_STATUS_FLAG_old")]
    [StringLength(38)]
    public string? DmlStatusFlagOld { get; set; }

    [Column("DML_STATUS_FLAG")]
    public int? DmlStatusFlag { get; set; }
}
