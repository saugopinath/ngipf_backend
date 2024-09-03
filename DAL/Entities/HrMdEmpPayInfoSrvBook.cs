using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_backend.DAL.Entities;

[Table("hr_md_emp_pay_info_srv_book", Schema = "ihrms_emp_master")]
public partial class HrMdEmpPayInfoSrvBook
{
    [Column("date_of_next_increment")]
    public DateOnly? DateOfNextIncrement { get; set; }

    [Column("wef")]
    public DateOnly? Wef { get; set; }

    [Column("effective_end_date")]
    public DateOnly? EffectiveEndDate { get; set; }

    [Column("active_flag")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("created_timestamp")]
    public DateOnly CreatedTimestamp { get; set; }

    [Column("modified_timestamp")]
    public DateOnly ModifiedTimestamp { get; set; }

    [Column("int_treasury_code")]
    [StringLength(5)]
    public string? IntTreasuryCode { get; set; }

    [Column("go_order_number")]
    [StringLength(100)]
    public string? GoOrderNumber { get; set; }

    [Column("go_order_date")]
    public DateOnly? GoOrderDate { get; set; }

    [Column("remarks")]
    [StringLength(1000)]
    public string? Remarks { get; set; }

    [Column("service_book_flag")]
    [StringLength(1)]
    public string? ServiceBookFlag { get; set; }

    [Column("notional_date")]
    public DateOnly? NotionalDate { get; set; }

    [Column("modifiable_flag")]
    [StringLength(1)]
    public string? ModifiableFlag { get; set; }

    [Column("inserted_flag")]
    [StringLength(1)]
    public string? InsertedFlag { get; set; }

    [Column("int_pay_info_srv_book_id_old")]
    [StringLength(38)]
    public string? IntPayInfoSrvBookIdOld { get; set; }

    [Column("srv_book_request_init_old")]
    [StringLength(38)]
    public string? SrvBookRequestInitOld { get; set; }

    [Column("srv_book_request_init")]
    public int? SrvBookRequestInit { get; set; }

    [Column("int_emp_pay_information_id_old")]
    [StringLength(38)]
    public string? IntEmpPayInformationIdOld { get; set; }

    [Column("int_emp_pay_information_id")]
    public int? IntEmpPayInformationId { get; set; }

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

    [Column("request_id_old")]
    [StringLength(38)]
    public string? RequestIdOld { get; set; }

    [Column("request_id")]
    public int? RequestId { get; set; }

    [Column("ppo_id_old")]
    [StringLength(38)]
    public string? PpoIdOld { get; set; }

    [Column("ppo_id")]
    public int? PpoId { get; set; }

    [Column("last_pay_basic_old")]
    [StringLength(38)]
    public string? LastPayBasicOld { get; set; }

    [Column("last_pay_basic")]
    public int? LastPayBasic { get; set; }

    [Column("last_grade_pay_old")]
    [StringLength(38)]
    public string? LastGradePayOld { get; set; }

    [Column("last_grade_pay")]
    public int? LastGradePay { get; set; }

    [Column("last_pay_da_old")]
    [StringLength(38)]
    public string? LastPayDaOld { get; set; }

    [Column("last_pay_da")]
    public int? LastPayDa { get; set; }

    [Column("last_pay_hra_old")]
    [StringLength(38)]
    public string? LastPayHraOld { get; set; }

    [Column("last_pay_hra")]
    public int? LastPayHra { get; set; }

    [Column("basic_pension_old")]
    [StringLength(38)]
    public string? BasicPensionOld { get; set; }

    [Column("basic_pension")]
    public int? BasicPension { get; set; }

    [Column("da_pension_old")]
    [StringLength(38)]
    public string? DaPensionOld { get; set; }

    [Column("da_pension")]
    public int? DaPension { get; set; }

    [Column("hra_pension_old")]
    [StringLength(38)]
    public string? HraPensionOld { get; set; }

    [Column("hra_pension")]
    public int? HraPension { get; set; }

    [Column("int_omi_reason_for_changes_old")]
    [StringLength(38)]
    public string? IntOmiReasonForChangesOld { get; set; }

    [Column("int_omi_reason_for_changes")]
    public int? IntOmiReasonForChanges { get; set; }

    [Column("dml_status_flag_old")]
    [StringLength(38)]
    public string? DmlStatusFlagOld { get; set; }

    [Column("dml_status_flag")]
    public int? DmlStatusFlag { get; set; }

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

    [Key]
    [Column("int_pay_info_srv_book_id")]
    public int IntPayInfoSrvBookId { get; set; }

    [InverseProperty("IntPayInfoSrvBook")]
    public virtual ICollection<HrMdEmpPayInformationWf> HrMdEmpPayInformationWfs { get; set; } = new List<HrMdEmpPayInformationWf>();

    [InverseProperty("IntPayInfoSrvBook")]
    public virtual ICollection<HrMdEmpPayInformation> HrMdEmpPayInformations { get; set; } = new List<HrMdEmpPayInformation>();
}
