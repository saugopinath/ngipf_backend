using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_backend.DAL.Entities;

[Table("td_pf_recovery_dtls", Schema = "ngipf")]
public partial class TdPfRecoveryDtl
{
    [Key]
    [Column("int_recovery_id")]
    [StringLength(38)]
    public string IntRecoveryId { get; set; } = null!;

    [Column("int_final_payment_id")]
    [StringLength(38)]
    public string IntFinalPaymentId { get; set; } = null!;

    [Column("recovery_hoa_id")]
    public int RecoveryHoaId { get; set; }

    [Column("recovery_amount")]
    [Precision(14, 2)]
    public decimal RecoveryAmount { get; set; }

    [Column("int_reason_id")]
    public short IntReasonId { get; set; }

    [Column("other_details")]
    [StringLength(200)]
    public string? OtherDetails { get; set; }

    [Column("confirm_flag")]
    [MaxLength(1)]
    public char ConfirmFlag { get; set; }

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
}
