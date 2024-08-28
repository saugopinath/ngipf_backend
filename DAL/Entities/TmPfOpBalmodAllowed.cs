using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NGIPF_BE.DAL.Entities;

[Keyless]
[Table("tm_pf_op_balmod_allowed", Schema = "ngipf")]
public partial class TmPfOpBalmodAllowed
{
    [Column("employee_no")]
    [StringLength(15)]
    public string? EmployeeNo { get; set; }

    [Column("int_employee_id")]
    [StringLength(38)]
    public string? IntEmployeeId { get; set; }

    [Column("employee_name")]
    [StringLength(50)]
    public string? EmployeeName { get; set; }

    [Column("bal_capture_year")]
    public short? BalCaptureYear { get; set; }

    [Column("tr43_completed_year")]
    public short? Tr43CompletedYear { get; set; }

    [Column("mod_allowed_flag")]
    [StringLength(2)]
    public string? ModAllowedFlag { get; set; }

    [Column("created_timestamp", TypeName = "timestamp(0) without time zone")]
    public DateTime? CreatedTimestamp { get; set; }

    [Column("modified_timestamp", TypeName = "timestamp(0) without time zone")]
    public DateTime? ModifiedTimestamp { get; set; }

    [Column("created_user_id")]
    public long? CreatedUserId { get; set; }

    [Column("modified_user_id")]
    public long? ModifiedUserId { get; set; }

    [Column("dml_status_flag")]
    public short? DmlStatusFlag { get; set; }
}
