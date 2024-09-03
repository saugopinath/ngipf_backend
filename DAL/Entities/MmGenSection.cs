using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_backend.DAL.Entities;

[Keyless]
[Table("mm_gen_section", Schema = "ifmsadmin")]
public partial class MmGenSection
{
    [Column("section_name")]
    [StringLength(100)]
    public string? SectionName { get; set; }

    [Column("effective_from")]
    public DateOnly? EffectiveFrom { get; set; }

    [Column("active_flag")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("timestamp")]
    public DateOnly? Timestamp { get; set; }

    [Column("int_treasury_code")]
    [StringLength(5)]
    public string? IntTreasuryCode { get; set; }

    [Column("section_code_old")]
    [StringLength(38)]
    public string? SectionCodeOld { get; set; }

    [Column("section_code")]
    public int? SectionCode { get; set; }

    [Column("user_id_old")]
    [StringLength(38)]
    public string? UserIdOld { get; set; }

    [Column("user_id")]
    public int? UserId { get; set; }

    [Column("pc_section_code_old")]
    [StringLength(38)]
    public string? PcSectionCodeOld { get; set; }

    [Column("pc_section_code")]
    public int? PcSectionCode { get; set; }
}
