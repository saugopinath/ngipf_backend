using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_frontend.DAL.Entities;

[Table("lf_pl_op_opening_balance_permission_status", Schema = "ngipf")]
public partial class LfPlOpOpeningBalancePermissionStatus
{
    [Column("id")]
    public int Id { get; set; }

    [Key]
    [Column("int_operator_id")]
    public int IntOperatorId { get; set; }

    [Column("status")]
    public short? Status { get; set; }

    [Column("permitted_by")]
    public int? PermittedBy { get; set; }

    [Column("permitted_on")]
    public DateTime? PermittedOn { get; set; }

    [Column("permission_type")]
    public int? PermissionType { get; set; }

    [Column("memo_no")]
    [StringLength(200)]
    public string? MemoNo { get; set; }

    [Column("memo_date")]
    public DateOnly? MemoDate { get; set; }

    [ForeignKey("IntOperatorId")]
    [InverseProperty("LfPlOpOpeningBalancePermissionStatus")]
    public virtual TMmGenPlOperator IntOperator { get; set; } = null!;

    [ForeignKey("PermissionType")]
    [InverseProperty("LfPlOpOpeningBalancePermissionStatuses")]
    public virtual LfPlOpBalancePermissionStatusMaster? PermissionTypeNavigation { get; set; }
}
