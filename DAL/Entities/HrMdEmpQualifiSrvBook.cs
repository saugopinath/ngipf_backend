using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_backend.DAL.Entities;

[Keyless]
[Table("hr_md_emp_qualifi_srv_book", Schema = "ihrms_emp_master")]
public partial class HrMdEmpQualifiSrvBook
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

    [Column("created_timestamp")]
    public DateOnly CreatedTimestamp { get; set; }

    [Column("modified_timestamp")]
    public DateOnly ModifiedTimestamp { get; set; }

    [Column("modifiable_flag")]
    [StringLength(1)]
    public string? ModifiableFlag { get; set; }

    [Column("inserted_flag")]
    [StringLength(1)]
    public string? InsertedFlag { get; set; }

    [Column("remarks")]
    [StringLength(100)]
    public string? Remarks { get; set; }

    [Column("int_emp_qualifi_srv_book_id_old")]
    [StringLength(38)]
    public string? IntEmpQualifiSrvBookIdOld { get; set; }

    [Column("srv_book_request_init_old")]
    [StringLength(38)]
    public string? SrvBookRequestInitOld { get; set; }

    [Column("srv_book_request_init")]
    public int? SrvBookRequestInit { get; set; }

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

    [Column("prev_int_emp_qualification_id_old")]
    [StringLength(38)]
    public string? PrevIntEmpQualificationIdOld { get; set; }

    [Column("prev_int_emp_qualification_id")]
    public int? PrevIntEmpQualificationId { get; set; }

    [Column("dml_status_flag_old")]
    [StringLength(38)]
    public string? DmlStatusFlagOld { get; set; }

    [Column("dml_status_flag")]
    public int? DmlStatusFlag { get; set; }

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

    [Column("request_id_old")]
    [StringLength(38)]
    public string? RequestIdOld { get; set; }

    [Column("request_id")]
    public int? RequestId { get; set; }

    [Column("int_emp_qualifi_srv_book_id")]
    public int IntEmpQualifiSrvBookId { get; set; }
}
