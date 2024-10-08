﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_backend.DAL.Entities;

[Table("lf_pl_op_reconciliation_status", Schema = "ngipf")]
public partial class LfPlOpReconciliationStatus
{
    [Column("id")]
    public int Id { get; set; }

    [Key]
    [Column("int_operator_id")]
    public int IntOperatorId { get; set; }

    [Column("status")]
    public short? Status { get; set; }

    [Column("created_by")]
    public int? CreatedBy { get; set; }

    [Column("last_updated_by")]
    public int? LastUpdatedBy { get; set; }

    [Column("deleted_by")]
    public int? DeletedBy { get; set; }

    [Column("created_at", TypeName = "timestamp without time zone")]
    public DateTime? CreatedAt { get; set; }

    [Column("last_updated_at", TypeName = "timestamp without time zone")]
    public DateTime? LastUpdatedAt { get; set; }

    [Column("deleted_at", TypeName = "timestamp without time zone")]
    public DateTime? DeletedAt { get; set; }

    [Column("active_flag")]
    [MaxLength(1)]
    public char? ActiveFlag { get; set; }

    [ForeignKey("IntOperatorId")]
    [InverseProperty("LfPlOpReconciliationStatus")]
    public virtual TMmGenPlOperator IntOperator { get; set; } = null!;
}
