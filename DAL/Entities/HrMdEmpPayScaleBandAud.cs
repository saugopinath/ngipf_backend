using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;
using Microsoft.EntityFrameworkCore;

namespace ngipf_backend.DAL.Entities;

[Table("hr_md_emp_pay_scale_band_aud", Schema = "ihrms")]
public partial class HrMdEmpPayScaleBandAud
{
    [Key]
    [Column("int_emp_pay_scale_band_aud")]
    [StringLength(38)]
    public string IntEmpPayScaleBandAud { get; set; } = null!;

    [Column("int_emp_pay_scale_band_info")]
    [StringLength(38)]
    public string IntEmpPayScaleBandInfo { get; set; } = null!;

    [Column("int_employee_id")]
    [Precision(38, 0)]
    public BigInteger IntEmployeeId { get; set; }

    [Column("int_rev_pay_allowance_id")]
    [StringLength(38)]
    public string? IntRevPayAllowanceId { get; set; }

    [Column("int_payb_id")]
    [StringLength(38)]
    public string? IntPaybId { get; set; }

    [Column("int_pay_scale_id")]
    [StringLength(38)]
    public string? IntPayScaleId { get; set; }

    [Column("request_id")]
    public long? RequestId { get; set; }

    [Column("wef", TypeName = "timestamp(0) without time zone")]
    public DateTime? Wef { get; set; }

    [Column("effective_end_date", TypeName = "timestamp(0) without time zone")]
    public DateTime? EffectiveEndDate { get; set; }

    [Column("active_flag")]
    [StringLength(1)]
    public string ActiveFlag { get; set; } = null!;

    [Column("created_user_id")]
    public int CreatedUserId { get; set; }

    [Column("created_timestamp", TypeName = "timestamp(0) without time zone")]
    public DateTime CreatedTimestamp { get; set; }

    [Column("modified_user_id")]
    public int? ModifiedUserId { get; set; }

    [Column("modified_timestamp", TypeName = "timestamp(0) without time zone")]
    public DateTime? ModifiedTimestamp { get; set; }

    [Column("go_order_number")]
    [StringLength(50)]
    public string? GoOrderNumber { get; set; }

    [Column("go_order_date", TypeName = "timestamp(0) without time zone")]
    public DateTime? GoOrderDate { get; set; }

    [Column("remarks")]
    [StringLength(1000)]
    public string? Remarks { get; set; }

    [Column("notional_date", TypeName = "timestamp(0) without time zone")]
    public DateTime? NotionalDate { get; set; }

    [Column("service_book_flag")]
    [StringLength(1)]
    public string? ServiceBookFlag { get; set; }

    [Column("int_omi_reason_for_changes")]
    [StringLength(38)]
    public string? IntOmiReasonForChanges { get; set; }

    [Column("modifiable_flag")]
    [StringLength(1)]
    public string? ModifiableFlag { get; set; }

    [Column("int_omi_srv_book_block_id")]
    [StringLength(38)]
    public string? IntOmiSrvBookBlockId { get; set; }

    [Column("srv_book_request_init")]
    [StringLength(38)]
    public string? SrvBookRequestInit { get; set; }

    [Column("int_payfix_tool_id")]
    [StringLength(38)]
    public string? IntPayfixToolId { get; set; }
}
