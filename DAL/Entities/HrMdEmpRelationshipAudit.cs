using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;
using Microsoft.EntityFrameworkCore;

namespace ngipf_backend.DAL.Entities;

[Table("hr_md_emp_relationship_audit", Schema = "ihrms")]
[Index("IntEmployeeId", Name = "ind_hr_md_emp_relation_audit1")]
[Index("RequestId", Name = "ind_hr_md_emp_relation_audit2")]
[Index("IntRelMaritialStatus", Name = "ind_hr_md_emp_relation_audit3")]
public partial class HrMdEmpRelationshipAudit
{
    [Key]
    [Column("int_emp_relationship_id_audit")]
    [StringLength(38)]
    public string IntEmpRelationshipIdAudit { get; set; } = null!;

    [Column("int_emp_relationship_id")]
    [StringLength(38)]
    public string? IntEmpRelationshipId { get; set; }

    [Column("int_employee_id")]
    [Precision(38, 0)]
    public BigInteger? IntEmployeeId { get; set; }

    [Column("rel_int_omi_relationship")]
    [StringLength(38)]
    public string? RelIntOmiRelationship { get; set; }

    [Column("rel_int_omi_initials")]
    [StringLength(38)]
    public string? RelIntOmiInitials { get; set; }

    [Column("rel_first_name")]
    [StringLength(100)]
    public string? RelFirstName { get; set; }

    [Column("rel_mid_name")]
    [StringLength(30)]
    public string? RelMidName { get; set; }

    [Column("rel_last_name")]
    [StringLength(30)]
    public string? RelLastName { get; set; }

    [Column("remarks")]
    [StringLength(200)]
    public string? Remarks { get; set; }

    [Column("active_flag")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("wef", TypeName = "timestamp(0) without time zone")]
    public DateTime? Wef { get; set; }

    [Column("effective_end_date", TypeName = "timestamp(0) without time zone")]
    public DateTime? EffectiveEndDate { get; set; }

    [Column("dml_status_flag")]
    public short? DmlStatusFlag { get; set; }

    [Column("rel_date_of_birth", TypeName = "timestamp(0) without time zone")]
    public DateTime? RelDateOfBirth { get; set; }

    [Column("rel_working_flag")]
    [StringLength(1)]
    public string? RelWorkingFlag { get; set; }

    [Column("rel_income")]
    [Precision(10, 2)]
    public decimal? RelIncome { get; set; }

    [Column("rel_int_omi_physic_challenged")]
    [StringLength(38)]
    public string? RelIntOmiPhysicChallenged { get; set; }

    [Column("rel_physic_challenged_perc_vh")]
    public short? RelPhysicChallengedPercVh { get; set; }

    [Column("rel_physic_challenged_perc_ph")]
    public short? RelPhysicChallengedPercPh { get; set; }

    [Column("last_updated_by")]
    public int? LastUpdatedBy { get; set; }

    [Column("last_updated_on", TypeName = "timestamp without time zone")]
    public DateTime? LastUpdatedOn { get; set; }

    [Column("last_updated_by_role")]
    public int? LastUpdatedByRole { get; set; }

    [Column("request_id")]
    public long? RequestId { get; set; }

    [Column("wbhs_card_number")]
    [StringLength(50)]
    public string? WbhsCardNumber { get; set; }

    [Column("health_insurance_type")]
    [StringLength(1)]
    public string? HealthInsuranceType { get; set; }

    [Column("relationship_emp_no")]
    [StringLength(50)]
    public string? RelationshipEmpNo { get; set; }

    [Column("relationship_working_flag")]
    [StringLength(1)]
    public string? RelationshipWorkingFlag { get; set; }

    [Column("int_srv_id")]
    [StringLength(38)]
    public string? IntSrvId { get; set; }

    [Column("hra_drawn_flag")]
    [StringLength(1)]
    public string? HraDrawnFlag { get; set; }

    [Column("hra_amount")]
    public int? HraAmount { get; set; }

    [Column("distance_of_office")]
    [StringLength(1)]
    public string? DistanceOfOffice { get; set; }

    [Column("relationship_omi_distance_unit")]
    [StringLength(38)]
    public string? RelationshipOmiDistanceUnit { get; set; }

    [Column("relationship_monthly_income")]
    [Precision(10, 2)]
    public decimal? RelationshipMonthlyIncome { get; set; }

    [Column("int_rel_maritial_status")]
    [StringLength(38)]
    public string? IntRelMaritialStatus { get; set; }

    [Column("distance_office_gov_order_no")]
    [StringLength(100)]
    public string? DistanceOfficeGovOrderNo { get; set; }

    [Column("distance_office_gov_order_date", TypeName = "timestamp(0) without time zone")]
    public DateTime? DistanceOfficeGovOrderDate { get; set; }

    [Column("marriage_date", TypeName = "timestamp(0) without time zone")]
    public DateTime? MarriageDate { get; set; }

    [Column("rel_exact_height")]
    [Precision(7, 2)]
    public decimal? RelExactHeight { get; set; }

    [Column("int_rel_omi_height_unit")]
    [StringLength(38)]
    public string? IntRelOmiHeightUnit { get; set; }

    [Column("rel_identification_mark")]
    [StringLength(200)]
    public string? RelIdentificationMark { get; set; }

    [Column("rel_physic_challenged_perc_mr")]
    public short? RelPhysicChallengedPercMr { get; set; }
}
