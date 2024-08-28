using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NGIPF_BE.DAL.Entities;

[Keyless]
[Table("hr_mm_gen_loan_advance_roi", Schema = "ihrms_master")]
public partial class HrMmGenLoanAdvanceRoi
{
    [Column("WEF_DATE")]
    public DateOnly WefDate { get; set; }

    [Column("ACTIVE_FLAG")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("CREATED_TIMESTAMP", TypeName = "timestamp without time zone")]
    public DateTime CreatedTimestamp { get; set; }

    [Column("MODIFIED_TIMESTAMP", TypeName = "timestamp without time zone")]
    public DateTime ModifiedTimestamp { get; set; }

    [Column("INT_LOAN_ADVANCE_ROI_ID_old")]
    [StringLength(38)]
    public string? IntLoanAdvanceRoiIdOld { get; set; }

    [Column("INT_LOAN_ADVANCE_ROI_ID")]
    public int? IntLoanAdvanceRoiId { get; set; }

    [Column("INT_LOAN_ADVANCE_TYPE_ID_old")]
    [StringLength(38)]
    public string? IntLoanAdvanceTypeIdOld { get; set; }

    [Column("INT_LOAN_ADVANCE_TYPE_ID")]
    public int? IntLoanAdvanceTypeId { get; set; }

    [Column("ROI_old")]
    [StringLength(38)]
    public string? RoiOld { get; set; }

    [Column("ROI")]
    public int? Roi { get; set; }

    [Column("PENAL_ROI_old")]
    [StringLength(38)]
    public string? PenalRoiOld { get; set; }

    [Column("PENAL_ROI")]
    public int? PenalRoi { get; set; }

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

    [Column("INT_LOAN_ADVANCE_INSTALL_ID_old")]
    [StringLength(38)]
    public string? IntLoanAdvanceInstallIdOld { get; set; }

    [Column("INT_LOAN_ADVANCE_INSTALL_ID")]
    public int? IntLoanAdvanceInstallId { get; set; }

    [Column("DML_STATUS_FLAG_old")]
    [StringLength(38)]
    public string? DmlStatusFlagOld { get; set; }

    [Column("DML_STATUS_FLAG")]
    public int? DmlStatusFlag { get; set; }

    [Column("MIN_ROI_SLAB_AMOUNT_old")]
    [StringLength(38)]
    public string? MinRoiSlabAmountOld { get; set; }

    [Column("MIN_ROI_SLAB_AMOUNT")]
    public int? MinRoiSlabAmount { get; set; }

    [Column("MAX_ROI_SLAB_AMOUNT_old")]
    [StringLength(38)]
    public string? MaxRoiSlabAmountOld { get; set; }

    [Column("MAX_ROI_SLAB_AMOUNT")]
    public int? MaxRoiSlabAmount { get; set; }
}
