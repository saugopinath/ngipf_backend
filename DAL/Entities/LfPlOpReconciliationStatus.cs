using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NGIPF_BE.DAL.Entities;

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

    [ForeignKey("IntOperatorId")]
    [InverseProperty("LfPlOpReconciliationStatus")]
    public virtual TMmGenPlOperator IntOperator { get; set; } = null!;
}
