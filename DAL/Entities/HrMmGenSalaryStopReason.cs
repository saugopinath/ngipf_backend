using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_backend.DAL.Entities;

[Table("hr_mm_gen_salary_stop_reason", Schema = "ihrms")]
[Index("SalaryStopReasonDesc", Name = "uk_hr_mm_gen_salary_stop_re1", IsUnique = true)]
public partial class HrMmGenSalaryStopReason
{
    [Key]
    [Column("int_salary_stop_reason")]
    [StringLength(38)]
    public string IntSalaryStopReason { get; set; } = null!;

    [Column("salary_stop_reason_desc")]
    [StringLength(200)]
    public string SalaryStopReasonDesc { get; set; } = null!;

    [Column("active_flag")]
    [StringLength(1)]
    public string ActiveFlag { get; set; } = null!;

    [Column("wef", TypeName = "timestamp(0) without time zone")]
    public DateTime? Wef { get; set; }

    [Column("created_user_id")]
    public int CreatedUserId { get; set; }

    [Column("created_timestamp", TypeName = "timestamp(0) without time zone")]
    public DateTime CreatedTimestamp { get; set; }

    [Column("modified_user_id")]
    public int ModifiedUserId { get; set; }

    [Column("modified_timestamp", TypeName = "timestamp(0) without time zone")]
    public DateTime ModifiedTimestamp { get; set; }

    [Column("order_no_required")]
    [StringLength(1)]
    public string OrderNoRequired { get; set; } = null!;

    [Column("extra_field_required")]
    [StringLength(2)]
    public string? ExtraFieldRequired { get; set; }

    [Column("ebill_cessation_type_code")]
    [StringLength(1)]
    public string EbillCessationTypeCode { get; set; } = null!;
}
