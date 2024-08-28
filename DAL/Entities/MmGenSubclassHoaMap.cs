using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NGIPF_BE.DAL.Entities;

[Keyless]
[Table("mm_gen_subclass_hoa_map", Schema = "ifmsadmin")]
public partial class MmGenSubclassHoaMap
{
    [Column("active_flag")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("created_timestamp")]
    public DateOnly CreatedTimestamp { get; set; }

    [Column("modified_timestamp")]
    public DateOnly ModifiedTimestamp { get; set; }

    [Column("hrms_flag")]
    [StringLength(1)]
    public string? HrmsFlag { get; set; }

    [Column("subclass_id_old")]
    [StringLength(38)]
    public string? SubclassIdOld { get; set; }

    [Column("subclass_id")]
    public int? SubclassId { get; set; }

    [Column("hoa_id_old")]
    [StringLength(38)]
    public string? HoaIdOld { get; set; }

    [Column("hoa_id")]
    public int? HoaId { get; set; }

    [Column("int_bill_type_id_old")]
    [StringLength(38)]
    public string? IntBillTypeIdOld { get; set; }

    [Column("int_bill_type_id")]
    public int? IntBillTypeId { get; set; }

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
