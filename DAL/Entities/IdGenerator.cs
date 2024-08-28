using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_frontend.DAL.Entities;

[Keyless]
[Table("id_generator")]
public partial class IdGenerator
{
    [Column("id_name")]
    [StringLength(100)]
    public string? IdName { get; set; }

    [Column("last_id")]
    [Precision(38, 0)]
    public decimal? LastId { get; set; }
}
