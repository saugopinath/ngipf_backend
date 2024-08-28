using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NGIPF_BE.DAL.Entities;

[Keyless]
[Table("hr_md_emp_relation_address_wf", Schema = "ihrms_emp_master")]
public partial class HrMdEmpRelationAddressWf
{
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

    [Column("wef", TypeName = "timestamp without time zone")]
    public DateTime? Wef { get; set; }

    [Column("addr_type")]
    [StringLength(5)]
    public string? AddrType { get; set; }

    [Column("same_as_permanent_addr")]
    [StringLength(5)]
    public string? SameAsPermanentAddr { get; set; }

    [Column("active_flag")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("workflow_status_flag")]
    [StringLength(2)]
    public string? WorkflowStatusFlag { get; set; }

    [Column("last_updated_on", TypeName = "timestamp without time zone")]
    public DateTime? LastUpdatedOn { get; set; }

    [Column("effective_end_date")]
    public DateOnly? EffectiveEndDate { get; set; }

    [Column("int_relation_addr_id_wf_old")]
    [StringLength(38)]
    public string? IntRelationAddrIdWfOld { get; set; }

    [Column("int_relation_addr_id_old")]
    [StringLength(38)]
    public string? IntRelationAddrIdOld { get; set; }

    [Column("int_relation_addr_id")]
    public int? IntRelationAddrId { get; set; }

    [Column("int_employee_id_old")]
    [StringLength(38)]
    public string? IntEmployeeIdOld { get; set; }

    [Column("int_employee_id")]
    public int? IntEmployeeId { get; set; }

    [Column("int_emp_relationship_id_old")]
    [StringLength(38)]
    public string? IntEmpRelationshipIdOld { get; set; }

    [Column("int_emp_relationship_id")]
    public int? IntEmpRelationshipId { get; set; }

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

    [Column("int_relation_addr_id_wf")]
    public int IntRelationAddrIdWf { get; set; }
}
