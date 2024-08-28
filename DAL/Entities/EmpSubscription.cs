using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_frontend.DAL.Entities;

[Keyless]
[Table("emp_subscription", Schema = "ngipf")]
public partial class EmpSubscription
{
    [Column("int_employee_id")]
    public int? IntEmployeeId { get; set; }

    [Column("fin_year_from")]
    public short? FinYearFrom { get; set; }

    [Column("salary_month")]
    public double? SalaryMonth { get; set; }

    [Column("salary_year")]
    public double? SalaryYear { get; set; }

    [Column("challan_number")]
    [StringLength(12)]
    public string? ChallanNumber { get; set; }

    [Column("challan_date", TypeName = "timestamp(0) without time zone")]
    public DateTime? ChallanDate { get; set; }

    [Column("trans_type")]
    [StringLength(4000)]
    public string? TransType { get; set; }

    [Column("amount")]
    public double? Amount { get; set; }

    [Column("hoa")]
    public short? Hoa { get; set; }

    [ForeignKey("IntEmployeeId")]
    public virtual EmpPfBasicDetail? IntEmployee { get; set; }
}
