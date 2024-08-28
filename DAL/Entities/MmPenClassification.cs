using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_frontend.DAL.Entities;

[Keyless]
[Table("mm_pen_classification", Schema = "ifmsadmin")]
public partial class MmPenClassification
{
    [Column("classification_description")]
    [StringLength(200)]
    public string? ClassificationDescription { get; set; }

    [Column("hoa_id")]
    [StringLength(6)]
    public string? HoaId { get; set; }

    [Column("due_draw_flag")]
    [StringLength(1)]
    public string? DueDrawFlag { get; set; }

    [Column("classification_flag")]
    [StringLength(1)]
    public string? ClassificationFlag { get; set; }

    [Column("active_flag")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("created_timestamp")]
    public DateOnly CreatedTimestamp { get; set; }

    [Column("modified_timestamp")]
    public DateOnly ModifiedTimestamp { get; set; }

    [Column("cvp_flag")]
    [StringLength(1)]
    public string? CvpFlag { get; set; }

    [Column("old_hoa_id")]
    [StringLength(8)]
    public string? OldHoaId { get; set; }

    [Column("classification_id_old")]
    [StringLength(38)]
    public string? ClassificationIdOld { get; set; }

    [Column("classification_id")]
    public int? ClassificationId { get; set; }

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

    [Column("int_prim_cat_id_old")]
    [StringLength(38)]
    public string? IntPrimCatIdOld { get; set; }

    [Column("int_prim_cat_id")]
    public int? IntPrimCatId { get; set; }
}
