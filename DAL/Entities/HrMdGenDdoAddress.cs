using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_backend.DAL.Entities;

[Keyless]
[Table("hr_md_gen_ddo_address", Schema = "ihrms_master")]
public partial class HrMdGenDdoAddress
{
    [Column("HOUSE_NO_STREET_LANE")]
    [StringLength(100)]
    public string? HouseNoStreetLane { get; set; }

    [Column("CITY_TOWN_VILLAGE")]
    [StringLength(100)]
    public string? CityTownVillage { get; set; }

    [Column("POST_OFFICE")]
    [StringLength(100)]
    public string? PostOffice { get; set; }

    [Column("POLICE_STATION")]
    [StringLength(100)]
    public string? PoliceStation { get; set; }

    [Column("PIN")]
    [StringLength(10)]
    public string? Pin { get; set; }

    [Column("LAST_UPDATED_ON")]
    public DateOnly? LastUpdatedOn { get; set; }

    [Column("INT_MD_GEN_DDO_ADDRESS_old")]
    [StringLength(38)]
    public string? IntMdGenDdoAddressOld { get; set; }

    [Column("INT_MD_GEN_DDO_ADDRESS")]
    public int? IntMdGenDdoAddress { get; set; }

    [Column("INT_DDO_ID_old")]
    [StringLength(38)]
    public string? IntDdoIdOld { get; set; }

    [Column("INT_DDO_ID")]
    public int? IntDdoId { get; set; }

    [Column("STATE_ID_old")]
    [StringLength(38)]
    public string? StateIdOld { get; set; }

    [Column("STATE_ID")]
    public int? StateId { get; set; }

    [Column("INT_DISTRICT_ID_old")]
    [StringLength(38)]
    public string? IntDistrictIdOld { get; set; }

    [Column("INT_DISTRICT_ID")]
    public int? IntDistrictId { get; set; }

    [Column("LAST_UPDATED_BY_old")]
    [StringLength(38)]
    public string? LastUpdatedByOld { get; set; }

    [Column("LAST_UPDATED_BY")]
    public int? LastUpdatedBy { get; set; }

    [Column("INT_OMI_CITY_GRADE_old")]
    [StringLength(38)]
    public string? IntOmiCityGradeOld { get; set; }

    [Column("INT_OMI_CITY_GRADE")]
    public int? IntOmiCityGrade { get; set; }
}
