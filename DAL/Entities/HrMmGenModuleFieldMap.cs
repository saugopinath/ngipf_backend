using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_backend.DAL.Entities;

[Keyless]
[Table("hr_mm_gen_module_field_map", Schema = "ihrms_master")]
public partial class HrMmGenModuleFieldMap
{
    [Column("MODULE_NAME")]
    [StringLength(60)]
    public string? ModuleName { get; set; }

    [Column("MODULE_ABBR")]
    [StringLength(6)]
    public string? ModuleAbbr { get; set; }

    [Column("BUSINESS_PK")]
    [StringLength(50)]
    public string? BusinessPk { get; set; }

    [Column("ENABLE_DISABLE_FLAG")]
    [StringLength(1)]
    public string? EnableDisableFlag { get; set; }

    [Column("INT_MODULE_FIELD_MAP_ID_old")]
    [StringLength(38)]
    public string? IntModuleFieldMapIdOld { get; set; }

    [Column("INT_MODULE_FIELD_MAP_ID")]
    public int? IntModuleFieldMapId { get; set; }

    [Column("INT_MODULE_ID_old")]
    [StringLength(38)]
    public string? IntModuleIdOld { get; set; }

    [Column("INT_MODULE_ID")]
    public int? IntModuleId { get; set; }
}
