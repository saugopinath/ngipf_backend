using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_backend.DAL.Entities;

[Table("hr_md_emp_relation_address", Schema = "ihrms_emp_master")]
public partial class HrMdEmpRelationAddress
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

    [Column("created_timestamp")]
    public DateOnly CreatedTimestamp { get; set; }

    [Column("modified_timestamp")]
    public DateOnly ModifiedTimestamp { get; set; }

    [Column("effective_end_date")]
    public DateOnly? EffectiveEndDate { get; set; }

    [Column("int_relation_addr_id_old")]
    [StringLength(38)]
    public string? IntRelationAddrIdOld { get; set; }

    [Column("int_employee_id_old")]
    [StringLength(38)]
    public string? IntEmployeeIdOld { get; set; }

    [Column("int_employee_id")]
    public int? IntEmployeeId { get; set; }

    [Column("int_emp_relationship_id_old")]
    [StringLength(38)]
    public string? IntEmpRelationshipIdOld { get; set; }

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

    [Column("int_emp_relationship_id")]
    public int? IntEmpRelationshipId { get; set; }

    [Key]
    [Column("int_relation_addr_id")]
    public int IntRelationAddrId { get; set; }

    [InverseProperty("IntRelationAddr")]
    public virtual ICollection<HrMdEmpNomineeDtl> HrMdEmpNomineeDtls { get; set; } = new List<HrMdEmpNomineeDtl>();
}
