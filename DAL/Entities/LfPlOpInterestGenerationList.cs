using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_frontend.DAL.Entities;

[Keyless]
[Table("lf_pl_op_interest_generation_list", Schema = "ngipf")]
public partial class LfPlOpInterestGenerationList
{
    [Column("id")]
    public int Id { get; set; }

    [Column("int_operator_id")]
    public int IntOperatorId { get; set; }

    [Column("int_generation_type")]
    public int? IntGenerationType { get; set; }

    [Column("status")]
    public short? Status { get; set; }

    [Column("go_number")]
    [StringLength(200)]
    public string? GoNumber { get; set; }

    [Column("go_date")]
    public DateOnly? GoDate { get; set; }

    [ForeignKey("IntGenerationType")]
    public virtual MmGenInterestGenerationMaster? IntGenerationTypeNavigation { get; set; }

    [ForeignKey("IntOperatorId")]
    public virtual TMmGenPlOperator IntOperator { get; set; } = null!;
}
