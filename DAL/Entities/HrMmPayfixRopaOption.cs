using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NGIPF_BE.DAL.Entities;

[Keyless]
[Table("hr_mm_payfix_ropa_option", Schema = "ihrms_master")]
public partial class HrMmPayfixRopaOption
{
    [Column("OPTION_DESC")]
    [StringLength(300)]
    public string? OptionDesc { get; set; }

    [Column("OPTION_DETAIL")]
    [StringLength(400)]
    public string? OptionDetail { get; set; }

    [Column("ACTIVE_FLAG")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("CREATED_TIMESTAMP")]
    public DateOnly? CreatedTimestamp { get; set; }

    [Column("MODIFIED_TIMESTAMP")]
    public DateOnly? ModifiedTimestamp { get; set; }

    [Column("OPTION_NO_old")]
    [StringLength(38)]
    public string? OptionNoOld { get; set; }

    [Column("OPTION_NO")]
    public int? OptionNo { get; set; }

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
