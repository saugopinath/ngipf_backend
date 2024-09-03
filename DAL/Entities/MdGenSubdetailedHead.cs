using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_backend.DAL.Entities;

[PrimaryKey("DetailedHead", "SubdetailedHead")]
[Table("md_gen_subdetailed_head", Schema = "ifmsadmin")]
[Index("DetailedHead", "SubdetailedHead", Name = "md_gen_subdetailed_head_detailed_head_subdetailed_head_key", IsUnique = true)]
public partial class MdGenSubdetailedHead
{
    [Key]
    [Column("detailed_head")]
    [StringLength(3)]
    public string DetailedHead { get; set; } = null!;

    [Key]
    [Column("subdetailed_head")]
    [StringLength(2)]
    public string SubdetailedHead { get; set; } = null!;

    [Column("description")]
    [StringLength(100)]
    public string? Description { get; set; }

    [Column("active_flag")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("created_timestamp")]
    public DateOnly CreatedTimestamp { get; set; }

    [Column("modified_timestamp")]
    public DateOnly ModifiedTimestamp { get; set; }

    [Column("created_user_id_old")]
    [StringLength(38)]
    public string? CreatedUserIdOld { get; set; }

    [Column("created_user_id")]
    public int? CreatedUserId { get; set; }

    [Column("modified_user_id_old")]
    [StringLength(38)]
    public string? ModifiedUserIdOld { get; set; }

    [Column("modified_user_id")]
    public int? ModifiedUserId { get; set; }
}
