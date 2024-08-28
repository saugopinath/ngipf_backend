using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_frontend.DAL.Entities;

[Keyless]
[Table("mm_pen_category", Schema = "ifmsadmin")]
public partial class MmPenCategory
{
    [Column("sub_cat_desc")]
    [StringLength(200)]
    public string? SubCatDesc { get; set; }

    [Column("category_desc")]
    [StringLength(400)]
    public string? CategoryDesc { get; set; }

    [Column("active_flag")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("created_timestamp")]
    public DateOnly CreatedTimestamp { get; set; }

    [Column("modified_timestamp")]
    public DateOnly ModifiedTimestamp { get; set; }

    [Column("pen_category_id_old")]
    [StringLength(38)]
    public string? PenCategoryIdOld { get; set; }

    [Column("pen_category_id")]
    public int? PenCategoryId { get; set; }

    [Column("int_prim_cat_id_old")]
    [StringLength(38)]
    public string? IntPrimCatIdOld { get; set; }

    [Column("int_prim_cat_id")]
    public int? IntPrimCatId { get; set; }

    [Column("int_sub_cat_id_old")]
    [StringLength(38)]
    public string? IntSubCatIdOld { get; set; }

    [Column("int_sub_cat_id")]
    public int? IntSubCatId { get; set; }

    [Column("family_cnvt_cat_id_old")]
    [StringLength(38)]
    public string? FamilyCnvtCatIdOld { get; set; }

    [Column("family_cnvt_cat_id")]
    public int? FamilyCnvtCatId { get; set; }

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
