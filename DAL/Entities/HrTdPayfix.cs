using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_frontend.DAL.Entities;

[Table("hr_td_payfix", Schema = "ihrms_emp_master")]
public partial class HrTdPayfix
{
    [Column("order_number")]
    [StringLength(30)]
    public string? OrderNumber { get; set; }

    [Column("order_date")]
    public DateOnly? OrderDate { get; set; }

    [Column("start_date")]
    public DateOnly StartDate { get; set; }

    [Column("end_date")]
    public DateOnly? EndDate { get; set; }

    [Column("validate_flag")]
    [StringLength(1)]
    public string? ValidateFlag { get; set; }

    [Column("hrms_flag")]
    [StringLength(1)]
    public string? HrmsFlag { get; set; }

    [Column("employee_choice_flag")]
    [StringLength(3)]
    public string? EmployeeChoiceFlag { get; set; }

    [Column("employee_choice_date")]
    public DateOnly? EmployeeChoiceDate { get; set; }

    [Column("actual_date")]
    public DateOnly? ActualDate { get; set; }

    [Column("notional_date")]
    public DateOnly? NotionalDate { get; set; }

    [Column("created_timestamp")]
    public DateOnly CreatedTimestamp { get; set; }

    [Column("modified_timestamp")]
    public DateOnly ModifiedTimestamp { get; set; }

    [Column("next_increment_date")]
    public DateOnly? NextIncrementDate { get; set; }

    [Column("int_td_payfix_id_old")]
    [StringLength(38)]
    public string? IntTdPayfixIdOld { get; set; }

    [Column("int_tm_payfix_id_old")]
    [StringLength(38)]
    public string? IntTmPayfixIdOld { get; set; }

    [Column("int_tm_payfix_id")]
    public int? IntTmPayfixId { get; set; }

    [Column("page_no_old")]
    [StringLength(38)]
    public string? PageNoOld { get; set; }

    [Column("page_no")]
    public int? PageNo { get; set; }

    [Column("int_fix_type_id_old")]
    [StringLength(38)]
    public string? IntFixTypeIdOld { get; set; }

    [Column("int_fix_type_id")]
    public int? IntFixTypeId { get; set; }

    [Column("type_request_id_old")]
    [StringLength(38)]
    public string? TypeRequestIdOld { get; set; }

    [Column("type_request_id")]
    public int? TypeRequestId { get; set; }

    [Column("from_ropa_old")]
    [StringLength(38)]
    public string? FromRopaOld { get; set; }

    [Column("from_ropa")]
    public int? FromRopa { get; set; }

    [Column("to_ropa_old")]
    [StringLength(38)]
    public string? ToRopaOld { get; set; }

    [Column("to_ropa")]
    public int? ToRopa { get; set; }

    [Column("from_ps_old")]
    [StringLength(38)]
    public string? FromPsOld { get; set; }

    [Column("from_ps")]
    public int? FromPs { get; set; }

    [Column("to_ps_old")]
    [StringLength(38)]
    public string? ToPsOld { get; set; }

    [Column("to_ps")]
    public int? ToPs { get; set; }

    [Column("from_pb_old")]
    [StringLength(38)]
    public string? FromPbOld { get; set; }

    [Column("from_pb")]
    public int? FromPb { get; set; }

    [Column("to_pb_old")]
    [StringLength(38)]
    public string? ToPbOld { get; set; }

    [Column("to_pb")]
    public int? ToPb { get; set; }

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

    [Column("from_gp_old")]
    [StringLength(38)]
    public string? FromGpOld { get; set; }

    [Column("from_gp")]
    public int? FromGp { get; set; }

    [Column("to_gp_old")]
    [StringLength(38)]
    public string? ToGpOld { get; set; }

    [Column("to_gp")]
    public int? ToGp { get; set; }

    [Column("from_emp_pay_scale_band_info_old")]
    [StringLength(38)]
    public string? FromEmpPayScaleBandInfoOld { get; set; }

    [Column("from_emp_pay_scale_band_info")]
    public int? FromEmpPayScaleBandInfo { get; set; }

    [Column("to_emp_pay_scale_band_info_old")]
    [StringLength(38)]
    public string? ToEmpPayScaleBandInfoOld { get; set; }

    [Column("to_emp_pay_scale_band_info")]
    public int? ToEmpPayScaleBandInfo { get; set; }

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

    [Column("notional_fore_or_after_noon_old")]
    [StringLength(38)]
    public string? NotionalForeOrAfterNoonOld { get; set; }

    [Column("notional_fore_or_after_noon")]
    public int? NotionalForeOrAfterNoon { get; set; }

    [Column("actual_fore_or_after_noon_old")]
    [StringLength(38)]
    public string? ActualForeOrAfterNoonOld { get; set; }

    [Column("actual_fore_or_after_noon")]
    public int? ActualForeOrAfterNoon { get; set; }

    [Column("npromo_request_map_id_old")]
    [StringLength(38)]
    public string? NpromoRequestMapIdOld { get; set; }

    [Column("npromo_request_map_id")]
    public int? NpromoRequestMapId { get; set; }

    [Column("int_promo_type_id_old")]
    [StringLength(38)]
    public string? IntPromoTypeIdOld { get; set; }

    [Column("int_promo_type_id")]
    public int? IntPromoTypeId { get; set; }

    [Column("int_employee_id_old")]
    [StringLength(38)]
    public string? IntEmployeeIdOld { get; set; }

    [Column("int_employee_id")]
    public int? IntEmployeeId { get; set; }

    [Key]
    [Column("int_td_payfix_id")]
    public int IntTdPayfixId { get; set; }
}
