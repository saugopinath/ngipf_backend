using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NGIPF_BE.DAL.Entities;

[Table("opening_balance_type", Schema = "ngipf_master")]
public partial class OpeningBalanceType
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("name")]
    [StringLength(50)]
    public string? Name { get; set; }

    [Column("status")]
    public short? Status { get; set; }

    [InverseProperty("OpTypeNavigation")]
    public virtual ICollection<EmpOpeningBalanceAccpeted> EmpOpeningBalanceAccpeteds { get; set; } = new List<EmpOpeningBalanceAccpeted>();
}
