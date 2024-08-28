using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_frontend.DAL.Entities;

[Table("hr_md_payfix_tool_mapping", Schema = "ihrms")]
public partial class HrMdPayfixToolMapping
{
    [Key]
    [Column("int_payfix_tool_map_id")]
    [StringLength(38)]
    public string IntPayfixToolMapId { get; set; } = null!;

    [Column("int_payfix_type_id")]
    [StringLength(38)]
    public string IntPayfixTypeId { get; set; } = null!;

    [Column("int_payfix_tool_id")]
    [StringLength(38)]
    public string IntPayfixToolId { get; set; } = null!;

    [Column("sys_cal_flag")]
    [StringLength(1)]
    public string SysCalFlag { get; set; } = null!;

    [Column("wef", TypeName = "timestamp(0) without time zone")]
    public DateTime Wef { get; set; }

    [Column("ropa_type")]
    [StringLength(4)]
    public string? RopaType { get; set; }

    [Column("active_flag")]
    [StringLength(1)]
    public string ActiveFlag { get; set; } = null!;

    [Column("dml_status_flag")]
    public short DmlStatusFlag { get; set; }

    [Column("created_user_id")]
    public int CreatedUserId { get; set; }

    [Column("created_timestamp", TypeName = "timestamp(0) without time zone")]
    public DateTime CreatedTimestamp { get; set; }

    [Column("modified_user_id")]
    public int ModifiedUserId { get; set; }

    [Column("modified_timestamp", TypeName = "timestamp(0) without time zone")]
    public DateTime ModifiedTimestamp { get; set; }

    [Column("service_book_flag")]
    [StringLength(1)]
    public string? ServiceBookFlag { get; set; }
}
