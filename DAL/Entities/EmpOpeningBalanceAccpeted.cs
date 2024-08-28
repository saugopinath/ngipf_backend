using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NGIPF_BE.DAL.Entities;

[PrimaryKey("IntEmployeeId", "FinancialYear")]
[Table("emp_opening_balance_accpeted", Schema = "ngipf")]
public partial class EmpOpeningBalanceAccpeted
{
    [Column("id")]
    public int Id { get; set; }

    [Key]
    [Column("int_employee_id")]
    public int IntEmployeeId { get; set; }

    [Key]
    [Column("financial_year")]
    public int FinancialYear { get; set; }

    [Column("opening_balance")]
    public double? OpeningBalance { get; set; }

    [Column("closing_balance")]
    public double? ClosingBalance { get; set; }

    [Column("op_type")]
    public int? OpType { get; set; }

    [Column("int_operator_id")]
    public int? IntOperatorId { get; set; }

    [ForeignKey("FinancialYear")]
    [InverseProperty("EmpOpeningBalanceAccpeteds")]
    public virtual MmGenFinancialYear FinancialYearNavigation { get; set; } = null!;

    [ForeignKey("IntEmployeeId")]
    [InverseProperty("EmpOpeningBalanceAccpeteds")]
    public virtual EmpPfBasicDetail IntEmployee { get; set; } = null!;

    [ForeignKey("IntOperatorId")]
    [InverseProperty("EmpOpeningBalanceAccpeteds")]
    public virtual TMmGenPlOperator? IntOperator { get; set; }

    [ForeignKey("OpType")]
    [InverseProperty("EmpOpeningBalanceAccpeteds")]
    public virtual OpeningBalanceType? OpTypeNavigation { get; set; }
}
