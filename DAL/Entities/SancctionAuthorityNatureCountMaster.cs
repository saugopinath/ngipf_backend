using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_frontend.DAL.Entities;

[Table("sancction_authority_nature_count_master", Schema = "ngipf_master")]
public partial class SancctionAuthorityNatureCountMaster
{
    [Key]
    [Column("code")]
    public short Code { get; set; }

    [Column("desctiption")]
    [StringLength(100)]
    public string? Desctiption { get; set; }

    [Column("is_active")]
    public bool? IsActive { get; set; }
}
