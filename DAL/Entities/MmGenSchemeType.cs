using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_frontend.DAL.Entities;

[Keyless]
[Table("mm_gen_scheme_type", Schema = "ifmsadmin")]
public partial class MmGenSchemeType
{
    [Column("scheme_type_code")]
    [StringLength(2)]
    public string? SchemeTypeCode { get; set; }

    [Column("description")]
    [StringLength(60)]
    public string? Description { get; set; }

    [Column("type")]
    [MaxLength(1)]
    public char? Type { get; set; }

    [Column("active_flag")]
    [MaxLength(1)]
    public char? ActiveFlag { get; set; }

    [Column("created_timestamp")]
    public DateOnly CreatedTimestamp { get; set; }

    [Column("modified_timestamp")]
    public DateOnly ModifiedTimestamp { get; set; }

    [Column("created_user_id_old")]
    [StringLength(38)]
    public string? CreatedUserIdOld { get; set; }

    [Column("created_user_id")]
    public int? CreatedUserId { get; set; }

    [Column("modified_user_id_old")]
    [StringLength(38)]
    public string? ModifiedUserIdOld { get; set; }

    [Column("modified_user_id")]
    public int? ModifiedUserId { get; set; }

    [Column("geometric_series_value_old")]
    [StringLength(38)]
    public string? GeometricSeriesValueOld { get; set; }

    [Column("geometric_series_value")]
    public int? GeometricSeriesValue { get; set; }
}
