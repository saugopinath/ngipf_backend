using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_backend.DAL.Entities;

[Keyless]
[Table("lf_pl_op_interest_generation_list", Schema = "ngipf")]
public partial class LfPlOpInterestGenerationList
{
    [Column("id")]
    public int Id { get; set; }

    [Column("int_operator_id")]
    public int IntOperatorId { get; set; }

    [Column("int_generation_type")]
    public int? IntGenerationType { get; set; }

    [Column("status")]
    public short? Status { get; set; }

    [Column("go_number")]
    [StringLength(200)]
    public string? GoNumber { get; set; }

    [Column("go_date")]
    public DateOnly? GoDate { get; set; }

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

    [ForeignKey("IntGenerationType")]
    public virtual InterestGenerationMst? IntGenerationTypeNavigation { get; set; }

    [ForeignKey("IntOperatorId")]
    public virtual TMmGenPlOperator IntOperator { get; set; } = null!;
}
