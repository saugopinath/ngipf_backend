using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_frontend.DAL.Entities;

[Table("hr_tm_payfix", Schema = "ihrms_emp_master")]
public partial class HrTmPayfix
{
    [Column("request_id")]
    public long RequestId { get; set; }

    [Column("fix_from_date", TypeName = "timestamp(0) without time zone")]
    public DateTime? FixFromDate { get; set; }

    [Column("fix_to_date", TypeName = "timestamp(0) without time zone")]
    public DateTime? FixToDate { get; set; }

    [Column("workflow_status_flag")]
    [StringLength(2)]
    public string WorkflowStatusFlag { get; set; } = null!;

    [Column("end_of_service", TypeName = "timestamp(0) without time zone")]
    public DateTime? EndOfService { get; set; }

    [Column("band_pay")]
    public double? BandPay { get; set; }

    [Column("min_entry_point")]
    public double? MinEntryPoint { get; set; }

    [Column("basic")]
    public double Basic { get; set; }

    [Column("dml_status_flag")]
    public short DmlStatusFlag { get; set; }

    [Column("created_user_id")]
    public int CreatedUserId { get; set; }

    [Column("created_timestamp", TypeName = "timestamp(0) without time zone")]
    public DateTime CreatedTimestamp { get; set; }

    [Column("modified_user_id")]
    public int ModifiedUserId { get; set; }

    [Column("modified_timestamp", TypeName = "timestamp(0) without time zone")]
    public DateTime ModifiedTimestamp { get; set; }

    [Column("approve_by_user_id")]
    public int? ApproveByUserId { get; set; }

    [Column("approve_by_role_id")]
    public int? ApproveByRoleId { get; set; }

    [Column("bulk_app_flag")]
    [StringLength(1)]
    public string? BulkAppFlag { get; set; }

    [Column("order_gen_flag")]
    [StringLength(1)]
    public string? OrderGenFlag { get; set; }

    [Column("emp_info_update_flag")]
    [StringLength(1)]
    public string? EmpInfoUpdateFlag { get; set; }

    [Column("cancel_by_user_id")]
    public int? CancelByUserId { get; set; }

    [Column("cancel_by_role_id")]
    public int? CancelByRoleId { get; set; }

    [Column("workflow_check_flag")]
    [StringLength(1)]
    public string? WorkflowCheckFlag { get; set; }

    [Column("int_tm_payfix_id_old")]
    [StringLength(38)]
    public string? IntTmPayfixIdOld { get; set; }

    [Column("int_employee_id_old")]
    [StringLength(38)]
    public string? IntEmployeeIdOld { get; set; }

    [Column("int_employee_id")]
    public int? IntEmployeeId { get; set; }

    [Column("int_srv_id_old")]
    [StringLength(38)]
    public string? IntSrvIdOld { get; set; }

    [Column("int_srv_id")]
    public int? IntSrvId { get; set; }

    [Column("int_cadre_id_old")]
    [StringLength(38)]
    public string? IntCadreIdOld { get; set; }

    [Column("int_cadre_id")]
    public int? IntCadreId { get; set; }

    [Column("int_employee_type_id_old")]
    [StringLength(38)]
    public string? IntEmployeeTypeIdOld { get; set; }

    [Column("int_employee_type_id")]
    public int? IntEmployeeTypeId { get; set; }

    [Column("int_employment_type_id_old")]
    [StringLength(38)]
    public string? IntEmploymentTypeIdOld { get; set; }

    [Column("int_employment_type_id")]
    public int? IntEmploymentTypeId { get; set; }

    [Column("int_parent_dept_id_old")]
    [StringLength(38)]
    public string? IntParentDeptIdOld { get; set; }

    [Column("int_parent_dept_id")]
    public int? IntParentDeptId { get; set; }

    [Column("int_present_dept_id_old")]
    [StringLength(38)]
    public string? IntPresentDeptIdOld { get; set; }

    [Column("int_present_dept_id")]
    public int? IntPresentDeptId { get; set; }

    [Column("int_post_id_old")]
    [StringLength(38)]
    public string? IntPostIdOld { get; set; }

    [Column("int_post_id")]
    public int? IntPostId { get; set; }

    [Column("int_group_id_old")]
    [StringLength(38)]
    public string? IntGroupIdOld { get; set; }

    [Column("int_group_id")]
    public int? IntGroupId { get; set; }

    [Column("int_designation_id_old")]
    [StringLength(38)]
    public string? IntDesignationIdOld { get; set; }

    [Column("int_designation_id")]
    public int? IntDesignationId { get; set; }

    [Column("int_ddo_id_old")]
    [StringLength(38)]
    public string? IntDdoIdOld { get; set; }

    [Column("int_ddo_id")]
    public int? IntDdoId { get; set; }

    [Column("int_rev_pay_allowance_id_old")]
    [StringLength(38)]
    public string? IntRevPayAllowanceIdOld { get; set; }

    [Column("int_rev_pay_allowance_id")]
    public int? IntRevPayAllowanceId { get; set; }

    [Column("int_pay_scale_id_old")]
    [StringLength(38)]
    public string? IntPayScaleIdOld { get; set; }

    [Column("int_pay_scale_id")]
    public int? IntPayScaleId { get; set; }

    [Column("int_payb_id_old")]
    [StringLength(38)]
    public string? IntPaybIdOld { get; set; }

    [Column("int_payb_id")]
    public int? IntPaybId { get; set; }

    [Column("int_emp_pay_and_allowance_id_old")]
    [StringLength(38)]
    public string? IntEmpPayAndAllowanceIdOld { get; set; }

    [Column("int_emp_pay_and_allowance_id")]
    public int? IntEmpPayAndAllowanceId { get; set; }

    [Column("int_grade_pay_id_old")]
    [StringLength(38)]
    public string? IntGradePayIdOld { get; set; }

    [Column("int_grade_pay_id")]
    public int? IntGradePayId { get; set; }

    [Key]
    [Column("int_tm_payfix_id")]
    public int IntTmPayfixId { get; set; }

    [InverseProperty("IntTmPayfix")]
    public virtual ICollection<HrMdEmpPayAndAllowance> HrMdEmpPayAndAllowances { get; set; } = new List<HrMdEmpPayAndAllowance>();
}
