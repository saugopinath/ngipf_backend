﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_backend.DAL.Entities;

[Keyless]
[Table("hr_mm_gen_pl_pf_ddo_map", Schema = "ngipf")]
public partial class HrMmGenPlPfDdoMap
{
    [Column("int_pl_pf_ddo_map")]
    [Precision(38, 0)]
    public decimal? IntPlPfDdoMap { get; set; }

    [Column("int_treasury_code")]
    [StringLength(5)]
    public string? IntTreasuryCode { get; set; }

    [Column("treasury_code")]
    [StringLength(4)]
    public string? TreasuryCode { get; set; }

    [Column("treasury_name")]
    [StringLength(100)]
    public string? TreasuryName { get; set; }

    [Column("operator_id")]
    [Precision(6, 0)]
    public decimal? OperatorId { get; set; }

    [Column("operator_name")]
    [StringLength(100)]
    public string? OperatorName { get; set; }

    [Column("scheme_id")]
    [Precision(6, 0)]
    public decimal? SchemeId { get; set; }

    [Column("scheme_desc")]
    [StringLength(100)]
    public string? SchemeDesc { get; set; }

    [Column("int_operator_id")]
    [Precision(6, 0)]
    public decimal? IntOperatorId { get; set; }

    [Column("major_head")]
    [StringLength(4)]
    public string? MajorHead { get; set; }

    [Column("submajor_head")]
    [StringLength(2)]
    public string? SubmajorHead { get; set; }

    [Column("minor_head")]
    [StringLength(3)]
    public string? MinorHead { get; set; }

    [Column("scheme_head")]
    [StringLength(3)]
    public string? SchemeHead { get; set; }

    [Column("detail_head")]
    [StringLength(2)]
    public string? DetailHead { get; set; }

    [Column("int_ddo_id")]
    [Precision(7, 0)]
    public decimal? IntDdoId { get; set; }

    [Column("active_flag")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("created_time_stamp", TypeName = "timestamp without time zone")]
    public DateTime CreatedTimeStamp { get; set; }

    [Column("created_user_id")]
    [StringLength(6)]
    public string? CreatedUserId { get; set; }

    [Column("modified_time_stamp", TypeName = "timestamp without time zone")]
    public DateTime? ModifiedTimeStamp { get; set; }

    [Column("modified_user_id")]
    [StringLength(6)]
    public string? ModifiedUserId { get; set; }

    [Column("dml_status_flag")]
    [Precision(1, 0)]
    public decimal? DmlStatusFlag { get; set; }

    [Column("role_id")]
    [Precision(5, 0)]
    public decimal? RoleId { get; set; }

    [Column("local_global_flag")]
    [StringLength(1)]
    public string? LocalGlobalFlag { get; set; }

    [Column("hoa_id")]
    [Precision(6, 0)]
    public decimal? HoaId { get; set; }

    [Column("int_treasury_code_op")]
    [StringLength(5)]
    public string? IntTreasuryCodeOp { get; set; }

    [Column("treasury_code_op")]
    [StringLength(4)]
    public string? TreasuryCodeOp { get; set; }

    [Column("treasury_name_op")]
    [StringLength(100)]
    public string? TreasuryNameOp { get; set; }
}
