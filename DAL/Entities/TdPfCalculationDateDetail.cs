using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NGIPF_BE.DAL.Entities;

[Table("td_pf_calculation_date_detail", Schema = "ngipf")]
public partial class TdPfCalculationDateDetail
{
    [Key]
    [Column("int_calculation_detail_id")]
    [StringLength(38)]
    public string IntCalculationDetailId { get; set; } = null!;

    [Column("int_final_payment_id")]
    [StringLength(38)]
    public string IntFinalPaymentId { get; set; } = null!;

    [Column("interest_payment_date", TypeName = "timestamp(0) without time zone")]
    public DateTime InterestPaymentDate { get; set; }

    [Column("interest_rate_availble_date", TypeName = "timestamp(0) without time zone")]
    public DateTime InterestRateAvailbleDate { get; set; }

    [Column("go_number")]
    [StringLength(50)]
    public string? GoNumber { get; set; }

    [Column("go_date", TypeName = "timestamp(0) without time zone")]
    public DateTime? GoDate { get; set; }

    [Column("residual_interest_from_date", TypeName = "timestamp(0) without time zone")]
    public DateTime? ResidualInterestFromDate { get; set; }

    [Column("residual_interest_to_date", TypeName = "timestamp(0) without time zone")]
    public DateTime? ResidualInterestToDate { get; set; }

    [Column("conifm_flag")]
    [MaxLength(1)]
    public char ConifmFlag { get; set; }

    [Column("dml_status_flag")]
    public short DmlStatusFlag { get; set; }
}
