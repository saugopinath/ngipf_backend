using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_frontend.DAL.Entities;

[Table("hr_tm_srv_book_request_init", Schema = "ihrms_emp_master")]
public partial class HrTmSrvBookRequestInit
{
    [Column("request_status_flag")]
    [StringLength(1)]
    public string? RequestStatusFlag { get; set; }

    [Column("modifiable_flag")]
    [StringLength(1)]
    public string? ModifiableFlag { get; set; }

    [Column("remarks")]
    [StringLength(1000)]
    public string? Remarks { get; set; }

    [Column("start_time", TypeName = "timestamp without time zone")]
    public DateTime StartTime { get; set; }

    [Column("end_time", TypeName = "timestamp without time zone")]
    public DateTime? EndTime { get; set; }

    [Column("validated_flag")]
    [StringLength(1)]
    public string? ValidatedFlag { get; set; }

    [Column("created_timestamp")]
    public DateOnly CreatedTimestamp { get; set; }

    [Column("approved_rej_timestamp")]
    public DateOnly? ApprovedRejTimestamp { get; set; }

    [Column("request_type")]
    [StringLength(15)]
    public string? RequestType { get; set; }

    [Column("srv_book_request_init_old")]
    [StringLength(38)]
    public string? SrvBookRequestInitOld { get; set; }

    [Column("int_employee_id_old")]
    [StringLength(38)]
    public string? IntEmployeeIdOld { get; set; }

    [Column("int_employee_id")]
    public int? IntEmployeeId { get; set; }

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

    [Column("sequence_no_old")]
    [StringLength(38)]
    public string? SequenceNoOld { get; set; }

    [Column("sequence_no")]
    public int? SequenceNo { get; set; }

    [Column("created_user_id_old")]
    [StringLength(38)]
    public string? CreatedUserIdOld { get; set; }

    [Column("created_user_id")]
    public int? CreatedUserId { get; set; }

    [Column("created_role_id_old")]
    [StringLength(38)]
    public string? CreatedRoleIdOld { get; set; }

    [Column("created_role_id")]
    public int? CreatedRoleId { get; set; }

    [Column("prev_srv_book_request_init_old")]
    [StringLength(38)]
    public string? PrevSrvBookRequestInitOld { get; set; }

    [Column("prev_srv_book_request_init")]
    public int? PrevSrvBookRequestInit { get; set; }

    [Column("approved_rej_user_id_old")]
    [StringLength(38)]
    public string? ApprovedRejUserIdOld { get; set; }

    [Column("approved_rej_user_id")]
    public int? ApprovedRejUserId { get; set; }

    [Column("approved_rej_role_id_old")]
    [StringLength(38)]
    public string? ApprovedRejRoleIdOld { get; set; }

    [Column("approved_rej_role_id")]
    public int? ApprovedRejRoleId { get; set; }

    [Column("int_emp_cadre_at_time_old")]
    [StringLength(38)]
    public string? IntEmpCadreAtTimeOld { get; set; }

    [Column("int_emp_cadre_at_time")]
    public int? IntEmpCadreAtTime { get; set; }

    [Column("int_emp_p_dept_at_time_old")]
    [StringLength(38)]
    public string? IntEmpPDeptAtTimeOld { get; set; }

    [Column("int_emp_p_dept_at_time")]
    public int? IntEmpPDeptAtTime { get; set; }

    [Column("int_emp_srv_at_time_old")]
    [StringLength(38)]
    public string? IntEmpSrvAtTimeOld { get; set; }

    [Column("int_emp_srv_at_time")]
    public int? IntEmpSrvAtTime { get; set; }

    [Column("int_emp_group_at_time_old")]
    [StringLength(38)]
    public string? IntEmpGroupAtTimeOld { get; set; }

    [Column("int_emp_group_at_time")]
    public int? IntEmpGroupAtTime { get; set; }

    [Column("int_emp_post_at_time_old")]
    [StringLength(38)]
    public string? IntEmpPostAtTimeOld { get; set; }

    [Column("int_emp_post_at_time")]
    public int? IntEmpPostAtTime { get; set; }

    [Column("int_head_of_office_id_at_time_old")]
    [StringLength(38)]
    public string? IntHeadOfOfficeIdAtTimeOld { get; set; }

    [Column("int_head_of_office_id_at_time")]
    public int? IntHeadOfOfficeIdAtTime { get; set; }

    [Column("int_app_authority_id_at_time_old")]
    [StringLength(38)]
    public string? IntAppAuthorityIdAtTimeOld { get; set; }

    [Column("int_app_authority_id_at_time")]
    public int? IntAppAuthorityIdAtTime { get; set; }

    [Key]
    [Column("srv_book_request_init")]
    public int SrvBookRequestInit { get; set; }

    [InverseProperty("SrvBookRequestInitNavigation")]
    public virtual ICollection<HrMdAppntDtlsSrvBook> HrMdAppntDtlsSrvBooks { get; set; } = new List<HrMdAppntDtlsSrvBook>();

    [InverseProperty("SrvBookRequestInitNavigation")]
    public virtual ICollection<HrMdConfDtlsSrvBook> HrMdConfDtlsSrvBooks { get; set; } = new List<HrMdConfDtlsSrvBook>();

    [InverseProperty("SrvBookRequestInitNavigation")]
    public virtual ICollection<HrMdEmpPayAndAllowance> HrMdEmpPayAndAllowances { get; set; } = new List<HrMdEmpPayAndAllowance>();

    [InverseProperty("SrvBookRequestInitNavigation")]
    public virtual ICollection<HrMdEmpPayInformationWf> HrMdEmpPayInformationWfs { get; set; } = new List<HrMdEmpPayInformationWf>();

    [InverseProperty("SrvBookRequestInitNavigation")]
    public virtual ICollection<HrMdEmpPayInformation> HrMdEmpPayInformations { get; set; } = new List<HrMdEmpPayInformation>();
}
