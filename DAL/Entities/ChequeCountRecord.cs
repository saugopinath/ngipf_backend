﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_backend.DAL.Entities;

[Keyless]
[Table("cheque_count_record")]
public partial class ChequeCountRecord
{
    [Column("id")]
    public int? Id { get; set; }

    [Column("financial_year_id")]
    public short? FinancialYearId { get; set; }

    [Column("count")]
    public int? Count { get; set; }

    [Column("utilized")]
    public int? Utilized { get; set; }

    [Column("?column?")]
    public int? Column { get; set; }
}
