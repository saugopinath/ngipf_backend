using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_frontend.DAL.Entities;

[Keyless]
[Table("hr_mm_gen_other_map_master", Schema = "ihrms_master")]
public partial class HrMmGenOtherMapMaster
{
    [Column("ACTIVE_FLAG")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("CREATED_ON")]
    public DateOnly? CreatedOn { get; set; }

    [Column("LAST_UPDATED_ON")]
    public DateOnly? LastUpdatedOn { get; set; }

    [Column("INT_OTHER_MASTER_MAP_ID_old")]
    [StringLength(38)]
    public string? IntOtherMasterMapIdOld { get; set; }

    [Column("INT_OTHER_MASTER_MAP_ID")]
    public int? IntOtherMasterMapId { get; set; }

    [Column("MODULE_TYPE_old")]
    [StringLength(38)]
    public string? ModuleTypeOld { get; set; }

    [Column("MODULE_TYPE")]
    public int? ModuleType { get; set; }

    [Column("INT_CUSTODIAN_ID_old")]
    [StringLength(38)]
    public string? IntCustodianIdOld { get; set; }

    [Column("INT_CUSTODIAN_ID")]
    public int? IntCustodianId { get; set; }

    [Column("INT_CUSTODIAN_DET_ID_old")]
    [StringLength(38)]
    public string? IntCustodianDetIdOld { get; set; }

    [Column("INT_CUSTODIAN_DET_ID")]
    public int? IntCustodianDetId { get; set; }

    [Column("DML_STATUS_FLAG_old")]
    [StringLength(38)]
    public string? DmlStatusFlagOld { get; set; }

    [Column("DML_STATUS_FLAG")]
    public int? DmlStatusFlag { get; set; }

    [Column("CREATED_BY_old")]
    [StringLength(38)]
    public string? CreatedByOld { get; set; }

    [Column("CREATED_BY")]
    public int? CreatedBy { get; set; }

    [Column("CREATED_ROLE_old")]
    [StringLength(38)]
    public string? CreatedRoleOld { get; set; }

    [Column("CREATED_ROLE")]
    public int? CreatedRole { get; set; }

    [Column("LAST_UPDATED_BY_old")]
    [StringLength(38)]
    public string? LastUpdatedByOld { get; set; }

    [Column("LAST_UPDATED_BY")]
    public int? LastUpdatedBy { get; set; }

    [Column("LAST_UPDATED_ROLE_old")]
    [StringLength(38)]
    public string? LastUpdatedRoleOld { get; set; }

    [Column("LAST_UPDATED_ROLE")]
    public int? LastUpdatedRole { get; set; }
}
