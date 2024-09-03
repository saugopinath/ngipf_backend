using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_backend.DAL.Entities;

[Table("pf_mm_gen_year_close_process", Schema = "ngipf")]
public partial class PfMmGenYearCloseProcess
{
    [Key]
    [Column("int_pf_mm_year_close")]
    [StringLength(38)]
    public string IntPfMmYearClose { get; set; } = null!;

    [Column("fin_year_from")]
    public short? FinYearFrom { get; set; }

    [Column("percent_case_to_be_checked")]
    public short PercentCaseToBeChecked { get; set; }

    [Column("no_of_emp_in_each_bill")]
    public double? NoOfEmpInEachBill { get; set; }

    /// <summary>
    /// &apos;i&apos; for initiated, &apos;p&apos; for processing, &apos;c&apos; for completed
    /// </summary>
    [Column("job_status")]
    [StringLength(1)]
    public string? JobStatus { get; set; }

    [Column("remarks")]
    [StringLength(500)]
    public string? Remarks { get; set; }

    [Column("active_flag")]
    [StringLength(1)]
    public string ActiveFlag { get; set; } = null!;

    [Column("dml_status_flag")]
    public short DmlStatusFlag { get; set; }

    [Column("created_user_id")]
    public int CreatedUserId { get; set; }

    [Column("created_timestamp", TypeName = "timestamp(0) without time zone")]
    public DateTime CreatedTimestamp { get; set; }

    [Column("created_role_id")]
    public int? CreatedRoleId { get; set; }

    [Column("modified_user_id")]
    public int ModifiedUserId { get; set; }

    [Column("modified_timestamp", TypeName = "timestamp(0) without time zone")]
    public DateTime ModifiedTimestamp { get; set; }

    [Column("modified_role_id")]
    public int? ModifiedRoleId { get; set; }

    [Column("fp_excl_date", TypeName = "timestamp(0) without time zone")]
    public DateTime? FpExclDate { get; set; }

    [Column("rg_bill_priority_date", TypeName = "timestamp(0) without time zone")]
    public DateTime? RgBillPriorityDate { get; set; }

    [Column("yr_end_process_stage")]
    [StringLength(400)]
    public string? YrEndProcessStage { get; set; }

    [Column("yr_end_completed_time", TypeName = "timestamp(0) without time zone")]
    public DateTime? YrEndCompletedTime { get; set; }
}
