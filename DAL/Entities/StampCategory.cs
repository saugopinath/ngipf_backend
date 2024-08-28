﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_frontend.DAL.Entities;

[Table("stamp_category", Schema = "cts_master")]
public partial class StampCategory
{
    [Column("stamp_category")]
    [StringLength(2)]
    public string StampCategory1 { get; set; } = null!;

    [Column("description", TypeName = "character varying")]
    public string Description { get; set; } = null!;

    [Required]
    [Column("is_active")]
    public bool? IsActive { get; set; }

    [Column("created_at", TypeName = "timestamp without time zone")]
    public DateTime? CreatedAt { get; set; }

    [Column("created_by")]
    public long? CreatedBy { get; set; }

    [Column("updated_at", TypeName = "timestamp without time zone")]
    public DateTime? UpdatedAt { get; set; }

    [Column("updated_by")]
    public long? UpdatedBy { get; set; }

    [Key]
    [Column("stamp_category_id")]
    public long StampCategoryId { get; set; }

    [Column("hoa_id")]
    public long? HoaId { get; set; }

    [Column("hoa", TypeName = "character varying")]
    public string? Hoa { get; set; }

    [Column("subDtlHead")]
    [StringLength(2)]
    public string? SubDtlHead { get; set; }

    [InverseProperty("StampCategory")]
    public virtual ICollection<DiscountDetail> DiscountDetails { get; set; } = new List<DiscountDetail>();

    [InverseProperty("StampCategory")]
    public virtual ICollection<StampCombination> StampCombinations { get; set; } = new List<StampCombination>();
}
