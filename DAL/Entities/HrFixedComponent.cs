using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_backend.DAL.Entities;

[Keyless]
[Table("hr_fixed_component", Schema = "ihrms_master")]
public partial class HrFixedComponent
{
    [Column("fixed_component_abbr")]
    [StringLength(5)]
    public string? FixedComponentAbbr { get; set; }

    [Column("fixed_component_desc")]
    [StringLength(100)]
    public string? FixedComponentDesc { get; set; }

    [Column("active_flag")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("calculation_required")]
    [StringLength(1)]
    public string? CalculationRequired { get; set; }

    [Column("created_timestamp")]
    public DateOnly CreatedTimestamp { get; set; }

    [Column("modified_timestamp")]
    public DateOnly ModifiedTimestamp { get; set; }

    [Column("int_fixed_component_id_old")]
    [StringLength(38)]
    public string? IntFixedComponentIdOld { get; set; }

    [Column("int_fixed_component_id")]
    public int? IntFixedComponentId { get; set; }

    [Column("int_omi_component_type_id_old")]
    [StringLength(38)]
    public string? IntOmiComponentTypeIdOld { get; set; }

    [Column("int_omi_component_type_id")]
    public int? IntOmiComponentTypeId { get; set; }

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
}
