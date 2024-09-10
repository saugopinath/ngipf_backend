using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_backend.DAL.Entities;

[Table("workflow_office_type_mst", Schema = "ngipf_master")]
public partial class WorkflowOfficeTypeMst
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("name")]
    [StringLength(50)]
    public string? Name { get; set; }

    [Column("active_flag")]
    [StringLength(2)]
    public string? ActiveFlag { get; set; }

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

    [Column("display_rank")]
    public short? DisplayRank { get; set; }

    [InverseProperty("IntOfficeType")]
    public virtual ICollection<WorkflowMasterCode> WorkflowMasterCodes { get; set; } = new List<WorkflowMasterCode>();
}
