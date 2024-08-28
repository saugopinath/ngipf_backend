using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NGIPF_BE.DAL.Entities;

[Table("hr_tm_emp_increment", Schema = "ihrms")]
[Index("IntSrvId", Name = "ind_hr_tm_emp_incr1")]
[Index("IntRevPayAllowanceId", Name = "ind_hr_tm_emp_incr2")]
[Index("IntCadreId", Name = "ind_hr_tm_emp_incr3")]
[Index("IntGrpId", Name = "ind_hr_tm_emp_incr4")]
[Index("IntSectionId", Name = "ind_hr_tm_emp_incr5")]
[Index("IntPayheadId", Name = "ind_hr_tm_emp_incr6")]
[Index("IntTdRevPayAllowanceId", Name = "ind_hr_tm_emp_incr7")]
[Index("IntDdoId", Name = "ind_hr_tm_emp_incr8")]
[Index("HighestPayBandId", Name = "ind_hr_tm_emp_incr9")]
public partial class HrTmEmpIncrement
{
    [Key]
    [Column("int_incement_id")]
    [StringLength(38)]
    public string IntIncementId { get; set; } = null!;

    [Column("int_srv_id")]
    [StringLength(38)]
    public string? IntSrvId { get; set; }

    [Column("int_rev_pay_allowance_id")]
    [StringLength(38)]
    public string? IntRevPayAllowanceId { get; set; }

    [Column("int_cadre_id")]
    [StringLength(38)]
    public string? IntCadreId { get; set; }

    [Column("int_grp_id")]
    [StringLength(38)]
    public string? IntGrpId { get; set; }

    [Column("int_section_id")]
    [StringLength(38)]
    public string? IntSectionId { get; set; }

    [Column("int_payhead_id")]
    [StringLength(38)]
    public string? IntPayheadId { get; set; }

    [Column("incr_day")]
    public short? IncrDay { get; set; }

    [Column("incr_month")]
    public short? IncrMonth { get; set; }

    [Column("incr_year")]
    public short? IncrYear { get; set; }

    [Column("active_flag")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("dml_status_flag")]
    public short? DmlStatusFlag { get; set; }

    [Column("created_user_id")]
    public int? CreatedUserId { get; set; }

    [Column("modified_user_id")]
    public int? ModifiedUserId { get; set; }

    [Column("created_timestamp", TypeName = "timestamp without time zone")]
    public DateTime? CreatedTimestamp { get; set; }

    [Column("modified_timestamp", TypeName = "timestamp without time zone")]
    public DateTime? ModifiedTimestamp { get; set; }

    [Column("approve_flag_obs")]
    [StringLength(1)]
    public string? ApproveFlagObs { get; set; }

    [Column("approve_date_obs", TypeName = "timestamp(0) without time zone")]
    public DateTime? ApproveDateObs { get; set; }

    [Column("approve_by_obs")]
    public int? ApproveByObs { get; set; }

    [Column("stagnation_flag_obs")]
    [StringLength(1)]
    public string? StagnationFlagObs { get; set; }

    [Column("calculation_flag_obs")]
    [StringLength(1)]
    public string? CalculationFlagObs { get; set; }

    [Column("error_flag_obs")]
    [StringLength(1)]
    public string? ErrorFlagObs { get; set; }

    [Column("request_id")]
    public long? RequestId { get; set; }

    [Column("job_status")]
    [StringLength(30)]
    public string? JobStatus { get; set; }

    [Column("int_td_rev_pay_allowance_id")]
    [StringLength(38)]
    public string? IntTdRevPayAllowanceId { get; set; }

    [Column("increment_month_obs")]
    public short? IncrementMonthObs { get; set; }

    [Column("increment_day_obs")]
    public short? IncrementDayObs { get; set; }

    [Column("increment_percentage")]
    [Precision(5, 2)]
    public decimal? IncrementPercentage { get; set; }

    [Column("incr_order_no")]
    [StringLength(100)]
    public string? IncrOrderNo { get; set; }

    [Column("incr_order_date", TypeName = "timestamp(0) without time zone")]
    public DateTime? IncrOrderDate { get; set; }

    [Column("request_id_calculation")]
    public long? RequestIdCalculation { get; set; }

    [Column("int_ddo_id")]
    public int? IntDdoId { get; set; }

    [Column("incr_effective_date", TypeName = "timestamp(0) without time zone")]
    public DateTime? IncrEffectiveDate { get; set; }

    [Column("highest_pay_band_id")]
    [StringLength(38)]
    public string? HighestPayBandId { get; set; }

    [Column("highest_pay_band_min_amt")]
    public int? HighestPayBandMinAmt { get; set; }

    [Column("highest_pay_band_max_amt")]
    public int? HighestPayBandMaxAmt { get; set; }

    [Column("emp_serial_no")]
    public int? EmpSerialNo { get; set; }
}
