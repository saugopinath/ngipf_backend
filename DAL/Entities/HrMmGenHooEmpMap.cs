using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_frontend.DAL.Entities;

[Keyless]
[Table("hr_mm_gen_hoo_emp_map", Schema = "ihrms_master")]
public partial class HrMmGenHooEmpMap
{
    [Column("active_flag")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("wef")]
    public DateOnly? Wef { get; set; }

    [Column("last_updated_on")]
    public DateOnly LastUpdatedOn { get; set; }

    [Column("tag_flag")]
    [StringLength(1)]
    public string? TagFlag { get; set; }

    [Column("approve_date")]
    public DateOnly? ApproveDate { get; set; }

    [Column("servicebook_flag")]
    [StringLength(1)]
    public string? ServicebookFlag { get; set; }

    [Column("modify_flag")]
    [StringLength(1)]
    public string? ModifyFlag { get; set; }

    [Column("substantive_additional_flag")]
    [StringLength(1)]
    public string? SubstantiveAdditionalFlag { get; set; }

    [Column("outside_cadre_schedule_hoo")]
    [StringLength(100)]
    public string? OutsideCadreScheduleHoo { get; set; }

    [Column("untag_flag")]
    [StringLength(100)]
    public string? UntagFlag { get; set; }

    [Column("int_mm_gen_h_e_map_id_old")]
    [StringLength(38)]
    public string? IntMmGenHEMapIdOld { get; set; }

    [Column("int_mm_gen_h_e_map_id")]
    public int? IntMmGenHEMapId { get; set; }

    [Column("int_ddo_id_old")]
    [StringLength(38)]
    public string? IntDdoIdOld { get; set; }

    [Column("int_ddo_id")]
    public int? IntDdoId { get; set; }

    [Column("int_dept_id_old")]
    [StringLength(38)]
    public string? IntDeptIdOld { get; set; }

    [Column("int_dept_id")]
    public int? IntDeptId { get; set; }

    [Column("int_employee_id_old")]
    [StringLength(38)]
    public string? IntEmployeeIdOld { get; set; }

    [Column("int_employee_id")]
    public int? IntEmployeeId { get; set; }

    [Column("request_id_old")]
    [StringLength(38)]
    public string? RequestIdOld { get; set; }

    [Column("request_id")]
    public int? RequestId { get; set; }

    [Column("dml_status_flag_old")]
    [StringLength(38)]
    public string? DmlStatusFlagOld { get; set; }

    [Column("dml_status_flag")]
    public int? DmlStatusFlag { get; set; }

    [Column("last_updated_by_old")]
    [StringLength(38)]
    public string? LastUpdatedByOld { get; set; }

    [Column("last_updated_by")]
    public int? LastUpdatedBy { get; set; }

    [Column("last_updated_role_old")]
    [StringLength(38)]
    public string? LastUpdatedRoleOld { get; set; }

    [Column("last_updated_role")]
    public int? LastUpdatedRole { get; set; }

    [Column("int_level_id_old")]
    [StringLength(38)]
    public string? IntLevelIdOld { get; set; }

    [Column("int_level_id")]
    public int? IntLevelId { get; set; }

    [Column("int_head_of_office_id_old")]
    [StringLength(38)]
    public string? IntHeadOfOfficeIdOld { get; set; }

    [Column("approve_flag_old")]
    [StringLength(38)]
    public string? ApproveFlagOld { get; set; }

    [Column("approve_flag")]
    public int? ApproveFlag { get; set; }

    [Column("approve_by_old")]
    [StringLength(38)]
    public string? ApproveByOld { get; set; }

    [Column("approve_by")]
    public int? ApproveBy { get; set; }

    [Column("map_sequence_old")]
    [StringLength(38)]
    public string? MapSequenceOld { get; set; }

    [Column("map_sequence")]
    public int? MapSequence { get; set; }

    [Column("int_app_authority_id_old")]
    [StringLength(38)]
    public string? IntAppAuthorityIdOld { get; set; }

    [Column("int_app_authority_id")]
    public int? IntAppAuthorityId { get; set; }

    [Column("request_id_untag_old")]
    [StringLength(38)]
    public string? RequestIdUntagOld { get; set; }

    [Column("request_id_untag")]
    public int? RequestIdUntag { get; set; }

    [Column("int_head_of_office_id")]
    public int? IntHeadOfOfficeId { get; set; }
}
