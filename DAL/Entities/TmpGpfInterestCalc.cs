using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NGIPF_BE.DAL.Entities;

[Keyless]
[Table("tmp_gpf_interest_calc", Schema = "ngipf")]
public partial class TmpGpfInterestCalc
{
    [Column("int_employee_id")]
    [StringLength(38)]
    public string IntEmployeeId { get; set; } = null!;

    [Column("interest_from_month")]
    public short InterestFromMonth { get; set; }

    [Column("interest_from_year")]
    public short InterestFromYear { get; set; }

    [Column("amount")]
    [Precision(16, 6)]
    public decimal Amount { get; set; }

    [Column("positive_negative_flag")]
    [StringLength(2)]
    public string PositiveNegativeFlag { get; set; } = null!;

    [Column("int_rate")]
    [Precision(5, 2)]
    public decimal IntRate { get; set; }

    [Column("calculated_int_amt")]
    [Precision(16, 6)]
    public decimal CalculatedIntAmt { get; set; }

    [Column("interest_upto_month")]
    public short InterestUptoMonth { get; set; }

    [Column("interest_upto_year")]
    public short InterestUptoYear { get; set; }

    [Column("duration_in_month")]
    public short DurationInMonth { get; set; }

    [Column("rollback_flag")]
    [StringLength(1)]
    public string RollbackFlag { get; set; } = null!;

    [Column("int_transaction_id")]
    [StringLength(38)]
    public string? IntTransactionId { get; set; }
}
