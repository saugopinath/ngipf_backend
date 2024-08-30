using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_frontend.DAL.Entities;

[Table("go_details_mst", Schema = "ngipf_master")]
public partial class GoDetailsMst
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("go_number")]
    [StringLength(100)]
    public string? GoNumber { get; set; }

    [Column("go_date")]
    public DateOnly? GoDate { get; set; }

    [Column("wef")]
    public DateOnly? Wef { get; set; }

    [Column("type_code")]
    public short? TypeCode { get; set; }

    [Column("active_flag")]
    [MaxLength(1)]
    public char? ActiveFlag { get; set; }

    [Column("wet")]
    public DateOnly? Wet { get; set; }

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

    [InverseProperty("IntGo")]
    public virtual ICollection<AdvanceAmountEligibilityMst> AdvanceAmountEligibilityMsts { get; set; } = new List<AdvanceAmountEligibilityMst>();

    [InverseProperty("IntGo")]
    public virtual ICollection<AdvancePurposeAdvanceMapping> AdvancePurposeAdvanceMappings { get; set; } = new List<AdvancePurposeAdvanceMapping>();

    [InverseProperty("IntGo")]
    public virtual ICollection<AdvanceRecoveryDurationEligibilityMst> AdvanceRecoveryDurationEligibilityMsts { get; set; } = new List<AdvanceRecoveryDurationEligibilityMst>();

    [InverseProperty("IntGo")]
    public virtual ICollection<AdvanceServiceDurationEligibilityMst> AdvanceServiceDurationEligibilityMsts { get; set; } = new List<AdvanceServiceDurationEligibilityMst>();

    [InverseProperty("IntGo")]
    public virtual ICollection<InterestDateExceptionMst> InterestDateExceptionMsts { get; set; } = new List<InterestDateExceptionMst>();

    [InverseProperty("IntGo")]
    public virtual ICollection<InterestRateExceptionMst> InterestRateExceptionMsts { get; set; } = new List<InterestRateExceptionMst>();

    [InverseProperty("IntGo")]
    public virtual ICollection<InterestRateMst> InterestRateMsts { get; set; } = new List<InterestRateMst>();
}
