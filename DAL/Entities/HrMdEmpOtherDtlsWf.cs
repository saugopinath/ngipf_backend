using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_backend.DAL.Entities;

[Keyless]
[Table("hr_md_emp_other_dtls_wf", Schema = "ihrms_emp_master")]
public partial class HrMdEmpOtherDtlsWf
{
    [Column("information1")]
    [StringLength(50)]
    public string? Information1 { get; set; }

    [Column("information2")]
    [StringLength(50)]
    public string? Information2 { get; set; }

    [Column("information3")]
    [StringLength(50)]
    public string? Information3 { get; set; }

    [Column("wef")]
    public DateOnly? Wef { get; set; }

    [Column("master_abbr")]
    [StringLength(10)]
    public string? MasterAbbr { get; set; }

    [Column("master_type")]
    [StringLength(5)]
    public string? MasterType { get; set; }

    [Column("active_flag")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("workflow_status_flag")]
    [StringLength(2)]
    public string? WorkflowStatusFlag { get; set; }

    [Column("last_updated_on", TypeName = "timestamp without time zone")]
    public DateTime? LastUpdatedOn { get; set; }

    [Column("go_order_number")]
    [StringLength(50)]
    public string? GoOrderNumber { get; set; }

    [Column("go_order_date")]
    public DateOnly? GoOrderDate { get; set; }

    [Column("int_other_contr_dtls_wf_old")]
    [StringLength(38)]
    public string? IntOtherContrDtlsWfOld { get; set; }

    [Column("int_other_contr_dtls_old")]
    [StringLength(38)]
    public string? IntOtherContrDtlsOld { get; set; }

    [Column("int_other_contr_dtls")]
    public int? IntOtherContrDtls { get; set; }

    [Column("int_employee_id_old")]
    [StringLength(38)]
    public string? IntEmployeeIdOld { get; set; }

    [Column("int_employee_id")]
    public int? IntEmployeeId { get; set; }

    [Column("int_omi_other_dtls_old")]
    [StringLength(38)]
    public string? IntOmiOtherDtlsOld { get; set; }

    [Column("last_updated_by_old")]
    [StringLength(38)]
    public string? LastUpdatedByOld { get; set; }

    [Column("last_updated_by")]
    public int? LastUpdatedBy { get; set; }

    [Column("last_updated_by_role_old")]
    [StringLength(38)]
    public string? LastUpdatedByRoleOld { get; set; }

    [Column("last_updated_by_role")]
    public int? LastUpdatedByRole { get; set; }

    [Column("dml_status_flag_old")]
    [StringLength(38)]
    public string? DmlStatusFlagOld { get; set; }

    [Column("dml_status_flag")]
    public int? DmlStatusFlag { get; set; }

    [Column("request_id_old")]
    [StringLength(38)]
    public string? RequestIdOld { get; set; }

    [Column("request_id")]
    public long? RequestId { get; set; }

    [Column("int_other_contr_dtls_wf")]
    public int? IntOtherContrDtlsWf { get; set; }

    [Column("int_omi_other_dtls")]
    public int? IntOmiOtherDtls { get; set; }

    [ForeignKey("IntEmployeeId")]
    public virtual HrMmEmpBasicDtl? IntEmployee { get; set; }

    [ForeignKey("RequestId")]
    public virtual HrMmGenWorkflowMaster? Request { get; set; }
}
