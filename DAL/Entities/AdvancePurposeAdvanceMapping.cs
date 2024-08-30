using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_frontend.DAL.Entities;

[Table("advance_purpose_advance_mapping", Schema = "ngipf_master")]
public partial class AdvancePurposeAdvanceMapping
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("int_operator_id")]
    public int? IntOperatorId { get; set; }

    [Column("int_purpose_id")]
    public int? IntPurposeId { get; set; }

    [Column("int_advance_type")]
    public int? IntAdvanceType { get; set; }

    [Column("int_go_id")]
    public int? IntGoId { get; set; }

    [Column("active_flag")]
    [MaxLength(1)]
    public char? ActiveFlag { get; set; }

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

    [ForeignKey("IntAdvanceType")]
    [InverseProperty("AdvancePurposeAdvanceMappings")]
    public virtual AdvanceTypeMst? IntAdvanceTypeNavigation { get; set; }

    [ForeignKey("IntGoId")]
    [InverseProperty("AdvancePurposeAdvanceMappings")]
    public virtual GoDetailsMst? IntGo { get; set; }

    [ForeignKey("IntOperatorId")]
    [InverseProperty("AdvancePurposeAdvanceMappings")]
    public virtual TMmGenPlOperator? IntOperator { get; set; }

    [ForeignKey("IntPurposeId")]
    [InverseProperty("AdvancePurposeAdvanceMappings")]
    public virtual AdvancePurposeMst? IntPurpose { get; set; }
}
