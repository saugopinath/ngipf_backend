using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NGIPF_BE.DAL.Entities;

[Keyless]
[Table("mv_pf_drawal_det", Schema = "ngipf")]
public partial class MvPfDrawalDet
{
    [Column("employee_no")]
    [StringLength(50)]
    public string? EmployeeNo { get; set; }

    [Column("emp_first_name")]
    [StringLength(100)]
    public string? EmpFirstName { get; set; }

    [Column("loan_type")]
    [StringLength(200)]
    public string? LoanType { get; set; }

    [Column("cessation_type")]
    [StringLength(200)]
    public string? CessationType { get; set; }

    [Column("ret_cess_date")]
    [StringLength(10)]
    public string? RetCessDate { get; set; }

    [Column("application_id")]
    [StringLength(50)]
    public string? ApplicationId { get; set; }

    [Column("application_date")]
    [StringLength(10)]
    public string? ApplicationDate { get; set; }

    [Column("sanction_id")]
    [StringLength(100)]
    public string? SanctionId { get; set; }

    [Column("sanction_date")]
    [StringLength(10)]
    public string? SanctionDate { get; set; }

    [Column("paymentauthorityid_date")]
    [StringLength(25)]
    public string? PaymentauthorityidDate { get; set; }

    [Column("bill_number")]
    [StringLength(60)]
    public string? BillNumber { get; set; }

    [Column("bill_date")]
    [StringLength(10)]
    public string? BillDate { get; set; }

    [Column("gross_amount")]
    [StringLength(40)]
    public string? GrossAmount { get; set; }

    [Column("net_amount")]
    [StringLength(40)]
    public string? NetAmount { get; set; }

    [Column("online_trn_id")]
    [StringLength(40)]
    public string? OnlineTrnId { get; set; }

    [Column("token_number")]
    [StringLength(40)]
    public string? TokenNumber { get; set; }

    [Column("token_date")]
    [StringLength(10)]
    public string? TokenDate { get; set; }

    [Column("voucher_number")]
    [StringLength(9)]
    public string? VoucherNumber { get; set; }

    [Column("voucher_date")]
    [StringLength(10)]
    public string? VoucherDate { get; set; }

    [Column("voucher_flag")]
    [MaxLength(1)]
    public char? VoucherFlag { get; set; }

    [Column("hoo_code")]
    [StringLength(4000)]
    public string? HooCode { get; set; }

    [Column("recovery_amount")]
    public double? RecoveryAmount { get; set; }
}
