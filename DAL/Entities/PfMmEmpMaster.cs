using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NGIPF_BE.DAL.Entities;

[Table("pf_mm_emp_master", Schema = "ngipf")]
public partial class PfMmEmpMaster
{
    [Key]
    [Column("int_pf_emp_master_id")]
    [StringLength(38)]
    public string IntPfEmpMasterId { get; set; } = null!;

    [Column("int_employee_id")]
    [StringLength(38)]
    public string IntEmployeeId { get; set; } = null!;

    /// <summary>
    /// for ready reference
    /// </summary>
    [Column("employee_no")]
    [StringLength(50)]
    public string EmployeeNo { get; set; } = null!;

    /// <summary>
    /// for ready reference
    /// </summary>
    [Column("emp_name")]
    [StringLength(160)]
    public string? EmpName { get; set; }

    [Column("gpf_group_code")]
    [StringLength(5)]
    public string GpfGroupCode { get; set; } = null!;

    [Column("active_flag")]
    [StringLength(1)]
    public string ActiveFlag { get; set; } = null!;

    [Column("dml_status_flag")]
    public short DmlStatusFlag { get; set; }

    [Column("created_user_id")]
    public int CreatedUserId { get; set; }

    [Column("created_timestamp", TypeName = "timestamp(0) without time zone")]
    public DateTime CreatedTimestamp { get; set; }

    [Column("modified_user_id")]
    public int ModifiedUserId { get; set; }

    [Column("modified_timestamp", TypeName = "timestamp(0) without time zone")]
    public DateTime ModifiedTimestamp { get; set; }

    /// <summary>
    /// (y/n) whether modified or not
    /// </summary>
    [Column("modified_flag")]
    [StringLength(1)]
    public string? ModifiedFlag { get; set; }

    /// <summary>
    /// user remarks
    /// </summary>
    [Column("remarks")]
    [StringLength(1000)]
    public string? Remarks { get; set; }

    [Column("created_role_id")]
    public int? CreatedRoleId { get; set; }

    [Column("modified_role_id")]
    public short? ModifiedRoleId { get; set; }
}
