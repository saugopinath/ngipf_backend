using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_frontend.DAL.Entities;

[Keyless]
[Table("hr_mm_gen_emp_app_auth_map", Schema = "ihrms_master")]
public partial class HrMmGenEmpAppAuthMap
{
    [Column("WEF")]
    public DateOnly? Wef { get; set; }

    [Column("ACTIVE_FLAG")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("CREATED_TIMESTAMP")]
    public DateOnly? CreatedTimestamp { get; set; }

    [Column("MODIFIED_TIMESTAMP")]
    public DateOnly? ModifiedTimestamp { get; set; }

    [Column("WORK_FLOW_STATUS_FLAG")]
    [StringLength(2)]
    public string? WorkFlowStatusFlag { get; set; }

    [Column("EMP_CREATED_BY_APP_AUTH")]
    [StringLength(3)]
    public string? EmpCreatedByAppAuth { get; set; }

    [Column("UNTAG_FLAG")]
    [StringLength(1)]
    public string? UntagFlag { get; set; }

    [Column("INT_MM_GEN_EMP_APP_AUTH_MAP_old")]
    [StringLength(38)]
    public string? IntMmGenEmpAppAuthMapOld { get; set; }

    [Column("INT_MM_GEN_EMP_APP_AUTH_MAP")]
    public int? IntMmGenEmpAppAuthMap { get; set; }

    [Column("INT_EMPLOYEE_ID_old")]
    [StringLength(38)]
    public string? IntEmployeeIdOld { get; set; }

    [Column("INT_EMPLOYEE_ID")]
    public int? IntEmployeeId { get; set; }

    [Column("INT_APP_AUTHORITY_ID_old")]
    [StringLength(38)]
    public string? IntAppAuthorityIdOld { get; set; }

    [Column("INT_APP_AUTHORITY_ID")]
    public int? IntAppAuthorityId { get; set; }

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

    [Column("REQUEST_ID_old")]
    [StringLength(38)]
    public string? RequestIdOld { get; set; }

    [Column("REQUEST_ID")]
    public int? RequestId { get; set; }

    [Column("INT_TM_SANCTION_POST_old")]
    [StringLength(38)]
    public string? IntTmSanctionPostOld { get; set; }

    [Column("INT_TM_SANCTION_POST")]
    public int? IntTmSanctionPost { get; set; }

    [Column("EMP_CREATED_REQUEST_ID_old")]
    [StringLength(38)]
    public string? EmpCreatedRequestIdOld { get; set; }

    [Column("EMP_CREATED_REQUEST_ID")]
    public int? EmpCreatedRequestId { get; set; }

    [Column("INT_POST_CODE_old")]
    [StringLength(38)]
    public string? IntPostCodeOld { get; set; }

    [Column("INT_POST_CODE")]
    public int? IntPostCode { get; set; }

    [Column("INT_EMP_TERMINATION_REVOKE_old")]
    [StringLength(38)]
    public string? IntEmpTerminationRevokeOld { get; set; }

    [Column("INT_EMP_TERMINATION_REVOKE")]
    public int? IntEmpTerminationRevoke { get; set; }
}
