using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_backend.DAL.Entities;

[Keyless]
[Table("hr_mm_gen_hoa_map", Schema = "ihrms_master")]
public partial class HrMmGenHoaMap
{
    [Column("OLD_DEMAND_NO")]
    [StringLength(2)]
    public string? OldDemandNo { get; set; }

    [Column("OLD_MAJOR_HEAD")]
    [StringLength(4)]
    public string? OldMajorHead { get; set; }

    [Column("OLD_SUBMAJOR_HEAD")]
    [StringLength(2)]
    public string? OldSubmajorHead { get; set; }

    [Column("OLD_MINOR_HEAD")]
    [StringLength(3)]
    public string? OldMinorHead { get; set; }

    [Column("OLD_PLAN_STATUS")]
    [StringLength(2)]
    public string? OldPlanStatus { get; set; }

    [Column("OLD_SCHEME_HEAD")]
    [StringLength(3)]
    public string? OldSchemeHead { get; set; }

    [Column("OLD_DETAIL_HEAD")]
    [StringLength(2)]
    public string? OldDetailHead { get; set; }

    [Column("OLD_SUBDETAIL_HEAD")]
    [StringLength(2)]
    public string? OldSubdetailHead { get; set; }

    [Column("OLD_CHARGED_VOTED")]
    [StringLength(1)]
    public string? OldChargedVoted { get; set; }

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

    [Column("ACTIVE_FLAG")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("CREATED_TIMESTAMP")]
    public DateOnly CreatedTimestamp { get; set; }

    [Column("MODIFIED_TIMESTAMP")]
    public DateOnly ModifiedTimestamp { get; set; }

    [Column("HRMS_FLAG")]
    [StringLength(1)]
    public string? HrmsFlag { get; set; }

    [Column("OLD_DEPT_CODE")]
    [StringLength(2)]
    public string? OldDeptCode { get; set; }

    [Column("DEPT_CODE")]
    [StringLength(2)]
    public string? DeptCode { get; set; }

    [Column("OLD_SCHEME_TYPE")]
    [StringLength(2)]
    public string? OldSchemeType { get; set; }

    [Column("NEW_SCHEME_TYPE")]
    [StringLength(2)]
    public string? NewSchemeType { get; set; }

    [Column("GOVT_ORDER_NO")]
    [StringLength(500)]
    public string? GovtOrderNo { get; set; }

    [Column("GOVT_ORDER_DATE")]
    public DateOnly? GovtOrderDate { get; set; }

    [Column("WEF_DATE")]
    public DateOnly? WefDate { get; set; }

    [Column("FIN_YEAR_FROM_old")]
    [StringLength(38)]
    public string? FinYearFromOld { get; set; }

    [Column("FIN_YEAR_FROM")]
    public int? FinYearFrom { get; set; }

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

    [Column("DML_STATUS_FLAG_old")]
    [StringLength(38)]
    public string? DmlStatusFlagOld { get; set; }

    [Column("DML_STATUS_FLAG")]
    public int? DmlStatusFlag { get; set; }

    [Column("INT_HOA_MAP_ID_old")]
    [StringLength(38)]
    public string? IntHoaMapIdOld { get; set; }

    [Column("INT_HOA_MAP_ID")]
    public int? IntHoaMapId { get; set; }
}
