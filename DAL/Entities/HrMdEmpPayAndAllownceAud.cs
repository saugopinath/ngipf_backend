using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;
using Microsoft.EntityFrameworkCore;

namespace ngipf_frontend.DAL.Entities;

[Table("hr_md_emp_pay_and_allownce_aud", Schema = "ihrms")]
[Index("IntEmployeeId", Name = "ind_hr_md_emp_pay_and_all_aud1")]
[Index("IntCompId", Name = "ind_hr_md_emp_pay_and_all_aud2")]
[Index("IntEmpPayAndAllowanceId", Name = "ind_hr_md_emp_pay_and_all_aud3")]
[Index("RequestId", Name = "ind_hr_md_emp_pay_and_all_aud4")]
public partial class HrMdEmpPayAndAllownceAud
{
    [Key]
    [Column("int_emp_pay_and_allow_id_aud")]
    [StringLength(38)]
    public string IntEmpPayAndAllowIdAud { get; set; } = null!;

    [Column("int_emp_pay_and_allowance_id")]
    [StringLength(38)]
    public string? IntEmpPayAndAllowanceId { get; set; }

    [Column("int_employee_id")]
    [Precision(38, 0)]
    public BigInteger? IntEmployeeId { get; set; }

    [Column("int_comp_id")]
    [StringLength(38)]
    public string? IntCompId { get; set; }

    [Column("allowance_amount")]
    [Precision(10, 2)]
    public decimal? AllowanceAmount { get; set; }

    [Column("wef", TypeName = "timestamp(0) without time zone")]
    public DateTime? Wef { get; set; }

    [Column("effective_end_date", TypeName = "timestamp(0) without time zone")]
    public DateTime? EffectiveEndDate { get; set; }

    [Column("last_updated_by")]
    public int? LastUpdatedBy { get; set; }

    [Column("last_updated_on", TypeName = "timestamp without time zone")]
    public DateTime? LastUpdatedOn { get; set; }

    [Column("last_updated_by_role")]
    public int? LastUpdatedByRole { get; set; }

    [Column("dml_status_flag")]
    public short? DmlStatusFlag { get; set; }

    [Column("request_id")]
    public long? RequestId { get; set; }

    [Column("remarks")]
    [StringLength(1000)]
    public string? Remarks { get; set; }

    [Column("modifiable_flag")]
    [StringLength(1)]
    public string? ModifiableFlag { get; set; }

    [Column("active_flag")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("org_effective_end_date", TypeName = "timestamp(0) without time zone")]
    public DateTime? OrgEffectiveEndDate { get; set; }

    [Column("int_grade_pay_id")]
    [StringLength(38)]
    public string? IntGradePayId { get; set; }

    [Column("int_payb_id")]
    [StringLength(38)]
    public string? IntPaybId { get; set; }

    [Column("int_pay_scale_id")]
    [StringLength(38)]
    public string? IntPayScaleId { get; set; }

    [Column("int_rev_pay_allowance_id")]
    [StringLength(38)]
    public string? IntRevPayAllowanceId { get; set; }

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

    [Column("legacy_flag")]
    [StringLength(1)]
    public string? LegacyFlag { get; set; }

    [Column("int_omi_srv_book_block_id")]
    [StringLength(38)]
    public string? IntOmiSrvBookBlockId { get; set; }

    [Column("srv_book_request_init")]
    [StringLength(38)]
    public string? SrvBookRequestInit { get; set; }

    [Column("int_pay_allow_dtls_srv_book")]
    [StringLength(38)]
    public string? IntPayAllowDtlsSrvBook { get; set; }

    [Column("int_pay_info_dtls_srv_book")]
    [StringLength(38)]
    public string? IntPayInfoDtlsSrvBook { get; set; }
}
