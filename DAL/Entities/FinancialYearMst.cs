﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_frontend.DAL.Entities;

[Table("financial_year_mst", Schema = "ngipf_master")]
public partial class FinancialYearMst
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("name")]
    [StringLength(50)]
    public string? Name { get; set; }

    [Column("active_flag")]
    [MaxLength(1)]
    public char? ActiveFlag { get; set; }

    [Column("created_by")]
    public int? CreatedBy { get; set; }

    [Column("last_updated_by")]
    public int? LastUpdatedBy { get; set; }

    [Column("deleted_by")]
    public int? DeletedBy { get; set; }

    [Column("created_at", TypeName = "timestamp without time zone")]
    public DateTime? CreatedAt { get; set; }

    [Column("last_updated_at", TypeName = "timestamp without time zone")]
    public DateTime? LastUpdatedAt { get; set; }

    [Column("deleted_at", TypeName = "timestamp without time zone")]
    public DateTime? DeletedAt { get; set; }

    [InverseProperty("FinancialYearNavigation")]
    public virtual ICollection<EmpOpeningBalanceAccpeted> EmpOpeningBalanceAccpeteds { get; set; } = new List<EmpOpeningBalanceAccpeted>();

    [InverseProperty("FinancialYearCodeUptoNavigation")]
    public virtual ICollection<LfPlOpInterestCreditedStatus> LfPlOpInterestCreditedStatuses { get; set; } = new List<LfPlOpInterestCreditedStatus>();
}
