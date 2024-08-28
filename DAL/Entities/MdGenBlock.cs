using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NGIPF_BE.DAL.Entities;

[Table("md_gen_block", Schema = "ifmsadmin")]
[Index("BlockCode", Name = "md_gen_block_block_code_key", IsUnique = true)]
public partial class MdGenBlock
{
    [Column("zp_code")]
    [StringLength(10)]
    public string? ZpCode { get; set; }

    [Column("block_code")]
    [StringLength(10)]
    public string? BlockCode { get; set; }

    [Column("block_name")]
    [StringLength(200)]
    public string? BlockName { get; set; }

    [Column("active_flag")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("created_timestamp")]
    public DateOnly CreatedTimestamp { get; set; }

    [Column("modified_timestamp")]
    public DateOnly ModifiedTimestamp { get; set; }

    [Column("int_block_id_old")]
    [StringLength(38)]
    public string? IntBlockIdOld { get; set; }

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

    [Key]
    [Column("int_block_id")]
    public int IntBlockId { get; set; }
}
