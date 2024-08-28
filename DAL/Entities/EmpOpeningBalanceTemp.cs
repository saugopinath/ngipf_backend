using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_frontend.DAL.Entities;

[Keyless]
[Table("emp_opening_balance_temp", Schema = "ngipf")]
public partial class EmpOpeningBalanceTemp
{
    [Column("id")]
    public int Id { get; set; }

    [Column("int_employee_id")]
    public int? IntEmployeeId { get; set; }

    [Column("financial_year")]
    public int? FinancialYear { get; set; }

    [Column("opening_balance")]
    public double? OpeningBalance { get; set; }

    [Column("closing_balance")]
    public double? ClosingBalance { get; set; }

    [Column("op_type")]
    public int? OpType { get; set; }

    [ForeignKey("IntEmployeeId")]
    public virtual EmpPfBasicDetail? IntEmployee { get; set; }
}
