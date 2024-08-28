using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NGIPF_BE.DAL.Entities;

[Keyless]
[Table("stake_holder_mapping", Schema = "ngipf")]
public partial class StakeHolderMapping
{
    [Column("int_stake_holder_mapping")]
    public int IntStakeHolderMapping { get; set; }

    [Column("functionality_type")]
    [StringLength(30)]
    public string? FunctionalityType { get; set; }

    [Column("int_pl_operator_id")]
    public int? IntPlOperatorId { get; set; }

    [Column("sanc_auth_count")]
    public short? SancAuthCount { get; set; }

    [Column("recom_auth_count")]
    public short? RecomAuthCount { get; set; }

    [Column("wef")]
    public DateOnly? Wef { get; set; }

    [Column("active_flag")]
    [MaxLength(1)]
    public char? ActiveFlag { get; set; }

    [Column("dml_status_flag")]
    [StringLength(3)]
    public string? DmlStatusFlag { get; set; }

    [Column("created_user_id")]
    public long? CreatedUserId { get; set; }

    [Column("created_date")]
    public DateOnly? CreatedDate { get; set; }

    [Column("modified_user_id")]
    public long? ModifiedUserId { get; set; }

    [Column("modified_date")]
    public DateOnly? ModifiedDate { get; set; }

    [Column("sanction_auth_nature")]
    public short? SanctionAuthNature { get; set; }

    [Column("reco_auth_nature")]
    public short? RecoAuthNature { get; set; }

    [Column("reco_auth_required")]
    public bool? RecoAuthRequired { get; set; }

    [Column("dept_hoa_id")]
    public short? DeptHoaId { get; set; }
}
