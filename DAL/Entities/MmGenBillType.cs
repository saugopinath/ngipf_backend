using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_backend.DAL.Entities;

[Keyless]
[Table("mm_gen_bill_type", Schema = "ifmsadmin")]
public partial class MmGenBillType
{
    [Column("module_type")]
    [StringLength(1)]
    public string? ModuleType { get; set; }

    [Column("bill_type")]
    [StringLength(1)]
    public string? BillType { get; set; }

    [Column("description")]
    [StringLength(80)]
    public string? Description { get; set; }

    [Column("active_flag")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("created_timestamp")]
    public DateOnly CreatedTimestamp { get; set; }

    [Column("modified_timestamp")]
    public DateOnly ModifiedTimestamp { get; set; }

    [Column("bill_type_id_old")]
    [StringLength(38)]
    public string? BillTypeIdOld { get; set; }

    [Column("bill_type_id")]
    public int? BillTypeId { get; set; }

    [Column("user_id_old")]
    [StringLength(38)]
    public string? UserIdOld { get; set; }

    [Column("user_id")]
    public int? UserId { get; set; }

    [Column("modified_user_id_old")]
    [StringLength(38)]
    public string? ModifiedUserIdOld { get; set; }

    [Column("modified_user_id")]
    public int? ModifiedUserId { get; set; }
}
