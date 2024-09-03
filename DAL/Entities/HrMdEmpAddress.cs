using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_backend.DAL.Entities;

[Table("hr_md_emp_address", Schema = "ihrms_emp_master")]
public partial class HrMdEmpAddress
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

    [Column("created_timestamp")]
    public DateOnly CreatedTimestamp { get; set; }

    [Column("modified_timestamp")]
    public DateOnly ModifiedTimestamp { get; set; }

    [Column("effective_end_date")]
    public DateOnly? EffectiveEndDate { get; set; }

    [Column("int_emp_addr_id_old")]
    [StringLength(38)]
    public string? IntEmpAddrIdOld { get; set; }

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

    [Column("prev_int_emp_addr_id_old")]
    [StringLength(38)]
    public string? PrevIntEmpAddrIdOld { get; set; }

    [Column("prev_int_emp_addr_id")]
    public int? PrevIntEmpAddrId { get; set; }

    [Column("dml_status_flag_old")]
    [StringLength(38)]
    public string? DmlStatusFlagOld { get; set; }

    [Column("dml_status_flag")]
    public int? DmlStatusFlag { get; set; }

    [Column("same_int_emp_addr_id_old")]
    [StringLength(38)]
    public string? SameIntEmpAddrIdOld { get; set; }

    [Column("same_int_emp_addr_id")]
    public int? SameIntEmpAddrId { get; set; }

    [Column("request_id_old")]
    [StringLength(38)]
    public string? RequestIdOld { get; set; }

    [Column("request_id")]
    public long? RequestId { get; set; }

    [Column("country_id_old")]
    [StringLength(38)]
    public string? CountryIdOld { get; set; }

    [Column("country_id")]
    public int? CountryId { get; set; }

    [Key]
    [Column("int_emp_addr_id")]
    public int IntEmpAddrId { get; set; }

    [ForeignKey("CountryId")]
    [InverseProperty("HrMdEmpAddresses")]
    public virtual HrMmGenCountry? Country { get; set; }

    [InverseProperty("IntEmpAddr")]
    public virtual ICollection<HrMdEmpAddressWf> HrMdEmpAddressWfs { get; set; } = new List<HrMdEmpAddressWf>();

    [ForeignKey("IntDistrictId")]
    [InverseProperty("HrMdEmpAddresses")]
    public virtual MmGenDistrict? IntDistrict { get; set; }

    [ForeignKey("IntEmployeeId")]
    [InverseProperty("HrMdEmpAddresses")]
    public virtual HrMmEmpBasicDtl? IntEmployee { get; set; }

    [ForeignKey("RequestId")]
    [InverseProperty("HrMdEmpAddresses")]
    public virtual HrMmGenWorkflowMaster? Request { get; set; }

    [ForeignKey("StateId")]
    [InverseProperty("HrMdEmpAddresses")]
    public virtual MmGenState? State { get; set; }
}
