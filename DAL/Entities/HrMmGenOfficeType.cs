using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NGIPF_BE.DAL.Entities;

[Keyless]
[Table("hr_mm_gen_office_type", Schema = "ihrms_master")]
public partial class HrMmGenOfficeType
{
    [Column("OFFICE_TYPE_DESC")]
    [StringLength(2000)]
    public string? OfficeTypeDesc { get; set; }

    [Column("OFFICE_TYPE_ABBR")]
    [StringLength(20)]
    public string? OfficeTypeAbbr { get; set; }

    [Column("ACTIVE_FLAG")]
    [StringLength(2)]
    public string? ActiveFlag { get; set; }

    [Column("CREATED_TIMESTANP", TypeName = "timestamp without time zone")]
    public DateTime? CreatedTimestanp { get; set; }

    [Column("INT_OFFICE_TYPE_ID_old")]
    [StringLength(38)]
    public string? IntOfficeTypeIdOld { get; set; }

    [Column("INT_OFFICE_TYPE_ID")]
    public int? IntOfficeTypeId { get; set; }

    [Column("DML_STATUS_FLAG_old")]
    [StringLength(38)]
    public string? DmlStatusFlagOld { get; set; }

    [Column("DML_STATUS_FLAG")]
    public int? DmlStatusFlag { get; set; }
}
