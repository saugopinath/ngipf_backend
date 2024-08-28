using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_frontend.DAL.Entities;

[Keyless]
[Table("hr_mm_payfix_tool", Schema = "ihrms_master")]
public partial class HrMmPayfixTool
{
    [Column("TOOL_ABBR")]
    [StringLength(10)]
    public string? ToolAbbr { get; set; }

    [Column("TOOL_DESC")]
    [StringLength(100)]
    public string? ToolDesc { get; set; }

    [Column("WEF")]
    public DateOnly Wef { get; set; }

    [Column("ACTIVE_FLAG")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("CREATED_TIMESTAMP")]
    public DateOnly CreatedTimestamp { get; set; }

    [Column("MODIFIED_TIMESTAMP")]
    public DateOnly ModifiedTimestamp { get; set; }

    [Column("PAY_FIX_ROPA_ABBR")]
    [StringLength(2)]
    public string? PayFixRopaAbbr { get; set; }

    [Column("INT_PAYFIX_TOOL_ID_old")]
    [StringLength(38)]
    public string? IntPayfixToolIdOld { get; set; }

    [Column("INT_PAYFIX_TOOL_ID")]
    public int? IntPayfixToolId { get; set; }

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
}
