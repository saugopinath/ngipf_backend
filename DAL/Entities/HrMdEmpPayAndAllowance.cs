using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_frontend.DAL.Entities;

[Table("hr_md_emp_pay_and_allowance", Schema = "ihrms_emp_master")]
public partial class HrMdEmpPayAndAllowance
{
    [Column("wef")]
    public DateOnly? Wef { get; set; }

    [Column("effective_end_date")]
    public DateOnly? EffectiveEndDate { get; set; }

    [Column("last_updated_on", TypeName = "timestamp without time zone")]
    public DateTime? LastUpdatedOn { get; set; }

    [Column("remarks")]
    [StringLength(1000)]
    public string? Remarks { get; set; }

    [Column("modifiable_flag")]
    [StringLength(1)]
    public string? ModifiableFlag { get; set; }

    [Column("active_flag")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("go_order_number")]
    [StringLength(50)]
    public string? GoOrderNumber { get; set; }

    [Column("go_order_date")]
    public DateOnly? GoOrderDate { get; set; }

    [Column("service_book_flag")]
    [StringLength(1)]
    public string? ServiceBookFlag { get; set; }

    [Column("notional_date")]
    public DateOnly? NotionalDate { get; set; }

    [Column("legacy_flag")]
    [StringLength(1)]
    public string? LegacyFlag { get; set; }

    [Column("deleted_frm_srv_bk")]
    [StringLength(1)]
    public string? DeletedFrmSrvBk { get; set; }

    [Column("process_data_flag")]
    [StringLength(1)]
    public string? ProcessDataFlag { get; set; }

    [Column("int_emp_pay_and_allowance_id_old")]
    [StringLength(38)]
    public string? IntEmpPayAndAllowanceIdOld { get; set; }

    [Column("int_employee_id_old")]
    [StringLength(38)]
    public string? IntEmployeeIdOld { get; set; }

    [Column("int_employee_id")]
    public int? IntEmployeeId { get; set; }

    [Column("int_comp_id_old")]
    [StringLength(38)]
    public string? IntCompIdOld { get; set; }

    [Column("int_comp_id")]
    public int? IntCompId { get; set; }

    [Column("allowance_amount_old")]
    [StringLength(38)]
    public string? AllowanceAmountOld { get; set; }

    [Column("allowance_amount")]
    public int? AllowanceAmount { get; set; }

    [Column("last_updated_by_old")]
    [StringLength(38)]
    public string? LastUpdatedByOld { get; set; }

    [Column("last_updated_by")]
    public int? LastUpdatedBy { get; set; }

    [Column("request_id_old")]
    [StringLength(38)]
    public string? RequestIdOld { get; set; }

    [Column("request_id")]
    public long? RequestId { get; set; }

    [Column("int_grade_pay_id_old")]
    [StringLength(38)]
    public string? IntGradePayIdOld { get; set; }

    [Column("int_grade_pay_id")]
    public int? IntGradePayId { get; set; }

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

    [Column("int_rev_pay_allowance_id_old")]
    [StringLength(38)]
    public string? IntRevPayAllowanceIdOld { get; set; }

    [Column("int_rev_pay_allowance_id")]
    public int? IntRevPayAllowanceId { get; set; }

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

    [Column("int_td_payfix_dtl_id_old")]
    [StringLength(38)]
    public string? IntTdPayfixDtlIdOld { get; set; }

    [Column("int_td_payfix_dtl_id")]
    public int? IntTdPayfixDtlId { get; set; }

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

    [Column("int_emp_pay_information_id_old")]
    [StringLength(38)]
    public string? IntEmpPayInformationIdOld { get; set; }

    [Column("int_emp_pay_information_id")]
    public int? IntEmpPayInformationId { get; set; }

    [Column("int_emp_pay_scale_band_info_old")]
    [StringLength(38)]
    public string? IntEmpPayScaleBandInfoOld { get; set; }

    [Column("int_emp_pay_scale_band_info")]
    public int? IntEmpPayScaleBandInfo { get; set; }

    [Column("int_tm_payfix_id_old")]
    [StringLength(38)]
    public string? IntTmPayfixIdOld { get; set; }

    [Column("int_tm_payfix_id")]
    public int? IntTmPayfixId { get; set; }

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

    [Column("int_pay_allow_dtls_srv_book_old")]
    [StringLength(38)]
    public string? IntPayAllowDtlsSrvBookOld { get; set; }

    [Column("int_pay_allow_dtls_srv_book")]
    public int? IntPayAllowDtlsSrvBook { get; set; }

    [Column("int_pay_info_dtls_srv_book_old")]
    [StringLength(38)]
    public string? IntPayInfoDtlsSrvBookOld { get; set; }

    [Column("int_pay_info_dtls_srv_book")]
    public int? IntPayInfoDtlsSrvBook { get; set; }

    [Column("process_source_pk_old")]
    [StringLength(38)]
    public string? ProcessSourcePkOld { get; set; }

    [Column("process_source_pk")]
    public int? ProcessSourcePk { get; set; }

    [Key]
    [Column("int_emp_pay_and_allowance_id")]
    public int IntEmpPayAndAllowanceId { get; set; }

    [ForeignKey("IntCompId")]
    [InverseProperty("HrMdEmpPayAndAllowances")]
    public virtual HrMmGenComponent? IntComp { get; set; }

    [ForeignKey("IntEmpPayInformationId")]
    [InverseProperty("HrMdEmpPayAndAllowances")]
    public virtual HrMdEmpPayInformation? IntEmpPayInformation { get; set; }

    [ForeignKey("IntEmployeeId")]
    [InverseProperty("HrMdEmpPayAndAllowances")]
    public virtual HrMmEmpBasicDtl? IntEmployee { get; set; }

    [ForeignKey("IntOmiSrvBookBlockId")]
    [InverseProperty("HrMdEmpPayAndAllowances")]
    public virtual HrMmGenOtherMaster? IntOmiSrvBookBlock { get; set; }

    [ForeignKey("IntPayAllowDtlsSrvBook")]
    [InverseProperty("HrMdEmpPayAndAllowances")]
    public virtual HrMdPayAllowanceSrvBook? IntPayAllowDtlsSrvBookNavigation { get; set; }

    [ForeignKey("IntPayInfoDtlsSrvBook")]
    [InverseProperty("HrMdEmpPayAndAllowances")]
    public virtual HrMdPayScaleBandSrvBook? IntPayInfoDtlsSrvBookNavigation { get; set; }

    [ForeignKey("IntTdIncementId")]
    [InverseProperty("HrMdEmpPayAndAllowances")]
    public virtual HrTdEmpIncrement? IntTdIncement { get; set; }

    [ForeignKey("IntTdPayfixDtlId")]
    [InverseProperty("HrMdEmpPayAndAllowances")]
    public virtual HrTdPayfixDtl? IntTdPayfixDtl { get; set; }

    [ForeignKey("IntTmPayfixId")]
    [InverseProperty("HrMdEmpPayAndAllowances")]
    public virtual HrTmPayfix? IntTmPayfix { get; set; }

    [ForeignKey("RequestId")]
    [InverseProperty("HrMdEmpPayAndAllowances")]
    public virtual HrMmGenWorkflowMaster? Request { get; set; }

    [ForeignKey("SrvBookRequestInit")]
    [InverseProperty("HrMdEmpPayAndAllowances")]
    public virtual HrTmSrvBookRequestInit? SrvBookRequestInitNavigation { get; set; }
}
