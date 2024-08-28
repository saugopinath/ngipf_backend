using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NGIPF_BE.DAL.Entities;

[Keyless]
[Table("hr_md_gen_ho_group_address", Schema = "ihrms_master")]
public partial class HrMdGenHoGroupAddress
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

    [Column("WORKFLOW_STATUS_FLAG")]
    [StringLength(10)]
    public string? WorkflowStatusFlag { get; set; }

    [Column("LAST_UPDATED_ON")]
    public DateOnly LastUpdatedOn { get; set; }

    [Column("APPROVE_FLAG")]
    [StringLength(1)]
    public string? ApproveFlag { get; set; }

    [Column("INT_HO_GRP_ADDRESS_ID_old")]
    [StringLength(38)]
    public string? IntHoGrpAddressIdOld { get; set; }

    [Column("INT_HO_GRP_ADDRESS_ID")]
    public int? IntHoGrpAddressId { get; set; }

    [Column("INT_HEAD_OF_OFFICE_ID_old")]
    [StringLength(38)]
    public string? IntHeadOfOfficeIdOld { get; set; }

    [Column("INT_HEAD_OF_OFFICE_ID")]
    public int? IntHeadOfOfficeId { get; set; }

    [Column("INT_HR_MD_GEN_GROUP_old")]
    [StringLength(38)]
    public string? IntHrMdGenGroupOld { get; set; }

    [Column("INT_HR_MD_GEN_GROUP")]
    public int? IntHrMdGenGroup { get; set; }

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

    [Column("REQUEST_ID_old")]
    [StringLength(38)]
    public string? RequestIdOld { get; set; }

    [Column("REQUEST_ID")]
    public int? RequestId { get; set; }

    [Column("DML_STATUS_FLAG_old")]
    [StringLength(38)]
    public string? DmlStatusFlagOld { get; set; }

    [Column("DML_STATUS_FLAG")]
    public int? DmlStatusFlag { get; set; }

    [Column("LAST_UPDATED_BY_old")]
    [StringLength(38)]
    public string? LastUpdatedByOld { get; set; }

    [Column("LAST_UPDATED_BY")]
    public int? LastUpdatedBy { get; set; }

    [Column("LAST_UPDATED_ROLE_old")]
    [StringLength(38)]
    public string? LastUpdatedRoleOld { get; set; }

    [Column("LAST_UPDATED_ROLE")]
    public int? LastUpdatedRole { get; set; }

    [Column("OFFICE_PHONE_NO_old")]
    [StringLength(38)]
    public string? OfficePhoneNoOld { get; set; }

    [Column("OFFICE_PHONE_NO")]
    public int? OfficePhoneNo { get; set; }
}
