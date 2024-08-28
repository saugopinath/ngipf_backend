using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NGIPF_BE.DAL.Entities;

[Keyless]
[Table("hr_td_hoo_sec_emp_map", Schema = "ihrms_master")]
public partial class HrTdHooSecEmpMap
{
    [Column("ACTIVE_FLAG")]
    [StringLength(2)]
    public string? ActiveFlag { get; set; }

    [Column("CREATED_TIMESTAMP")]
    public DateOnly CreatedTimestamp { get; set; }

    [Column("MODIFYED_TIMESTAMP")]
    public DateOnly ModifyedTimestamp { get; set; }

    [Column("TAG_UNTAG_FLAG")]
    [StringLength(3)]
    public string? TagUntagFlag { get; set; }

    [Column("INT_HR_TD_HOO_SEC_EMP_MAP_old")]
    [StringLength(38)]
    public string? IntHrTdHooSecEmpMapOld { get; set; }

    [Column("INT_HR_TD_HOO_SEC_EMP_MAP")]
    public int? IntHrTdHooSecEmpMap { get; set; }

    [Column("INT_HR_TM_HOO_SEC_EMP_MAP_old")]
    [StringLength(38)]
    public string? IntHrTmHooSecEmpMapOld { get; set; }

    [Column("INT_HR_TM_HOO_SEC_EMP_MAP")]
    public int? IntHrTmHooSecEmpMap { get; set; }

    [Column("INT_EMPLOYEE_ID_old")]
    [StringLength(38)]
    public string? IntEmployeeIdOld { get; set; }

    [Column("INT_EMPLOYEE_ID")]
    public int? IntEmployeeId { get; set; }

    [Column("INT_SECTION_ID_old")]
    [StringLength(38)]
    public string? IntSectionIdOld { get; set; }

    [Column("INT_SECTION_ID")]
    public int? IntSectionId { get; set; }

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

    [Column("CREATED_ROLE_ID_old")]
    [StringLength(38)]
    public string? CreatedRoleIdOld { get; set; }

    [Column("CREATED_ROLE_ID")]
    public int? CreatedRoleId { get; set; }

    [Column("MODIFYED_USER_ID_old")]
    [StringLength(38)]
    public string? ModifyedUserIdOld { get; set; }

    [Column("MODIFYED_USER_ID")]
    public int? ModifyedUserId { get; set; }

    [Column("MODIFYED_ROLE_ID_old")]
    [StringLength(38)]
    public string? ModifyedRoleIdOld { get; set; }

    [Column("MODIFYED_ROLE_ID")]
    public int? ModifyedRoleId { get; set; }

    [Column("INT_TM_SANCTION_POST_old")]
    [StringLength(38)]
    public string? IntTmSanctionPostOld { get; set; }

    [Column("INT_TM_SANCTION_POST")]
    public int? IntTmSanctionPost { get; set; }

    [Column("UNTAG_REQUEST_ID_old")]
    [StringLength(38)]
    public string? UntagRequestIdOld { get; set; }

    [Column("UNTAG_REQUEST_ID")]
    public int? UntagRequestId { get; set; }

    [Column("INT_POSTCODE_ID_old")]
    [StringLength(38)]
    public string? IntPostcodeIdOld { get; set; }

    [Column("INT_POSTCODE_ID")]
    public int? IntPostcodeId { get; set; }
}
