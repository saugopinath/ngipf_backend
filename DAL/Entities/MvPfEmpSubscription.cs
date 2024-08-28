using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NGIPF_BE.DAL.Entities;

[Keyless]
[Table("mv_pf_emp_subscription", Schema = "ngipf")]
public partial class MvPfEmpSubscription
{
    [Column("employee_no")]
    [StringLength(50)]
    public string? EmployeeNo { get; set; }

    [Column("int_employee_id")]
    [StringLength(38)]
    public string? IntEmployeeId { get; set; }

    [Column("fin_year_from")]
    public short? FinYearFrom { get; set; }

    [Column("salary_month")]
    public double? SalaryMonth { get; set; }

    [Column("salary_year")]
    public double? SalaryYear { get; set; }

    [Column("int_treasury_code")]
    [StringLength(5)]
    public string? IntTreasuryCode { get; set; }

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
    [StringLength(21)]
    public string? Hoa { get; set; }
}
