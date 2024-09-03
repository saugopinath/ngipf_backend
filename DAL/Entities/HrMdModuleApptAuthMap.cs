using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_backend.DAL.Entities;

[Keyless]
[Table("hr_md_module_appt_auth_map", Schema = "ihrms_master")]
public partial class HrMdModuleApptAuthMap
{
    [Column("ACTIVE_FLAG")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("CREATED_TIMESTAMP")]
    public DateOnly CreatedTimestamp { get; set; }

    [Column("MODIFIED_TIMESTAMP")]
    public DateOnly ModifiedTimestamp { get; set; }

    [Column("INT_MODULE_AA_MAP_ID_old")]
    [StringLength(38)]
    public string? IntModuleAaMapIdOld { get; set; }

    [Column("INT_MODULE_AA_MAP_ID")]
    public int? IntModuleAaMapId { get; set; }

    [Column("INT_APP_AUTHORITY_ID_old")]
    [StringLength(38)]
    public string? IntAppAuthorityIdOld { get; set; }

    [Column("INT_APP_AUTHORITY_ID")]
    public int? IntAppAuthorityId { get; set; }

    [Column("INT_MODULE_ID_old")]
    [StringLength(38)]
    public string? IntModuleIdOld { get; set; }

    [Column("INT_MODULE_ID")]
    public int? IntModuleId { get; set; }

    [Column("MODULE_FLAG_old")]
    [StringLength(38)]
    public string? ModuleFlagOld { get; set; }

    [Column("MODULE_FLAG")]
    public int? ModuleFlag { get; set; }

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

    [Column("DOWN_LEVEL_FLAG_old")]
    [StringLength(38)]
    public string? DownLevelFlagOld { get; set; }

    [Column("DOWN_LEVEL_FLAG")]
    public int? DownLevelFlag { get; set; }

    [Column("FREEZ_LEVEL_old")]
    [StringLength(38)]
    public string? FreezLevelOld { get; set; }

    [Column("FREEZ_LEVEL")]
    public int? FreezLevel { get; set; }

    [Column("MD_CGM_APPT_AUTH_MAP_ID_old")]
    [StringLength(38)]
    public string? MdCgmApptAuthMapIdOld { get; set; }

    [Column("MD_CGM_APPT_AUTH_MAP_ID")]
    public int? MdCgmApptAuthMapId { get; set; }
}
