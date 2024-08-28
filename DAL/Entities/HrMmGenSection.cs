using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_frontend.DAL.Entities;

[Keyless]
[Table("hr_mm_gen_section", Schema = "ihrms_master")]
public partial class HrMmGenSection
{
    [Column("SECTION_NAME")]
    [StringLength(50)]
    public string? SectionName { get; set; }

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

    [Column("ACTIVE_FLAG")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("WEF")]
    public DateOnly? Wef { get; set; }

    [Column("CREATED_TIMESTAMP")]
    public DateOnly CreatedTimestamp { get; set; }

    [Column("MODIFIED_TIMESTAMP")]
    public DateOnly? ModifiedTimestamp { get; set; }

    [Column("INT_SECTION_ID_old")]
    [StringLength(38)]
    public string? IntSectionIdOld { get; set; }

    [Column("INT_SECTION_ID")]
    public int? IntSectionId { get; set; }

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

    [Column("INT_DEPT_ID_old")]
    [StringLength(38)]
    public string? IntDeptIdOld { get; set; }

    [Column("INT_DEPT_ID")]
    public int? IntDeptId { get; set; }

    [Column("INT_DDO_ID_old")]
    [StringLength(38)]
    public string? IntDdoIdOld { get; set; }

    [Column("INT_DDO_ID")]
    public int? IntDdoId { get; set; }

    [Column("CREATED_USER_ID_old")]
    [StringLength(38)]
    public string? CreatedUserIdOld { get; set; }

    [Column("CREATED_USER_ID")]
    public int? CreatedUserId { get; set; }

    [Column("MODIFIED_USER_ID_old")]
    [StringLength(38)]
    public string? ModifiedUserIdOld { get; set; }

    [Column("MODIFIED_USER_ID")]
    public int? ModifiedUserId { get; set; }

    [Column("INT_PL_PF_DDO_MAP_old")]
    [StringLength(38)]
    public string? IntPlPfDdoMapOld { get; set; }

    [Column("INT_PL_PF_DDO_MAP")]
    public int? IntPlPfDdoMap { get; set; }
}
