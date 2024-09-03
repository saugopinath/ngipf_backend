using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_backend.DAL.Entities;

[Table("mm_gen_bank_branch_ifsc", Schema = "ifmsadmin")]
public partial class MmGenBankBranchIfsc
{
    [Column("bank")]
    [StringLength(300)]
    public string? Bank { get; set; }

    [Key]
    [Column("ifsc_code")]
    [StringLength(90)]
    public string IfscCode { get; set; } = null!;

    [Column("micr_code")]
    [StringLength(42)]
    public string? MicrCode { get; set; }

    [Column("branch_name")]
    [StringLength(2000)]
    public string? BranchName { get; set; }

    [Column("address")]
    [StringLength(4000)]
    public string? Address { get; set; }

    [Column("contact")]
    [StringLength(2000)]
    public string? Contact { get; set; }

    [Column("city")]
    [StringLength(2000)]
    public string? City { get; set; }

    [Column("district")]
    [StringLength(2000)]
    public string? District { get; set; }

    [Column("state")]
    [StringLength(900)]
    public string? State { get; set; }

    [Column("wef_date")]
    public DateOnly? WefDate { get; set; }

    [Column("active_flag")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("created_timestamp")]
    public DateOnly? CreatedTimestamp { get; set; }

    [Column("created_user_id_old")]
    [StringLength(38)]
    public string? CreatedUserIdOld { get; set; }

    [Column("created_user_id")]
    public int? CreatedUserId { get; set; }

    [Column("dml_status_flag_old")]
    [StringLength(38)]
    public string? DmlStatusFlagOld { get; set; }

    [Column("dml_status_flag")]
    public int? DmlStatusFlag { get; set; }

    [InverseProperty("IfscCodeNavigation")]
    public virtual ICollection<HrMdEmpNomineeDtl> HrMdEmpNomineeDtls { get; set; } = new List<HrMdEmpNomineeDtl>();
}
