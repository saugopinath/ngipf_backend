using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_frontend.DAL.Entities;

[Keyless]
[Table("hr_mm_gen_stake_mod_permission", Schema = "ihrms")]
public partial class HrMmGenStakeModPermission
{
    [Column("int_stake_mod_permission")]
    [StringLength(38)]
    public string? IntStakeModPermission { get; set; }

    [Column("stake_code")]
    [StringLength(20)]
    public string? StakeCode { get; set; }

    [Column("stake_user_type")]
    [StringLength(4)]
    public string? StakeUserType { get; set; }

    [Column("active_flag")]
    [StringLength(2)]
    public string? ActiveFlag { get; set; }

    [Column("dml_status_flag")]
    public short? DmlStatusFlag { get; set; }
}
