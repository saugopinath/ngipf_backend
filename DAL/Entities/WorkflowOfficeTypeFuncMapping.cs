using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_backend.DAL.Entities;

[Table("workflow_office_type_func_mapping", Schema = "ngipf_master")]
public partial class WorkflowOfficeTypeFuncMapping
{
    [Key]
    [Column("int_workflow_off_type_func_id")]
    public int IntWorkflowOffTypeFuncId { get; set; }

    [Column("int_office_type_id")]
    public int? IntOfficeTypeId { get; set; }

    [Column("int_func_id")]
    public int? IntFuncId { get; set; }

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

    [ForeignKey("IntFuncId")]
    [InverseProperty("WorkflowOfficeTypeFuncMappingIntFuncs")]
    public virtual WorkflowFunctinalityTypeMst? IntFunc { get; set; }

    [ForeignKey("IntOfficeTypeId")]
    [InverseProperty("WorkflowOfficeTypeFuncMappingIntOfficeTypes")]
    public virtual WorkflowFunctinalityTypeMst? IntOfficeType { get; set; }
}
