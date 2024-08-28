using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_frontend.DAL.Entities;

[Table("hr_mm_gen_advance_purpose", Schema = "ingipfund")]
public partial class HrMmGenAdvancePurpose
{
    [Key]
    [Column("int_advance_purpose_id")]
    [Precision(38, 0)]
    public decimal IntAdvancePurposeId { get; set; }

    [Column("advance_purpose")]
    [StringLength(1000)]
    public string? AdvancePurpose { get; set; }

    [Column("active_flag")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("dml_ststus_flag")]
    [Precision(1, 0)]
    public decimal? DmlStstusFlag { get; set; }

    [Column("created_user_id")]
    [Precision(8, 0)]
    public decimal? CreatedUserId { get; set; }

    [Column("created_timestamp")]
    public DateOnly? CreatedTimestamp { get; set; }

    [Column("modified_user_id")]
    [Precision(8, 0)]
    public decimal? ModifiedUserId { get; set; }

    [Column("modified_timestamp", TypeName = "timestamp(6) without time zone")]
    public DateTime? ModifiedTimestamp { get; set; }

    [Column("wef")]
    public DateOnly? Wef { get; set; }

    [Column("remarks")]
    [StringLength(1000)]
    public string? Remarks { get; set; }

    [Column("go_no")]
    [StringLength(50)]
    public string? GoNo { get; set; }

    [Column("go_date")]
    public DateOnly? GoDate { get; set; }
}
