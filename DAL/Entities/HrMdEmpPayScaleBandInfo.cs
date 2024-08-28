using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_frontend.DAL.Entities;

[Table("hr_md_emp_pay_scale_band_info", Schema = "ihrms_emp_master")]
public partial class HrMdEmpPayScaleBandInfo
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
    public DateOnly? ModifiedTimestamp { get; set; }

    [Column("go_order_number")]
    [StringLength(50)]
    public string? GoOrderNumber { get; set; }

    [Column("go_order_date")]
    public DateOnly? GoOrderDate { get; set; }

    [Column("remarks")]
    [StringLength(1000)]
    public string? Remarks { get; set; }

    [Column("notional_date")]
    public DateOnly? NotionalDate { get; set; }

    [Column("service_book_flag")]
    [StringLength(1)]
    public string? ServiceBookFlag { get; set; }

    [Column("modifiable_flag")]
    [StringLength(1)]
    public string? ModifiableFlag { get; set; }

    [Column("deleted_frm_srv_bk")]
    [StringLength(1)]
    public string? DeletedFrmSrvBk { get; set; }

    [Column("inserted_flag")]
    [StringLength(1)]
    public string? InsertedFlag { get; set; }

    [Column("process_data_flag")]
    [StringLength(1)]
    public string? ProcessDataFlag { get; set; }

    [Column("int_emp_pay_scale_band_info_old")]
    [StringLength(38)]
    public string? IntEmpPayScaleBandInfoOld { get; set; }

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

    [Column("int_payb_id_old")]
    [StringLength(38)]
    public string? IntPaybIdOld { get; set; }

    [Column("int_payb_id")]
    public int? IntPaybId { get; set; }

    [Column("int_pay_scale_id_old")]
    [StringLength(38)]
    public string? IntPayScaleIdOld { get; set; }

    [Column("int_pay_scale_id")]
    public int? IntPayScaleId { get; set; }

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

    [Column("int_omi_reason_for_changes_old")]
    [StringLength(38)]
    public string? IntOmiReasonForChangesOld { get; set; }

    [Column("int_omi_reason_for_changes")]
    public int? IntOmiReasonForChanges { get; set; }

    [Column("int_omi_srv_book_block_id_old")]
    [StringLength(38)]
    public string? IntOmiSrvBookBlockIdOld { get; set; }

    [Column("int_omi_srv_book_block_id")]
    public int? IntOmiSrvBookBlockId { get; set; }

    [Column("int_pay_info_dtls_srv_book_old")]
    [StringLength(38)]
    public string? IntPayInfoDtlsSrvBookOld { get; set; }

    [Column("int_pay_info_dtls_srv_book")]
    public int? IntPayInfoDtlsSrvBook { get; set; }

    [Column("int_pay_info_dtls_srv_bk_promo_old")]
    [StringLength(38)]
    public string? IntPayInfoDtlsSrvBkPromoOld { get; set; }

    [Column("int_pay_info_dtls_srv_bk_promo")]
    public int? IntPayInfoDtlsSrvBkPromo { get; set; }

    [Column("int_td_payfix_ropa_dtl_id_old")]
    [StringLength(38)]
    public string? IntTdPayfixRopaDtlIdOld { get; set; }

    [Column("int_td_payfix_ropa_dtl_id")]
    public int? IntTdPayfixRopaDtlId { get; set; }

    [Column("int_payfix_tool_id_old")]
    [StringLength(38)]
    public string? IntPayfixToolIdOld { get; set; }

    [Column("int_payfix_tool_id")]
    public int? IntPayfixToolId { get; set; }

    [Column("serial_no_old")]
    [StringLength(38)]
    public string? SerialNoOld { get; set; }

    [Column("serial_no")]
    public int? SerialNo { get; set; }

    [Column("int_td_payfix_dtl_id_old")]
    [StringLength(38)]
    public string? IntTdPayfixDtlIdOld { get; set; }

    [Column("int_td_payfix_dtl_id")]
    public int? IntTdPayfixDtlId { get; set; }

    [Column("int_td_incement_id_old")]
    [StringLength(38)]
    public string? IntTdIncementIdOld { get; set; }

    [Column("int_td_incement_id")]
    public int? IntTdIncementId { get; set; }

    [Column("srv_book_request_init_old")]
    [StringLength(38)]
    public string? SrvBookRequestInitOld { get; set; }

    [Column("srv_book_request_init")]
    public int? SrvBookRequestInit { get; set; }

    [Key]
    [Column("int_emp_pay_scale_band_info")]
    public int IntEmpPayScaleBandInfo { get; set; }
}
