using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_backend.DAL.Entities;

[Table("mm_gen_interest_rate_master", Schema = "ngipf_master")]
public partial class MmGenInterestRateMaster
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("interest_rate")]
    public double? InterestRate { get; set; }

    [Column("status")]
    public short? Status { get; set; }

    [Column("go_number")]
    [StringLength(200)]
    public string? GoNumber { get; set; }

    [Column("go_date")]
    public DateOnly? GoDate { get; set; }

    [Column("wef")]
    public DateOnly? Wef { get; set; }

    [Column("wet")]
    public DateOnly? Wet { get; set; }
}
