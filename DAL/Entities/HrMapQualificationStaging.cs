using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NGIPF_BE.DAL.Entities;

[Keyless]
[Table("hr_map_qualification_staging", Schema = "ihrms_master")]
public partial class HrMapQualificationStaging
{
    [Column("DESC_COSA")]
    [StringLength(500)]
    public string? DescCosa { get; set; }

    [Column("DESC_IFMS")]
    [StringLength(500)]
    public string? DescIfms { get; set; }

    [Column("INT_QUALIFICATION_ID_old")]
    [StringLength(38)]
    public string? IntQualificationIdOld { get; set; }

    [Column("INT_QUALIFICATION_ID")]
    public int? IntQualificationId { get; set; }
}
