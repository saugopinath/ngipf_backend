using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_backend.DAL.Entities;

[Table("hr_md_gen_ddo_salary_head_map", Schema = "ihrms_master")]
[Index("IntDdoId", Name = "fki_fk_ihrms_master.hr_md_gen_ddo_salary_head_map_ddo")]
public partial class HrMdGenDdoSalaryHeadMap
{
    [Column("major_head")]
    [StringLength(4)]
    public string? MajorHead { get; set; }

    [Column("submajor_head")]
    [StringLength(2)]
    public string? SubmajorHead { get; set; }

    [Column("minor_head")]
    [StringLength(3)]
    public string? MinorHead { get; set; }

    [Column("plan_status")]
    [StringLength(2)]
    public string? PlanStatus { get; set; }

    [Column("scheme_head")]
    [StringLength(3)]
    public string? SchemeHead { get; set; }

    [Column("detail_head")]
    [StringLength(2)]
    public string? DetailHead { get; set; }

    [Column("charged_voted")]
    [StringLength(1)]
    public string? ChargedVoted { get; set; }

    [Column("remarks")]
    [StringLength(300)]
    public string? Remarks { get; set; }

    [Column("active_flag")]
    [StringLength(2)]
    public string? ActiveFlag { get; set; }

    [Column("wef")]
    public DateOnly Wef { get; set; }

    [Column("effective_end_date")]
    public DateOnly? EffectiveEndDate { get; set; }

    [Column("last_updated_on", TypeName = "timestamp without time zone")]
    public DateTime? LastUpdatedOn { get; set; }

    [Column("demand_no")]
    [StringLength(2)]
    public string? DemandNo { get; set; }

    [Column("int_ddo_salary_head_map_id_old")]
    [StringLength(38)]
    public string? IntDdoSalaryHeadMapIdOld { get; set; }

    [Column("int_ddo_id_old")]
    [StringLength(38)]
    public string? IntDdoIdOld { get; set; }

    [Column("int_ddo_id")]
    public int? IntDdoId { get; set; }

    [Column("last_updated_by_old")]
    [StringLength(38)]
    public string? LastUpdatedByOld { get; set; }

    [Column("last_updated_by")]
    public int? LastUpdatedBy { get; set; }

    [Column("last_updated_by_role_old")]
    [StringLength(38)]
    public string? LastUpdatedByRoleOld { get; set; }

    [Column("last_updated_by_role")]
    public int? LastUpdatedByRole { get; set; }

    [Column("int_omi_fin_year_old")]
    [StringLength(38)]
    public string? IntOmiFinYearOld { get; set; }

    [Column("int_omi_fin_year")]
    public int? IntOmiFinYear { get; set; }

    [Column("org_int_omi_fin_year_old")]
    [StringLength(38)]
    public string? OrgIntOmiFinYearOld { get; set; }

    [Column("org_int_omi_fin_year")]
    public int? OrgIntOmiFinYear { get; set; }

    [Column("old_int_ddo_salary_head_map_id_old")]
    [StringLength(38)]
    public string? OldIntDdoSalaryHeadMapIdOld { get; set; }

    [Column("old_int_ddo_salary_head_map_id")]
    public int? OldIntDdoSalaryHeadMapId { get; set; }

    [Key]
    [Column("int_ddo_salary_head_map_id")]
    public int IntDdoSalaryHeadMapId { get; set; }

    [ForeignKey("IntDdoId")]
    [InverseProperty("HrMdGenDdoSalaryHeadMaps")]
    public virtual MmGenDdo? IntDdo { get; set; }
}
