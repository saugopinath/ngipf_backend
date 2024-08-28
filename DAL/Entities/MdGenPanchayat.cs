using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NGIPF_BE.DAL.Entities;

[Table("md_gen_panchayat", Schema = "ifmsadmin")]
public partial class MdGenPanchayat
{
    [Column("zp_code")]
    [StringLength(10)]
    public string? ZpCode { get; set; }

    [Column("block_code")]
    [StringLength(10)]
    public string? BlockCode { get; set; }

    [Column("gp_code")]
    [StringLength(10)]
    public string? GpCode { get; set; }

    [Column("gp_name")]
    [StringLength(200)]
    public string? GpName { get; set; }

    [Column("active_flag")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("created_timestamp")]
    public DateOnly CreatedTimestamp { get; set; }

    [Column("modified_timestamp")]
    public DateOnly ModifiedTimestamp { get; set; }

    [Column("int_gp_id_old")]
    [StringLength(38)]
    public string? IntGpIdOld { get; set; }

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

    [Key]
    [Column("int_gp_id")]
    public int IntGpId { get; set; }
}
