using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_backend.DAL.Entities;

[Table("mm_ngipf_interest_rate", Schema = "ingipfund")]
public partial class MmNgipfInterestRate
{
    [Column("go_date")]
    public DateOnly? GoDate { get; set; }

    [Column("active_flag")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("user_id")]
    [Precision(22, 0)]
    public decimal? UserId { get; set; }

    [Column("modified_user_id")]
    [Precision(22, 0)]
    public decimal? ModifiedUserId { get; set; }

    [Column("created_timestamp")]
    public DateOnly? CreatedTimestamp { get; set; }

    [Column("modified_timestamp")]
    public DateOnly? ModifiedTimestamp { get; set; }

    [Column("dml_status_flag")]
    [Precision(22, 0)]
    public decimal? DmlStatusFlag { get; set; }

    [Column("legacy_flag")]
    [StringLength(1)]
    public string? LegacyFlag { get; set; }

    [Key]
    [Column("int_ngipf_rate_id")]
    [Precision(22, 0)]
    public decimal IntNgipfRateId { get; set; }

    [Column("fin_year_from")]
    [Precision(22, 0)]
    public decimal? FinYearFrom { get; set; }

    [Column("wef")]
    public DateOnly? Wef { get; set; }

    [Column("interest_rate")]
    [Precision(22, 2)]
    public decimal? InterestRate { get; set; }

    [Column("end_date")]
    public DateOnly? EndDate { get; set; }

    [Column("hoa_id")]
    public int? HoaId { get; set; }

    [Column("go_no")]
    [StringLength(100)]
    public string? GoNo { get; set; }

    [ForeignKey("HoaId")]
    [InverseProperty("MmNgipfInterestRates")]
    public virtual MmGenHoa? Hoa { get; set; }
}
