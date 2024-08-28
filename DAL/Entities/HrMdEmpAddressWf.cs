using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_frontend.DAL.Entities;

[Table("hr_md_emp_address_wf", Schema = "ihrms_emp_master")]
[Index("IntEmpAddrId", Name = "fki_fk_hr_md_emp_address_wf_emp_addres_id")]
public partial class HrMdEmpAddressWf
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

    [Column("wef")]
    public DateOnly? Wef { get; set; }

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

    [Column("int_emp_addr_id_wf_old")]
    [StringLength(38)]
    public string? IntEmpAddrIdWfOld { get; set; }

    [Column("int_emp_addr_id_old")]
    [StringLength(38)]
    public string? IntEmpAddrIdOld { get; set; }

    [Column("int_emp_addr_id")]
    public int? IntEmpAddrId { get; set; }

    [Column("int_employee_id_old")]
    [StringLength(38)]
    public string? IntEmployeeIdOld { get; set; }

    [Column("int_employee_id")]
    public int? IntEmployeeId { get; set; }

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

    [Column("country_id_old")]
    [StringLength(38)]
    public string? CountryIdOld { get; set; }

    [Column("country_id")]
    public int? CountryId { get; set; }

    [Key]
    [Column("int_emp_addr_id_wf")]
    public int IntEmpAddrIdWf { get; set; }

    [ForeignKey("IntEmpAddrId")]
    [InverseProperty("HrMdEmpAddressWfs")]
    public virtual HrMdEmpAddress? IntEmpAddr { get; set; }

    [ForeignKey("IntEmployeeId")]
    [InverseProperty("HrMdEmpAddressWfs")]
    public virtual HrMmEmpBasicDtl? IntEmployee { get; set; }
}
