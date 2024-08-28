using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;
using Microsoft.EntityFrameworkCore;

namespace NGIPF_BE.DAL.Entities;

[Table("hr_md_emp_nominee_dtl_audit", Schema = "ihrms")]
public partial class HrMdEmpNomineeDtlAudit
{
    [Key]
    [Column("int_nom_id_aud")]
    [StringLength(38)]
    public string IntNomIdAud { get; set; } = null!;

    [Column("int_nom_id")]
    [StringLength(38)]
    public string IntNomId { get; set; } = null!;

    [Column("int_employee_id")]
    [Precision(38, 0)]
    public BigInteger IntEmployeeId { get; set; }

    [Column("nominee_name")]
    [StringLength(200)]
    public string NomineeName { get; set; } = null!;

    [Column("gender")]
    [MaxLength(1)]
    public char? Gender { get; set; }

    [Column("int_marital_status_id")]
    [StringLength(38)]
    public string? IntMaritalStatusId { get; set; }

    [Column("date_of_birth", TypeName = "timestamp(0) without time zone")]
    public DateTime DateOfBirth { get; set; }

    [Column("minor_flag")]
    [MaxLength(1)]
    public char MinorFlag { get; set; }

    [Column("guardian_name")]
    [StringLength(200)]
    public string? GuardianName { get; set; }

    [Column("identification_mark")]
    [StringLength(100)]
    public string? IdentificationMark { get; set; }

    [Column("share_percentage")]
    [Precision(7, 2)]
    public decimal? SharePercentage { get; set; }

    [Column("bank_ac_no")]
    [StringLength(30)]
    public string? BankAcNo { get; set; }

    [Column("ifsc_code")]
    [StringLength(11)]
    public string? IfscCode { get; set; }

    [Column("priority_level")]
    public short PriorityLevel { get; set; }

    [Column("minor_flag_calculated_on", TypeName = "timestamp(0) without time zone")]
    public DateTime? MinorFlagCalculatedOn { get; set; }

    [Column("benf_type_id")]
    [StringLength(38)]
    public string BenfTypeId { get; set; } = null!;

    [Column("nominee_type")]
    [MaxLength(1)]
    public char NomineeType { get; set; }

    [Column("mobile_number")]
    [StringLength(11)]
    public string? MobileNumber { get; set; }

    [Column("dml_status_flag")]
    public short DmlStatusFlag { get; set; }

    [Column("user_id")]
    public int UserId { get; set; }

    [Column("created_timestamp", TypeName = "timestamp(6) without time zone")]
    public DateTime CreatedTimestamp { get; set; }

    [Column("int_emp_relationship_id")]
    [StringLength(38)]
    public string? IntEmpRelationshipId { get; set; }

    [Column("nom_int_omi_physic_challenged")]
    [StringLength(38)]
    public string? NomIntOmiPhysicChallenged { get; set; }

    [Column("nom_physic_challenged_perc_vh")]
    public short? NomPhysicChallengedPercVh { get; set; }

    [Column("nom_physic_challenged_perc_ph")]
    public short? NomPhysicChallengedPercPh { get; set; }

    [Column("int_relation_addr_id")]
    [StringLength(38)]
    public string? IntRelationAddrId { get; set; }

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

    [Column("state_id")]
    public short? StateId { get; set; }

    [Column("int_district_id")]
    public int? IntDistrictId { get; set; }

    [Column("pin")]
    [StringLength(10)]
    public string? Pin { get; set; }

    [Column("guardian_addr")]
    [StringLength(500)]
    public string? GuardianAddr { get; set; }

    [Column("relation_in_out")]
    [StringLength(1)]
    public string? RelationInOut { get; set; }

    [Column("role_id")]
    public int? RoleId { get; set; }

    [Column("request_id")]
    public long? RequestId { get; set; }

    [Column("org_nom_id_for_alternate")]
    [StringLength(38)]
    public string? OrgNomIdForAlternate { get; set; }

    [Column("active_flag")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("declaration_for_nominee")]
    [StringLength(300)]
    public string? DeclarationForNominee { get; set; }

    [Column("ese_flag")]
    [StringLength(1)]
    public string? EseFlag { get; set; }

    [Column("audit_user")]
    public int? AuditUser { get; set; }

    [Column("audit_role")]
    public int? AuditRole { get; set; }

    [Column("audit_date", TypeName = "timestamp(6) without time zone")]
    public DateTime? AuditDate { get; set; }

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
    public string CreationAfterDeathFlag { get; set; } = null!;

    [Column("nom_deceased_flag")]
    [StringLength(1)]
    public string NomDeceasedFlag { get; set; } = null!;

    [Column("age_on_created_date")]
    [StringLength(100)]
    public string? AgeOnCreatedDate { get; set; }

    [Column("out_rel_desc")]
    [StringLength(500)]
    public string? OutRelDesc { get; set; }

    [Column("modified_user_id")]
    public int? ModifiedUserId { get; set; }

    [Column("modified_role_id")]
    public int? ModifiedRoleId { get; set; }

    [Column("modified_timestamp", TypeName = "timestamp(6) without time zone")]
    public DateTime? ModifiedTimestamp { get; set; }

    [Column("hardcopy_submitted_flag")]
    [StringLength(1)]
    public string? HardcopySubmittedFlag { get; set; }

    [Column("hardcopy_submitted_date", TypeName = "timestamp(0) without time zone")]
    public DateTime? HardcopySubmittedDate { get; set; }

    [Column("hardcopy_change_flag")]
    [StringLength(1)]
    public string? HardcopyChangeFlag { get; set; }

    [Column("signature_place")]
    [StringLength(100)]
    public string? SignaturePlace { get; set; }

    [Column("nominee_legal_hire_flag")]
    [StringLength(1)]
    public string? NomineeLegalHireFlag { get; set; }

    [Column("int_guardian_type_omi_id")]
    [StringLength(38)]
    public string? IntGuardianTypeOmiId { get; set; }

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

    [Column("cert_date", TypeName = "timestamp(0) without time zone")]
    public DateTime? CertDate { get; set; }

    [Column("nom_men_challenged_perc_ph")]
    public short? NomMenChallengedPercPh { get; set; }
}
