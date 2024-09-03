using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_backend.DAL.Entities;

[Table("test", Schema = "bantan")]
public partial class Test
{
    [Key]
    [Column("id")]
    public long Id { get; set; }
}
