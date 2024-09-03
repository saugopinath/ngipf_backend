using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_backend.DAL.Entities;

[Keyless]
[Table("hr_map_department_staging", Schema = "ihrms_master")]
public partial class HrMapDepartmentStaging
{
    [Column("DESCRIPTION_COSA")]
    [StringLength(500)]
    public string? DescriptionCosa { get; set; }

    [Column("DESCRIPTION_IFMS")]
    [StringLength(500)]
    public string? DescriptionIfms { get; set; }

    [Column("INT_DEPT_ID_old")]
    [StringLength(38)]
    public string? IntDeptIdOld { get; set; }

    [Column("INT_DEPT_ID")]
    public int? IntDeptId { get; set; }
}
