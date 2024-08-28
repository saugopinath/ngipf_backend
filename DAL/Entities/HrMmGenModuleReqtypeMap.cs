using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_frontend.DAL.Entities;

[Keyless]
[Table("hr_mm_gen_module_reqtype_map", Schema = "ihrms_master")]
public partial class HrMmGenModuleReqtypeMap
{
    [Column("MODULE_NAME")]
    [StringLength(100)]
    public string? ModuleName { get; set; }

    [Column("REQUEST_TYPE")]
    [StringLength(100)]
    public string? RequestType { get; set; }

    [Column("ACTIVE_FLAG")]
    [StringLength(3)]
    public string? ActiveFlag { get; set; }

    [Column("CREATED_TIMESTAMP")]
    public DateOnly? CreatedTimestamp { get; set; }

    [Column("MODULE_ABBR")]
    [StringLength(100)]
    public string? ModuleAbbr { get; set; }

    [Column("MODULE_REQTYPE_MAP_ID_old")]
    [StringLength(38)]
    public string? ModuleReqtypeMapIdOld { get; set; }

    [Column("MODULE_REQTYPE_MAP_ID")]
    public int? ModuleReqtypeMapId { get; set; }

    [Column("MODULE_ID_old")]
    [StringLength(38)]
    public string? ModuleIdOld { get; set; }

    [Column("MODULE_ID")]
    public int? ModuleId { get; set; }

    [Column("DML_STATUS_FLAG_old")]
    [StringLength(38)]
    public string? DmlStatusFlagOld { get; set; }

    [Column("DML_STATUS_FLAG")]
    public int? DmlStatusFlag { get; set; }
}
