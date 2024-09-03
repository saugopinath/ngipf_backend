using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_backend.DAL.Entities;

[Table("hr_mm_gen_workflow_master", Schema = "ihrms_emp_master")]
public partial class HrMmGenWorkflowMaster
{
    [Key]
    [Column("request_id")]
    public long RequestId { get; set; }

    [Column("request_source_type")]
    [StringLength(15)]
    public string RequestSourceType { get; set; } = null!;

    [Column("request_date", TypeName = "timestamp(6) without time zone")]
    public DateTime RequestDate { get; set; }

    [Column("workflow_status_flag")]
    [StringLength(2)]
    public string WorkflowStatusFlag { get; set; } = null!;

    [Column("dml_status_flag")]
    public short DmlStatusFlag { get; set; }

    [Column("description")]
    [StringLength(1000)]
    public string? Description { get; set; }

    [Column("new_data_flag")]
    public short? NewDataFlag { get; set; }

    [Column("spcl_declaration_id")]
    public double? SpclDeclarationId { get; set; }

    [Column("business_rec_table_owner")]
    [StringLength(50)]
    public string? BusinessRecTableOwner { get; set; }

    [Column("business_rec_table")]
    [StringLength(100)]
    public string? BusinessRecTable { get; set; }

    [Column("subject_line")]
    [StringLength(4000)]
    public string? SubjectLine { get; set; }

    [Column("int_emp_id_old")]
    [StringLength(38)]
    public string? IntEmpIdOld { get; set; }

    [Column("int_emp_id")]
    public int? IntEmpId { get; set; }

    [Column("business_rec_pk_old")]
    [StringLength(38)]
    public string? BusinessRecPkOld { get; set; }

    [Column("business_rec_pk")]
    public int? BusinessRecPk { get; set; }

    [Column("request_type_id_old")]
    [StringLength(38)]
    public string? RequestTypeIdOld { get; set; }

    [Column("request_type_id")]
    public int? RequestTypeId { get; set; }

    [Column("wf_id_old")]
    [StringLength(38)]
    public string? WfIdOld { get; set; }

    [Column("wf_id")]
    public int? WfId { get; set; }

    [Column("parent_request_id_old")]
    [StringLength(38)]
    public string? ParentRequestIdOld { get; set; }

    [Column("parent_request_id")]
    public int? ParentRequestId { get; set; }

    [Column("functionality_id_old")]
    [StringLength(38)]
    public string? FunctionalityIdOld { get; set; }

    [Column("functionality_id")]
    public int? FunctionalityId { get; set; }

    [InverseProperty("Request")]
    public virtual ICollection<HrMdAppntDtlsSrvBook> HrMdAppntDtlsSrvBooks { get; set; } = new List<HrMdAppntDtlsSrvBook>();

    [InverseProperty("Request")]
    public virtual ICollection<HrMdConfDtlsSrvBook> HrMdConfDtlsSrvBooks { get; set; } = new List<HrMdConfDtlsSrvBook>();

    [InverseProperty("Request")]
    public virtual ICollection<HrMdEmpAddress> HrMdEmpAddresses { get; set; } = new List<HrMdEmpAddress>();

    [InverseProperty("Request")]
    public virtual ICollection<HrMdEmpPayAndAllowance> HrMdEmpPayAndAllowances { get; set; } = new List<HrMdEmpPayAndAllowance>();

    [InverseProperty("Request")]
    public virtual ICollection<HrMdEmpPayAndAllownceWf> HrMdEmpPayAndAllownceWfs { get; set; } = new List<HrMdEmpPayAndAllownceWf>();

    [InverseProperty("Request")]
    public virtual ICollection<HrMdEmpPayInformationWf> HrMdEmpPayInformationWfs { get; set; } = new List<HrMdEmpPayInformationWf>();

    [InverseProperty("Request")]
    public virtual ICollection<HrMdEmpPayInformation> HrMdEmpPayInformations { get; set; } = new List<HrMdEmpPayInformation>();

    [InverseProperty("Request")]
    public virtual ICollection<HrMdEmpQualification> HrMdEmpQualifications { get; set; } = new List<HrMdEmpQualification>();

    [InverseProperty("Request")]
    public virtual ICollection<HrMdEmpRelationship> HrMdEmpRelationships { get; set; } = new List<HrMdEmpRelationship>();

    [InverseProperty("Request")]
    public virtual ICollection<HrMdEmpWorkingDtl> HrMdEmpWorkingDtls { get; set; } = new List<HrMdEmpWorkingDtl>();
}
