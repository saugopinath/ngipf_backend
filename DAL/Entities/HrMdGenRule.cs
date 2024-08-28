using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_frontend.DAL.Entities;

[Keyless]
[Table("hr_md_gen_rule", Schema = "ihrms_master")]
public partial class HrMdGenRule
{
    [Column("ACTIVE_FLAG")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("CREATED_TIMESTAMP")]
    public DateOnly? CreatedTimestamp { get; set; }

    [Column("MODIFIED_TIMESTAMP")]
    public DateOnly? ModifiedTimestamp { get; set; }

    [Column("INT_RULE_MAP_ID_old")]
    [StringLength(38)]
    public string? IntRuleMapIdOld { get; set; }

    [Column("INT_RULE_MAP_ID")]
    public int? IntRuleMapId { get; set; }

    [Column("INT_RULE_ID_old")]
    [StringLength(38)]
    public string? IntRuleIdOld { get; set; }

    [Column("INT_RULE_ID")]
    public int? IntRuleId { get; set; }

    [Column("INT_CAS_ID_old")]
    [StringLength(38)]
    public string? IntCasIdOld { get; set; }

    [Column("INT_CAS_ID")]
    public int? IntCasId { get; set; }

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
