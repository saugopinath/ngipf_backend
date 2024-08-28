using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NGIPF_BE.DAL.Entities;

[Keyless]
[Table("hr_md_gen_ndo_emp_map_cur", Schema = "ihrms_master")]
public partial class HrMdGenNdoEmpMapCur
{
    [Column("ACTIVE_FLAG")]
    [StringLength(2)]
    public string? ActiveFlag { get; set; }

    [Column("WEF")]
    public DateOnly? Wef { get; set; }

    [Column("CREATED_TIMESTAMP")]
    public DateOnly? CreatedTimestamp { get; set; }

    [Column("MODIFIED_TIMESTAMP")]
    public DateOnly? ModifiedTimestamp { get; set; }

    [Column("APPROVE_FLAG")]
    [StringLength(1)]
    public string? ApproveFlag { get; set; }

    [Column("APPROVE_DATE")]
    public DateOnly? ApproveDate { get; set; }

    [Column("INT_NDO_EMP_MAP_ID_CUR_old")]
    [StringLength(38)]
    public string? IntNdoEmpMapIdCurOld { get; set; }

    [Column("INT_NDO_EMP_MAP_ID_CUR")]
    public int? IntNdoEmpMapIdCur { get; set; }

    [Column("INT_NDO_EMP_MAP_ID_WF_old")]
    [StringLength(38)]
    public string? IntNdoEmpMapIdWfOld { get; set; }

    [Column("INT_NDO_EMP_MAP_ID_WF")]
    public int? IntNdoEmpMapIdWf { get; set; }

    [Column("INT_NODAL_OFFICER_ID_old")]
    [StringLength(38)]
    public string? IntNodalOfficerIdOld { get; set; }

    [Column("INT_NODAL_OFFICER_ID")]
    public int? IntNodalOfficerId { get; set; }

    [Column("INT_EMPLOYEE_ID_old")]
    [StringLength(38)]
    public string? IntEmployeeIdOld { get; set; }

    [Column("INT_EMPLOYEE_ID")]
    public int? IntEmployeeId { get; set; }

    [Column("TAG_FLAG_old")]
    [StringLength(38)]
    public string? TagFlagOld { get; set; }

    [Column("TAG_FLAG")]
    public int? TagFlag { get; set; }

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

    [Column("APPROVE_USER_ID_old")]
    [StringLength(38)]
    public string? ApproveUserIdOld { get; set; }

    [Column("APPROVE_USER_ID")]
    public int? ApproveUserId { get; set; }

    [Column("INT_APPROVE_BY_NDO_old")]
    [StringLength(38)]
    public string? IntApproveByNdoOld { get; set; }

    [Column("INT_APPROVE_BY_NDO")]
    public int? IntApproveByNdo { get; set; }

    [Column("INT_MAP_BY_NDO_old")]
    [StringLength(38)]
    public string? IntMapByNdoOld { get; set; }

    [Column("INT_MAP_BY_NDO")]
    public int? IntMapByNdo { get; set; }

    [Column("INT_NDO_COMB_ID_old")]
    [StringLength(38)]
    public string? IntNdoCombIdOld { get; set; }

    [Column("INT_NDO_COMB_ID")]
    public int? IntNdoCombId { get; set; }
}
