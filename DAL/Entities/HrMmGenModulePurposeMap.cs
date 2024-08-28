using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NGIPF_BE.DAL.Entities;

[Keyless]
[Table("hr_mm_gen_module_purpose_map", Schema = "ihrms_master")]
public partial class HrMmGenModulePurposeMap
{
    [Column("MASTER_ABBR")]
    [StringLength(10)]
    public string? MasterAbbr { get; set; }

    [Column("MASTER_TYPE")]
    [StringLength(6)]
    public string? MasterType { get; set; }

    [Column("BUSINES_PK_TYPE")]
    [StringLength(50)]
    public string? BusinesPkType { get; set; }

    [Column("ACTIVE_FLAG")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("INT_MODULE_PURPOSE_MAP_old")]
    [StringLength(38)]
    public string? IntModulePurposeMapOld { get; set; }

    [Column("INT_MODULE_PURPOSE_MAP")]
    public int? IntModulePurposeMap { get; set; }

    [Column("DML_STATUS_FLAG_old")]
    [StringLength(38)]
    public string? DmlStatusFlagOld { get; set; }

    [Column("DML_STATUS_FLAG")]
    public int? DmlStatusFlag { get; set; }
}
