using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_frontend.DAL.Entities;

[Table("delegated_dppg_role_assignment_mst", Schema = "ngipf_master")]
public partial class DelegatedDppgRoleAssignmentMst
{
    [Key]
    [Column("int_del_dppg_id")]
    public int IntDelDppgId { get; set; }

    [Column("int_treasury_id")]
    public int? IntTreasuryId { get; set; }

    [Column("is_delegated_admin")]
    public bool? IsDelegatedAdmin { get; set; }

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
}
