using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_backend.DAL.Entities;

[Keyless]
[Table("hr_md_gen_nodal_officer", Schema = "ihrms_master")]
public partial class HrMdGenNodalOfficer
{
    [Column("ACTIVE_FLAG")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("CREATED_TIMESTAMP")]
    public DateOnly CreatedTimestamp { get; set; }

    [Column("MODIFIED_TIMESTAMP")]
    public DateOnly ModifiedTimestamp { get; set; }

    [Column("APPROVE_DATE")]
    public DateOnly? ApproveDate { get; set; }

    [Column("INT_MD_GEN_NODAL_OFFICER_ID_old")]
    [StringLength(38)]
    public string? IntMdGenNodalOfficerIdOld { get; set; }

    [Column("INT_MD_GEN_NODAL_OFFICER_ID")]
    public int? IntMdGenNodalOfficerId { get; set; }

    [Column("INT_NODAL_OFFICER_ID_old")]
    [StringLength(38)]
    public string? IntNodalOfficerIdOld { get; set; }

    [Column("INT_NODAL_OFFICER_ID")]
    public int? IntNodalOfficerId { get; set; }

    [Column("INT_SERVICE_ID_old")]
    [StringLength(38)]
    public string? IntServiceIdOld { get; set; }

    [Column("INT_SERVICE_ID")]
    public int? IntServiceId { get; set; }

    [Column("INT_CADRE_ID_old")]
    [StringLength(38)]
    public string? IntCadreIdOld { get; set; }

    [Column("INT_CADRE_ID")]
    public int? IntCadreId { get; set; }

    [Column("INT_GROUP_ID_old")]
    [StringLength(38)]
    public string? IntGroupIdOld { get; set; }

    [Column("INT_GROUP_ID")]
    public int? IntGroupId { get; set; }

    [Column("INT_HEAD_OFFICE_ID_old")]
    [StringLength(38)]
    public string? IntHeadOfficeIdOld { get; set; }

    [Column("INT_HEAD_OFFICE_ID")]
    public int? IntHeadOfficeId { get; set; }

    [Column("INT_DISTRICT_ID_old")]
    [StringLength(38)]
    public string? IntDistrictIdOld { get; set; }

    [Column("INT_DISTRICT_ID")]
    public int? IntDistrictId { get; set; }

    [Column("INT_ADMIN_DEPARTMENT_old")]
    [StringLength(38)]
    public string? IntAdminDepartmentOld { get; set; }

    [Column("INT_ADMIN_DEPARTMENT")]
    public int? IntAdminDepartment { get; set; }

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

    [Column("CREATED_ROLE_ID_old")]
    [StringLength(38)]
    public string? CreatedRoleIdOld { get; set; }

    [Column("CREATED_ROLE_ID")]
    public int? CreatedRoleId { get; set; }

    [Column("MODIFIED_ROLE_ID_old")]
    [StringLength(38)]
    public string? ModifiedRoleIdOld { get; set; }

    [Column("MODIFIED_ROLE_ID")]
    public int? ModifiedRoleId { get; set; }

    [Column("DML_STATUS_FLAG_old")]
    [StringLength(38)]
    public string? DmlStatusFlagOld { get; set; }

    [Column("DML_STATUS_FLAG")]
    public int? DmlStatusFlag { get; set; }

    [Column("APPROVE_FLAG_old")]
    [StringLength(38)]
    public string? ApproveFlagOld { get; set; }

    [Column("APPROVE_FLAG")]
    public int? ApproveFlag { get; set; }

    [Column("APPROVE_BY_old")]
    [StringLength(38)]
    public string? ApproveByOld { get; set; }

    [Column("APPROVE_BY")]
    public int? ApproveBy { get; set; }

    [Column("INT_CREATED_BY_APP_AUTH_old")]
    [StringLength(38)]
    public string? IntCreatedByAppAuthOld { get; set; }

    [Column("INT_CREATED_BY_APP_AUTH")]
    public int? IntCreatedByAppAuth { get; set; }

    [Column("INT_ROPA_ID_old")]
    [StringLength(38)]
    public string? IntRopaIdOld { get; set; }

    [Column("INT_ROPA_ID")]
    public int? IntRopaId { get; set; }

    [Column("INT_PAYSCALE_ID_old")]
    [StringLength(38)]
    public string? IntPayscaleIdOld { get; set; }

    [Column("INT_PAYSCALE_ID")]
    public int? IntPayscaleId { get; set; }

    [Column("INT_GRADEPAY_ID_old")]
    [StringLength(38)]
    public string? IntGradepayIdOld { get; set; }

    [Column("INT_GRADEPAY_ID")]
    public int? IntGradepayId { get; set; }

    [Column("INT_PARENT_DEPARTMENT_old")]
    [StringLength(38)]
    public string? IntParentDepartmentOld { get; set; }

    [Column("INT_PARENT_DEPARTMENT")]
    public int? IntParentDepartment { get; set; }

    [Column("INT_LEVEL_ID_old")]
    [StringLength(38)]
    public string? IntLevelIdOld { get; set; }

    [Column("INT_LEVEL_ID")]
    public int? IntLevelId { get; set; }

    [Column("INT_PAYBAND_ID_old")]
    [StringLength(38)]
    public string? IntPaybandIdOld { get; set; }

    [Column("INT_PAYBAND_ID")]
    public int? IntPaybandId { get; set; }
}
