using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_frontend.DAL.Entities;

[PrimaryKey("IntDdoId", "SectionCode", "EffectiveFrom")]
[Table("md_gen_ddo_section", Schema = "ifmsadmin")]
public partial class MdGenDdoSection
{
    [Key]
    [Column("effective_from")]
    public DateOnly EffectiveFrom { get; set; }

    [Column("active_flag")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("timestamp")]
    public DateOnly? Timestamp { get; set; }

    [Column("int_ddo_id_old")]
    [StringLength(38)]
    public string? IntDdoIdOld { get; set; }

    [Key]
    [Column("int_ddo_id")]
    public int IntDdoId { get; set; }

    [Column("section_code_old")]
    [StringLength(38)]
    public string? SectionCodeOld { get; set; }

    [Key]
    [Column("section_code")]
    public int SectionCode { get; set; }

    [Column("user_id_old")]
    [StringLength(38)]
    public string? UserIdOld { get; set; }

    [Column("user_id")]
    public int? UserId { get; set; }
}
