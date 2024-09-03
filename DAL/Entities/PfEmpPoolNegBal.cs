using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_backend.DAL.Entities;

[Keyless]
[Table("pf_emp_pool_neg_bal", Schema = "ngipf")]
public partial class PfEmpPoolNegBal
{
    [Column("int_gpf_pool_neg_bal_id")]
    [StringLength(38)]
    public string IntGpfPoolNegBalId { get; set; } = null!;

    [Column("int_employee_id")]
    [StringLength(38)]
    public string IntEmployeeId { get; set; } = null!;

    [Column("flag_neg_bal")]
    [MaxLength(1)]
    public char FlagNegBal { get; set; }

    [Column("dml_status_flag")]
    public short DmlStatusFlag { get; set; }

    [Column("created_user_id")]
    public int CreatedUserId { get; set; }

    [Column("created_timestamp", TypeName = "timestamp(0) without time zone")]
    public DateTime CreatedTimestamp { get; set; }

    [Column("created_role_id")]
    public int CreatedRoleId { get; set; }

    [Column("modified_user_id")]
    public int ModifiedUserId { get; set; }

    [Column("modified_timestamp", TypeName = "timestamp(0) without time zone")]
    public DateTime ModifiedTimestamp { get; set; }

    [Column("modified_role_id")]
    public int ModifiedRoleId { get; set; }

    [Column("remarks")]
    [StringLength(3000)]
    public string? Remarks { get; set; }
}
