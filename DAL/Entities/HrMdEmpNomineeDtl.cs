using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_backend.DAL.Entities;

[Table("hr_md_emp_nominee_dtl", Schema = "ihrms_emp_master")]
public partial class HrMdEmpNomineeDtl
{
    [Column("nominee_name")]
    [StringLength(200)]
    public string? NomineeName { get; set; }

    [Column("gender")]
    [MaxLength(1)]
    public char? Gender { get; set; }

    [Column("date_of_birth")]
    public DateOnly DateOfBirth { get; set; }

    [Column("minor_flag")]
    [MaxLength(1)]
    public char? MinorFlag { get; set; }

    [Column("guardian_name")]
    [StringLength(200)]
    public string? GuardianName { get; set; }

    [Column("identification_mark")]
    [StringLength(100)]
    public string? IdentificationMark { get; set; }

    [Column("bank_ac_no")]
    [StringLength(30)]
    public string? BankAcNo { get; set; }

    [Column("ifsc_code")]
    [StringLength(11)]
    public string? IfscCode { get; set; }

    [Column("minor_flag_calculated_on")]
    public DateOnly? MinorFlagCalculatedOn { get; set; }

    [Column("nominee_type")]
    [MaxLength(1)]
    public char? NomineeType { get; set; }

    [Column("mobile_number")]
    [StringLength(11)]
    public string? MobileNumber { get; set; }

    [Column("created_timestamp", TypeName = "timestamp without time zone")]
    public DateTime CreatedTimestamp { get; set; }

    [Column("modified_timestamp", TypeName = "timestamp without time zone")]
    public DateTime ModifiedTimestamp { get; set; }

    [Column("house_no_street_lane")]
    [StringLength(100)]
    public string? HouseNoStreetLane { get; set; }

    [Column("city_town_village")]
    [StringLength(100)]
    public string? CityTownVillage { get; set; }

    [Column("post_office")]
    [StringLength(100)]
    public string? PostOffice { get; set; }

    [Column("police_station")]
    [StringLength(100)]
    public string? PoliceStation { get; set; }

    [Column("pin")]
    [StringLength(10)]
    public string? Pin { get; set; }

    [Column("guardian_addr")]
    [StringLength(500)]
    public string? GuardianAddr { get; set; }

    [Column("relation_in_out")]
    [StringLength(1)]
    public string? RelationInOut { get; set; }

    [Column("active_flag")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("declaration_for_nominee")]
    [StringLength(300)]
    public string? DeclarationForNominee { get; set; }

    [Column("ese_flag")]
    [StringLength(1)]
    public string? EseFlag { get; set; }

    [Column("email_id")]
    [StringLength(100)]
    public string? EmailId { get; set; }

    [Column("nom_contingency")]
    [StringLength(500)]
    public string? NomContingency { get; set; }

    [Column("remarks")]
    [StringLength(500)]
    public string? Remarks { get; set; }

    [Column("reason")]
    [StringLength(500)]
    public string? Reason { get; set; }

    [Column("creation_after_death_flag")]
    [StringLength(1)]
    public string? CreationAfterDeathFlag { get; set; }

    [Column("nom_deceased_flag")]
    [StringLength(1)]
    public string? NomDeceasedFlag { get; set; }

    [Column("age_on_created_date")]
    [StringLength(100)]
    public string? AgeOnCreatedDate { get; set; }

    [Column("out_rel_desc")]
    [StringLength(500)]
    public string? OutRelDesc { get; set; }

    [Column("hardcopy_submitted_flag")]
    [StringLength(1)]
    public string? HardcopySubmittedFlag { get; set; }

    [Column("hardcopy_submitted_date")]
    public DateOnly? HardcopySubmittedDate { get; set; }

    [Column("hardcopy_change_flag")]
    [StringLength(1)]
    public string? HardcopyChangeFlag { get; set; }

    [Column("signature_place")]
    [StringLength(100)]
    public string? SignaturePlace { get; set; }

    [Column("nominee_legal_hire_flag")]
    [StringLength(1)]
    public string? NomineeLegalHireFlag { get; set; }

    [Column("minor_natural_rel_id")]
    [StringLength(50)]
    public string? MinorNaturalRelId { get; set; }

    [Column("minor_natural_rel_type")]
    [StringLength(100)]
    public string? MinorNaturalRelType { get; set; }

    [Column("certificate_number")]
    [StringLength(50)]
    public string? CertificateNumber { get; set; }

    [Column("issuing_authority")]
    [StringLength(100)]
    public string? IssuingAuthority { get; set; }

    [Column("cert_date")]
    public DateOnly? CertDate { get; set; }

    [Column("int_nom_id_old")]
    [StringLength(38)]
    public string? IntNomIdOld { get; set; }

    [Column("int_employee_id_old")]
    [StringLength(38)]
    public string? IntEmployeeIdOld { get; set; }

    [Column("int_employee_id")]
    public int? IntEmployeeId { get; set; }

    [Column("int_marital_status_id_old")]
    [StringLength(38)]
    public string? IntMaritalStatusIdOld { get; set; }

    [Column("int_marital_status_id")]
    public int? IntMaritalStatusId { get; set; }

    [Column("share_percentage_old")]
    [StringLength(38)]
    public string? SharePercentageOld { get; set; }

    [Column("share_percentage")]
    public int? SharePercentage { get; set; }

    [Column("priority_level_old")]
    [StringLength(38)]
    public string? PriorityLevelOld { get; set; }

    [Column("priority_level")]
    public int? PriorityLevel { get; set; }

    [Column("benf_type_id_old")]
    [StringLength(38)]
    public string? BenfTypeIdOld { get; set; }

    [Column("benf_type_id")]
    public int? BenfTypeId { get; set; }

    [Column("dml_status_flag_old")]
    [StringLength(38)]
    public string? DmlStatusFlagOld { get; set; }

    [Column("dml_status_flag")]
    public int? DmlStatusFlag { get; set; }

    [Column("user_id_old")]
    [StringLength(38)]
    public string? UserIdOld { get; set; }

    [Column("user_id")]
    public int? UserId { get; set; }

    [Column("modified_user_id_old")]
    [StringLength(38)]
    public string? ModifiedUserIdOld { get; set; }

    [Column("modified_user_id")]
    public int? ModifiedUserId { get; set; }

    [Column("int_emp_relationship_id_old")]
    [StringLength(38)]
    public string? IntEmpRelationshipIdOld { get; set; }

    [Column("int_emp_relationship_id")]
    public int? IntEmpRelationshipId { get; set; }

    [Column("nom_int_omi_physic_challenged_old")]
    [StringLength(38)]
    public string? NomIntOmiPhysicChallengedOld { get; set; }

    [Column("nom_int_omi_physic_challenged")]
    public int? NomIntOmiPhysicChallenged { get; set; }

    [Column("nom_physic_challenged_perc_vh_old")]
    [StringLength(38)]
    public string? NomPhysicChallengedPercVhOld { get; set; }

    [Column("nom_physic_challenged_perc_vh")]
    public int? NomPhysicChallengedPercVh { get; set; }

    [Column("nom_physic_challenged_perc_ph_old")]
    [StringLength(38)]
    public string? NomPhysicChallengedPercPhOld { get; set; }

    [Column("nom_physic_challenged_perc_ph")]
    public int? NomPhysicChallengedPercPh { get; set; }

    [Column("int_relation_addr_id_old")]
    [StringLength(38)]
    public string? IntRelationAddrIdOld { get; set; }

    [Column("int_relation_addr_id")]
    public int? IntRelationAddrId { get; set; }

    [Column("state_id_old")]
    [StringLength(38)]
    public string? StateIdOld { get; set; }

    [Column("state_id")]
    public int? StateId { get; set; }

    [Column("int_district_id_old")]
    [StringLength(38)]
    public string? IntDistrictIdOld { get; set; }

    [Column("int_district_id")]
    public int? IntDistrictId { get; set; }

    [Column("role_id_old")]
    [StringLength(38)]
    public string? RoleIdOld { get; set; }

    [Column("role_id")]
    public int? RoleId { get; set; }

    [Column("modified_role_id_old")]
    [StringLength(38)]
    public string? ModifiedRoleIdOld { get; set; }

    [Column("modified_role_id")]
    public int? ModifiedRoleId { get; set; }

    [Column("request_id_old")]
    [StringLength(38)]
    public string? RequestIdOld { get; set; }

    [Column("request_id")]
    public int? RequestId { get; set; }

    [Column("org_nom_id_for_alternate_old")]
    [StringLength(38)]
    public string? OrgNomIdForAlternateOld { get; set; }

    [Column("org_nom_id_for_alternate")]
    public int? OrgNomIdForAlternate { get; set; }

    [Column("processing_flag_old")]
    [StringLength(38)]
    public string? ProcessingFlagOld { get; set; }

    [Column("processing_flag")]
    public int? ProcessingFlag { get; set; }

    [Column("int_guardian_type_omi_id_old")]
    [StringLength(38)]
    public string? IntGuardianTypeOmiIdOld { get; set; }

    [Column("int_guardian_type_omi_id")]
    public int? IntGuardianTypeOmiId { get; set; }

    [Column("nom_men_challenged_perc_ph_old")]
    [StringLength(38)]
    public string? NomMenChallengedPercPhOld { get; set; }

    [Column("nom_men_challenged_perc_ph")]
    public int? NomMenChallengedPercPh { get; set; }

    [Key]
    [Column("int_nom_id")]
    public int IntNomId { get; set; }

    [ForeignKey("IfscCode")]
    [InverseProperty("HrMdEmpNomineeDtls")]
    public virtual MmGenBankBranchIfsc? IfscCodeNavigation { get; set; }

    [ForeignKey("IntEmpRelationshipId")]
    [InverseProperty("HrMdEmpNomineeDtls")]
    public virtual HrMdEmpRelationship? IntEmpRelationship { get; set; }

    [ForeignKey("IntEmployeeId")]
    [InverseProperty("HrMdEmpNomineeDtls")]
    public virtual HrMmEmpBasicDtl? IntEmployee { get; set; }

    [ForeignKey("IntMaritalStatusId")]
    [InverseProperty("HrMdEmpNomineeDtls")]
    public virtual HrMmGenOtherMaster? IntMaritalStatus { get; set; }

    [ForeignKey("IntRelationAddrId")]
    [InverseProperty("HrMdEmpNomineeDtls")]
    public virtual HrMdEmpRelationAddress? IntRelationAddr { get; set; }

    [InverseProperty("OrgNomIdForAlternateNavigation")]
    public virtual ICollection<HrMdEmpNomineeDtl> InverseOrgNomIdForAlternateNavigation { get; set; } = new List<HrMdEmpNomineeDtl>();

    [ForeignKey("OrgNomIdForAlternate")]
    [InverseProperty("InverseOrgNomIdForAlternateNavigation")]
    public virtual HrMdEmpNomineeDtl? OrgNomIdForAlternateNavigation { get; set; }
}
