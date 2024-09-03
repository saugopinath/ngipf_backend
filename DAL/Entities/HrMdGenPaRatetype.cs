using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_backend.DAL.Entities;

[Keyless]
[Table("hr_md_gen_pa_ratetype", Schema = "ihrms_master")]
public partial class HrMdGenPaRatetype
{
    [Column("RATETYPE_DESC")]
    [StringLength(20)]
    public string? RatetypeDesc { get; set; }

    [Column("CREATED_TIMESTAMP")]
    public DateOnly CreatedTimestamp { get; set; }

    [Column("MODIFIED_TIMESTAMP")]
    public DateOnly ModifiedTimestamp { get; set; }

    [Column("INT_MD_PA_RATETYPE_ID_old")]
    [StringLength(38)]
    public string? IntMdPaRatetypeIdOld { get; set; }

    [Column("INT_MD_PA_RATETYPE_ID")]
    public int? IntMdPaRatetypeId { get; set; }

    [Column("INT_MM_PA_RATETYPE_ID_old")]
    [StringLength(38)]
    public string? IntMmPaRatetypeIdOld { get; set; }

    [Column("INT_MM_PA_RATETYPE_ID")]
    public int? IntMmPaRatetypeId { get; set; }

    [Column("RATE_VALUE_FROM_old")]
    [StringLength(38)]
    public string? RateValueFromOld { get; set; }

    [Column("RATE_VALUE_FROM")]
    public int? RateValueFrom { get; set; }

    [Column("RATE_VALUE_TO_old")]
    [StringLength(38)]
    public string? RateValueToOld { get; set; }

    [Column("RATE_VALUE_TO")]
    public int? RateValueTo { get; set; }

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
}
