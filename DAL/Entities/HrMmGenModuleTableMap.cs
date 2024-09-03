using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_backend.DAL.Entities;

[Keyless]
[Table("hr_mm_gen_module_table_map", Schema = "ihrms_master")]
public partial class HrMmGenModuleTableMap
{
    [Column("MODULE_TYPE")]
    [StringLength(7)]
    public string? ModuleType { get; set; }

    [Column("TABLE_NAME")]
    [StringLength(30)]
    public string? TableName { get; set; }

    [Column("REMARKS")]
    [StringLength(100)]
    public string? Remarks { get; set; }

    [Column("INT_MODULE_TABLE_MAP_old")]
    [StringLength(38)]
    public string? IntModuleTableMapOld { get; set; }

    [Column("INT_MODULE_TABLE_MAP")]
    public int? IntModuleTableMap { get; set; }
}
