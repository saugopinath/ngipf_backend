using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;
using Microsoft.EntityFrameworkCore;

namespace ngipf_frontend.DAL.Entities;

[Table("hr_md_emp_other_dtls_audit", Schema = "ihrms")]
[Index("IntEmployeeId", Name = "ind_hr_md_emp_otr_dtls_aud2")]
[Index("RequestId", Name = "ind_hr_md_emp_otrdtls_aud3")]
public partial class HrMdEmpOtherDtlsAudit
{
    [Key]
    [Column("int_other_contr_dtls_audit")]
    [StringLength(38)]
    public string IntOtherContrDtlsAudit { get; set; } = null!;

    [Column("int_other_contr_dtls")]
    [StringLength(38)]
    public string? IntOtherContrDtls { get; set; }

    [Column("int_employee_id")]
    [Precision(38, 0)]
    public BigInteger? IntEmployeeId { get; set; }

    [Column("information1")]
    [StringLength(50)]
    public string? Information1 { get; set; }

    [Column("information2")]
    [StringLength(50)]
    public string? Information2 { get; set; }

    [Column("information3")]
    [StringLength(50)]
    public string? Information3 { get; set; }

    [Column("wef", TypeName = "timestamp(0) without time zone")]
    public DateTime? Wef { get; set; }

    [Column("int_omi_other_dtls")]
    [StringLength(38)]
    public string? IntOmiOtherDtls { get; set; }

    [Column("master_abbr")]
    [StringLength(10)]
    public string? MasterAbbr { get; set; }

    [Column("master_type")]
    [StringLength(5)]
    public string? MasterType { get; set; }

    [Column("active_flag")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("effective_end_date", TypeName = "timestamp(0) without time zone")]
    public DateTime? EffectiveEndDate { get; set; }

    [Column("last_updated_by")]
    public int? LastUpdatedBy { get; set; }

    [Column("last_updated_on", TypeName = "timestamp without time zone")]
    public DateTime? LastUpdatedOn { get; set; }

    [Column("last_updated_by_role")]
    public int? LastUpdatedByRole { get; set; }

    [Column("request_id")]
    [StringLength(38)]
    public string? RequestId { get; set; }
}
