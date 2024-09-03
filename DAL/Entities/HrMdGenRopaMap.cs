using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_backend.DAL.Entities;

[Keyless]
[Table("hr_md_gen_ropa_map", Schema = "ihrms_master")]
public partial class HrMdGenRopaMap
{
    [Column("ACTIVE_FLAG")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("REMARKS")]
    [StringLength(200)]
    public string? Remarks { get; set; }

    [Column("CREATED_TIMESTAMP")]
    public DateOnly CreatedTimestamp { get; set; }

    [Column("MODIFIED_TIMESTAMP")]
    public DateOnly ModifiedTimestamp { get; set; }

    [Column("MAP_STATUS")]
    [StringLength(2)]
    public string? MapStatus { get; set; }

    [Column("INT_ROPA_MAP_ID_old")]
    [StringLength(38)]
    public string? IntRopaMapIdOld { get; set; }

    [Column("INT_ROPA_MAP_ID")]
    public int? IntRopaMapId { get; set; }

    [Column("INT_NEW_PAYB_ID_old")]
    [StringLength(38)]
    public string? IntNewPaybIdOld { get; set; }

    [Column("INT_NEW_PAYB_ID")]
    public int? IntNewPaybId { get; set; }

    [Column("INT_OLD_PAYB_ID_old")]
    [StringLength(38)]
    public string? IntOldPaybIdOld { get; set; }

    [Column("INT_OLD_PAYB_ID")]
    public int? IntOldPaybId { get; set; }

    [Column("INT_NEW_GRADE_PAY_ID_old")]
    [StringLength(38)]
    public string? IntNewGradePayIdOld { get; set; }

    [Column("INT_NEW_GRADE_PAY_ID")]
    public int? IntNewGradePayId { get; set; }

    [Column("INT_OLD_GRADE_PAY_ID_old")]
    [StringLength(38)]
    public string? IntOldGradePayIdOld { get; set; }

    [Column("INT_OLD_GRADE_PAY_ID")]
    public int? IntOldGradePayId { get; set; }

    [Column("INT_NEW_PAY_SCALE_ID_old")]
    [StringLength(38)]
    public string? IntNewPayScaleIdOld { get; set; }

    [Column("INT_NEW_PAY_SCALE_ID")]
    public int? IntNewPayScaleId { get; set; }

    [Column("INT_OLD_PAY_SCALE_ID_old")]
    [StringLength(38)]
    public string? IntOldPayScaleIdOld { get; set; }

    [Column("INT_OLD_PAY_SCALE_ID")]
    public int? IntOldPayScaleId { get; set; }

    [Column("MULTI_FACT_PAY_BAND_old")]
    [StringLength(38)]
    public string? MultiFactPayBandOld { get; set; }

    [Column("MULTI_FACT_PAY_BAND")]
    public int? MultiFactPayBand { get; set; }

    [Column("MULTI_FACT_GRADE_PAY_old")]
    [StringLength(38)]
    public string? MultiFactGradePayOld { get; set; }

    [Column("MULTI_FACT_GRADE_PAY")]
    public int? MultiFactGradePay { get; set; }

    [Column("MULTI_FACT_PAY_SCALE_old")]
    [StringLength(38)]
    public string? MultiFactPayScaleOld { get; set; }

    [Column("MULTI_FACT_PAY_SCALE")]
    public int? MultiFactPayScale { get; set; }

    [Column("DML_STATUS_FLAG_old")]
    [StringLength(38)]
    public string? DmlStatusFlagOld { get; set; }

    [Column("DML_STATUS_FLAG")]
    public int? DmlStatusFlag { get; set; }

    [Column("CREATED_USER_ID_old")]
    [StringLength(38)]
    public string? CreatedUserIdOld { get; set; }

    [Column("CREATED_USER_ID")]
    public int? CreatedUserId { get; set; }

    [Column("MODIFIED_USER_ID_old")]
    [StringLength(38)]
    public string? ModifiedUserIdOld { get; set; }

    [Column("MODIFIED_USER_ID")]
    public int? ModifiedUserId { get; set; }

    [Column("INT_MAP_TRANS_ID_old")]
    [StringLength(38)]
    public string? IntMapTransIdOld { get; set; }

    [Column("INT_MAP_TRANS_ID")]
    public int? IntMapTransId { get; set; }
}
