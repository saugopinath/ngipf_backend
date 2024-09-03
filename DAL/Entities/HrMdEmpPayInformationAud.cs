using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;
using Microsoft.EntityFrameworkCore;

namespace ngipf_backend.DAL.Entities;

[Table("hr_md_emp_pay_information_aud", Schema = "ihrms")]
[Index("IntPayScaleIdObs", Name = "ind_hr_md_emp_pay_aud3")]
[Index("IntEmployeeId", Name = "ind_hr_md_emp_pay_info_aud")]
[Index("IntRevPayAllowanceId", Name = "ind_hr_md_emp_pay_info_aud1")]
[Index("IntPaybIdObs", Name = "ind_hr_md_emp_pay_info_aud2")]
[Index("RequestId", Name = "ind_hr_md_emp_pay_info_aud4")]
[Index("IntGradePayIdObs", Name = "ind_hr_md_emp_pay_info_aud8")]
public partial class HrMdEmpPayInformationAud
{
    [Key]
    [Column("int_emp_pay_information_id_aud")]
    [StringLength(38)]
    public string IntEmpPayInformationIdAud { get; set; } = null!;

    [Column("int_emp_pay_information_id")]
    [StringLength(38)]
    public string? IntEmpPayInformationId { get; set; }

    [Column("int_employee_id")]
    [Precision(38, 0)]
    public BigInteger? IntEmployeeId { get; set; }

    [Column("int_rev_pay_allowance_id")]
    [StringLength(38)]
    public string? IntRevPayAllowanceId { get; set; }

    [Column("int_payb_id_obs")]
    [StringLength(38)]
    public string? IntPaybIdObs { get; set; }

    [Column("int_pay_scale_id_obs")]
    [StringLength(38)]
    public string? IntPayScaleIdObs { get; set; }

    [Column("perc_of_basic_in_suspe_obs")]
    [Precision(5, 2)]
    public decimal? PercOfBasicInSuspeObs { get; set; }

    [Column("date_of_next_increment", TypeName = "timestamp(0) without time zone")]
    public DateTime? DateOfNextIncrement { get; set; }

    [Column("wef", TypeName = "timestamp(0) without time zone")]
    public DateTime? Wef { get; set; }

    [Column("effective_end_date", TypeName = "timestamp(0) without time zone")]
    public DateTime? EffectiveEndDate { get; set; }

    [Column("active_flag")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("created_user_id")]
    public int? CreatedUserId { get; set; }

    [Column("created_timestamp", TypeName = "timestamp(0) without time zone")]
    public DateTime? CreatedTimestamp { get; set; }

    [Column("modified_user_id")]
    public int? ModifiedUserId { get; set; }

    [Column("modified_timestamp", TypeName = "timestamp(0) without time zone")]
    public DateTime? ModifiedTimestamp { get; set; }

    [Column("benf_id_obs")]
    [StringLength(38)]
    public string? BenfIdObs { get; set; }

    [Column("request_id")]
    public long? RequestId { get; set; }

    [Column("health_insurance_type_obs")]
    [StringLength(1)]
    public string? HealthInsuranceTypeObs { get; set; }

    [Column("wbhs_card_number_obs")]
    [StringLength(50)]
    public string? WbhsCardNumberObs { get; set; }

    [Column("ppo_id")]
    public long? PpoId { get; set; }

    [Column("int_treasury_code")]
    [StringLength(5)]
    public string? IntTreasuryCode { get; set; }

    [Column("basic_pension")]
    [Precision(10, 2)]
    public decimal? BasicPension { get; set; }

    [Column("last_pay_basic")]
    [Precision(10, 2)]
    public decimal? LastPayBasic { get; set; }

    [Column("last_grade_pay")]
    [Precision(10, 2)]
    public decimal? LastGradePay { get; set; }

    [Column("last_pay_da")]
    [Precision(10, 2)]
    public decimal? LastPayDa { get; set; }

    [Column("last_pay_hra")]
    [Precision(10, 2)]
    public decimal? LastPayHra { get; set; }

    [Column("da_pension")]
    [Precision(10, 2)]
    public decimal? DaPension { get; set; }

    [Column("hra_pension")]
    [Precision(10, 2)]
    public decimal? HraPension { get; set; }

    [Column("int_grade_pay_id_obs")]
    [StringLength(38)]
    public string? IntGradePayIdObs { get; set; }

    [Column("go_order_number")]
    [StringLength(50)]
    public string? GoOrderNumber { get; set; }

    [Column("go_order_date", TypeName = "timestamp(0) without time zone")]
    public DateTime? GoOrderDate { get; set; }

    [Column("service_book_flag")]
    [StringLength(1)]
    public string? ServiceBookFlag { get; set; }

    [Column("notional_date", TypeName = "timestamp(0) without time zone")]
    public DateTime? NotionalDate { get; set; }

    [Column("int_omi_reason_for_changes")]
    [StringLength(38)]
    public string? IntOmiReasonForChanges { get; set; }

    [Column("modifiable_flag")]
    [StringLength(1)]
    public string? ModifiableFlag { get; set; }

    [Column("remarks")]
    [StringLength(1000)]
    public string? Remarks { get; set; }

    [Column("int_omi_srv_book_block_id")]
    [StringLength(38)]
    public string? IntOmiSrvBookBlockId { get; set; }

    [Column("srv_book_request_init")]
    [StringLength(38)]
    public string? SrvBookRequestInit { get; set; }

    [Column("int_pay_info_srv_book_id")]
    [StringLength(38)]
    public string? IntPayInfoSrvBookId { get; set; }

    [Column("int_pay_info_dtls_srv_book")]
    [StringLength(38)]
    public string? IntPayInfoDtlsSrvBook { get; set; }
}
