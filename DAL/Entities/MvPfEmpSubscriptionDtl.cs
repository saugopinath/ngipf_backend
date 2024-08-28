using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_frontend.DAL.Entities;

[Keyless]
[Table("mv_pf_emp_subscription_dtls", Schema = "ngipf")]
public partial class MvPfEmpSubscriptionDtl
{
    [Column("int_employee_id")]
    [StringLength(38)]
    public string? IntEmployeeId { get; set; }

    [Column("employee_no")]
    [StringLength(50)]
    public string? EmployeeNo { get; set; }

    [Column("salary_from_date", TypeName = "timestamp(0) without time zone")]
    public DateTime? SalaryFromDate { get; set; }

    [Column("employee_name")]
    [StringLength(162)]
    public string? EmployeeName { get; set; }

    [Column("voucher_number")]
    [StringLength(37)]
    public string? VoucherNumber { get; set; }

    [Column("voucher_date")]
    [StringLength(10)]
    public string? VoucherDate { get; set; }

    [Column("voucher_month")]
    [StringLength(2)]
    public string? VoucherMonth { get; set; }

    [Column("voucher_year")]
    [StringLength(4)]
    public string? VoucherYear { get; set; }

    [Column("arrear_from")]
    [StringLength(10)]
    public string? ArrearFrom { get; set; }

    [Column("arrear_to")]
    [StringLength(10)]
    public string? ArrearTo { get; set; }

    [Column("challan_number")]
    [StringLength(49)]
    public string? ChallanNumber { get; set; }

    [Column("challan_date")]
    [StringLength(10)]
    public string? ChallanDate { get; set; }

    [Column("ddo_code")]
    [StringLength(9)]
    public string? DdoCode { get; set; }

    [Column("ddo_designation")]
    [StringLength(200)]
    public string? DdoDesignation { get; set; }

    [Column("treasury_name")]
    [StringLength(100)]
    public string? TreasuryName { get; set; }

    [Column("total_installment")]
    public double? TotalInstallment { get; set; }

    [Column("amount")]
    public double? Amount { get; set; }

    [Column("fin_year_from")]
    public short? FinYearFrom { get; set; }

    [Column("int_treasury_code")]
    [StringLength(5)]
    public string? IntTreasuryCode { get; set; }

    [Column("salary_month")]
    public short? SalaryMonth { get; set; }

    [Column("salary_year")]
    public short? SalaryYear { get; set; }

    [Column("treasury_code")]
    [StringLength(4)]
    public string? TreasuryCode { get; set; }

    [Column("deposit_type")]
    [StringLength(20)]
    public string? DepositType { get; set; }

    [Column("hoa")]
    [StringLength(18)]
    public string? Hoa { get; set; }

    [Column("bt_serial_number")]
    public double? BtSerialNumber { get; set; }
}
