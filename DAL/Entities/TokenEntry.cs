﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_backend.DAL.Entities;

[Table("token_entry", Schema = "cts")]
[Index("TreasuryCode", "FinancialYearId", Name = "unique_treasary_code_fin_year", IsUnique = true)]
public partial class TokenEntry
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("token_no")]
    public int TokenNo { get; set; }

    [Column("treasury_code")]
    [StringLength(3)]
    public string TreasuryCode { get; set; } = null!;

    [Column("financial_year_id")]
    public short FinancialYearId { get; set; }

    [Column("created_at", TypeName = "timestamp without time zone")]
    public DateTime CreatedAt { get; set; }
}
