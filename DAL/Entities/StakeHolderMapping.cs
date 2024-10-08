﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_backend.DAL.Entities;

[Table("stake_holder_mapping", Schema = "ngipf")]
public partial class StakeHolderMapping
{
    [Column("int_stake_holder_mapping")]
    public int IntStakeHolderMapping { get; set; }

    [Column("sanc_auth_count")]
    public short? SancAuthCount { get; set; }

    [Column("recom_auth_count")]
    public short? RecomAuthCount { get; set; }

    [Column("wef")]
    public DateOnly? Wef { get; set; }

    [Column("active_flag")]
    [MaxLength(1)]
    public char? ActiveFlag { get; set; }

    [Column("sanction_auth_nature")]
    public short? SanctionAuthNature { get; set; }

    [Column("reco_auth_nature")]
    public short? RecoAuthNature { get; set; }

    [Column("reco_auth_required")]
    public bool? RecoAuthRequired { get; set; }

    [Key]
    [Column("int_hoa_id")]
    public int IntHoaId { get; set; }

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

    [ForeignKey("IntHoaId")]
    [InverseProperty("StakeHolderMapping")]
    public virtual NgipfHoaList IntHoa { get; set; } = null!;

    [ForeignKey("RecoAuthNature")]
    [InverseProperty("StakeHolderMappings")]
    public virtual RecomandingNatureMst? RecoAuthNatureNavigation { get; set; }

    [ForeignKey("RecomAuthCount")]
    [InverseProperty("StakeHolderMappings")]
    public virtual RecomandingAuthorityCountMst? RecomAuthCountNavigation { get; set; }

    [ForeignKey("SancAuthCount")]
    [InverseProperty("StakeHolderMappings")]
    public virtual SanctionAdminCountMst? SancAuthCountNavigation { get; set; }

    [ForeignKey("SanctionAuthNature")]
    [InverseProperty("StakeHolderMappings")]
    public virtual SanctionAdminNatureMst? SanctionAuthNatureNavigation { get; set; }
}
