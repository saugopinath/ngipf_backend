using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NGIPF_BE.DAL.Entities;

[Keyless]
[Table("hr_mm_gen_workflow_mod_subtype", Schema = "ihrms_master")]
public partial class HrMmGenWorkflowModSubtype
{
    [Column("NAME")]
    [StringLength(150)]
    public string? Name { get; set; }

    [Column("ABBR")]
    [StringLength(50)]
    public string? Abbr { get; set; }

    [Column("ACTIVE_FLAG")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("RECOMENDATION_NEEDED")]
    [StringLength(1)]
    public string? RecomendationNeeded { get; set; }

    [Column("SANCTION_NEEDED")]
    [StringLength(1)]
    public string? SanctionNeeded { get; set; }

    [Column("CREATED_ON", TypeName = "timestamp without time zone")]
    public DateTime CreatedOn { get; set; }

    [Column("LAST_UPDATED_ON", TypeName = "timestamp without time zone")]
    public DateTime? LastUpdatedOn { get; set; }

    [Column("BUSINESS_PK_TYPE")]
    [StringLength(200)]
    public string? BusinessPkType { get; set; }

    [Column("INT_MM_GEN_WF_MOD_SUBTYPE_ID_old")]
    [StringLength(38)]
    public string? IntMmGenWfModSubtypeIdOld { get; set; }

    [Column("INT_MM_GEN_WF_MOD_SUBTYPE_ID")]
    public int? IntMmGenWfModSubtypeId { get; set; }

    [Column("INT_MM_GEN_WF_MOD_TYPE_ID_old")]
    [StringLength(38)]
    public string? IntMmGenWfModTypeIdOld { get; set; }

    [Column("INT_MM_GEN_WF_MOD_TYPE_ID")]
    public int? IntMmGenWfModTypeId { get; set; }

    [Column("DML_STATUS_FLAG_old")]
    [StringLength(38)]
    public string? DmlStatusFlagOld { get; set; }

    [Column("DML_STATUS_FLAG")]
    public int? DmlStatusFlag { get; set; }

    [Column("CREATED_BY_old")]
    [StringLength(38)]
    public string? CreatedByOld { get; set; }

    [Column("CREATED_BY")]
    public int? CreatedBy { get; set; }

    [Column("CREATED_ROLE_old")]
    [StringLength(38)]
    public string? CreatedRoleOld { get; set; }

    [Column("CREATED_ROLE")]
    public int? CreatedRole { get; set; }

    [Column("LAST_UPDATED_BY_old")]
    [StringLength(38)]
    public string? LastUpdatedByOld { get; set; }

    [Column("LAST_UPDATED_BY")]
    public int? LastUpdatedBy { get; set; }

    [Column("LAST_UPDATED_ROLE_old")]
    [StringLength(38)]
    public string? LastUpdatedRoleOld { get; set; }

    [Column("LAST_UPDATED_ROLE")]
    public int? LastUpdatedRole { get; set; }

    [Column("INT_BUSINESS_PK_old")]
    [StringLength(38)]
    public string? IntBusinessPkOld { get; set; }

    [Column("INT_BUSINESS_PK")]
    public int? IntBusinessPk { get; set; }
}
