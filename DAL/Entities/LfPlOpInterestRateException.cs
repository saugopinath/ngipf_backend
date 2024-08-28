using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NGIPF_BE.DAL.Entities;

[Keyless]
[Table("lf_pl_op_interest_rate_exception", Schema = "ngipf")]
public partial class LfPlOpInterestRateException
{
    [Column("id")]
    public int Id { get; set; }

    [Column("int_operator_id")]
    public int IntOperatorId { get; set; }

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

    [ForeignKey("IntOperatorId")]
    public virtual TMmGenPlOperator IntOperator { get; set; } = null!;
}
