using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_backend.DAL.Entities;

[Keyless]
[Table("mm_pay_bytransfer_head", Schema = "ifmsadmin")]
public partial class MmPayBytransferHead
{
    [Column("bytransfer_type")]
    [StringLength(1)]
    public string? BytransferType { get; set; }

    [Column("description")]
    [StringLength(205)]
    public string? Description { get; set; }

    [Column("ag_bytransfer_flag")]
    [StringLength(1)]
    public string? AgBytransferFlag { get; set; }

    [Column("active_flag")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("created_timestamp")]
    public DateOnly CreatedTimestamp { get; set; }

    [Column("modified_timestamp")]
    public DateOnly ModifiedTimestamp { get; set; }

    [Column("bt_serial_number_old")]
    [StringLength(38)]
    public string? BtSerialNumberOld { get; set; }

    [Column("bt_serial_number")]
    public int? BtSerialNumber { get; set; }

    [Column("hoa_id_old")]
    [StringLength(38)]
    public string? HoaIdOld { get; set; }

    [Column("hoa_id")]
    public int? HoaId { get; set; }

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
