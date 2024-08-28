using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NGIPF_BE.DAL.Entities;

[Keyless]
[Table("mm_gen_bank_area", Schema = "ifmsadmin")]
public partial class MmGenBankArea
{
    [Column("area_name")]
    [StringLength(40)]
    public string? AreaName { get; set; }

    [Column("area_id_old")]
    [StringLength(38)]
    public string? AreaIdOld { get; set; }

    [Column("area_id")]
    public int? AreaId { get; set; }
}
