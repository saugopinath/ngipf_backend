using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_backend.DAL.Entities;

[Table("pf_mm_gen_other_master", Schema = "ngipf")]
[Index("MasterAbbr", Name = "uk_pf_mm_gen_other_master1", IsUnique = true)]
[Index("MasterDescr", Name = "uk_pf_mm_gen_other_master2", IsUnique = true)]
public partial class PfMmGenOtherMaster
{
    [Key]
    [Column("int_other_master_id")]
    [StringLength(38)]
    public string IntOtherMasterId { get; set; } = null!;

    /// <summary>
    /// abbr must not change, coding will be done with this
    /// </summary>
    [Column("master_abbr")]
    [StringLength(10)]
    public string MasterAbbr { get; set; } = null!;

    [Column("master_descr")]
    [StringLength(150)]
    public string? MasterDescr { get; set; }

    /// <summary>
    /// amc---adult minority check
    /// </summary>
    [Column("master_type")]
    [StringLength(6)]
    public string MasterType { get; set; } = null!;

    [Column("active_flag")]
    [StringLength(1)]
    public string ActiveFlag { get; set; } = null!;

    [Column("created_user_id")]
    public int CreatedUserId { get; set; }

    [Column("created_timestamp", TypeName = "timestamp(0) without time zone")]
    public DateTime CreatedTimestamp { get; set; }

    [Column("modified_user_id")]
    public int ModifiedUserId { get; set; }

    [Column("modified_timestamp", TypeName = "timestamp(0) without time zone")]
    public DateTime ModifiedTimestamp { get; set; }
}
