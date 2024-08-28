using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NGIPF_BE.DAL.Entities;

[Table("hr_details_emp_staging", Schema = "ihrms_emp_master")]
public partial class HrDetailsEmpStaging
{
    [Column("mon")]
    [StringLength(5)]
    public string? Mon { get; set; }

    [Column("yr")]
    public double? Yr { get; set; }

    [Column("ddo_code")]
    [StringLength(11)]
    public string? DdoCode { get; set; }

    [Column("emp_code")]
    [StringLength(20)]
    public string? EmpCode { get; set; }

    [Column("dept_name")]
    [StringLength(50)]
    public string? DeptName { get; set; }

    [Column("estb_name")]
    [StringLength(50)]
    public string? EstbName { get; set; }

    [Column("finyear")]
    [StringLength(9)]
    public string? Finyear { get; set; }

    [Column("emp_name")]
    [StringLength(40)]
    public string? EmpName { get; set; }

    [Column("sl")]
    public short? Sl { get; set; }

    [Column("designation")]
    [StringLength(50)]
    public string? Designation { get; set; }

    [Column("scale_option")]
    [StringLength(4)]
    public string? ScaleOption { get; set; }

    [Column("pay_scale")]
    [StringLength(150)]
    public string? PayScale { get; set; }

    [Column("personal_scale")]
    [StringLength(2)]
    public string? PersonalScale { get; set; }

    [Column("basic")]
    public int? Basic { get; set; }

    [Column("pf_type")]
    [StringLength(10)]
    public string? PfType { get; set; }

    [Column("gis")]
    [StringLength(4)]
    public string? Gis { get; set; }

    [Column("employee_group")]
    [StringLength(2)]
    public string? EmployeeGroup { get; set; }

    [Column("date_birth", TypeName = "timestamp(0) without time zone")]
    public DateTime? DateBirth { get; set; }

    [Column("date_join", TypeName = "timestamp(0) without time zone")]
    public DateTime? DateJoin { get; set; }

    [Column("date_post", TypeName = "timestamp(0) without time zone")]
    public DateTime? DatePost { get; set; }

    [Column("date_incr", TypeName = "timestamp(0) without time zone")]
    public DateTime? DateIncr { get; set; }

    [Column("incr_amount")]
    public int? IncrAmount { get; set; }

    [Column("service_status")]
    [StringLength(2)]
    public string? ServiceStatus { get; set; }

    [Column("deputation_status")]
    [StringLength(2)]
    public string? DeputationStatus { get; set; }

    [Column("service_type")]
    [StringLength(2)]
    public string? ServiceType { get; set; }

    [Column("spouse_status")]
    [StringLength(6)]
    public string? SpouseStatus { get; set; }

    [Column("resident")]
    [StringLength(50)]
    public string? Resident { get; set; }

    [Column("govt_qrts")]
    [StringLength(50)]
    public string? GovtQrts { get; set; }

    [Column("quarter_type")]
    [StringLength(2)]
    public string? QuarterType { get; set; }

    [Column("sex")]
    [StringLength(6)]
    public string? Sex { get; set; }

    [Column("marital")]
    [StringLength(10)]
    public string? Marital { get; set; }

    [Column("religion")]
    [StringLength(10)]
    public string? Religion { get; set; }

    [Column("address_1")]
    [StringLength(100)]
    public string? Address1 { get; set; }

    [Column("address_2")]
    [StringLength(100)]
    public string? Address2 { get; set; }

    [Column("pan_no")]
    [StringLength(10)]
    public string? PanNo { get; set; }

    [Column("pay_option")]
    [StringLength(25)]
    public string? PayOption { get; set; }

    [Column("bank_name")]
    [StringLength(50)]
    public string? BankName { get; set; }

    [Column("acct_no")]
    [StringLength(20)]
    public string? AcctNo { get; set; }

    [Column("pay_taken")]
    [StringLength(2)]
    public string? PayTaken { get; set; }

    [Column("bill_type")]
    [StringLength(2)]
    public string? BillType { get; set; }

    [Column("billno")]
    [StringLength(10)]
    public string? Billno { get; set; }

    [Column("bill_date", TypeName = "timestamp(0) without time zone")]
    public DateTime? BillDate { get; set; }

    [Column("gis_1")]
    [StringLength(2)]
    public string? Gis1 { get; set; }

    [Column("date_retr", TypeName = "timestamp(0) without time zone")]
    public DateTime? DateRetr { get; set; }

    [Column("bill_code")]
    [StringLength(2)]
    public string? BillCode { get; set; }

    [Column("handicapped")]
    [StringLength(3)]
    public string? Handicapped { get; set; }

    [Column("date_sec", TypeName = "timestamp(0) without time zone")]
    public DateTime? DateSec { get; set; }

    [Column("village_worker")]
    [StringLength(3)]
    public string? VillageWorker { get; set; }

    [Column("pf_code")]
    [StringLength(20)]
    public string? PfCode { get; set; }

    [Column("pf_no")]
    public long? PfNo { get; set; }

    [Column("incr_last", TypeName = "timestamp(0) without time zone")]
    public DateTime? IncrLast { get; set; }

    [Column("hr_amt")]
    public double? HrAmt { get; set; }

    [Column("gpf")]
    [StringLength(10)]
    public string? Gpf { get; set; }

    [Column("grade")]
    public int? Grade { get; set; }

    [Column("npa")]
    public int? Npa { get; set; }

    [Column("ma_option")]
    [StringLength(3)]
    public string? MaOption { get; set; }

    [Column("father_name")]
    [StringLength(50)]
    public string? FatherName { get; set; }

    [Column("mother_name")]
    [StringLength(50)]
    public string? MotherName { get; set; }

    [Column("spouse_name")]
    [StringLength(50)]
    public string? SpouseName { get; set; }

    [Column("bankacct_name")]
    [StringLength(50)]
    public string? BankacctName { get; set; }

    [Column("pensionopt")]
    [StringLength(10)]
    public string? Pensionopt { get; set; }

    [Column("designation_1")]
    [StringLength(50)]
    public string? Designation1 { get; set; }

    [Column("micr_code")]
    [StringLength(9)]
    public string? MicrCode { get; set; }

    [Column("ifsc_code")]
    [StringLength(11)]
    public string? IfscCode { get; set; }

    [Column("bacct_no")]
    [StringLength(20)]
    public string? BacctNo { get; set; }

    [Column("emp_category")]
    [StringLength(20)]
    public string? EmpCategory { get; set; }

    [Column("emp_caste")]
    [StringLength(20)]
    public string? EmpCaste { get; set; }

    [Column("post_sanctioned")]
    [StringLength(50)]
    public string? PostSanctioned { get; set; }

    [Column("special_qualification")]
    [StringLength(50)]
    public string? SpecialQualification { get; set; }

    [Column("qualification")]
    [StringLength(20)]
    public string? Qualification { get; set; }

    [Column("gpf_id")]
    [StringLength(20)]
    public string? GpfId { get; set; }

    [Column("rank")]
    [StringLength(12)]
    public string? Rank { get; set; }

    [Column("lpc_issued")]
    [StringLength(2)]
    public string? LpcIssued { get; set; }

    [Column("lpc_issue_date", TypeName = "timestamp(0) without time zone")]
    public DateTime? LpcIssueDate { get; set; }

    [Column("last_pay")]
    public int? LastPay { get; set; }

    [Column("pension")]
    public int? Pension { get; set; }

    [Column("academic_group")]
    [StringLength(20)]
    public string? AcademicGroup { get; set; }

    [Column("payrelated_qlf")]
    [StringLength(50)]
    public string? PayrelatedQlf { get; set; }

    [Column("dise_code")]
    [StringLength(11)]
    public string? DiseCode { get; set; }

    [Column("pran_no")]
    [StringLength(12)]
    public string? PranNo { get; set; }

    [Column("uid_emp")]
    [StringLength(50)]
    public string? UidEmp { get; set; }

    [Column("mobile")]
    [StringLength(10)]
    public string? Mobile { get; set; }

    [Column("emai_id")]
    [StringLength(50)]
    public string? EmaiId { get; set; }

    [Column("processing_status")]
    [StringLength(2)]
    public string? ProcessingStatus { get; set; }

    [Column("created_user_id")]
    public int? CreatedUserId { get; set; }

    [Column("created_timestamp", TypeName = "timestamp(0) without time zone")]
    public DateTime? CreatedTimestamp { get; set; }

    [Column("modified_user_id")]
    public int? ModifiedUserId { get; set; }

    [Column("modified_timestamp", TypeName = "timestamp(0) without time zone")]
    public DateTime? ModifiedTimestamp { get; set; }

    [Column("dml_status_flag")]
    public short? DmlStatusFlag { get; set; }

    [Column("post_description")]
    [StringLength(500)]
    public string? PostDescription { get; set; }

    [Column("gpf_series")]
    [StringLength(30)]
    public string? GpfSeries { get; set; }

    [Column("gpf_series1")]
    [StringLength(12)]
    public string? GpfSeries1 { get; set; }

    [Column("gpf_account_no")]
    [StringLength(20)]
    public string? GpfAccountNo { get; set; }

    [Column("int_ddo_id")]
    public int? IntDdoId { get; set; }

    [Column("int_dept_id")]
    public short? IntDeptId { get; set; }

    [Column("benf_id")]
    [StringLength(20)]
    public string? BenfId { get; set; }

    [Column("pran_no_staging")]
    [StringLength(12)]
    public string? PranNoStaging { get; set; }

    [Column("fixed_ddo_code")]
    [StringLength(11)]
    public string? FixedDdoCode { get; set; }

    [Column("int_legacy_data_temp_old")]
    [StringLength(38)]
    public string? IntLegacyDataTempOld { get; set; }

    [Column("int_legacy_data_temp")]
    public int? IntLegacyDataTemp { get; set; }

    [Column("file_unique_id_old")]
    [StringLength(38)]
    public string? FileUniqueIdOld { get; set; }

    [Column("file_unique_id")]
    public int? FileUniqueId { get; set; }

    [Column("int_section_id_old")]
    [StringLength(38)]
    public string? IntSectionIdOld { get; set; }

    [Column("int_section_id")]
    public int? IntSectionId { get; set; }

    [Column("int_designation_id_old")]
    [StringLength(38)]
    public string? IntDesignationIdOld { get; set; }

    [Column("int_designation_id")]
    public int? IntDesignationId { get; set; }

    [Column("int_post_id_old")]
    [StringLength(38)]
    public string? IntPostIdOld { get; set; }

    [Column("int_post_id")]
    public int? IntPostId { get; set; }

    [Column("int_omi_gpf_type_id_old")]
    [StringLength(38)]
    public string? IntOmiGpfTypeIdOld { get; set; }

    [Column("int_omi_gpf_type_id")]
    public int? IntOmiGpfTypeId { get; set; }

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

    [Column("int_comp_id_gis_savings_old")]
    [StringLength(38)]
    public string? IntCompIdGisSavingsOld { get; set; }

    [Column("int_comp_id_gis_savings")]
    public int? IntCompIdGisSavings { get; set; }

    [Column("int_grp_id_old")]
    [StringLength(38)]
    public string? IntGrpIdOld { get; set; }

    [Column("int_grp_id")]
    public int? IntGrpId { get; set; }

    [Column("int_other_master_id_srv_status_old")]
    [StringLength(38)]
    public string? IntOtherMasterIdSrvStatusOld { get; set; }

    [Column("int_other_master_id_srv_status")]
    public int? IntOtherMasterIdSrvStatus { get; set; }

    [Column("int_srv_id_old")]
    [StringLength(38)]
    public string? IntSrvIdOld { get; set; }

    [Column("int_srv_id")]
    public int? IntSrvId { get; set; }

    [Column("int_residential_type_id_old")]
    [StringLength(38)]
    public string? IntResidentialTypeIdOld { get; set; }

    [Column("int_residential_type_id")]
    public int? IntResidentialTypeId { get; set; }

    [Column("int_omi_quarter_type_id_old")]
    [StringLength(38)]
    public string? IntOmiQuarterTypeIdOld { get; set; }

    [Column("int_omi_quarter_type_id")]
    public int? IntOmiQuarterTypeId { get; set; }

    [Column("int_govt_quarter_comp_id_old")]
    [StringLength(38)]
    public string? IntGovtQuarterCompIdOld { get; set; }

    [Column("int_govt_quarter_comp_id")]
    public int? IntGovtQuarterCompId { get; set; }

    [Column("int_omi_employee_gender_old")]
    [StringLength(38)]
    public string? IntOmiEmployeeGenderOld { get; set; }

    [Column("int_omi_employee_gender")]
    public int? IntOmiEmployeeGender { get; set; }

    [Column("int_omi_employee_marital_stat_old")]
    [StringLength(38)]
    public string? IntOmiEmployeeMaritalStatOld { get; set; }

    [Column("int_omi_employee_marital_stat")]
    public int? IntOmiEmployeeMaritalStat { get; set; }

    [Column("int_omi_employee_religion_old")]
    [StringLength(38)]
    public string? IntOmiEmployeeReligionOld { get; set; }

    [Column("int_omi_employee_religion")]
    public int? IntOmiEmployeeReligion { get; set; }

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

    [Column("emp_visual_challenged_perc_old")]
    [StringLength(38)]
    public string? EmpVisualChallengedPercOld { get; set; }

    [Column("emp_visual_challenged_perc")]
    public int? EmpVisualChallengedPerc { get; set; }

    [Column("int_grade_pay_id_old")]
    [StringLength(38)]
    public string? IntGradePayIdOld { get; set; }

    [Column("int_grade_pay_id")]
    public int? IntGradePayId { get; set; }

    [Column("int_other_master_id_emp_catg_old")]
    [StringLength(38)]
    public string? IntOtherMasterIdEmpCatgOld { get; set; }

    [Column("int_other_master_id_emp_catg")]
    public int? IntOtherMasterIdEmpCatg { get; set; }

    [Column("int_omi_employee_caste_old")]
    [StringLength(38)]
    public string? IntOmiEmployeeCasteOld { get; set; }

    [Column("int_omi_employee_caste")]
    public int? IntOmiEmployeeCaste { get; set; }

    [Column("int_qualification_id_old")]
    [StringLength(38)]
    public string? IntQualificationIdOld { get; set; }

    [Column("int_qualification_id")]
    public int? IntQualificationId { get; set; }

    [Column("int_omi_academic_group_old")]
    [StringLength(38)]
    public string? IntOmiAcademicGroupOld { get; set; }

    [Column("int_omi_academic_group")]
    public int? IntOmiAcademicGroup { get; set; }

    [Column("int_omi_deputation_status_old")]
    [StringLength(38)]
    public string? IntOmiDeputationStatusOld { get; set; }

    [Column("int_omi_deputation_status")]
    public int? IntOmiDeputationStatus { get; set; }

    [Column("int_emp_details_staging_id_old")]
    [StringLength(38)]
    public string? IntEmpDetailsStagingIdOld { get; set; }

    [Key]
    [Column("int_emp_details_staging_id")]
    public int IntEmpDetailsStagingId { get; set; }

    [InverseProperty("IntEmpDetailsStaging")]
    public virtual ICollection<HrMmEmpBasicDtl> HrMmEmpBasicDtls { get; set; } = new List<HrMmEmpBasicDtl>();
}
