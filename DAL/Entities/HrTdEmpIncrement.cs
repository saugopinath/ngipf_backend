using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NGIPF_BE.DAL.Entities;

[Table("hr_td_emp_increment", Schema = "ihrms_emp_master")]
public partial class HrTdEmpIncrement
{
    [Column("incement_wef")]
    public DateOnly IncementWef { get; set; }

    [Column("bill_wef")]
    public DateOnly BillWef { get; set; }

    [Column("emp_joining_dt")]
    public DateOnly EmpJoiningDt { get; set; }

    [Column("active_flag")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("created_timestamp", TypeName = "timestamp without time zone")]
    public DateTime CreatedTimestamp { get; set; }

    [Column("modified_timestamp", TypeName = "timestamp without time zone")]
    public DateTime ModifiedTimestamp { get; set; }

    [Column("approve_flag_obs")]
    [StringLength(1)]
    public string? ApproveFlagObs { get; set; }

    [Column("approve_date_obs")]
    public DateOnly? ApproveDateObs { get; set; }

    [Column("stagnation_flag_obs")]
    [StringLength(1)]
    public string? StagnationFlagObs { get; set; }

    [Column("error_flag_obs")]
    [StringLength(1)]
    public string? ErrorFlagObs { get; set; }

    [Column("pay_band_existing")]
    [StringLength(10)]
    public string? PayBandExisting { get; set; }

    [Column("pay_band_next")]
    [StringLength(10)]
    public string? PayBandNext { get; set; }

    [Column("calculation_status")]
    [StringLength(2)]
    public string? CalculationStatus { get; set; }

    [Column("incr_wef_date_obs")]
    public DateOnly? IncrWefDateObs { get; set; }

    [Column("last_bill_date")]
    public DateOnly? LastBillDate { get; set; }

    [Column("rej_status")]
    [StringLength(2)]
    public string? RejStatus { get; set; }

    [Column("int_td_incement_id_old")]
    [StringLength(38)]
    public string? IntTdIncementIdOld { get; set; }

    [Column("int_incement_id_old")]
    [StringLength(38)]
    public string? IntIncementIdOld { get; set; }

    [Column("int_incement_id")]
    public int? IntIncementId { get; set; }

    [Column("int_employee_id_old")]
    [StringLength(38)]
    public string? IntEmployeeIdOld { get; set; }

    [Column("int_employee_id")]
    public int? IntEmployeeId { get; set; }

    [Column("int_payband_existing_old")]
    [StringLength(38)]
    public string? IntPaybandExistingOld { get; set; }

    [Column("int_payband_existing")]
    public int? IntPaybandExisting { get; set; }

    [Column("gread_pay_existing_old")]
    [StringLength(38)]
    public string? GreadPayExistingOld { get; set; }

    [Column("gread_pay_existing")]
    public int? GreadPayExisting { get; set; }

    [Column("basic_existing_old")]
    [StringLength(38)]
    public string? BasicExistingOld { get; set; }

    [Column("basic_existing")]
    public int? BasicExisting { get; set; }

    [Column("dml_status_flag_old")]
    [StringLength(38)]
    public string? DmlStatusFlagOld { get; set; }

    [Column("dml_status_flag")]
    public int? DmlStatusFlag { get; set; }

    [Column("created_user_id_old")]
    [StringLength(38)]
    public string? CreatedUserIdOld { get; set; }

    [Column("created_user_id")]
    public int? CreatedUserId { get; set; }

    [Column("modified_user_id_old")]
    [StringLength(38)]
    public string? ModifiedUserIdOld { get; set; }

    [Column("modified_user_id")]
    public int? ModifiedUserId { get; set; }

    [Column("approve_by_obs_old")]
    [StringLength(38)]
    public string? ApproveByObsOld { get; set; }

    [Column("approve_by_obs")]
    public int? ApproveByObs { get; set; }

    [Column("int_payband_next_old")]
    [StringLength(38)]
    public string? IntPaybandNextOld { get; set; }

    [Column("int_payband_next")]
    public int? IntPaybandNext { get; set; }

    [Column("gread_pay_next_old")]
    [StringLength(38)]
    public string? GreadPayNextOld { get; set; }

    [Column("gread_pay_next")]
    public int? GreadPayNext { get; set; }

    [Column("basic_next_old")]
    [StringLength(38)]
    public string? BasicNextOld { get; set; }

    [Column("basic_next")]
    public int? BasicNext { get; set; }

    [Column("int_gread_pay_id_next_old")]
    [StringLength(38)]
    public string? IntGreadPayIdNextOld { get; set; }

    [Column("int_gread_pay_id_next")]
    public int? IntGreadPayIdNext { get; set; }

    [Column("min_amt_existing_old")]
    [StringLength(38)]
    public string? MinAmtExistingOld { get; set; }

    [Column("min_amt_existing")]
    public int? MinAmtExisting { get; set; }

    [Column("max_amt_existing_old")]
    [StringLength(38)]
    public string? MaxAmtExistingOld { get; set; }

    [Column("max_amt_existing")]
    public int? MaxAmtExisting { get; set; }

    [Column("min_amt_next_old")]
    [StringLength(38)]
    public string? MinAmtNextOld { get; set; }

    [Column("min_amt_next")]
    public int? MinAmtNext { get; set; }

    [Column("max_amt_next_old")]
    [StringLength(38)]
    public string? MaxAmtNextOld { get; set; }

    [Column("max_amt_next")]
    public int? MaxAmtNext { get; set; }

    [Column("incr_year_old")]
    [StringLength(38)]
    public string? IncrYearOld { get; set; }

    [Column("incr_year")]
    public int? IncrYear { get; set; }

    [Column("int_designation_id_old")]
    [StringLength(38)]
    public string? IntDesignationIdOld { get; set; }

    [Column("int_designation_id")]
    public int? IntDesignationId { get; set; }

    [Column("int_post_id_old")]
    [StringLength(38)]
    public string? IntPostIdOld { get; set; }

    [Column("int_post_id")]
    public int? IntPostId { get; set; }

    [Column("int_payscale_existing_old")]
    [StringLength(38)]
    public string? IntPayscaleExistingOld { get; set; }

    [Column("int_payscale_existing")]
    public int? IntPayscaleExisting { get; set; }

    [Column("int_payscale_next_old")]
    [StringLength(38)]
    public string? IntPayscaleNextOld { get; set; }

    [Column("int_payscale_next")]
    public int? IntPayscaleNext { get; set; }

    [Column("request_id_for_rej_old")]
    [StringLength(38)]
    public string? RequestIdForRejOld { get; set; }

    [Column("request_id_for_rej")]
    public int? RequestIdForRej { get; set; }

    [Key]
    [Column("int_td_incement_id")]
    public int IntTdIncementId { get; set; }

    [InverseProperty("IntTdIncement")]
    public virtual ICollection<HrMdEmpPayAndAllowance> HrMdEmpPayAndAllowances { get; set; } = new List<HrMdEmpPayAndAllowance>();
}
