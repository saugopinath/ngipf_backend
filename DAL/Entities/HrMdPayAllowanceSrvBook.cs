using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NGIPF_BE.DAL.Entities;

[Table("hr_md_pay_allowance_srv_book", Schema = "ihrms_emp_master")]
public partial class HrMdPayAllowanceSrvBook
{
    [Column("wef")]
    public DateOnly? Wef { get; set; }

    [Column("effective_end_date")]
    public DateOnly? EffectiveEndDate { get; set; }

    [Column("active_flag")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("created_timestamp", TypeName = "timestamp without time zone")]
    public DateTime? CreatedTimestamp { get; set; }

    [Column("remarks")]
    [StringLength(1000)]
    public string? Remarks { get; set; }

    [Column("modifiable_flag")]
    [StringLength(1)]
    public string? ModifiableFlag { get; set; }

    [Column("go_order_number")]
    [StringLength(100)]
    public string? GoOrderNumber { get; set; }

    [Column("go_order_date")]
    public DateOnly? GoOrderDate { get; set; }

    [Column("service_book_flag")]
    [StringLength(1)]
    public string? ServiceBookFlag { get; set; }

    [Column("notional_date")]
    public DateOnly? NotionalDate { get; set; }

    [Column("inserted_flag")]
    [StringLength(1)]
    public string? InsertedFlag { get; set; }

    [Column("modified_by_ddo_flag")]
    [StringLength(1)]
    public string? ModifiedByDdoFlag { get; set; }

    [Column("modified_timestamp")]
    public DateOnly ModifiedTimestamp { get; set; }

    [Column("int_pay_allow_dtls_srv_book_old")]
    [StringLength(38)]
    public string? IntPayAllowDtlsSrvBookOld { get; set; }

    [Column("srv_book_request_init_old")]
    [StringLength(38)]
    public string? SrvBookRequestInitOld { get; set; }

    [Column("srv_book_request_init")]
    public int? SrvBookRequestInit { get; set; }

    [Column("int_emp_pay_and_allowance_id_old")]
    [StringLength(38)]
    public string? IntEmpPayAndAllowanceIdOld { get; set; }

    [Column("int_emp_pay_and_allowance_id")]
    public int? IntEmpPayAndAllowanceId { get; set; }

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

    [Column("created_user_id_old")]
    [StringLength(38)]
    public string? CreatedUserIdOld { get; set; }

    [Column("created_user_id")]
    public int? CreatedUserId { get; set; }

    [Column("request_id_old")]
    [StringLength(38)]
    public string? RequestIdOld { get; set; }

    [Column("request_id")]
    public int? RequestId { get; set; }

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

    [Column("dml_status_flag_old")]
    [StringLength(38)]
    public string? DmlStatusFlagOld { get; set; }

    [Column("dml_status_flag")]
    public int? DmlStatusFlag { get; set; }

    [Column("int_pay_info_dtls_srv_book_old")]
    [StringLength(38)]
    public string? IntPayInfoDtlsSrvBookOld { get; set; }

    [Column("modified_user_id_old")]
    [StringLength(38)]
    public string? ModifiedUserIdOld { get; set; }

    [Column("modified_user_id")]
    public int? ModifiedUserId { get; set; }

    [Column("int_pay_info_dtls_srv_book")]
    public int? IntPayInfoDtlsSrvBook { get; set; }

    [Key]
    [Column("int_pay_allow_dtls_srv_book")]
    public int IntPayAllowDtlsSrvBook { get; set; }

    [InverseProperty("IntPayAllowDtlsSrvBookNavigation")]
    public virtual ICollection<HrMdEmpPayAndAllowance> HrMdEmpPayAndAllowances { get; set; } = new List<HrMdEmpPayAndAllowance>();
}
