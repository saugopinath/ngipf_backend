using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_frontend.DAL.Entities;

[Keyless]
[Table("hr_mm_payfix_type", Schema = "ihrms_master")]
public partial class HrMmPayfixType
{
    [Column("PAYFIX_ABBR")]
    [StringLength(10)]
    public string? PayfixAbbr { get; set; }

    [Column("PAYFIX_DESC")]
    [StringLength(100)]
    public string? PayfixDesc { get; set; }

    [Column("WEF")]
    public DateOnly Wef { get; set; }

    [Column("DIRECT_FLAG")]
    [StringLength(1)]
    public string? DirectFlag { get; set; }

    [Column("ACTIVE_FLAG")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("CREATED_TIMESTAMP")]
    public DateOnly CreatedTimestamp { get; set; }

    [Column("MODIFIED_TIMESTAMP")]
    public DateOnly ModifiedTimestamp { get; set; }

    [Column("SERVICE_BOOK_FLAG")]
    [StringLength(1)]
    public string? ServiceBookFlag { get; set; }

    [Column("INT_PAYFIX_TYPE_ID_old")]
    [StringLength(38)]
    public string? IntPayfixTypeIdOld { get; set; }

    [Column("INT_PAYFIX_TYPE_ID")]
    public int? IntPayfixTypeId { get; set; }

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
