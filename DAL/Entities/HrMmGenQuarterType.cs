using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NGIPF_BE.DAL.Entities;

[Keyless]
[Table("hr_mm_gen_quarter_type", Schema = "ihrms_master")]
public partial class HrMmGenQuarterType
{
    [Column("QUARTER_DESCRIPTION")]
    [StringLength(200)]
    public string? QuarterDescription { get; set; }

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

    [Column("WEF")]
    public DateOnly? Wef { get; set; }

    [Column("CREATED_TIMESTAMP")]
    public DateOnly CreatedTimestamp { get; set; }

    [Column("MODIFIED_TIMESTAMP")]
    public DateOnly ModifiedTimestamp { get; set; }

    [Column("QUARTER_ABBR")]
    [StringLength(5)]
    public string? QuarterAbbr { get; set; }

    [Column("INT_QUARTER_TYPE_ID_old")]
    [StringLength(38)]
    public string? IntQuarterTypeIdOld { get; set; }

    [Column("INT_QUARTER_TYPE_ID")]
    public int? IntQuarterTypeId { get; set; }

    [Column("INT_OMI_QUARTER_TYPE_old")]
    [StringLength(38)]
    public string? IntOmiQuarterTypeOld { get; set; }

    [Column("INT_OMI_QUARTER_TYPE")]
    public int? IntOmiQuarterType { get; set; }

    [Column("RENT_AMOUNT_old")]
    [StringLength(38)]
    public string? RentAmountOld { get; set; }

    [Column("RENT_AMOUNT")]
    public int? RentAmount { get; set; }

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
}
