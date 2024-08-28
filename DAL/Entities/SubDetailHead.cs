﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_frontend.DAL.Entities;

[Table("sub_detail_head", Schema = "master")]
public partial class SubDetailHead
{
    [Key]
    [Column("id")]
    public short Id { get; set; }

    [Column("code")]
    [StringLength(2)]
    public string? Code { get; set; }

    [Column("name")]
    [StringLength(100)]
    public string? Name { get; set; }

    [Column("detail_head_id")]
    public short? DetailHeadId { get; set; }

    [ForeignKey("DetailHeadId")]
    [InverseProperty("SubDetailHeads")]
    public virtual DetailHead? DetailHead { get; set; }
}
