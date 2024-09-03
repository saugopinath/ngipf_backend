using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_backend.DAL.Entities;

[Table("emp_arrear_dtls", Schema = "ngipf")]
public partial class EmpArrearDtl
{
    [Key]
    [Column("int_arrear_dtls_id")]
    public int IntArrearDtlsId { get; set; }

    [Column("int_employee_id")]
    public int? IntEmployeeId { get; set; }

    [Column("from_date", TypeName = "timestamp(0) without time zone")]
    public DateTime FromDate { get; set; }

    [Column("to_date", TypeName = "timestamp(0) without time zone")]
    public DateTime ToDate { get; set; }

    [Column("int_component_id")]
    public int? IntComponentId { get; set; }

    [Column("component_flag")]
    [StringLength(1)]
    public string ComponentFlag { get; set; } = null!;

    [Column("system_due")]
    public double? SystemDue { get; set; }

    [Column("manual_due")]
    public double ManualDue { get; set; }

    [Column("system_drawn")]
    public double SystemDrawn { get; set; }

    [Column("manual_drawn")]
    public double ManualDrawn { get; set; }

    [Column("active_flag")]
    [StringLength(1)]
    public string ActiveFlag { get; set; } = null!;

    [Column("ded_comp_mstr_abbr")]
    [StringLength(10)]
    public string? DedCompMstrAbbr { get; set; }

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

    [ForeignKey("IntEmployeeId")]
    [InverseProperty("EmpArrearDtls")]
    public virtual EmpPfBasicDetail? IntEmployee { get; set; }
}
