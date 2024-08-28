using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NGIPF_BE.DAL.Entities;

[Table("md_gen_scheme_head", Schema = "ifmsadmin")]
[Index("FinYearFrom", "DemandNo", "MajorHead", "SubmajorHead", "MinorHead", "SchemeHead", "PlanStatusCode", Name = "md_gen_scheme_head_fin_year_from_demand_no_major_head_subma_key", IsUnique = true)]
public partial class MdGenSchemeHead
{
    [Column("demand_no")]
    [StringLength(2)]
    public string? DemandNo { get; set; }

    [Column("major_head")]
    [StringLength(4)]
    public string? MajorHead { get; set; }

    [Column("submajor_head")]
    [StringLength(2)]
    public string? SubmajorHead { get; set; }

    [Column("minor_head")]
    [StringLength(3)]
    public string? MinorHead { get; set; }

    [Column("scheme_head")]
    [StringLength(3)]
    public string? SchemeHead { get; set; }

    [Column("plan_status_code")]
    [StringLength(2)]
    public string? PlanStatusCode { get; set; }

    [Column("description")]
    [StringLength(500)]
    public string? Description { get; set; }

    [Column("scheme_code")]
    [StringLength(5)]
    public string? SchemeCode { get; set; }

    [Column("active_flag")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("created_timestamp")]
    public DateOnly CreatedTimestamp { get; set; }

    [Column("modified_timestamp")]
    public DateOnly ModifiedTimestamp { get; set; }

    [Column("category_code")]
    [StringLength(1)]
    public string? CategoryCode { get; set; }

    [Column("sector_code")]
    [StringLength(2)]
    public string? SectorCode { get; set; }

    [Column("earmarked_code")]
    [StringLength(2)]
    public string? EarmarkedCode { get; set; }

    [Column("dev_code")]
    [StringLength(2)]
    public string? DevCode { get; set; }

    [Column("dept_code")]
    [StringLength(2)]
    public string? DeptCode { get; set; }

    [Column("central_state")]
    [StringLength(2)]
    public string? CentralState { get; set; }

    [Column("scheme_type")]
    [StringLength(2)]
    public string? SchemeType { get; set; }

    [Column("sub_scheme_type_code")]
    [StringLength(4)]
    public string? SubSchemeTypeCode { get; set; }

    [Column("int_scheme_id_old")]
    [StringLength(38)]
    public string? IntSchemeIdOld { get; set; }

    [Key]
    [Column("int_scheme_id")]
    public int IntSchemeId { get; set; }

    [Column("fin_year_from_old")]
    [StringLength(38)]
    public string? FinYearFromOld { get; set; }

    [Column("fin_year_from")]
    public int? FinYearFrom { get; set; }

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

    [Column("state_share_old")]
    [StringLength(38)]
    public string? StateShareOld { get; set; }

    [Column("state_share")]
    public int? StateShare { get; set; }

    [InverseProperty("IntScheme")]
    public virtual ICollection<DeptHoaMapping> DeptHoaMappings { get; set; } = new List<DeptHoaMapping>();
}
