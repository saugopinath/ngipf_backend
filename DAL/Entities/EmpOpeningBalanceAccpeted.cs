using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_frontend.DAL.Entities;

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

    [Column("active_flag")]
    [MaxLength(1)]
    public char? ActiveFlag { get; set; }

    [ForeignKey("FinancialYear")]
    [InverseProperty("EmpOpeningBalanceAccpeteds")]
    public virtual FinancialYearMst FinancialYearNavigation { get; set; } = null!;

    [ForeignKey("IntEmployeeId")]
    [InverseProperty("EmpOpeningBalanceAccpeteds")]
    public virtual EmpPfBasicDetail IntEmployee { get; set; } = null!;

    [ForeignKey("IntOperatorId")]
    [InverseProperty("EmpOpeningBalanceAccpeteds")]
    public virtual TMmGenPlOperator? IntOperator { get; set; }

    [ForeignKey("OpType")]
    [InverseProperty("EmpOpeningBalanceAccpeteds")]
    public virtual OpeningBalanceTypeMst? OpTypeNavigation { get; set; }
}
