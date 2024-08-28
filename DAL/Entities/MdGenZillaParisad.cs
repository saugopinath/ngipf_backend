using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_frontend.DAL.Entities;

[Keyless]
[Table("md_gen_zilla_parisad", Schema = "ifmsadmin")]
public partial class MdGenZillaParisad
{
    [Column("state_code")]
    [StringLength(10)]
    public string? StateCode { get; set; }

    [Column("zp_code")]
    [StringLength(10)]
    public string? ZpCode { get; set; }

    [Column("zp_name")]
    [StringLength(200)]
    public string? ZpName { get; set; }

    [Column("active_flag")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("created_timestamp")]
    public DateOnly CreatedTimestamp { get; set; }

    [Column("modified_timestamp")]
    public DateOnly ModifiedTimestamp { get; set; }

    [Column("int_zilla_id_old")]
    [StringLength(38)]
    public string? IntZillaIdOld { get; set; }

    [Column("int_zilla_id")]
    public int? IntZillaId { get; set; }

    [Column("user_id_old")]
    [StringLength(38)]
    public string? UserIdOld { get; set; }

    [Column("user_id")]
    public int? UserId { get; set; }

    [Column("modified_user_id_old")]
    [StringLength(38)]
    public string? ModifiedUserIdOld { get; set; }

    [Column("modified_user_id")]
    public int? ModifiedUserId { get; set; }
}
