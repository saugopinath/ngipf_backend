using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NGIPF_BE.DAL.Entities;

[Table("hr_md_pay_scale_band_srv_book", Schema = "ihrms_emp_master")]
public partial class HrMdPayScaleBandSrvBook
{
    [Column("wef")]
    public DateOnly Wef { get; set; }

    [Column("effective_end_date")]
    public DateOnly? EffectiveEndDate { get; set; }

    [Column("active_flag")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("created_timestamp")]
    public DateOnly CreatedTimestamp { get; set; }

    [Column("modified_timestamp")]
    public DateOnly ModifiedTimestamp { get; set; }

    [Column("go_order_number")]
    [StringLength(100)]
    public string? GoOrderNumber { get; set; }

    [Column("go_order_date")]
    public DateOnly? GoOrderDate { get; set; }

    [Column("remarks")]
    [StringLength(1000)]
    public string? Remarks { get; set; }

    [Column("pay_fixation_date")]
    public DateOnly? PayFixationDate { get; set; }

    [Column("service_book_flag")]
    [StringLength(1)]
    public string? ServiceBookFlag { get; set; }

    [Column("modifiable_flag")]
    [StringLength(1)]
    public string? ModifiableFlag { get; set; }

    [Column("inserted_flag")]
    [StringLength(1)]
    public string? InsertedFlag { get; set; }

    [Column("notional_effect_date")]
    public DateOnly? NotionalEffectDate { get; set; }

    [Column("modified_by_ddo_flag")]
    [StringLength(1)]
    public string? ModifiedByDdoFlag { get; set; }

    [Column("int_pay_info_dtls_srv_book_old")]
    [StringLength(38)]
    public string? IntPayInfoDtlsSrvBookOld { get; set; }

    [Column("srv_book_request_init_old")]
    [StringLength(38)]
    public string? SrvBookRequestInitOld { get; set; }

    [Column("srv_book_request_init")]
    public int? SrvBookRequestInit { get; set; }

    [Column("int_emp_pay_scale_band_info_old")]
    [StringLength(38)]
    public string? IntEmpPayScaleBandInfoOld { get; set; }

    [Column("int_emp_pay_scale_band_info")]
    public int? IntEmpPayScaleBandInfo { get; set; }

    [Column("int_employee_id_old")]
    [StringLength(38)]
    public string? IntEmployeeIdOld { get; set; }

    [Column("int_employee_id")]
    public int? IntEmployeeId { get; set; }

    [Column("int_rev_pay_allowance_id_old")]
    [StringLength(38)]
    public string? IntRevPayAllowanceIdOld { get; set; }

    [Column("int_rev_pay_allowance_id")]
    public int? IntRevPayAllowanceId { get; set; }

    [Column("int_payb_id_from_old")]
    [StringLength(38)]
    public string? IntPaybIdFromOld { get; set; }

    [Column("int_payb_id_from")]
    public int? IntPaybIdFrom { get; set; }

    [Column("int_pay_scale_id_from_old")]
    [StringLength(38)]
    public string? IntPayScaleIdFromOld { get; set; }

    [Column("int_pay_scale_id_from")]
    public int? IntPayScaleIdFrom { get; set; }

    [Column("request_id_old")]
    [StringLength(38)]
    public string? RequestIdOld { get; set; }

    [Column("request_id")]
    public int? RequestId { get; set; }

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

    [Column("int_omi_type_of_promotion_old")]
    [StringLength(38)]
    public string? IntOmiTypeOfPromotionOld { get; set; }

    [Column("int_omi_type_of_promotion")]
    public int? IntOmiTypeOfPromotion { get; set; }

    [Column("int_omi_srv_book_block_id_old")]
    [StringLength(38)]
    public string? IntOmiSrvBookBlockIdOld { get; set; }

    [Column("int_omi_srv_book_block_id")]
    public int? IntOmiSrvBookBlockId { get; set; }

    [Column("dml_status_flag_old")]
    [StringLength(38)]
    public string? DmlStatusFlagOld { get; set; }

    [Column("dml_status_flag")]
    public int? DmlStatusFlag { get; set; }

    [Column("int_payb_id_to_old")]
    [StringLength(38)]
    public string? IntPaybIdToOld { get; set; }

    [Column("int_payb_id_to")]
    public int? IntPaybIdTo { get; set; }

    [Column("int_pay_scale_id_to_old")]
    [StringLength(38)]
    public string? IntPayScaleIdToOld { get; set; }

    [Column("int_pay_scale_id_to")]
    public int? IntPayScaleIdTo { get; set; }

    [Column("int_appnt_dtls_srv_book_obs_old")]
    [StringLength(38)]
    public string? IntAppntDtlsSrvBookObsOld { get; set; }

    [Column("int_appnt_dtls_srv_book_obs")]
    public int? IntAppntDtlsSrvBookObs { get; set; }

    [Column("int_appnt_dtls_srv_book_s_old")]
    [StringLength(38)]
    public string? IntAppntDtlsSrvBookSOld { get; set; }

    [Column("int_appnt_dtls_srv_book_s")]
    public int? IntAppntDtlsSrvBookS { get; set; }

    [Column("pay_scale_due_to_old")]
    [StringLength(38)]
    public string? PayScaleDueToOld { get; set; }

    [Column("pay_scale_due_to")]
    public int? PayScaleDueTo { get; set; }

    [Column("int_pay_info_dtls_srv_bk_promo_old")]
    [StringLength(38)]
    public string? IntPayInfoDtlsSrvBkPromoOld { get; set; }

    [Column("int_pay_info_dtls_srv_bk_promo")]
    public int? IntPayInfoDtlsSrvBkPromo { get; set; }

    [Column("prev_int_pay_info_srv_book_old")]
    [StringLength(38)]
    public string? PrevIntPayInfoSrvBookOld { get; set; }

    [Column("prev_int_pay_info_srv_book")]
    public int? PrevIntPayInfoSrvBook { get; set; }

    [Column("int_payfix_tool_id_old")]
    [StringLength(38)]
    public string? IntPayfixToolIdOld { get; set; }

    [Column("int_payfix_tool_id")]
    public int? IntPayfixToolId { get; set; }

    [Column("sl_no_old")]
    [StringLength(38)]
    public string? SlNoOld { get; set; }

    [Column("sl_no")]
    public int? SlNo { get; set; }

    [Column("int_td_payfix_id_old")]
    [StringLength(38)]
    public string? IntTdPayfixIdOld { get; set; }

    [Column("int_td_payfix_id")]
    public int? IntTdPayfixId { get; set; }

    [Key]
    [Column("int_pay_info_dtls_srv_book")]
    public int IntPayInfoDtlsSrvBook { get; set; }

    [InverseProperty("IntPayInfoDtlsSrvBookNavigation")]
    public virtual ICollection<HrMdEmpPayAndAllowance> HrMdEmpPayAndAllowances { get; set; } = new List<HrMdEmpPayAndAllowance>();

    [InverseProperty("IntPayInfoDtlsSrvBookNavigation")]
    public virtual ICollection<HrMdEmpPayInformationWf> HrMdEmpPayInformationWfs { get; set; } = new List<HrMdEmpPayInformationWf>();

    [InverseProperty("IntPayInfoDtlsSrvBookNavigation")]
    public virtual ICollection<HrMdEmpPayInformation> HrMdEmpPayInformations { get; set; } = new List<HrMdEmpPayInformation>();
}
