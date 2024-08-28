using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_frontend.DAL.Entities;

[Table("mm_pf_interest_rate", Schema = "ngipf")]
[Index("Wef", Name = "uk_mm_gpf_interest_rate1", IsUnique = true)]
public partial class MmPfInterestRate
{
    [Key]
    [Column("int_category_id")]
    [StringLength(38)]
    public string IntCategoryId { get; set; } = null!;

    [Column("fin_year_from")]
    public short FinYearFrom { get; set; }

    [Column("wef", TypeName = "timestamp(0) without time zone")]
    public DateTime Wef { get; set; }

    [Column("interest_rate")]
    [Precision(4, 2)]
    public decimal InterestRate { get; set; }

    [Column("end_date", TypeName = "timestamp(0) without time zone")]
    public DateTime? EndDate { get; set; }

    [Column("hoa_id")]
    public int? HoaId { get; set; }

    [Column("go_no")]
    [StringLength(100)]
    public string? GoNo { get; set; }

    [Column("go_date", TypeName = "timestamp(0) without time zone")]
    public DateTime? GoDate { get; set; }

    [Column("active_flag")]
    [StringLength(1)]
    public string ActiveFlag { get; set; } = null!;

    [Column("user_id")]
    public int UserId { get; set; }

    [Column("modified_user_id")]
    public int ModifiedUserId { get; set; }

    [Column("created_timestamp", TypeName = "timestamp(0) without time zone")]
    public DateTime CreatedTimestamp { get; set; }

    [Column("modified_timestamp", TypeName = "timestamp(0) without time zone")]
    public DateTime ModifiedTimestamp { get; set; }
}
