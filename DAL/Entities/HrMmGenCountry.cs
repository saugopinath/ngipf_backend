using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_frontend.DAL.Entities;

[Table("hr_mm_gen_country", Schema = "ihrms_master")]
public partial class HrMmGenCountry
{
    [Column("country_name")]
    [StringLength(100)]
    public string? CountryName { get; set; }

    [Column("country_short_name")]
    [StringLength(3)]
    public string? CountryShortName { get; set; }

    [Column("created_timestamp")]
    public DateOnly CreatedTimestamp { get; set; }

    [Column("modified_timestamp")]
    public DateOnly ModifiedTimestamp { get; set; }

    [Column("active_flag")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("country_id_old")]
    [StringLength(38)]
    public string? CountryIdOld { get; set; }

    [Key]
    [Column("country_id")]
    public int CountryId { get; set; }

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

    [Column("dml_status_flag_old")]
    [StringLength(38)]
    public string? DmlStatusFlagOld { get; set; }

    [Column("dml_status_flag")]
    public int? DmlStatusFlag { get; set; }

    [InverseProperty("Country")]
    public virtual ICollection<HrMdEmpAddress> HrMdEmpAddresses { get; set; } = new List<HrMdEmpAddress>();
}
