using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_backend.DAL.Entities;

[Table("hr_md_appnt_dtls_srv_book", Schema = "ihrms_emp_master")]
[Index("SrvBookRequestInit", "BusinessPkType", "RowId", Name = "uk_hr_md_appnt_dtls_srv_book3", IsUnique = true)]
public partial class HrMdAppntDtlsSrvBook
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
    public DateOnly? Wef { get; set; }

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

    [Column("leave_schedule_flag")]
    [StringLength(1)]
    public string? LeaveScheduleFlag { get; set; }

    [Column("int_appnt_dtls_srv_book_old")]
    [StringLength(38)]
    public string? IntAppntDtlsSrvBookOld { get; set; }

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

    [Column("int_omi_reason_for_changes_old")]
    [StringLength(38)]
    public string? IntOmiReasonForChangesOld { get; set; }

    [Column("int_omi_reason_for_changes")]
    public int? IntOmiReasonForChanges { get; set; }

    [Column("int_pay_allow_dtls_srv_book_o_old")]
    [StringLength(38)]
    public string? IntPayAllowDtlsSrvBookOOld { get; set; }

    [Column("int_pay_allow_dtls_srv_book_o")]
    public int? IntPayAllowDtlsSrvBookO { get; set; }

    [Column("row_id_old")]
    [StringLength(38)]
    public string? RowIdOld { get; set; }

    [Column("row_id")]
    public int? RowId { get; set; }

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

    [Column("int_omi_employment_type_old")]
    [StringLength(38)]
    public string? IntOmiEmploymentTypeOld { get; set; }

    [Column("int_omi_employment_type")]
    public int? IntOmiEmploymentType { get; set; }

    [Column("prev_int_appnt_dtls_srv_book_old")]
    [StringLength(38)]
    public string? PrevIntAppntDtlsSrvBookOld { get; set; }

    [Column("prev_int_appnt_dtls_srv_book")]
    public int? PrevIntAppntDtlsSrvBook { get; set; }

    [Key]
    [Column("int_appnt_dtls_srv_book")]
    public int IntAppntDtlsSrvBook { get; set; }

    [InverseProperty("IntAppntDtlsSrvBookNavigation")]
    public virtual ICollection<HrMdConfDtlsSrvBook> HrMdConfDtlsSrvBooks { get; set; } = new List<HrMdConfDtlsSrvBook>();

    [InverseProperty("IntAppntDtlsSrvBookNavigation")]
    public virtual ICollection<HrMdEmpWorkingDtl> HrMdEmpWorkingDtls { get; set; } = new List<HrMdEmpWorkingDtl>();

    [ForeignKey("IntEmpWorkingDtlsId")]
    [InverseProperty("HrMdAppntDtlsSrvBooks")]
    public virtual HrMdEmpWorkingDtl? IntEmpWorkingDtls { get; set; }

    [ForeignKey("IntModeOfRecruitment")]
    [InverseProperty("HrMdAppntDtlsSrvBookIntModeOfRecruitmentNavigations")]
    public virtual HrMmGenOtherMaster? IntModeOfRecruitmentNavigation { get; set; }

    [ForeignKey("IntOmiEmploymentType")]
    [InverseProperty("HrMdAppntDtlsSrvBookIntOmiEmploymentTypeNavigations")]
    public virtual HrMmGenOtherMaster? IntOmiEmploymentTypeNavigation { get; set; }

    [ForeignKey("IntOmiSrvBookBlockId")]
    [InverseProperty("HrMdAppntDtlsSrvBookIntOmiSrvBookBlocks")]
    public virtual HrMmGenOtherMaster? IntOmiSrvBookBlock { get; set; }

    [ForeignKey("RequestId")]
    [InverseProperty("HrMdAppntDtlsSrvBooks")]
    public virtual HrMmGenWorkflowMaster? Request { get; set; }

    [ForeignKey("SrvBookRequestInit")]
    [InverseProperty("HrMdAppntDtlsSrvBooks")]
    public virtual HrTmSrvBookRequestInit? SrvBookRequestInitNavigation { get; set; }

    [ForeignKey("YearOfAllotment")]
    [InverseProperty("HrMdAppntDtlsSrvBookYearOfAllotmentNavigations")]
    public virtual HrMmGenOtherMaster? YearOfAllotmentNavigation { get; set; }
}
