using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NGIPF_BE.DAL.Entities;

[Keyless]
[Table("hr_md_payfix_cadre_tool_map", Schema = "ihrms_master")]
public partial class HrMdPayfixCadreToolMap
{
    [Column("WEF")]
    public DateOnly Wef { get; set; }

    [Column("CREATED_TIMESTAMP")]
    public DateOnly CreatedTimestamp { get; set; }

    [Column("MODIFIED_TIMESTAMP")]
    public DateOnly ModifiedTimestamp { get; set; }

    [Column("INT_PF_CADRE_TOOL_MAP_ID_old")]
    [StringLength(38)]
    public string? IntPfCadreToolMapIdOld { get; set; }

    [Column("INT_PF_CADRE_TOOL_MAP_ID")]
    public int? IntPfCadreToolMapId { get; set; }

    [Column("INT_CADRE_ID_old")]
    [StringLength(38)]
    public string? IntCadreIdOld { get; set; }

    [Column("INT_CADRE_ID")]
    public int? IntCadreId { get; set; }

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
