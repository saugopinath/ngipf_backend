using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_frontend.DAL.Entities;

[Table("mm_gen_financial_year", Schema = "ngipf_master")]
public partial class MmGenFinancialYear
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("description")]
    [StringLength(50)]
    public string? Description { get; set; }

    [Column("status")]
    public short? Status { get; set; }

    [InverseProperty("FinancialYearNavigation")]
    public virtual ICollection<EmpOpeningBalanceAccpeted> EmpOpeningBalanceAccpeteds { get; set; } = new List<EmpOpeningBalanceAccpeted>();

    [InverseProperty("FinancialYearCodeUptoNavigation")]
    public virtual ICollection<LfPlOpInterestCreditedStatus> LfPlOpInterestCreditedStatuses { get; set; } = new List<LfPlOpInterestCreditedStatus>();
}
