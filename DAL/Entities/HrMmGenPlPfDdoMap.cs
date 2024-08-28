using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_frontend.DAL.Entities;

[Keyless]
[Table("hr_mm_gen_pl_pf_ddo_map", Schema = "ihrms_master")]
public partial class HrMmGenPlPfDdoMap
{
    [Column("INT_TREASURY_CODE")]
    [StringLength(5)]
    public string? IntTreasuryCode { get; set; }

    [Column("TREASURY_CODE")]
    [StringLength(4)]
    public string? TreasuryCode { get; set; }

    [Column("TREASURY_NAME")]
    [StringLength(100)]
    public string? TreasuryName { get; set; }

    [Column("OPERATOR_NAME")]
    [StringLength(100)]
    public string? OperatorName { get; set; }

    [Column("SCHEME_DESC")]
    [StringLength(100)]
    public string? SchemeDesc { get; set; }

    [Column("MAJOR_HEAD")]
    [StringLength(4)]
    public string? MajorHead { get; set; }

    [Column("SUBMAJOR_HEAD")]
    [StringLength(2)]
    public string? SubmajorHead { get; set; }

    [Column("MINOR_HEAD")]
    [StringLength(3)]
    public string? MinorHead { get; set; }

    [Column("SCHEME_HEAD")]
    [StringLength(3)]
    public string? SchemeHead { get; set; }

    [Column("DETAIL_HEAD")]
    [StringLength(2)]
    public string? DetailHead { get; set; }

    [Column("ACTIVE_FLAG")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("CREATED_TIME_STAMP", TypeName = "timestamp without time zone")]
    public DateTime CreatedTimeStamp { get; set; }

    [Column("CREATED_USER_ID")]
    [StringLength(6)]
    public string? CreatedUserId { get; set; }

    [Column("MODIFIED_TIME_STAMP", TypeName = "timestamp without time zone")]
    public DateTime? ModifiedTimeStamp { get; set; }

    [Column("MODIFIED_USER_ID")]
    [StringLength(6)]
    public string? ModifiedUserId { get; set; }

    [Column("LOCAL_GLOBAL_FLAG")]
    [StringLength(1)]
    public string? LocalGlobalFlag { get; set; }

    [Column("INT_TREASURY_CODE_OP")]
    [StringLength(5)]
    public string? IntTreasuryCodeOp { get; set; }

    [Column("TREASURY_CODE_OP")]
    [StringLength(4)]
    public string? TreasuryCodeOp { get; set; }

    [Column("TREASURY_NAME_OP")]
    [StringLength(100)]
    public string? TreasuryNameOp { get; set; }

    [Column("INT_PL_PF_DDO_MAP_old")]
    [StringLength(38)]
    public string? IntPlPfDdoMapOld { get; set; }

    [Column("INT_PL_PF_DDO_MAP")]
    public int? IntPlPfDdoMap { get; set; }

    [Column("OPERATOR_ID_old")]
    [StringLength(38)]
    public string? OperatorIdOld { get; set; }

    [Column("OPERATOR_ID")]
    public int? OperatorId { get; set; }

    [Column("SCHEME_ID_old")]
    [StringLength(38)]
    public string? SchemeIdOld { get; set; }

    [Column("SCHEME_ID")]
    public int? SchemeId { get; set; }

    [Column("INT_OPERATOR_ID_old")]
    [StringLength(38)]
    public string? IntOperatorIdOld { get; set; }

    [Column("INT_OPERATOR_ID")]
    public int? IntOperatorId { get; set; }

    [Column("INT_DDO_ID_old")]
    [StringLength(38)]
    public string? IntDdoIdOld { get; set; }

    [Column("INT_DDO_ID")]
    public int? IntDdoId { get; set; }

    [Column("DML_STATUS_FLAG_old")]
    [StringLength(38)]
    public string? DmlStatusFlagOld { get; set; }

    [Column("DML_STATUS_FLAG")]
    public int? DmlStatusFlag { get; set; }

    [Column("ROLE_ID_old")]
    [StringLength(38)]
    public string? RoleIdOld { get; set; }

    [Column("ROLE_ID")]
    public int? RoleId { get; set; }

    [Column("HOA_ID_old")]
    [StringLength(38)]
    public string? HoaIdOld { get; set; }

    [Column("HOA_ID")]
    public int? HoaId { get; set; }
}
