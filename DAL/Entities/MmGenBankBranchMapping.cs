using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_frontend.DAL.Entities;

[Keyless]
[Table("mm_gen_bank_branch_mapping", Schema = "ifmsadmin")]
public partial class MmGenBankBranchMapping
{
    [Column("active_flag")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("timestamp")]
    public DateOnly? Timestamp { get; set; }

    [Column("bank_branch_id_old")]
    [StringLength(38)]
    public string? BankBranchIdOld { get; set; }

    [Column("bank_branch_id")]
    public int? BankBranchId { get; set; }

    [Column("bank_id_old")]
    [StringLength(38)]
    public string? BankIdOld { get; set; }

    [Column("bank_id")]
    public int? BankId { get; set; }

    [Column("area_id_old")]
    [StringLength(38)]
    public string? AreaIdOld { get; set; }

    [Column("area_id")]
    public int? AreaId { get; set; }

    [Column("user_id_old")]
    [StringLength(38)]
    public string? UserIdOld { get; set; }

    [Column("user_id")]
    public int? UserId { get; set; }
}
