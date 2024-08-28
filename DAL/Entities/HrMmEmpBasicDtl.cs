using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NGIPF_BE.DAL.Entities;

[Table("hr_mm_emp_basic_dtls", Schema = "ihrms_emp_master")]
[Index("IntEmployeeIdOld", Name = "hr_mm_emp_basic_dtls_int_employee_id_old_key", IsUnique = true)]
[Index("EmployeeNo", Name = "uk_tm_sr_emp_basic_dtls", IsUnique = true)]
public partial class HrMmEmpBasicDtl
{
    [Column("employee_id")]
    [StringLength(20)]
    public string? EmployeeId { get; set; }

    [Column("employee_no")]
    [StringLength(50)]
    public string? EmployeeNo { get; set; }

    [Column("emp_first_name")]
    [StringLength(100)]
    public string? EmpFirstName { get; set; }

    [Column("emp_mid_name")]
    [StringLength(30)]
    public string? EmpMidName { get; set; }

    [Column("emp_last_name")]
    [StringLength(30)]
    public string? EmpLastName { get; set; }

    [Column("date_of_birth")]
    public DateOnly DateOfBirth { get; set; }

    [Column("caste_certi_no")]
    [StringLength(50)]
    public string? CasteCertiNo { get; set; }

    [Column("caste_certi_auth")]
    [StringLength(100)]
    public string? CasteCertiAuth { get; set; }

    [Column("identification_mark")]
    [StringLength(350)]
    public string? IdentificationMark { get; set; }

    [Column("date_of_joining")]
    public DateOnly DateOfJoining { get; set; }

    [Column("phyc_certi_no")]
    [StringLength(50)]
    public string? PhycCertiNo { get; set; }

    [Column("phyc_certi_auth")]
    [StringLength(50)]
    public string? PhycCertiAuth { get; set; }

    [Column("prev_int_employee_id")]
    [StringLength(50)]
    public string? PrevIntEmployeeId { get; set; }

    [Column("hra_drawn_by_self")]
    [StringLength(2)]
    public string? HraDrawnBySelf { get; set; }

    [Column("entitled_for_pension")]
    [StringLength(3)]
    public string? EntitledForPension { get; set; }

    [Column("entitled_for_npa")]
    [StringLength(2)]
    public string? EntitledForNpa { get; set; }

    [Column("remarks")]
    [StringLength(100)]
    public string? Remarks { get; set; }

    [Column("processing_status")]
    [StringLength(5)]
    public string? ProcessingStatus { get; set; }

    [Column("cadre_yes_no")]
    [StringLength(2)]
    public string? CadreYesNo { get; set; }

    [Column("legacy_flag")]
    [StringLength(1)]
    public string? LegacyFlag { get; set; }

    [Column("date_of_retirement")]
    public DateOnly? DateOfRetirement { get; set; }

    [Column("gpf_series")]
    [StringLength(30)]
    public string? GpfSeries { get; set; }

    [Column("gpf_series1")]
    [StringLength(12)]
    public string? GpfSeries1 { get; set; }

    [Column("gpf_account_no")]
    [StringLength(20)]
    public string? GpfAccountNo { get; set; }

    [Column("pran_no")]
    [StringLength(12)]
    public string? PranNo { get; set; }

    [Column("service_pensionable")]
    [StringLength(1)]
    public string? ServicePensionable { get; set; }

    [Column("active_flag")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("active_inactive_date")]
    public DateOnly? ActiveInactiveDate { get; set; }

    [Column("active_inactive_reason")]
    [StringLength(500)]
    public string? ActiveInactiveReason { get; set; }

    [Column("service_end_gov_order_no")]
    [StringLength(100)]
    public string? ServiceEndGovOrderNo { get; set; }

    [Column("service_end_gov_order_date")]
    public DateOnly? ServiceEndGovOrderDate { get; set; }

    [Column("date_of_retirement_bef_extn")]
    public DateOnly? DateOfRetirementBefExtn { get; set; }

    [Column("prev_emp_name")]
    [StringLength(100)]
    public string? PrevEmpName { get; set; }

    [Column("emp_source")]
    [StringLength(10)]
    public string? EmpSource { get; set; }

    [Column("emp_salary_source")]
    [StringLength(10)]
    public string? EmpSalarySource { get; set; }

    [Column("old_gpf_account_no")]
    [StringLength(50)]
    public string? OldGpfAccountNo { get; set; }

    [Column("retired_flag")]
    [StringLength(1)]
    public string? RetiredFlag { get; set; }

    [Column("int_employee_id_old")]
    [StringLength(38)]
    public string IntEmployeeIdOld { get; set; } = null!;

    [Column("emp_int_omi_initials_old")]
    [StringLength(38)]
    public string? EmpIntOmiInitialsOld { get; set; }

    [Column("emp_int_omi_initials")]
    public int? EmpIntOmiInitials { get; set; }

    [Column("emp_int_omi_gender_old")]
    [StringLength(38)]
    public string? EmpIntOmiGenderOld { get; set; }

    [Column("emp_int_omi_gender")]
    public int? EmpIntOmiGender { get; set; }

    [Column("emp_int_omi_cast_old")]
    [StringLength(38)]
    public string? EmpIntOmiCastOld { get; set; }

    [Column("emp_int_omi_cast")]
    public int? EmpIntOmiCast { get; set; }

    [Column("emp_int_omi_nationality_old")]
    [StringLength(38)]
    public string? EmpIntOmiNationalityOld { get; set; }

    [Column("emp_int_omi_nationality")]
    public int? EmpIntOmiNationality { get; set; }

    [Column("exact_height_old")]
    [StringLength(38)]
    public string? ExactHeightOld { get; set; }

    [Column("exact_height")]
    public int? ExactHeight { get; set; }

    [Column("int_emp_omi_height_unit_old")]
    [StringLength(38)]
    public string? IntEmpOmiHeightUnitOld { get; set; }

    [Column("int_emp_omi_height_unit")]
    public int? IntEmpOmiHeightUnit { get; set; }

    [Column("emp_int_omi_religion_old")]
    [StringLength(38)]
    public string? EmpIntOmiReligionOld { get; set; }

    [Column("emp_int_omi_religion")]
    public int? EmpIntOmiReligion { get; set; }

    [Column("emp_int_omi_physic_challenged_old")]
    [StringLength(38)]
    public string? EmpIntOmiPhysicChallengedOld { get; set; }

    [Column("emp_int_omi_physic_challenged")]
    public int? EmpIntOmiPhysicChallenged { get; set; }

    [Column("emp_physic_challenged_perc_old")]
    [StringLength(38)]
    public string? EmpPhysicChallengedPercOld { get; set; }

    [Column("emp_physic_challenged_perc")]
    public int? EmpPhysicChallengedPerc { get; set; }

    [Column("emp_int_omi_blood_group_old")]
    [StringLength(38)]
    public string? EmpIntOmiBloodGroupOld { get; set; }

    [Column("emp_int_omi_blood_group")]
    public int? EmpIntOmiBloodGroup { get; set; }

    [Column("int_emp_details_staging_id_old")]
    [StringLength(38)]
    public string? IntEmpDetailsStagingIdOld { get; set; }

    [Column("int_emp_details_staging_id")]
    public int? IntEmpDetailsStagingId { get; set; }

    [Column("int_batch_id_old")]
    [StringLength(38)]
    public string? IntBatchIdOld { get; set; }

    [Column("int_batch_id")]
    public int? IntBatchId { get; set; }

    [Column("deputaion_flag_old")]
    [StringLength(38)]
    public string? DeputaionFlagOld { get; set; }

    [Column("deputaion_flag")]
    public int? DeputaionFlag { get; set; }

    [Column("emp_visual_challenged_perc_old")]
    [StringLength(38)]
    public string? EmpVisualChallengedPercOld { get; set; }

    [Column("emp_visual_challenged_perc")]
    public int? EmpVisualChallengedPerc { get; set; }

    [Column("int_request_id_old")]
    [StringLength(38)]
    public string? IntRequestIdOld { get; set; }

    [Column("int_request_id")]
    public int? IntRequestId { get; set; }

    [Column("request_id_old")]
    [StringLength(38)]
    public string? RequestIdOld { get; set; }

    [Column("request_id")]
    public int? RequestId { get; set; }

    [Column("int_omi_pf_nps_type_old")]
    [StringLength(38)]
    public string? IntOmiPfNpsTypeOld { get; set; }

    [Column("int_omi_pf_nps_type")]
    public int? IntOmiPfNpsType { get; set; }

    [Column("latest_int_transfer_out_id_old")]
    [StringLength(38)]
    public string? LatestIntTransferOutIdOld { get; set; }

    [Column("latest_int_transfer_out_id")]
    public int? LatestIntTransferOutId { get; set; }

    [Column("latest_int_transfer_out_lpc_id_old")]
    [StringLength(38)]
    public string? LatestIntTransferOutLpcIdOld { get; set; }

    [Column("latest_int_transfer_out_lpc_id")]
    public int? LatestIntTransferOutLpcId { get; set; }

    [Column("emp_srl_no_old")]
    [StringLength(38)]
    public string? EmpSrlNoOld { get; set; }

    [Column("emp_srl_no")]
    public int? EmpSrlNo { get; set; }

    [Column("joining_fore_aft_noon_old")]
    [StringLength(38)]
    public string? JoiningForeAftNoonOld { get; set; }

    [Column("joining_fore_aft_noon")]
    public int? JoiningForeAftNoon { get; set; }

    [Column("int_omi_date_of_birth_doc_old")]
    [StringLength(38)]
    public string? IntOmiDateOfBirthDocOld { get; set; }

    [Column("int_omi_date_of_birth_doc")]
    public int? IntOmiDateOfBirthDoc { get; set; }

    [Key]
    [Column("int_employee_id")]
    public int IntEmployeeId { get; set; }

    [ForeignKey("EmpIntOmiCast")]
    [InverseProperty("HrMmEmpBasicDtlEmpIntOmiCastNavigations")]
    public virtual HrMmGenOtherMaster? EmpIntOmiCastNavigation { get; set; }

    [ForeignKey("EmpIntOmiGender")]
    [InverseProperty("HrMmEmpBasicDtlEmpIntOmiGenderNavigations")]
    public virtual HrMmGenOtherMaster? EmpIntOmiGenderNavigation { get; set; }

    [ForeignKey("EmpIntOmiInitials")]
    [InverseProperty("HrMmEmpBasicDtlEmpIntOmiInitialsNavigations")]
    public virtual HrMmGenOtherMaster? EmpIntOmiInitialsNavigation { get; set; }

    [ForeignKey("EmpIntOmiNationality")]
    [InverseProperty("HrMmEmpBasicDtlEmpIntOmiNationalityNavigations")]
    public virtual HrMmGenOtherMaster? EmpIntOmiNationalityNavigation { get; set; }

    [ForeignKey("EmpIntOmiPhysicChallenged")]
    [InverseProperty("HrMmEmpBasicDtlEmpIntOmiPhysicChallengedNavigations")]
    public virtual HrMmGenOtherMaster? EmpIntOmiPhysicChallengedNavigation { get; set; }

    [ForeignKey("EmpIntOmiReligion")]
    [InverseProperty("HrMmEmpBasicDtlEmpIntOmiReligionNavigations")]
    public virtual HrMmGenOtherMaster? EmpIntOmiReligionNavigation { get; set; }

    public virtual ICollection<EmpPfBasicDetail> EmpPfBasicDetails { get; set; } = new List<EmpPfBasicDetail>();

    [InverseProperty("IntEmployee")]
    public virtual ICollection<HrMdConfDtlsSrvBook> HrMdConfDtlsSrvBooks { get; set; } = new List<HrMdConfDtlsSrvBook>();

    [InverseProperty("IntEmployee")]
    public virtual ICollection<HrMdEmpAddressWf> HrMdEmpAddressWfs { get; set; } = new List<HrMdEmpAddressWf>();

    [InverseProperty("IntEmployee")]
    public virtual ICollection<HrMdEmpAddress> HrMdEmpAddresses { get; set; } = new List<HrMdEmpAddress>();

    [InverseProperty("IntEmployee")]
    public virtual ICollection<HrMdEmpNomineeDtlWf> HrMdEmpNomineeDtlWfs { get; set; } = new List<HrMdEmpNomineeDtlWf>();

    [InverseProperty("IntEmployee")]
    public virtual ICollection<HrMdEmpNomineeDtl> HrMdEmpNomineeDtls { get; set; } = new List<HrMdEmpNomineeDtl>();

    [InverseProperty("IntEmployee")]
    public virtual ICollection<HrMdEmpPayAndAllowance> HrMdEmpPayAndAllowances { get; set; } = new List<HrMdEmpPayAndAllowance>();

    [InverseProperty("IntEmployee")]
    public virtual ICollection<HrMdEmpPayAndAllownceWf> HrMdEmpPayAndAllownceWfs { get; set; } = new List<HrMdEmpPayAndAllownceWf>();

    [InverseProperty("IntEmployee")]
    public virtual ICollection<HrMdEmpPayInformationWf> HrMdEmpPayInformationWfs { get; set; } = new List<HrMdEmpPayInformationWf>();

    [InverseProperty("IntEmployee")]
    public virtual ICollection<HrMdEmpPayInformation> HrMdEmpPayInformations { get; set; } = new List<HrMdEmpPayInformation>();

    [InverseProperty("IntEmployee")]
    public virtual ICollection<HrMdEmpQualification> HrMdEmpQualifications { get; set; } = new List<HrMdEmpQualification>();

    [InverseProperty("IntEmployee")]
    public virtual ICollection<HrMdEmpWorkingDtl> HrMdEmpWorkingDtls { get; set; } = new List<HrMdEmpWorkingDtl>();

    [ForeignKey("IntEmpDetailsStagingId")]
    [InverseProperty("HrMmEmpBasicDtls")]
    public virtual HrDetailsEmpStaging? IntEmpDetailsStaging { get; set; }

    [ForeignKey("IntEmpOmiHeightUnit")]
    [InverseProperty("HrMmEmpBasicDtlIntEmpOmiHeightUnitNavigations")]
    public virtual HrMmGenOtherMaster? IntEmpOmiHeightUnitNavigation { get; set; }
}
