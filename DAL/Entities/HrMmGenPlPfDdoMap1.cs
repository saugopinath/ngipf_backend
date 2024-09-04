using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_backend.DAL.Entities;

[Table("hr_mm_gen_pl_pf_ddo_map", Schema = "ihrms")]
public partial class HrMmGenPlPfDdoMap1
{
    [Key]
    [Column("int_pl_pf_ddo_map")]
    [Precision(38, 0)]
    public decimal IntPlPfDdoMap { get; set; }

    [Column("int_treasury_code")]
    [StringLength(5)]
    public string IntTreasuryCode { get; set; } = null!;

    [Column("treasury_code")]
    [StringLength(4)]
    public string TreasuryCode { get; set; } = null!;

    [Column("treasury_name")]
    [StringLength(100)]
    public string TreasuryName { get; set; } = null!;

    [Column("operator_id")]
    public int OperatorId { get; set; }

    [Column("operator_name")]
    [StringLength(100)]
    public string OperatorName { get; set; } = null!;

    [Column("scheme_id")]
    public int SchemeId { get; set; }

    [Column("scheme_desc")]
    [StringLength(100)]
    public string SchemeDesc { get; set; } = null!;

    [Column("int_operator_id")]
    public int IntOperatorId { get; set; }

    [Column("major_head")]
    [StringLength(4)]
    public string MajorHead { get; set; } = null!;

    [Column("submajor_head")]
    [StringLength(2)]
    public string SubmajorHead { get; set; } = null!;

    [Column("minor_head")]
    [StringLength(3)]
    public string MinorHead { get; set; } = null!;

    [Column("scheme_head")]
    [StringLength(3)]
    public string SchemeHead { get; set; } = null!;

    [Column("detail_head")]
    [StringLength(2)]
    public string DetailHead { get; set; } = null!;

    [Column("int_ddo_id")]
    public int IntDdoId { get; set; }

    [Column("active_flag")]
    [StringLength(1)]
    public string ActiveFlag { get; set; } = null!;

    [Column("created_time_stamp", TypeName = "timestamp(6) without time zone")]
    public DateTime CreatedTimeStamp { get; set; }

    [Column("created_user_id")]
    [StringLength(6)]
    public string CreatedUserId { get; set; } = null!;

    [Column("modified_time_stamp", TypeName = "timestamp(6) without time zone")]
    public DateTime? ModifiedTimeStamp { get; set; }

    [Column("modified_user_id")]
    [StringLength(6)]
    public string? ModifiedUserId { get; set; }

    [Column("dml_status_flag")]
    public short DmlStatusFlag { get; set; }

    [Column("role_id")]
    public int? RoleId { get; set; }

    [Column("local_global_flag")]
    [StringLength(1)]
    public string LocalGlobalFlag { get; set; } = null!;

    [Column("hoa_id")]
    public int HoaId { get; set; }

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
