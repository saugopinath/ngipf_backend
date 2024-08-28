using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NGIPF_BE.DAL.Entities;

[Table("pf_op_bal_request", Schema = "ingipfund")]
public partial class PfOpBalRequest1
{
    [Key]
    [Column("int_opbal_request_id")]
    [Precision(22, 0)]
    public decimal IntOpbalRequestId { get; set; }

    [Column("parent_request_id")]
    [Precision(22, 0)]
    public decimal? ParentRequestId { get; set; }

    [Column("child_request_id")]
    [Precision(22, 0)]
    public decimal? ChildRequestId { get; set; }

    [Column("int_pl_operator_id")]
    [Precision(22, 0)]
    public decimal? IntPlOperatorId { get; set; }

    [Column("request_status")]
    [StringLength(2)]
    public string? RequestStatus { get; set; }

    [Column("active_flag")]
    [MaxLength(1)]
    public char? ActiveFlag { get; set; }

    [Column("dml_status_flag")]
    public short? DmlStatusFlag { get; set; }

    [Column("created_user_id")]
    public long? CreatedUserId { get; set; }

    [Column("created_date")]
    public DateOnly? CreatedDate { get; set; }

    [Column("modified_user_id")]
    public long? ModifiedUserId { get; set; }

    [Column("modified_date")]
    public DateOnly? ModifiedDate { get; set; }
}
