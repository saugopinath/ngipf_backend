using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NGIPF_BE.DAL.Entities;

[Table("pf_dept_op_hoa", Schema = "ingipfund")]
public partial class PfDeptOpHoa1
{
    [Column("dept_code")]
    [StringLength(5)]
    public string? DeptCode { get; set; }

    [Column("dept_desc")]
    [StringLength(500)]
    public string? DeptDesc { get; set; }

    [Column("demand_no")]
    public int? DemandNo { get; set; }

    [Column("institutions")]
    [StringLength(500)]
    public string? Institutions { get; set; }

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
    public long? IntSchemeId { get; set; }

    [Key]
    [Column("int_dept_hoa_id")]
    [Precision(38, 0)]
    public decimal IntDeptHoaId { get; set; }
}
