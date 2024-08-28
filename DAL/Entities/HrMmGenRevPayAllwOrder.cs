using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NGIPF_BE.DAL.Entities;

[Table("hr_mm_gen_rev_pay_allw_order", Schema = "ihrms_master")]
public partial class HrMmGenRevPayAllwOrder
{
    [Column("pay_allowance_name")]
    [StringLength(50)]
    public string? PayAllowanceName { get; set; }

    [Column("pay_allowance_abbr")]
    [StringLength(50)]
    public string? PayAllowanceAbbr { get; set; }

    [Column("rule_circulated_on")]
    public DateOnly? RuleCirculatedOn { get; set; }

    [Column("effective_from_date")]
    public DateOnly? EffectiveFromDate { get; set; }

    [Column("active_flag")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("created_timestamp")]
    public DateOnly CreatedTimestamp { get; set; }

    [Column("modified_timestamp")]
    public DateOnly ModifiedTimestamp { get; set; }

    [Column("go_no")]
    [StringLength(100)]
    public string? GoNo { get; set; }

    [Column("ropa_abbr_system_code")]
    [StringLength(10)]
    public string? RopaAbbrSystemCode { get; set; }

    [Column("int_rev_pay_allowance_id_old")]
    [StringLength(38)]
    public string? IntRevPayAllowanceIdOld { get; set; }

    [Column("int_srv_id_old")]
    [StringLength(38)]
    public string? IntSrvIdOld { get; set; }

    [Column("int_srv_id")]
    public int? IntSrvId { get; set; }

    [Column("effective_from_fin_yr_from_old")]
    [StringLength(38)]
    public string? EffectiveFromFinYrFromOld { get; set; }

    [Column("effective_from_fin_yr_from")]
    public int? EffectiveFromFinYrFrom { get; set; }

    [Column("effective_from_cal_yr_from_old")]
    [StringLength(38)]
    public string? EffectiveFromCalYrFromOld { get; set; }

    [Column("effective_from_cal_yr_from")]
    public int? EffectiveFromCalYrFrom { get; set; }

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

    [Column("int_omi_pay_band_or_scale_old")]
    [StringLength(38)]
    public string? IntOmiPayBandOrScaleOld { get; set; }

    [Column("int_omi_pay_band_or_scale")]
    public int? IntOmiPayBandOrScale { get; set; }

    [Column("max_basic_old")]
    [StringLength(38)]
    public string? MaxBasicOld { get; set; }

    [Column("max_basic")]
    public int? MaxBasic { get; set; }

    [Key]
    [Column("int_rev_pay_allowance_id")]
    public int IntRevPayAllowanceId { get; set; }

    [InverseProperty("IntRevPayAllowance")]
    public virtual ICollection<HrMdEmpPayInformationWf> HrMdEmpPayInformationWfs { get; set; } = new List<HrMdEmpPayInformationWf>();

    [InverseProperty("IntRevPayAllowance")]
    public virtual ICollection<HrMdEmpPayInformation> HrMdEmpPayInformations { get; set; } = new List<HrMdEmpPayInformation>();
}
