using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NGIPF_BE.DAL.Entities;

[Table("td_final_payment_cancel", Schema = "ngipf")]
public partial class TdFinalPaymentCancel
{
    [Key]
    [Column("int_cancel_id")]
    [StringLength(38)]
    public string IntCancelId { get; set; } = null!;

    [Column("int_final_payment_id")]
    [StringLength(38)]
    public string IntFinalPaymentId { get; set; } = null!;

    [Column("cancel_request_id")]
    [StringLength(38)]
    public string CancelRequestId { get; set; } = null!;

    [Column("sanction_id")]
    [StringLength(20)]
    public string? SanctionId { get; set; }

    [Column("sanction_date", TypeName = "timestamp(0) without time zone")]
    public DateTime? SanctionDate { get; set; }

    [Column("cancel_reject_flag")]
    [MaxLength(1)]
    public char? CancelRejectFlag { get; set; }

    [Column("dml_status_flag")]
    public short DmlStatusFlag { get; set; }

    [Column("user_id")]
    public int UserId { get; set; }

    [Column("created_timestamp", TypeName = "timestamp(0) without time zone")]
    public DateTime CreatedTimestamp { get; set; }

    [Column("modified_user_id")]
    public int ModifiedUserId { get; set; }

    [Column("modified_timestamp", TypeName = "timestamp(0) without time zone")]
    public DateTime ModifiedTimestamp { get; set; }

    [Column("int_cancellation_type_id")]
    [StringLength(38)]
    public string? IntCancellationTypeId { get; set; }

    [Column("memo_no")]
    [StringLength(38)]
    public string? MemoNo { get; set; }

    [Column("memo_date", TypeName = "timestamp(0) without time zone")]
    public DateTime? MemoDate { get; set; }

    [Column("remarks")]
    [StringLength(200)]
    public string? Remarks { get; set; }

    [Column("cancel_reason")]
    [StringLength(500)]
    public string? CancelReason { get; set; }

    [Column("cancel_by")]
    [StringLength(38)]
    public string? CancelBy { get; set; }

    [Column("cancel_date", TypeName = "timestamp(0) without time zone")]
    public DateTime? CancelDate { get; set; }

    [Column("cancel_reason_other")]
    [StringLength(500)]
    public string? CancelReasonOther { get; set; }

    [Column("int_employee_id")]
    [StringLength(38)]
    public string? IntEmployeeId { get; set; }
}
