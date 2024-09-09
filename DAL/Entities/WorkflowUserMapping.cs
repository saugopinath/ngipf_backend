using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_backend.DAL.Entities;

[Table("workflow_user_mapping", Schema = "ngipf_master")]
public partial class WorkflowUserMapping
{
    [Key]
    [Column("int_mm_workflow_user_mapping")]
    public int IntMmWorkflowUserMapping { get; set; }

    [Column("int_user_id")]
    public int? IntUserId { get; set; }

    [Column("int_role_id")]
    public int? IntRoleId { get; set; }

    [Column("parent_id")]
    public int? ParentId { get; set; }

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

    [Column("int_workflow_id")]
    public int? IntWorkflowId { get; set; }

    [ForeignKey("IntRoleId")]
    [InverseProperty("WorkflowUserMappings")]
    public virtual MmGenRole? IntRole { get; set; }

    [ForeignKey("IntUserId")]
    [InverseProperty("WorkflowUserMappings")]
    public virtual MmGenUser? IntUser { get; set; }

    [ForeignKey("IntWorkflowId")]
    [InverseProperty("WorkflowUserMappings")]
    public virtual WorkflowMasterCode? IntWorkflow { get; set; }
}
