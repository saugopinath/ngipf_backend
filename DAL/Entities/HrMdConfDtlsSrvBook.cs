using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_backend.DAL.Entities;

[Table("hr_md_conf_dtls_srv_book", Schema = "ihrms_emp_master")]
public partial class HrMdConfDtlsSrvBook
{
    [Column("employee_no")]
    [StringLength(50)]
    public string? EmployeeNo { get; set; }

    [Column("business_pk_type")]
    [StringLength(5)]
    public string? BusinessPkType { get; set; }

    [Column("parent_flag")]
    [StringLength(1)]
    public string? ParentFlag { get; set; }

    [Column("wef")]
    public DateOnly Wef { get; set; }

    [Column("active_flag")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("order_no")]
    [StringLength(100)]
    public string? OrderNo { get; set; }

    [Column("order_date")]
    public DateOnly? OrderDate { get; set; }

    [Column("modifiable_flag")]
    [StringLength(1)]
    public string? ModifiableFlag { get; set; }

    [Column("service_book_flag")]
    [StringLength(1)]
    public string? ServiceBookFlag { get; set; }

    [Column("date_of_joining")]
    public DateOnly? DateOfJoining { get; set; }

    [Column("inserted_flag")]
    [StringLength(1)]
    public string? InsertedFlag { get; set; }

    [Column("remarks")]
    [StringLength(500)]
    public string? Remarks { get; set; }

    [Column("created_timestamp")]
    public DateOnly CreatedTimestamp { get; set; }

    [Column("modified_timestamp")]
    public DateOnly ModifiedTimestamp { get; set; }

    [Column("int_conf_dtls_srv_book_old")]
    [StringLength(38)]
    public string? IntConfDtlsSrvBookOld { get; set; }

    [Column("srv_book_request_init_old")]
    [StringLength(38)]
    public string? SrvBookRequestInitOld { get; set; }

    [Column("srv_book_request_init")]
    public int? SrvBookRequestInit { get; set; }

    [Column("int_employee_id_old")]
    [StringLength(38)]
    public string? IntEmployeeIdOld { get; set; }

    [Column("int_employee_id")]
    public int? IntEmployeeId { get; set; }

    [Column("int_emp_working_dtls_id_old")]
    [StringLength(38)]
    public string? IntEmpWorkingDtlsIdOld { get; set; }

    [Column("int_emp_working_dtls_id")]
    public int? IntEmpWorkingDtlsId { get; set; }

    [Column("int_business_pk_old")]
    [StringLength(38)]
    public string? IntBusinessPkOld { get; set; }

    [Column("int_business_pk")]
    public int? IntBusinessPk { get; set; }

    [Column("request_id_old")]
    [StringLength(38)]
    public string? RequestIdOld { get; set; }

    [Column("request_id")]
    public long? RequestId { get; set; }

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

    [Column("dml_status_flag_old")]
    [StringLength(38)]
    public string? DmlStatusFlagOld { get; set; }

    [Column("dml_status_flag")]
    public int? DmlStatusFlag { get; set; }

    [Column("int_omi_srv_book_block_id_old")]
    [StringLength(38)]
    public string? IntOmiSrvBookBlockIdOld { get; set; }

    [Column("int_omi_srv_book_block_id")]
    public int? IntOmiSrvBookBlockId { get; set; }

    [Column("int_appnt_dtls_srv_book_old")]
    [StringLength(38)]
    public string? IntAppntDtlsSrvBookOld { get; set; }

    [Column("int_appnt_dtls_srv_book")]
    public int? IntAppntDtlsSrvBook { get; set; }

    [Column("int_omi_reason_for_changes_old")]
    [StringLength(38)]
    public string? IntOmiReasonForChangesOld { get; set; }

    [Column("int_omi_reason_for_changes")]
    public int? IntOmiReasonForChanges { get; set; }

    [Column("created_user_id_old")]
    [StringLength(38)]
    public string? CreatedUserIdOld { get; set; }

    [Column("created_user_id")]
    public int? CreatedUserId { get; set; }

    [Column("modified_user_id_old")]
    [StringLength(38)]
    public string? ModifiedUserIdOld { get; set; }

    [Column("modified_user_id")]
    public int? ModifiedUserId { get; set; }

    [Column("prev_int_conf_dtls_srv_book_old")]
    [StringLength(38)]
    public string? PrevIntConfDtlsSrvBookOld { get; set; }

    [Column("prev_int_conf_dtls_srv_book")]
    public int? PrevIntConfDtlsSrvBook { get; set; }

    [Key]
    [Column("int_conf_dtls_srv_book")]
    public int IntConfDtlsSrvBook { get; set; }

    [ForeignKey("IntAppntDtlsSrvBook")]
    [InverseProperty("HrMdConfDtlsSrvBooks")]
    public virtual HrMdAppntDtlsSrvBook? IntAppntDtlsSrvBookNavigation { get; set; }

    [ForeignKey("IntEmpWorkingDtlsId")]
    [InverseProperty("HrMdConfDtlsSrvBooks")]
    public virtual HrMdEmpWorkingDtl? IntEmpWorkingDtls { get; set; }

    [ForeignKey("IntEmployeeId")]
    [InverseProperty("HrMdConfDtlsSrvBooks")]
    public virtual HrMmEmpBasicDtl? IntEmployee { get; set; }

    [ForeignKey("RequestId")]
    [InverseProperty("HrMdConfDtlsSrvBooks")]
    public virtual HrMmGenWorkflowMaster? Request { get; set; }

    [ForeignKey("SrvBookRequestInit")]
    [InverseProperty("HrMdConfDtlsSrvBooks")]
    public virtual HrTmSrvBookRequestInit? SrvBookRequestInitNavigation { get; set; }
}
