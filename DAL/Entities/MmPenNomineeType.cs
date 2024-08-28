using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NGIPF_BE.DAL.Entities;

[Keyless]
[Table("mm_pen_nominee_type", Schema = "ifmsadmin")]
public partial class MmPenNomineeType
{
    [Column("nominee_type")]
    [StringLength(1)]
    public string? NomineeType { get; set; }

    [Column("description")]
    [StringLength(60)]
    public string? Description { get; set; }

    [Column("hoa_id")]
    [StringLength(6)]
    public string? HoaId { get; set; }

    [Column("active_flag")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("created_timestamp")]
    public DateOnly CreatedTimestamp { get; set; }

    [Column("modified_timestamp")]
    public DateOnly ModifiedTimestamp { get; set; }

    [Column("int_nominee_type_old")]
    [StringLength(38)]
    public string? IntNomineeTypeOld { get; set; }

    [Column("int_nominee_type")]
    public int? IntNomineeType { get; set; }

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
