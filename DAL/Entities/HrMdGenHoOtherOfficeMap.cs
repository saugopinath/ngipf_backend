using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_frontend.DAL.Entities;

[Keyless]
[Table("hr_md_gen_ho_other_office_map", Schema = "ihrms_master")]
public partial class HrMdGenHoOtherOfficeMap
{
    [Column("OTHER_OFFICE_TYPE")]
    [StringLength(10)]
    public string? OtherOfficeType { get; set; }

    [Column("OTHER_OFFICE_CODE")]
    [StringLength(50)]
    public string? OtherOfficeCode { get; set; }

    [Column("ACTIVE_FLAG")]
    [StringLength(2)]
    public string? ActiveFlag { get; set; }

    [Column("CREATED_TIMESTAMP", TypeName = "timestamp without time zone")]
    public DateTime? CreatedTimestamp { get; set; }

    [Column("INT_HO_OTHER_OFFICE_MAP_ID_old")]
    [StringLength(38)]
    public string? IntHoOtherOfficeMapIdOld { get; set; }

    [Column("INT_HO_OTHER_OFFICE_MAP_ID")]
    public int? IntHoOtherOfficeMapId { get; set; }

    [Column("INT_HEAD_OF_OFFICE_ID_old")]
    [StringLength(38)]
    public string? IntHeadOfOfficeIdOld { get; set; }

    [Column("INT_HEAD_OF_OFFICE_ID")]
    public int? IntHeadOfOfficeId { get; set; }

    [Column("INT_OTHER_OFFICE_ID_old")]
    [StringLength(38)]
    public string? IntOtherOfficeIdOld { get; set; }

    [Column("INT_OTHER_OFFICE_ID")]
    public int? IntOtherOfficeId { get; set; }

    [Column("DML_STATUS_FLAG_old")]
    [StringLength(38)]
    public string? DmlStatusFlagOld { get; set; }

    [Column("DML_STATUS_FLAG")]
    public int? DmlStatusFlag { get; set; }
}
