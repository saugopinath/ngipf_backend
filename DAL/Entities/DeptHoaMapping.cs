using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_frontend.DAL.Entities;

[Table("dept_hoa_mapping", Schema = "ngipf_master")]
public partial class DeptHoaMapping
{
    [Column("dept_code")]
    [StringLength(5)]
    public string? DeptCode { get; set; }

    [Column("demand_no")]
    public int? DemandNo { get; set; }

    [Column("hoa")]
    [StringLength(50)]
    public string? Hoa { get; set; }

    [Column("pf_code")]
    [StringLength(50)]
    public string? PfCode { get; set; }

    [Column("active_flag")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("user_id")]
    public int? UserId { get; set; }

    [Column("modified_user_id")]
    public int? ModifiedUserId { get; set; }

    [Column("created_timestamp", TypeName = "timestamp(0) without time zone")]
    public DateTime? CreatedTimestamp { get; set; }

    [Column("modified_timestamp", TypeName = "timestamp(0) without time zone")]
    public DateTime? ModifiedTimestamp { get; set; }

    [Column("int_scheme_id")]
    public int? IntSchemeId { get; set; }

    [Key]
    [Column("int_dept_hoa_id")]
    public short IntDeptHoaId { get; set; }

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

    public virtual MmGenDepartment? DeptCodeNavigation { get; set; }

    [ForeignKey("IntSchemeId")]
    [InverseProperty("DeptHoaMappings")]
    public virtual MdGenSchemeHead? IntScheme { get; set; }
}
