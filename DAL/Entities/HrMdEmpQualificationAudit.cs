using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;
using Microsoft.EntityFrameworkCore;

namespace ngipf_frontend.DAL.Entities;

[Table("hr_md_emp_qualification_audit", Schema = "ihrms")]
[Index("IntQualificationId", Name = "ind_hr_md_emp_qfn_au1")]
[Index("IntOmiQualCategory", Name = "ind_hr_md_emp_qfn_au2")]
[Index("RequestId", Name = "ind_hr_md_emp_qfn_au4")]
[Index("IntEmployeeId", Name = "ind_hr_md_emp_qfn_aud")]
public partial class HrMdEmpQualificationAudit
{
    [Key]
    [Column("int_emp_qualification_id_aud")]
    [StringLength(38)]
    public string IntEmpQualificationIdAud { get; set; } = null!;

    [Column("int_emp_qualification_id")]
    [StringLength(38)]
    public string? IntEmpQualificationId { get; set; }

    [Column("int_employee_id")]
    [Precision(38, 0)]
    public BigInteger? IntEmployeeId { get; set; }

    [Column("int_qualification_id")]
    [StringLength(38)]
    public string? IntQualificationId { get; set; }

    [Column("int_omi_qual_category")]
    [StringLength(38)]
    public string? IntOmiQualCategory { get; set; }

    [Column("education_start_year")]
    public short? EducationStartYear { get; set; }

    [Column("education_end_year")]
    public short? EducationEndYear { get; set; }

    [Column("education_start_date", TypeName = "timestamp(0) without time zone")]
    public DateTime? EducationStartDate { get; set; }

    [Column("education_end_date", TypeName = "timestamp(0) without time zone")]
    public DateTime? EducationEndDate { get; set; }

    [Column("percentage_obtained")]
    [Precision(5, 2)]
    public decimal? PercentageObtained { get; set; }

    [Column("cgpa")]
    [Precision(5, 2)]
    public decimal? Cgpa { get; set; }

    [Column("description")]
    [StringLength(500)]
    public string? Description { get; set; }

    [Column("qualification_type")]
    [StringLength(3)]
    public string? QualificationType { get; set; }

    [Column("active_flag")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("effective_end_date", TypeName = "timestamp(0) without time zone")]
    public DateTime? EffectiveEndDate { get; set; }

    [Column("dml_status_flag")]
    public short? DmlStatusFlag { get; set; }

    [Column("last_updated_by")]
    public int? LastUpdatedBy { get; set; }

    [Column("last_updated_on", TypeName = "timestamp without time zone")]
    public DateTime? LastUpdatedOn { get; set; }

    [Column("last_updated_by_role")]
    public int? LastUpdatedByRole { get; set; }

    [Column("request_id")]
    public long? RequestId { get; set; }

    [Column("int_omi_srv_book_block_id")]
    [StringLength(38)]
    public string? IntOmiSrvBookBlockId { get; set; }

    [Column("remarks")]
    [StringLength(500)]
    public string? Remarks { get; set; }
}
