using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NGIPF_BE.DAL.Entities;

[Table("sancction_authority_nature_master", Schema = "ngipf_master")]
public partial class SancctionAuthorityNatureMaster
{
    [Key]
    [Column("code")]
    public short Code { get; set; }

    [Column("description")]
    [StringLength(100)]
    public string? Description { get; set; }

    [Column("is_active")]
    public bool? IsActive { get; set; }
}
