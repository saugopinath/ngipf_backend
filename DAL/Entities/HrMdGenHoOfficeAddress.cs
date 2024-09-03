using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_backend.DAL.Entities;

[Keyless]
[Table("hr_md_gen_ho_office_address", Schema = "ihrms_master")]
public partial class HrMdGenHoOfficeAddress
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

    [Column("ACTIVE_FLAG")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("WEF")]
    public DateOnly Wef { get; set; }

    [Column("CREATED_TIMESTAMP")]
    public DateOnly CreatedTimestamp { get; set; }

    [Column("MODIFIED_TIMESTAMP")]
    public DateOnly ModifiedTimestamp { get; set; }

    [Column("APPROVE_FLAG")]
    [StringLength(1)]
    public string? ApproveFlag { get; set; }

    [Column("APPROVE_DATE")]
    public DateOnly? ApproveDate { get; set; }

    [Column("INT_OFFICE_ADDRESS_ID_old")]
    [StringLength(38)]
    public string? IntOfficeAddressIdOld { get; set; }

    [Column("INT_OFFICE_ADDRESS_ID")]
    public int? IntOfficeAddressId { get; set; }

    [Column("INT_HEAD_OF_OFFICE_ID_old")]
    [StringLength(38)]
    public string? IntHeadOfOfficeIdOld { get; set; }

    [Column("INT_HEAD_OF_OFFICE_ID")]
    public int? IntHeadOfOfficeId { get; set; }

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

    [Column("DML_STATUS_FLAG_old")]
    [StringLength(38)]
    public string? DmlStatusFlagOld { get; set; }

    [Column("DML_STATUS_FLAG")]
    public int? DmlStatusFlag { get; set; }

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

    [Column("APPROVE_BY_old")]
    [StringLength(38)]
    public string? ApproveByOld { get; set; }

    [Column("APPROVE_BY")]
    public int? ApproveBy { get; set; }
}
