using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_backend.DAL.Entities;

[Table("hr_td_payfix_dtl", Schema = "ihrms_emp_master")]
public partial class HrTdPayfixDtl
{
    [Column("wef")]
    public DateOnly Wef { get; set; }

    [Column("add_sub_flag")]
    [StringLength(1)]
    public string? AddSubFlag { get; set; }

    [Column("validate_flag")]
    [StringLength(1)]
    public string? ValidateFlag { get; set; }

    [Column("remarks")]
    [StringLength(200)]
    public string? Remarks { get; set; }

    [Column("created_timestamp")]
    public DateOnly CreatedTimestamp { get; set; }

    [Column("modified_timestamp")]
    public DateOnly ModifiedTimestamp { get; set; }

    [Column("notional_date")]
    public DateOnly? NotionalDate { get; set; }

    [Column("int_td_payfix_dtl_id_old")]
    [StringLength(38)]
    public string? IntTdPayfixDtlIdOld { get; set; }

    [Column("int_td_payfix_id_old")]
    [StringLength(38)]
    public string? IntTdPayfixIdOld { get; set; }

    [Column("int_td_payfix_id")]
    public int? IntTdPayfixId { get; set; }

    [Column("serial_no_old")]
    [StringLength(38)]
    public string? SerialNoOld { get; set; }

    [Column("serial_no")]
    public int? SerialNo { get; set; }

    [Column("int_payfix_tool_map_id_old")]
    [StringLength(38)]
    public string? IntPayfixToolMapIdOld { get; set; }

    [Column("int_payfix_tool_map_id")]
    public int? IntPayfixToolMapId { get; set; }

    [Column("from_pay_scale_id_old")]
    [StringLength(38)]
    public string? FromPayScaleIdOld { get; set; }

    [Column("from_pay_scale_id")]
    public int? FromPayScaleId { get; set; }

    [Column("to_pay_scale_id_old")]
    [StringLength(38)]
    public string? ToPayScaleIdOld { get; set; }

    [Column("to_pay_scale_id")]
    public int? ToPayScaleId { get; set; }

    [Column("from_pay_band_id_old")]
    [StringLength(38)]
    public string? FromPayBandIdOld { get; set; }

    [Column("from_pay_band_id")]
    public int? FromPayBandId { get; set; }

    [Column("to_pay_band_id_old")]
    [StringLength(38)]
    public string? ToPayBandIdOld { get; set; }

    [Column("to_pay_band_id")]
    public int? ToPayBandId { get; set; }

    [Column("from_grade_pay_id_old")]
    [StringLength(38)]
    public string? FromGradePayIdOld { get; set; }

    [Column("from_grade_pay_id")]
    public int? FromGradePayId { get; set; }

    [Column("to_grade_pay_id_old")]
    [StringLength(38)]
    public string? ToGradePayIdOld { get; set; }

    [Column("to_grade_pay_id")]
    public int? ToGradePayId { get; set; }

    [Column("from_band_pay_old")]
    [StringLength(38)]
    public string? FromBandPayOld { get; set; }

    [Column("from_band_pay")]
    public int? FromBandPay { get; set; }

    [Column("to_band_pay_old")]
    [StringLength(38)]
    public string? ToBandPayOld { get; set; }

    [Column("to_band_pay")]
    public int? ToBandPay { get; set; }

    [Column("from_grade_pay_old")]
    [StringLength(38)]
    public string? FromGradePayOld { get; set; }

    [Column("from_grade_pay")]
    public int? FromGradePay { get; set; }

    [Column("to_grade_pay_old")]
    [StringLength(38)]
    public string? ToGradePayOld { get; set; }

    [Column("to_grade_pay")]
    public int? ToGradePay { get; set; }

    [Column("sys_amount_old")]
    [StringLength(38)]
    public string? SysAmountOld { get; set; }

    [Column("sys_amount")]
    public int? SysAmount { get; set; }

    [Column("mod_amount_old")]
    [StringLength(38)]
    public string? ModAmountOld { get; set; }

    [Column("mod_amount")]
    public int? ModAmount { get; set; }

    [Column("from_basic_old")]
    [StringLength(38)]
    public string? FromBasicOld { get; set; }

    [Column("from_basic")]
    public int? FromBasic { get; set; }

    [Column("to_basic_old")]
    [StringLength(38)]
    public string? ToBasicOld { get; set; }

    [Column("to_basic")]
    public int? ToBasic { get; set; }

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

    [Key]
    [Column("int_td_payfix_dtl_id")]
    public int IntTdPayfixDtlId { get; set; }

    [InverseProperty("IntTdPayfixDtl")]
    public virtual ICollection<HrMdEmpPayAndAllowance> HrMdEmpPayAndAllowances { get; set; } = new List<HrMdEmpPayAndAllowance>();
}
