using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_frontend.DAL.Entities;

[Keyless]
[Table("lf_pl_op_interest_date_exception", Schema = "ngipf")]
public partial class LfPlOpInterestDateException
{
    [Column("id")]
    public int Id { get; set; }

    [Column("int_operator_id")]
    public int IntOperatorId { get; set; }

    [Column("day_of_month")]
    [StringLength(50)]
    public string? DayOfMonth { get; set; }

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
