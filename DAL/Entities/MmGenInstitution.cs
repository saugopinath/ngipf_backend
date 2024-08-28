using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NGIPF_BE.DAL.Entities;

[Keyless]
[Table("mm_gen_institution", Schema = "ifmsadmin")]
public partial class MmGenInstitution
{
    [Column("bank_account_number")]
    [StringLength(15)]
    public string? BankAccountNumber { get; set; }

    [Column("school_name")]
    [StringLength(100)]
    public string? SchoolName { get; set; }

    [Column("active_flag")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("int_treasury_code")]
    [StringLength(5)]
    public string? IntTreasuryCode { get; set; }

    [Column("office_code")]
    [StringLength(255)]
    public string? OfficeCode { get; set; }

    [Column("school_code_old")]
    [StringLength(38)]
    public string? SchoolCodeOld { get; set; }

    [Column("school_code")]
    public int? SchoolCode { get; set; }

    [Column("int_branch_id_old")]
    [StringLength(38)]
    public string? IntBranchIdOld { get; set; }

    [Column("int_branch_id")]
    public int? IntBranchId { get; set; }
}
