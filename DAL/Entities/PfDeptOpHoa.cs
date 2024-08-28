using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NGIPF_BE.DAL.Entities;

[Table("pf_dept_op_hoa", Schema = "ngipf")]
public partial class PfDeptOpHoa
{
    [Column("dept_code")]
    [StringLength(5)]
    public string DeptCode { get; set; } = null!;

    [Column("dept_desc")]
    [StringLength(500)]
    public string DeptDesc { get; set; } = null!;

    [Column("demand_no")]
    public int DemandNo { get; set; }

    [Column("institutions")]
    [StringLength(500)]
    public string Institutions { get; set; } = null!;

    [Column("hoa")]
    [StringLength(50)]
    public string Hoa { get; set; } = null!;

    [Column("pf_code")]
    [StringLength(50)]
    public string? PfCode { get; set; }

    [Column("active_flag")]
    [StringLength(1)]
    public string ActiveFlag { get; set; } = null!;

    [Column("user_id")]
    public int UserId { get; set; }

    [Column("modified_user_id")]
    public int ModifiedUserId { get; set; }

    [Column("created_timestamp", TypeName = "timestamp(0) without time zone")]
    public DateTime CreatedTimestamp { get; set; }

    [Column("modified_timestamp", TypeName = "timestamp(0) without time zone")]
    public DateTime ModifiedTimestamp { get; set; }

    [Column("int_scheme_id")]
    public long? IntSchemeId { get; set; }

    [Key]
    [Column("int_dept_hoa_id")]
    [StringLength(38)]
    public string IntDeptHoaId { get; set; } = null!;
}
