using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_backend.DAL.Entities;

[Keyless]
[Table("hr_md_emp_srv_book_request", Schema = "ihrms_emp_master")]
public partial class HrMdEmpSrvBookRequest
{
    [Column("wef_date")]
    public DateOnly? WefDate { get; set; }

    [Column("active_flag")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("last_created_timestamp", TypeName = "timestamp without time zone")]
    public DateTime? LastCreatedTimestamp { get; set; }

    [Column("centralized_de_flag")]
    [StringLength(2)]
    public string? CentralizedDeFlag { get; set; }

    [Column("workflow_status_flag")]
    [StringLength(2)]
    public string? WorkflowStatusFlag { get; set; }

    [Column("send_accept_flag")]
    [StringLength(1)]
    public string? SendAcceptFlag { get; set; }

    [Column("internal_external_flag")]
    [StringLength(1)]
    public string? InternalExternalFlag { get; set; }

    [Column("app_hoo_type_from")]
    [StringLength(3)]
    public string? AppHooTypeFrom { get; set; }

    [Column("app_hoo_type_to")]
    [StringLength(3)]
    public string? AppHooTypeTo { get; set; }

    [Column("activity_time", TypeName = "timestamp without time zone")]
    public DateTime? ActivityTime { get; set; }

    [Column("int_dept_srch")]
    [StringLength(3)]
    public string? IntDeptSrch { get; set; }

    [Column("int_emp_srv_book_request_old")]
    [StringLength(38)]
    public string? IntEmpSrvBookRequestOld { get; set; }

    [Column("int_employee_id_old")]
    [StringLength(38)]
    public string? IntEmployeeIdOld { get; set; }

    [Column("int_employee_id")]
    public int? IntEmployeeId { get; set; }

    [Column("int_head_of_office_id_to_old")]
    [StringLength(38)]
    public string? IntHeadOfOfficeIdToOld { get; set; }

    [Column("int_head_of_office_id_to")]
    public int? IntHeadOfOfficeIdTo { get; set; }

    [Column("int_app_authority_id_to_old")]
    [StringLength(38)]
    public string? IntAppAuthorityIdToOld { get; set; }

    [Column("int_app_authority_id_to")]
    public int? IntAppAuthorityIdTo { get; set; }

    [Column("last_activity_done_by_user_old")]
    [StringLength(38)]
    public string? LastActivityDoneByUserOld { get; set; }

    [Column("last_activity_done_by_user")]
    public int? LastActivityDoneByUser { get; set; }

    [Column("request_id_old")]
    [StringLength(38)]
    public string? RequestIdOld { get; set; }

    [Column("request_id")]
    public int? RequestId { get; set; }

    [Column("dml_status_flag_old")]
    [StringLength(38)]
    public string? DmlStatusFlagOld { get; set; }

    [Column("dml_status_flag")]
    public int? DmlStatusFlag { get; set; }

    [Column("last_activity_done_by_role_old")]
    [StringLength(38)]
    public string? LastActivityDoneByRoleOld { get; set; }

    [Column("last_activity_done_by_role")]
    public int? LastActivityDoneByRole { get; set; }

    [Column("int_declaration_id_old")]
    [StringLength(38)]
    public string? IntDeclarationIdOld { get; set; }

    [Column("int_declaration_id")]
    public int? IntDeclarationId { get; set; }

    [Column("log_sequence_old")]
    [StringLength(38)]
    public string? LogSequenceOld { get; set; }

    [Column("log_sequence")]
    public int? LogSequence { get; set; }

    [Column("prev_int_emp_srv_book_request_old")]
    [StringLength(38)]
    public string? PrevIntEmpSrvBookRequestOld { get; set; }

    [Column("prev_int_emp_srv_book_request")]
    public int? PrevIntEmpSrvBookRequest { get; set; }

    [Column("int_app_authority_id_from_old")]
    [StringLength(38)]
    public string? IntAppAuthorityIdFromOld { get; set; }

    [Column("int_app_authority_id_from")]
    public int? IntAppAuthorityIdFrom { get; set; }

    [Column("int_head_of_office_id_from_old")]
    [StringLength(38)]
    public string? IntHeadOfOfficeIdFromOld { get; set; }

    [Column("int_head_of_office_id_from")]
    public int? IntHeadOfOfficeIdFrom { get; set; }

    [Column("activity_done_by_user_old")]
    [StringLength(38)]
    public string? ActivityDoneByUserOld { get; set; }

    [Column("activity_done_by_user")]
    public int? ActivityDoneByUser { get; set; }

    [Column("activity_done_by_role_old")]
    [StringLength(38)]
    public string? ActivityDoneByRoleOld { get; set; }

    [Column("activity_done_by_role")]
    public int? ActivityDoneByRole { get; set; }

    [Column("int_level_id_srch_old")]
    [StringLength(38)]
    public string? IntLevelIdSrchOld { get; set; }

    [Column("int_level_id_srch")]
    public int? IntLevelIdSrch { get; set; }

    [Column("int_emp_post_id_at_time_old")]
    [StringLength(38)]
    public string? IntEmpPostIdAtTimeOld { get; set; }

    [Column("int_emp_post_id_at_time")]
    public int? IntEmpPostIdAtTime { get; set; }

    [Column("int_emp_desig_id_at_time_old")]
    [StringLength(38)]
    public string? IntEmpDesigIdAtTimeOld { get; set; }

    [Column("int_emp_desig_id_at_time")]
    public int? IntEmpDesigIdAtTime { get; set; }

    [Column("int_emp_srv_book_request")]
    public int IntEmpSrvBookRequest { get; set; }
}
