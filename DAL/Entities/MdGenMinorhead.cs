using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NGIPF_BE.DAL.Entities;

[PrimaryKey("MajorHead", "SubmajorHead", "MinorHead")]
[Table("md_gen_minorhead", Schema = "ifmsadmin")]
public partial class MdGenMinorhead
{
    [Key]
    [Column("major_head")]
    [StringLength(4)]
    public string MajorHead { get; set; } = null!;

    [Key]
    [Column("submajor_head")]
    [StringLength(2)]
    public string SubmajorHead { get; set; } = null!;

    [Key]
    [Column("minor_head")]
    [StringLength(3)]
    public string MinorHead { get; set; } = null!;

    [Column("description")]
    [StringLength(150)]
    public string? Description { get; set; }

    [Column("active_flag")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("created_timestamp")]
    public DateOnly CreatedTimestamp { get; set; }

    [Column("modified_timestamp")]
    public DateOnly ModifiedTimestamp { get; set; }

    [Column("created_user_id_old")]
    [StringLength(38)]
    public string? CreatedUserIdOld { get; set; }

    [Column("created_user_id")]
    public int? CreatedUserId { get; set; }

    [Column("modified_user_id_old")]
    [StringLength(38)]
    public string? ModifiedUserIdOld { get; set; }

    [Column("modified_user_id")]
    public int? ModifiedUserId { get; set; }

    [Column("dml_status_flag_old")]
    [StringLength(38)]
    public string? DmlStatusFlagOld { get; set; }

    [Column("dml_status_flag")]
    public int? DmlStatusFlag { get; set; }
}
