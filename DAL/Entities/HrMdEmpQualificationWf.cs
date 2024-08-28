using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NGIPF_BE.DAL.Entities;

[Keyless]
[Table("hr_md_emp_qualification_wf", Schema = "ihrms_emp_master")]
public partial class HrMdEmpQualificationWf
{
    [Column("education_start_date")]
    public DateOnly? EducationStartDate { get; set; }

    [Column("education_end_date")]
    public DateOnly? EducationEndDate { get; set; }

    [Column("description")]
    [StringLength(500)]
    public string? Description { get; set; }

    [Column("qualification_type")]
    [StringLength(3)]
    public string? QualificationType { get; set; }

    [Column("active_flag")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("effective_end_date")]
    public DateOnly? EffectiveEndDate { get; set; }

    [Column("workflow_status_flag")]
    [StringLength(2)]
    public string? WorkflowStatusFlag { get; set; }

    [Column("last_updated_on", TypeName = "timestamp without time zone")]
    public DateTime? LastUpdatedOn { get; set; }

    [Column("remarks")]
    [StringLength(500)]
    public string? Remarks { get; set; }

    [Column("int_emp_qualification_id_wf_old")]
    [StringLength(38)]
    public string? IntEmpQualificationIdWfOld { get; set; }

    [Column("int_emp_qualification_id_old")]
    [StringLength(38)]
    public string? IntEmpQualificationIdOld { get; set; }

    [Column("int_emp_qualification_id")]
    public int? IntEmpQualificationId { get; set; }

    [Column("int_employee_id_old")]
    [StringLength(38)]
    public string? IntEmployeeIdOld { get; set; }

    [Column("int_employee_id")]
    public int? IntEmployeeId { get; set; }

    [Column("int_qualification_id_old")]
    [StringLength(38)]
    public string? IntQualificationIdOld { get; set; }

    [Column("int_qualification_id")]
    public int? IntQualificationId { get; set; }

    [Column("int_omi_qual_category_old")]
    [StringLength(38)]
    public string? IntOmiQualCategoryOld { get; set; }

    [Column("int_omi_qual_category")]
    public int? IntOmiQualCategory { get; set; }

    [Column("education_start_year_old")]
    [StringLength(38)]
    public string? EducationStartYearOld { get; set; }

    [Column("education_start_year")]
    public int? EducationStartYear { get; set; }

    [Column("education_end_year_old")]
    [StringLength(38)]
    public string? EducationEndYearOld { get; set; }

    [Column("education_end_year")]
    public int? EducationEndYear { get; set; }

    [Column("percentage_obtained_old")]
    [StringLength(38)]
    public string? PercentageObtainedOld { get; set; }

    [Column("percentage_obtained")]
    public int? PercentageObtained { get; set; }

    [Column("cgpa_old")]
    [StringLength(38)]
    public string? CgpaOld { get; set; }

    [Column("cgpa")]
    public int? Cgpa { get; set; }

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

    [Column("last_updated_by_role_old")]
    [StringLength(38)]
    public string? LastUpdatedByRoleOld { get; set; }

    [Column("last_updated_by_role")]
    public int? LastUpdatedByRole { get; set; }

    [Column("request_id_old")]
    [StringLength(38)]
    public string? RequestIdOld { get; set; }

    [Column("request_id")]
    public int? RequestId { get; set; }

    [Column("int_omi_srv_book_block_id_old")]
    [StringLength(38)]
    public string? IntOmiSrvBookBlockIdOld { get; set; }

    [Column("int_omi_srv_book_block_id")]
    public int? IntOmiSrvBookBlockId { get; set; }

    [Column("int_emp_qualification_id_wf")]
    public int IntEmpQualificationIdWf { get; set; }
}
