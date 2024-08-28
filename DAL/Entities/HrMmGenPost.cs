using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NGIPF_BE.DAL.Entities;

[Keyless]
[Table("hr_mm_gen_post", Schema = "ihrms_master")]
public partial class HrMmGenPost
{
    [Column("POST_NAME")]
    [StringLength(1000)]
    public string? PostName { get; set; }

    [Column("WEF_DATE", TypeName = "timestamp without time zone")]
    public DateTime? WefDate { get; set; }

    [Column("ACTIVE_FLAG")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("CREATED_TIMESTAMP")]
    public DateOnly CreatedTimestamp { get; set; }

    [Column("MODIFIED_TIMESTAMP", TypeName = "timestamp without time zone")]
    public DateTime ModifiedTimestamp { get; set; }

    [Column("DEMAND_NO")]
    [StringLength(2)]
    public string? DemandNo { get; set; }

    [Column("MAJOR_HEAD")]
    [StringLength(4)]
    public string? MajorHead { get; set; }

    [Column("SUBMAJOR_HEAD")]
    [StringLength(2)]
    public string? SubmajorHead { get; set; }

    [Column("MINOR_HEAD")]
    [StringLength(3)]
    public string? MinorHead { get; set; }

    [Column("PLAN_STATUS")]
    [StringLength(2)]
    public string? PlanStatus { get; set; }

    [Column("SCHEME_HEAD")]
    [StringLength(3)]
    public string? SchemeHead { get; set; }

    [Column("DETAIL_HEAD")]
    [StringLength(2)]
    public string? DetailHead { get; set; }

    [Column("SUBDETAIL_HEAD")]
    [StringLength(2)]
    public string? SubdetailHead { get; set; }

    [Column("CHARGED_VOTED")]
    [StringLength(1)]
    public string? ChargedVoted { get; set; }

    [Column("MONTH_13_SALARY")]
    [StringLength(1)]
    public string? Month13Salary { get; set; }

    [Column("INT_POST_ID_old")]
    [StringLength(38)]
    public string? IntPostIdOld { get; set; }

    [Column("INT_POST_ID")]
    public int? IntPostId { get; set; }

    [Column("POST_ID_old")]
    [StringLength(38)]
    public string? PostIdOld { get; set; }

    [Column("POST_ID")]
    public int? PostId { get; set; }

    [Column("INT_POST_TYPE_ID_old")]
    [StringLength(38)]
    public string? IntPostTypeIdOld { get; set; }

    [Column("INT_POST_TYPE_ID")]
    public int? IntPostTypeId { get; set; }

    [Column("INT_GRP_ID_old")]
    [StringLength(38)]
    public string? IntGrpIdOld { get; set; }

    [Column("INT_GRP_ID")]
    public int? IntGrpId { get; set; }

    [Column("INT_SRV_ID_old")]
    [StringLength(38)]
    public string? IntSrvIdOld { get; set; }

    [Column("INT_SRV_ID")]
    public int? IntSrvId { get; set; }

    [Column("INT_PAYB_ID_old")]
    [StringLength(38)]
    public string? IntPaybIdOld { get; set; }

    [Column("INT_PAYB_ID")]
    public int? IntPaybId { get; set; }

    [Column("INT_GRADE_PAY_ID_old")]
    [StringLength(38)]
    public string? IntGradePayIdOld { get; set; }

    [Column("INT_GRADE_PAY_ID")]
    public int? IntGradePayId { get; set; }

    [Column("INT_DEPT_ID_old")]
    [StringLength(38)]
    public string? IntDeptIdOld { get; set; }

    [Column("INT_DEPT_ID")]
    public int? IntDeptId { get; set; }

    [Column("CREATED_USER_ID_old")]
    [StringLength(38)]
    public string? CreatedUserIdOld { get; set; }

    [Column("CREATED_USER_ID")]
    public int? CreatedUserId { get; set; }

    [Column("MODIFIED_USER_ID_old")]
    [StringLength(38)]
    public string? ModifiedUserIdOld { get; set; }

    [Column("MODIFIED_USER_ID")]
    public int? ModifiedUserId { get; set; }

    [Column("INT_CADRE_ID_old")]
    [StringLength(38)]
    public string? IntCadreIdOld { get; set; }

    [Column("INT_CADRE_ID")]
    public int? IntCadreId { get; set; }

    [Column("NO_OF_POST_SANCTIONED_old")]
    [StringLength(38)]
    public string? NoOfPostSanctionedOld { get; set; }

    [Column("NO_OF_POST_SANCTIONED")]
    public int? NoOfPostSanctioned { get; set; }

    [Column("INT_PAY_SCALE_ID_old")]
    [StringLength(38)]
    public string? IntPayScaleIdOld { get; set; }

    [Column("INT_PAY_SCALE_ID")]
    public int? IntPayScaleId { get; set; }
}
