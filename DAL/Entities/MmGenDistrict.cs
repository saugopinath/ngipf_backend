using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_backend.DAL.Entities;

[Table("mm_gen_district", Schema = "ifmsadmin")]
public partial class MmGenDistrict
{
    [Column("district_code")]
    [StringLength(3)]
    public string? DistrictCode { get; set; }

    [Column("district_name")]
    [StringLength(50)]
    public string? DistrictName { get; set; }

    [Column("active_flag")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("created_timestamp")]
    public DateOnly CreatedTimestamp { get; set; }

    [Column("modified_timestamp")]
    public DateOnly ModifiedTimestamp { get; set; }

    [Column("district_id")]
    [StringLength(3)]
    public string? DistrictId { get; set; }

    [Column("district_census_code")]
    [StringLength(5)]
    public string? DistrictCensusCode { get; set; }

    [Column("int_district_id_old")]
    [StringLength(38)]
    public string? IntDistrictIdOld { get; set; }

    [Key]
    [Column("int_district_id")]
    public int IntDistrictId { get; set; }

    [Column("state_id_old")]
    [StringLength(38)]
    public string? StateIdOld { get; set; }

    [Column("state_id")]
    public int? StateId { get; set; }

    [Column("user_id_old")]
    [StringLength(38)]
    public string? UserIdOld { get; set; }

    [Column("user_id")]
    public int? UserId { get; set; }

    [Column("modified_user_id_old")]
    [StringLength(38)]
    public string? ModifiedUserIdOld { get; set; }

    [Column("modified_user_id")]
    public int? ModifiedUserId { get; set; }

    [InverseProperty("IntDistrict")]
    public virtual ICollection<HrMdEmpAddress> HrMdEmpAddresses { get; set; } = new List<HrMdEmpAddress>();
}
