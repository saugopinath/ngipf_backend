using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_backend.DAL.Entities;

[Keyless]
[Table("hr_mm_gen_pay_head_map", Schema = "ihrms_master")]
public partial class HrMmGenPayHeadMap
{
    [Column("ACTIVE_FLAG")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("CREATED_TIMESTAMP")]
    public DateOnly CreatedTimestamp { get; set; }

    [Column("MODIFIED_TIMESTAMP")]
    public DateOnly ModifiedTimestamp { get; set; }

    [Column("INT_PAY_HEAD_MAP_ID_old")]
    [StringLength(38)]
    public string? IntPayHeadMapIdOld { get; set; }

    [Column("INT_PAY_HEAD_MAP_ID")]
    public int? IntPayHeadMapId { get; set; }

    [Column("FROM_PAY_HEAD_old")]
    [StringLength(38)]
    public string? FromPayHeadOld { get; set; }

    [Column("FROM_PAY_HEAD")]
    public int? FromPayHead { get; set; }

    [Column("TO_PAY_HEAD_old")]
    [StringLength(38)]
    public string? ToPayHeadOld { get; set; }

    [Column("TO_PAY_HEAD")]
    public int? ToPayHead { get; set; }

    [Column("CREATED_USER_ID_old")]
    [StringLength(38)]
    public string? CreatedUserIdOld { get; set; }

    [Column("CREATED_USER_ID")]
    public int? CreatedUserId { get; set; }

    [Column("CREATED_ROLE_ID_old")]
    [StringLength(38)]
    public string? CreatedRoleIdOld { get; set; }

    [Column("CREATED_ROLE_ID")]
    public int? CreatedRoleId { get; set; }

    [Column("MODIFIED_USER_ID_old")]
    [StringLength(38)]
    public string? ModifiedUserIdOld { get; set; }

    [Column("MODIFIED_USER_ID")]
    public int? ModifiedUserId { get; set; }

    [Column("MODIFIED_ROLE_ID_old")]
    [StringLength(38)]
    public string? ModifiedRoleIdOld { get; set; }

    [Column("MODIFIED_ROLE_ID")]
    public int? ModifiedRoleId { get; set; }

    [Column("INT_DDO_ID_old")]
    [StringLength(38)]
    public string? IntDdoIdOld { get; set; }

    [Column("INT_DDO_ID")]
    public int? IntDdoId { get; set; }
}
