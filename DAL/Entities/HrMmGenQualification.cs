using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_backend.DAL.Entities;

[Table("hr_mm_gen_qualification", Schema = "ihrms_master")]
public partial class HrMmGenQualification
{
    [Column("qualification_description")]
    [StringLength(600)]
    public string? QualificationDescription { get; set; }

    [Column("short_name")]
    [StringLength(30)]
    public string? ShortName { get; set; }

    [Column("active_flag")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("pay_related")]
    [StringLength(1)]
    public string? PayRelated { get; set; }

    [Column("special_qualification")]
    [StringLength(1)]
    public string? SpecialQualification { get; set; }

    [Column("created_timestamp", TypeName = "timestamp without time zone")]
    public DateTime CreatedTimestamp { get; set; }

    [Column("modified_timestamp", TypeName = "timestamp without time zone")]
    public DateTime? ModifiedTimestamp { get; set; }

    [Column("academic_group_desc")]
    [StringLength(100)]
    public string? AcademicGroupDesc { get; set; }

    [Column("qualification_type_desc")]
    [StringLength(100)]
    public string? QualificationTypeDesc { get; set; }

    [Column("int_qualification_id_old")]
    [StringLength(38)]
    public string? IntQualificationIdOld { get; set; }

    [Column("dml_status_flag_old")]
    [StringLength(38)]
    public string? DmlStatusFlagOld { get; set; }

    [Column("dml_status_flag")]
    public int? DmlStatusFlag { get; set; }

    [Column("int_omi_academic_group_old")]
    [StringLength(38)]
    public string? IntOmiAcademicGroupOld { get; set; }

    [Column("int_omi_academic_group")]
    public int? IntOmiAcademicGroup { get; set; }

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

    [Key]
    [Column("int_qualification_id")]
    public int IntQualificationId { get; set; }

    [InverseProperty("IntQualification")]
    public virtual ICollection<HrMdEmpQualification> HrMdEmpQualifications { get; set; } = new List<HrMdEmpQualification>();
}
