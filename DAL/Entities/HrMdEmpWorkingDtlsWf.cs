﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_backend.DAL.Entities;

[Keyless]
[Table("hr_md_emp_working_dtls_wf", Schema = "ihrms_emp_master")]
public partial class HrMdEmpWorkingDtlsWf
{
    [Column("parent_flag")]
    [StringLength(1)]
    public string? ParentFlag { get; set; }

    [Column("wef")]
    public DateOnly? Wef { get; set; }

    [Column("business_pk_type")]
    [StringLength(5)]
    public string? BusinessPkType { get; set; }

    [Column("active_flag")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("workflow_status_flag")]
    [StringLength(2)]
    public string? WorkflowStatusFlag { get; set; }

    [Column("last_updated_on", TypeName = "timestamp without time zone")]
    public DateTime? LastUpdatedOn { get; set; }

    [Column("go_order_number")]
    [StringLength(500)]
    public string? GoOrderNumber { get; set; }

    [Column("go_order_date")]
    public DateOnly? GoOrderDate { get; set; }

    [Column("reason")]
    [StringLength(300)]
    public string? Reason { get; set; }

    [Column("joining_order_no")]
    [StringLength(500)]
    public string? JoiningOrderNo { get; set; }

    [Column("joining_order_date")]
    public DateOnly? JoiningOrderDate { get; set; }

    [Column("substantive_additional_flag")]
    [StringLength(2)]
    public string? SubstantiveAdditionalFlag { get; set; }

    [Column("date_of_release")]
    public DateOnly? DateOfRelease { get; set; }

    [Column("release_order_no")]
    [StringLength(500)]
    public string? ReleaseOrderNo { get; set; }

    [Column("release_order_date")]
    public DateOnly? ReleaseOrderDate { get; set; }

    [Column("modifiable_flag")]
    [StringLength(1)]
    public string? ModifiableFlag { get; set; }

    [Column("service_book_flag")]
    [StringLength(1)]
    public string? ServiceBookFlag { get; set; }

    [Column("out_side_hrms_master")]
    [StringLength(1)]
    public string? OutSideHrmsMaster { get; set; }

    [Column("head_of_office_description")]
    [StringLength(500)]
    public string? HeadOfOfficeDescription { get; set; }

    [Column("remarks")]
    [StringLength(1000)]
    public string? Remarks { get; set; }

    [Column("inserted_flag")]
    [StringLength(1)]
    public string? InsertedFlag { get; set; }

    [Column("convertion_of_post_flag")]
    [StringLength(1)]
    public string? ConvertionOfPostFlag { get; set; }

    [Column("nature_of_release_order_no")]
    [StringLength(100)]
    public string? NatureOfReleaseOrderNo { get; set; }

    [Column("nature_of_release_order_date")]
    public DateOnly? NatureOfReleaseOrderDate { get; set; }

    [Column("int_emp_working_dtls_id_wf_old")]
    [StringLength(38)]
    public string? IntEmpWorkingDtlsIdWfOld { get; set; }

    [Column("int_emp_working_dtls_id_old")]
    [StringLength(38)]
    public string? IntEmpWorkingDtlsIdOld { get; set; }

    [Column("int_emp_working_dtls_id")]
    public int? IntEmpWorkingDtlsId { get; set; }

    [Column("int_employee_id_old")]
    [StringLength(38)]
    public string? IntEmployeeIdOld { get; set; }

    [Column("int_employee_id")]
    public int? IntEmployeeId { get; set; }

    [Column("int_business_pk_old")]
    [StringLength(38)]
    public string? IntBusinessPkOld { get; set; }

    [Column("int_business_pk")]
    public int? IntBusinessPk { get; set; }

    [Column("last_updated_by_old")]
    [StringLength(38)]
    public string? LastUpdatedByOld { get; set; }

    [Column("last_updated_by")]
    public int? LastUpdatedBy { get; set; }

    [Column("last_updated_by_role_old")]
    [StringLength(38)]
    public string? LastUpdatedByRoleOld { get; set; }

    [Column("last_updated_by_role")]
    public int? LastUpdatedByRole { get; set; }

    [Column("dml_status_flag_old")]
    [StringLength(38)]
    public string? DmlStatusFlagOld { get; set; }

    [Column("dml_status_flag")]
    public int? DmlStatusFlag { get; set; }

    [Column("request_id_old")]
    [StringLength(38)]
    public string? RequestIdOld { get; set; }

    [Column("request_id")]
    public int? RequestId { get; set; }

    [Column("fore_or_after_noon_old")]
    [StringLength(38)]
    public string? ForeOrAfterNoonOld { get; set; }

    [Column("fore_or_after_noon")]
    public int? ForeOrAfterNoon { get; set; }

    [Column("int_omi_reason_for_changes_old")]
    [StringLength(38)]
    public string? IntOmiReasonForChangesOld { get; set; }

    [Column("int_omi_reason_for_changes")]
    public int? IntOmiReasonForChanges { get; set; }

    [Column("int_head_of_office_id_old")]
    [StringLength(38)]
    public string? IntHeadOfOfficeIdOld { get; set; }

    [Column("int_head_of_office_id")]
    public int? IntHeadOfOfficeId { get; set; }

    [Column("release_fore_aft_noon_old")]
    [StringLength(38)]
    public string? ReleaseForeAftNoonOld { get; set; }

    [Column("release_fore_aft_noon")]
    public int? ReleaseForeAftNoon { get; set; }

    [Column("srv_book_request_init_old")]
    [StringLength(38)]
    public string? SrvBookRequestInitOld { get; set; }

    [Column("srv_book_request_init")]
    public int? SrvBookRequestInit { get; set; }

    [Column("int_appnt_dtls_srv_book_old")]
    [StringLength(38)]
    public string? IntAppntDtlsSrvBookOld { get; set; }

    [Column("int_appnt_dtls_srv_book")]
    public int? IntAppntDtlsSrvBook { get; set; }

    [Column("int_omi_srv_book_block_id_old")]
    [StringLength(38)]
    public string? IntOmiSrvBookBlockIdOld { get; set; }

    [Column("int_omi_srv_book_block_id")]
    public int? IntOmiSrvBookBlockId { get; set; }

    [Column("int_level_id_old")]
    [StringLength(38)]
    public string? IntLevelIdOld { get; set; }

    [Column("int_level_id")]
    public int? IntLevelId { get; set; }

    [Column("int_dept_id_old")]
    [StringLength(38)]
    public string? IntDeptIdOld { get; set; }

    [Column("int_dept_id")]
    public int? IntDeptId { get; set; }

    [Column("int_mode_of_recruitment_old")]
    [StringLength(38)]
    public string? IntModeOfRecruitmentOld { get; set; }

    [Column("int_mode_of_recruitment")]
    public int? IntModeOfRecruitment { get; set; }

    [Column("year_of_allotment_old")]
    [StringLength(38)]
    public string? YearOfAllotmentOld { get; set; }

    [Column("year_of_allotment")]
    public int? YearOfAllotment { get; set; }

    [Column("row_id_old")]
    [StringLength(38)]
    public string? RowIdOld { get; set; }

    [Column("row_id")]
    public int? RowId { get; set; }

    [Column("int_conf_dtls_srv_book_old")]
    [StringLength(38)]
    public string? IntConfDtlsSrvBookOld { get; set; }

    [Column("int_conf_dtls_srv_book")]
    public int? IntConfDtlsSrvBook { get; set; }

    [Column("int_post_dtls_srv_book_old")]
    [StringLength(38)]
    public string? IntPostDtlsSrvBookOld { get; set; }

    [Column("int_post_dtls_srv_book")]
    public int? IntPostDtlsSrvBook { get; set; }

    [Column("int_omi_employment_type_old")]
    [StringLength(38)]
    public string? IntOmiEmploymentTypeOld { get; set; }

    [Column("int_omi_employment_type")]
    public int? IntOmiEmploymentType { get; set; }

    [Column("int_omi_nature_of_release_old")]
    [StringLength(38)]
    public string? IntOmiNatureOfReleaseOld { get; set; }

    [Column("int_omi_nature_of_release")]
    public int? IntOmiNatureOfRelease { get; set; }

    [Column("int_post_dtls_srv_book_convert_old")]
    [StringLength(38)]
    public string? IntPostDtlsSrvBookConvertOld { get; set; }

    [Column("int_post_dtls_srv_book_convert")]
    public int? IntPostDtlsSrvBookConvert { get; set; }

    [Column("int_emp_working_dtls_id_wf")]
    public int IntEmpWorkingDtlsIdWf { get; set; }
}
