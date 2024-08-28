using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NGIPF_BE.DAL.Entities;

[Table("hr_mm_gen_grade_pay", Schema = "ihrms_master")]
public partial class HrMmGenGradePay
{
    [Column("wef_date", TypeName = "timestamp without time zone")]
    public DateTime? WefDate { get; set; }

    [Column("active_flag")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("created_timestamp")]
    public DateOnly CreatedTimestamp { get; set; }

    [Column("modified_timestamp")]
    public DateOnly ModifiedTimestamp { get; set; }

    [Column("int_grade_pay_id_old")]
    [StringLength(38)]
    public string? IntGradePayIdOld { get; set; }

    [Column("grade_pay_id_old")]
    [StringLength(38)]
    public string? GradePayIdOld { get; set; }

    [Column("grade_pay_id")]
    public int? GradePayId { get; set; }

    [Column("int_payb_id_old")]
    [StringLength(38)]
    public string? IntPaybIdOld { get; set; }

    [Column("int_payb_id")]
    public int? IntPaybId { get; set; }

    [Column("grade_pay_old")]
    [StringLength(38)]
    public string? GradePayOld { get; set; }

    [Column("grade_pay")]
    public int? GradePay { get; set; }

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

    [Column("int_grp_id_old")]
    [StringLength(38)]
    public string? IntGrpIdOld { get; set; }

    [Column("int_grp_id")]
    public int? IntGrpId { get; set; }

    [Column("int_gis_grp_id_old")]
    [StringLength(38)]
    public string? IntGisGrpIdOld { get; set; }

    [Column("int_gis_grp_id")]
    public int? IntGisGrpId { get; set; }

    [Key]
    [Column("int_grade_pay_id")]
    public int IntGradePayId { get; set; }

    [InverseProperty("IntGradePayIdObsNavigation")]
    public virtual ICollection<HrMdEmpPayInformationWf> HrMdEmpPayInformationWfs { get; set; } = new List<HrMdEmpPayInformationWf>();

    [InverseProperty("IntGradePayIdObsNavigation")]
    public virtual ICollection<HrMdEmpPayInformation> HrMdEmpPayInformations { get; set; } = new List<HrMdEmpPayInformation>();
}
