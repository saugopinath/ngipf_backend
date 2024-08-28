using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_frontend.DAL.Entities;

[Table("pf_op_bal_request", Schema = "ngipf")]
public partial class PfOpBalRequest
{
    [Key]
    [Column("int_opbal_request_id")]
    [StringLength(38)]
    public string IntOpbalRequestId { get; set; } = null!;

    [Column("parent_request_id")]
    [StringLength(38)]
    public string ParentRequestId { get; set; } = null!;

    [Column("child_request_id")]
    [StringLength(38)]
    public string ChildRequestId { get; set; } = null!;

    [Column("int_pl_operator_id")]
    [StringLength(38)]
    public string? IntPlOperatorId { get; set; }

    [Column("request_status")]
    [StringLength(2)]
    public string? RequestStatus { get; set; }

    [Column("active_flag")]
    [MaxLength(1)]
    public char ActiveFlag { get; set; }

    [Column("dml_status_flag")]
    public short DmlStatusFlag { get; set; }

    [Column("created_user_id")]
    public long CreatedUserId { get; set; }

    [Column("created_date", TypeName = "timestamp(0) without time zone")]
    public DateTime CreatedDate { get; set; }

    [Column("modified_user_id")]
    public long ModifiedUserId { get; set; }

    [Column("modified_date", TypeName = "timestamp(0) without time zone")]
    public DateTime ModifiedDate { get; set; }
}
