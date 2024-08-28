using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NGIPF_BE.DAL.Entities;

[Keyless]
[Table("mv_pf_emp_withdrawal", Schema = "ngipf")]
public partial class MvPfEmpWithdrawal
{
    [Column("employee_no")]
    [StringLength(50)]
    public string? EmployeeNo { get; set; }

    [Column("int_employee_id")]
    [StringLength(38)]
    public string? IntEmployeeId { get; set; }

    [Column("voucher_number")]
    [StringLength(9)]
    public string? VoucherNumber { get; set; }

    [Column("voucher_date", TypeName = "timestamp(0) without time zone")]
    public DateTime? VoucherDate { get; set; }

    [Column("fin_year_from")]
    public short? FinYearFrom { get; set; }

    [Column("withdrawal_amt")]
    [Precision(14, 2)]
    public decimal? WithdrawalAmt { get; set; }

    [Column("hoa")]
    [StringLength(21)]
    public string? Hoa { get; set; }

    [Column("trans_type")]
    [StringLength(13)]
    public string? TransType { get; set; }
}
