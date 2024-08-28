using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_frontend.DAL.Entities;

[PrimaryKey("IntTreasuryCode", "IntDivisionId")]
[Table("mm_gen_division", Schema = "master")]
public partial class MmGenDivision
{
    [Key]
    [Column("int_treasury_code")]
    public short IntTreasuryCode { get; set; }

    [Key]
    [Column("int_division_id")]
    public short IntDivisionId { get; set; }

    [Column("division_code")]
    public short DivisionCode { get; set; }

    [Column("division_name")]
    [StringLength(80)]
    public string DivisionName { get; set; } = null!;

    [Column("hoa_id")]
    public int HoaId { get; set; }

    [Column("active_flag")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("user_id")]
    public int UserId { get; set; }

    [Column("modified_user_id")]
    public int ModifiedUserId { get; set; }

    [Column("created_timestamp", TypeName = "timestamp(0) without time zone")]
    public DateTime CreatedTimestamp { get; set; }

    [Column("modified_timestamp", TypeName = "timestamp(0) without time zone")]
    public DateTime ModifiedTimestamp { get; set; }
}
