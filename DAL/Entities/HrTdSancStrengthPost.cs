using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_frontend.DAL.Entities;

[Table("hr_td_sanc_strength_post", Schema = "ihrms")]
public partial class HrTdSancStrengthPost
{
    [Key]
    [Column("int_td_sanction_post")]
    [StringLength(38)]
    public string IntTdSanctionPost { get; set; } = null!;

    [Column("int_tm_sanction_post")]
    [StringLength(38)]
    public string IntTmSanctionPost { get; set; } = null!;

    [Column("deputation_flag")]
    [StringLength(1)]
    public string DeputationFlag { get; set; } = null!;

    [Column("post_gradation")]
    [StringLength(50)]
    public string? PostGradation { get; set; }

    [Column("flag_inc_dec")]
    [StringLength(1)]
    public string FlagIncDec { get; set; } = null!;

    [Column("sanctioned_strength")]
    public int SanctionedStrength { get; set; }

    [Column("go_number")]
    [StringLength(50)]
    public string? GoNumber { get; set; }

    [Column("go_date", TypeName = "timestamp(0) without time zone")]
    public DateTime? GoDate { get; set; }

    [Column("wef_date", TypeName = "timestamp(0) without time zone")]
    public DateTime? WefDate { get; set; }

    [Column("existing_strength")]
    public int ExistingStrength { get; set; }

    [Column("existing_strength_udef")]
    public short ExistingStrengthUdef { get; set; }

    [Column("post_code_gen")]
    [StringLength(1)]
    public string PostCodeGen { get; set; } = null!;

    [Column("created_apt_auth_id")]
    [StringLength(38)]
    public string? CreatedAptAuthId { get; set; }

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

    [Column("int_hoo_section_id")]
    [StringLength(38)]
    public string? IntHooSectionId { get; set; }
}
