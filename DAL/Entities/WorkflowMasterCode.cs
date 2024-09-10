using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_backend.DAL.Entities;

[Table("workflow_master_code", Schema = "ngipf_master")]
public partial class WorkflowMasterCode
{
    [Key]
    [Column("int_mm_workflow_status_code")]
    public int IntMmWorkflowStatusCode { get; set; }

    [Column("int_office_type_id")]
    public int? IntOfficeTypeId { get; set; }

    [Column("int_func_id")]
    public int? IntFuncId { get; set; }

    [Column("int_hoa_id")]
    public int? IntHoaId { get; set; }

    [Column("int_treasury_id")]
    public int? IntTreasuryId { get; set; }

    [Column("int_operator_id")]
    public int? IntOperatorId { get; set; }

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
    [InverseProperty("WorkflowMasterCodes")]
    public virtual WorkflowFunctinalityTypeMst? IntFunc { get; set; }

    [ForeignKey("IntHoaId")]
    [InverseProperty("WorkflowMasterCodes")]
    public virtual NgipfHoaList? IntHoa { get; set; }

    [ForeignKey("IntOfficeTypeId")]
    [InverseProperty("WorkflowMasterCodes")]
    public virtual WorkflowOfficeTypeMst? IntOfficeType { get; set; }

    [ForeignKey("IntOperatorId")]
    [InverseProperty("WorkflowMasterCodes")]
    public virtual TMmGenPlOperator? IntOperator { get; set; }

    [ForeignKey("IntTreasuryId")]
    [InverseProperty("WorkflowMasterCodes")]
    public virtual MmGenTreasury? IntTreasury { get; set; }

    [InverseProperty("IntWorkflow")]
    public virtual ICollection<WorkflowUserMapping> WorkflowUserMappings { get; set; } = new List<WorkflowUserMapping>();
}
