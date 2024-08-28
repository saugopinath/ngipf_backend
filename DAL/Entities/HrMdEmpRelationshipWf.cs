using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NGIPF_BE.DAL.Entities;

[Keyless]
[Table("hr_md_emp_relationship_wf", Schema = "ihrms_emp_master")]
public partial class HrMdEmpRelationshipWf
{
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

    [Column("wef")]
    public DateOnly? Wef { get; set; }

    [Column("effective_end_date")]
    public DateOnly? EffectiveEndDate { get; set; }

    [Column("rel_date_of_birth")]
    public DateOnly? RelDateOfBirth { get; set; }

    [Column("rel_working_flag")]
    [StringLength(1)]
    public string? RelWorkingFlag { get; set; }

    [Column("workflow_status_flag")]
    [StringLength(2)]
    public string? WorkflowStatusFlag { get; set; }

    [Column("last_updated_on", TypeName = "timestamp without time zone")]
    public DateTime? LastUpdatedOn { get; set; }

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

    [Column("hra_drawn_flag")]
    [StringLength(1)]
    public string? HraDrawnFlag { get; set; }

    [Column("distance_of_office")]
    [StringLength(1)]
    public string? DistanceOfOffice { get; set; }

    [Column("distance_office_gov_order_no")]
    [StringLength(100)]
    public string? DistanceOfficeGovOrderNo { get; set; }

    [Column("distance_office_gov_order_date")]
    public DateOnly? DistanceOfficeGovOrderDate { get; set; }

    [Column("marriage_date")]
    public DateOnly? MarriageDate { get; set; }

    [Column("rel_identification_mark")]
    [StringLength(200)]
    public string? RelIdentificationMark { get; set; }

    [Column("int_emp_relationship_id_wf_old")]
    [StringLength(38)]
    public string? IntEmpRelationshipIdWfOld { get; set; }

    [Column("int_emp_relationship_id_old")]
    [StringLength(38)]
    public string? IntEmpRelationshipIdOld { get; set; }

    [Column("int_emp_relationship_id")]
    public int? IntEmpRelationshipId { get; set; }

    [Column("int_employee_id_old")]
    [StringLength(38)]
    public string? IntEmployeeIdOld { get; set; }

    [Column("int_employee_id")]
    public int? IntEmployeeId { get; set; }

    [Column("rel_int_omi_relationship_old")]
    [StringLength(38)]
    public string? RelIntOmiRelationshipOld { get; set; }

    [Column("rel_int_omi_relationship")]
    public int? RelIntOmiRelationship { get; set; }

    [Column("rel_int_omi_initials_old")]
    [StringLength(38)]
    public string? RelIntOmiInitialsOld { get; set; }

    [Column("rel_int_omi_initials")]
    public int? RelIntOmiInitials { get; set; }

    [Column("dml_status_flag_old")]
    [StringLength(38)]
    public string? DmlStatusFlagOld { get; set; }

    [Column("dml_status_flag")]
    public int? DmlStatusFlag { get; set; }

    [Column("rel_income_old")]
    [StringLength(38)]
    public string? RelIncomeOld { get; set; }

    [Column("rel_income")]
    public int? RelIncome { get; set; }

    [Column("rel_int_omi_physic_challenged_old")]
    [StringLength(38)]
    public string? RelIntOmiPhysicChallengedOld { get; set; }

    [Column("rel_int_omi_physic_challenged")]
    public int? RelIntOmiPhysicChallenged { get; set; }

    [Column("rel_physic_challenged_perc_vh_old")]
    [StringLength(38)]
    public string? RelPhysicChallengedPercVhOld { get; set; }

    [Column("rel_physic_challenged_perc_vh")]
    public int? RelPhysicChallengedPercVh { get; set; }

    [Column("rel_physic_challenged_perc_ph_old")]
    [StringLength(38)]
    public string? RelPhysicChallengedPercPhOld { get; set; }

    [Column("rel_physic_challenged_perc_ph")]
    public int? RelPhysicChallengedPercPh { get; set; }

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

    [Column("request_id_old")]
    [StringLength(38)]
    public string? RequestIdOld { get; set; }

    [Column("request_id")]
    public int? RequestId { get; set; }

    [Column("int_srv_id_old")]
    [StringLength(38)]
    public string? IntSrvIdOld { get; set; }

    [Column("int_srv_id")]
    public int? IntSrvId { get; set; }

    [Column("hra_amount_old")]
    [StringLength(38)]
    public string? HraAmountOld { get; set; }

    [Column("hra_amount")]
    public int? HraAmount { get; set; }

    [Column("relationship_omi_distance_unit_old")]
    [StringLength(38)]
    public string? RelationshipOmiDistanceUnitOld { get; set; }

    [Column("relationship_omi_distance_unit")]
    public int? RelationshipOmiDistanceUnit { get; set; }

    [Column("relationship_monthly_income_old")]
    [StringLength(38)]
    public string? RelationshipMonthlyIncomeOld { get; set; }

    [Column("relationship_monthly_income")]
    public int? RelationshipMonthlyIncome { get; set; }

    [Column("int_rel_maritial_status_old")]
    [StringLength(38)]
    public string? IntRelMaritialStatusOld { get; set; }

    [Column("int_rel_maritial_status")]
    public int? IntRelMaritialStatus { get; set; }

    [Column("rel_exact_height_old")]
    [StringLength(38)]
    public string? RelExactHeightOld { get; set; }

    [Column("rel_exact_height")]
    public int? RelExactHeight { get; set; }

    [Column("int_rel_omi_height_unit_old")]
    [StringLength(38)]
    public string? IntRelOmiHeightUnitOld { get; set; }

    [Column("int_rel_omi_height_unit")]
    public int? IntRelOmiHeightUnit { get; set; }

    [Column("rel_physic_challenged_perc_mr_old")]
    [StringLength(38)]
    public string? RelPhysicChallengedPercMrOld { get; set; }

    [Column("rel_physic_challenged_perc_mr")]
    public int? RelPhysicChallengedPercMr { get; set; }

    [Column("int_emp_relationship_id_wf")]
    public int IntEmpRelationshipIdWf { get; set; }
}
