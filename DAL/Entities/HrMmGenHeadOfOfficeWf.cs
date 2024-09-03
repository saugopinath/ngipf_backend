using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_backend.DAL.Entities;

[Keyless]
[Table("hr_mm_gen_head_of_office_wf", Schema = "ihrms_master")]
public partial class HrMmGenHeadOfOfficeWf
{
    [Column("NAME_OF_OFFICE")]
    [StringLength(200)]
    public string? NameOfOffice { get; set; }

    [Column("OFFICE_CODE")]
    [StringLength(30)]
    public string? OfficeCode { get; set; }

    [Column("ACTIVE_FLAG")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("CREATED_TIMESTAMP")]
    public DateOnly CreatedTimestamp { get; set; }

    [Column("MODIFIED_TIMESTAMP")]
    public DateOnly ModifiedTimestamp { get; set; }

    [Column("APPROVE_FLAG")]
    [StringLength(1)]
    public string? ApproveFlag { get; set; }

    [Column("APPROVE_DATE")]
    public DateOnly? ApproveDate { get; set; }

    [Column("DEMAND_NO")]
    [StringLength(2)]
    public string? DemandNo { get; set; }

    [Column("GOVT_HEADER_YES_NO")]
    [StringLength(1)]
    public string? GovtHeaderYesNo { get; set; }

    [Column("GOVT_PARASTATAL_FLAG")]
    [StringLength(1)]
    public string? GovtParastatalFlag { get; set; }

    [Column("NON_SALARIED_HOO")]
    [StringLength(2)]
    public string? NonSalariedHoo { get; set; }

    [Column("INT_HEAD_OF_OFFICE_ID_old")]
    [StringLength(38)]
    public string? IntHeadOfOfficeIdOld { get; set; }

    [Column("INT_HEAD_OF_OFFICE_ID")]
    public int? IntHeadOfOfficeId { get; set; }

    [Column("INT_DEPT_ID_old")]
    [StringLength(38)]
    public string? IntDeptIdOld { get; set; }

    [Column("INT_DEPT_ID")]
    public int? IntDeptId { get; set; }

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

    [Column("DML_STATUS_FLAG_old")]
    [StringLength(38)]
    public string? DmlStatusFlagOld { get; set; }

    [Column("DML_STATUS_FLAG")]
    public int? DmlStatusFlag { get; set; }

    [Column("APPROVE_BY_old")]
    [StringLength(38)]
    public string? ApproveByOld { get; set; }

    [Column("APPROVE_BY")]
    public int? ApproveBy { get; set; }

    [Column("LEVEL_ID_old")]
    [StringLength(38)]
    public string? LevelIdOld { get; set; }

    [Column("LEVEL_ID")]
    public int? LevelId { get; set; }

    [Column("INT_CREATED_BY_HO_old")]
    [StringLength(38)]
    public string? IntCreatedByHoOld { get; set; }

    [Column("INT_CREATED_BY_HO")]
    public int? IntCreatedByHo { get; set; }
}
