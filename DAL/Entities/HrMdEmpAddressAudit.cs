using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;
using Microsoft.EntityFrameworkCore;

namespace ngipf_backend.DAL.Entities;

[Table("hr_md_emp_address_audit", Schema = "ihrms")]
[Index("IntEmployeeId", Name = "ind_hr_md_emp_address_audit2")]
[Index("IntDistrictId", Name = "ind_hr_md_emp_address_audit3")]
[Index("StateId", Name = "ind_hr_md_emp_address_audit4")]
[Index("RequestId", Name = "ind_hr_md_emp_address_audit45")]
public partial class HrMdEmpAddressAudit
{
    [Key]
    [Column("int_emp_addr_id_aud")]
    [Precision(38, 0)]
    public decimal IntEmpAddrIdAud { get; set; }

    [Column("int_emp_addr_id")]
    [Precision(38, 0)]
    public decimal? IntEmpAddrId { get; set; }

    [Column("int_employee_id")]
    [Precision(38, 0)]
    public BigInteger? IntEmployeeId { get; set; }

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

    [Column("wef", TypeName = "timestamp(0) without time zone")]
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

    [Column("effective_end_date", TypeName = "timestamp(0) without time zone")]
    public DateTime? EffectiveEndDate { get; set; }

    [Column("last_updated_by")]
    public int? LastUpdatedBy { get; set; }

    [Column("last_updated_on", TypeName = "timestamp without time zone")]
    public DateTime? LastUpdatedOn { get; set; }

    [Column("request_id")]
    public long? RequestId { get; set; }

    [Column("country_id")]
    public short? CountryId { get; set; }
}
