using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NGIPF_BE.DAL.Entities;

[Table("ngipf_request_distribution", Schema = "ingipfund")]
public partial class NgipfRequestDistribution
{
    [Key]
    [Column("int_distribution_id")]
    [Precision(22, 0)]
    public decimal IntDistributionId { get; set; }

    [Column("distribution_wef")]
    public DateOnly? DistributionWef { get; set; }

    [Column("int_func_id")]
    [Precision(22, 0)]
    public decimal? IntFuncId { get; set; }

    [Column("forward_office_type")]
    [StringLength(20)]
    public string? ForwardOfficeType { get; set; }

    [Column("hoa_id")]
    public int? HoaId { get; set; }

    [Column("office_code")]
    [StringLength(20)]
    public string? OfficeCode { get; set; }

    [Column("int_pf_id")]
    [Precision(22, 0)]
    public decimal? IntPfId { get; set; }

    [Column("int_trs_code")]
    [StringLength(5)]
    public string? IntTrsCode { get; set; }

    [Column("int_dist_id")]
    [Precision(22, 0)]
    public decimal? IntDistId { get; set; }

    [Column("role_id")]
    [Precision(22, 0)]
    public decimal? RoleId { get; set; }

    [Column("user_id")]
    [Precision(22, 0)]
    public decimal? UserId { get; set; }

    [Column("exception_flag")]
    [StringLength(1)]
    public string? ExceptionFlag { get; set; }

    [Column("parent_distribution_id")]
    [Precision(22, 0)]
    public decimal? ParentDistributionId { get; set; }

    [Column("active_flag")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("active_from_date")]
    public DateOnly? ActiveFromDate { get; set; }

    [Column("active_to_date")]
    public DateOnly? ActiveToDate { get; set; }

    [Column("created_user_id")]
    [Precision(22, 0)]
    public decimal? CreatedUserId { get; set; }

    [Column("created_timestamp")]
    public DateOnly? CreatedTimestamp { get; set; }

    [Column("modified_user_id")]
    [Precision(22, 0)]
    public decimal? ModifiedUserId { get; set; }

    [Column("modified_timestamp")]
    public DateOnly? ModifiedTimestamp { get; set; }

    [Column("sub_system_id")]
    [Precision(22, 0)]
    public decimal? SubSystemId { get; set; }

    [ForeignKey("HoaId")]
    [InverseProperty("NgipfRequestDistributions")]
    public virtual MmGenHoa? Hoa { get; set; }

    public virtual MmGenTreasury? IntTrsCodeNavigation { get; set; }
}
