using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_backend.DAL.Entities;

[Table("advance_type_mst", Schema = "ngipf_master")]
public partial class AdvanceTypeMst
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("name")]
    [StringLength(50)]
    public string Name { get; set; } = null!;

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

    [InverseProperty("IntAdvanceTypeNavigation")]
    public virtual ICollection<AdvanceAmountEligibilityMst> AdvanceAmountEligibilityMsts { get; set; } = new List<AdvanceAmountEligibilityMst>();

    [InverseProperty("IntAdvanceTypeNavigation")]
    public virtual ICollection<AdvancePurposeAdvanceMapping> AdvancePurposeAdvanceMappings { get; set; } = new List<AdvancePurposeAdvanceMapping>();

    [InverseProperty("IntAdvanceTypeNavigation")]
    public virtual ICollection<AdvanceRecoveryDurationEligibilityMst> AdvanceRecoveryDurationEligibilityMsts { get; set; } = new List<AdvanceRecoveryDurationEligibilityMst>();

    [InverseProperty("IntAdvanceTypeNavigation")]
    public virtual ICollection<AdvanceServiceDurationEligibilityMst> AdvanceServiceDurationEligibilityMsts { get; set; } = new List<AdvanceServiceDurationEligibilityMst>();
}
